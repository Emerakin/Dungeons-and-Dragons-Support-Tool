using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackendLogic.PC;

namespace Formulars.PC
{
    public partial class CharacterSheet : Form
    {
        public Character Character { get; set; }
        private LearntSpell _spellToEdit;
        private InventoryItem _itemToEdit;
        private CharacterCommandExecutor _commandExecutor;
        private Label[] _money;

        public CharacterSheet()
        {
            InitializeComponent();
            Init();
        }

        public CharacterSheet(Character character, CharacterCommandExecutor commandExecutor)
        {
            InitializeComponent();
            Character = character;
            _commandExecutor = commandExecutor;
            Init();
            InitializeText();
        }

        private void Init()
        {
            _money = new Label[] { labelPP, labelGP, labelEP, labelSP, labelCP };
            _spellToEdit = null;
            _itemToEdit = null;
            panelItemFilter.Visible = false;
            panelSpellFilter.Visible = false;
            panelNewSpell.Visible = false;
            panelNewItem.Visible = false;
            panelItemList.Dock = DockStyle.Fill;
            panelSpellList.Dock = DockStyle.Fill;
            
            flowLayoutPanelInventory.Height = panelItemList.Height + 30;
            flowLayoutPanelSpells.Height = panelSpellList.Height + 30;
            comboBoxNewSpellLevel.SelectedIndex = 0;
            comboBoxNewSpellSchool.SelectedIndex = 0;
            comboBoxSpellLevelFilter.SelectedIndex = 0;
            comboBoxSpellSchoolFilter.SelectedIndex = 0;
            foreach (Item item in Character.Equipment)
            {
                EquipmentItem itemForm = new EquipmentItem(item);
                flowLayoutPanelEquipment.Controls.Add(itemForm);
                itemForm.UnequipEquipmentItem += UnequipEquipmentItem;
            }
            foreach (Item item in Character.Inventory)
            {
                InventoryItem itemForm = new InventoryItem(item);
                flowLayoutPanelInventory.Controls.Add(itemForm);
                itemForm.DeleteInventoryItem += DeleteInventoryItem;
                itemForm.EditInventoryItem += EditInventoryItem;
                itemForm.EquipInventoryItem += EquipInventoryItem;
            }
            foreach (Spell spell in Character.Spells)
            {
                LearntSpell spellForm = new LearntSpell(spell);
                spellForm.DeleteLearntSpell += DeleteLearntSpell;
                spellForm.EditLearntSpell += EditLearntSpell;
                flowLayoutPanelSpells.Controls.Add(spellForm);
            }
            RefreshCategories();
        }

        private void InitializeText()
        {
            labelName.Text = Character.Name;
            RefreshHpLabels();
            RefreshMoneyLabels();
            RefreshWeightLabel();
        }

        private void RefreshCategories()
        {
            comboBoxItemCategoryFilter.Items.Clear();
            comboBoxItemCategoryFilter.Items.Add("All");
            comboBoxNewItemCategory.Items.Clear();
            foreach (string category in _commandExecutor.GetItemCategories(Character))
            {
                comboBoxItemCategoryFilter.Items.Add(category);
                comboBoxNewItemCategory.Items.Add(category);
            }
            comboBoxItemCategoryFilter.SelectedIndex = 0;
            ComboBoxItemCategoryFIlter_SelectionChangeCommitted(this, EventArgs.Empty);
        }

        private void ButtonFilterItem_Click(object sender, EventArgs e)
        {
            if (panelItemList.Visible)
            {
                panelItemFilter.Visible = !panelItemFilter.Visible;
                flowLayoutPanelInventory.Height += panelItemFilter.Visible ? -30 : 30;
            }
        }

        private void ButtonFilterSpell_Click(object sender, EventArgs e)
        {
            if (panelSpellList.Visible)
            {
                panelSpellFilter.Visible = !panelSpellFilter.Visible;
                flowLayoutPanelSpells.Height += panelSpellFilter.Visible ? -30 : 30;
            }
        }

        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            if (!panelItemList.Visible)
            {
                return;
            }
            panelItemFilter.Visible = false;
            panelItemList.Visible = false;
            panelNewItem.Visible = true;
        }

        private void ButtonAddSpell_Click(object sender, EventArgs e)
        {
            if (!panelSpellList.Visible)
            {
                return;
            }
            panelSpellFilter.Visible = false;
            panelSpellList.Visible = false;
            panelNewSpell.Visible = true;
        }

        private void DeleteInventoryItem(InventoryItem source, EventArgs e)
        {
            flowLayoutPanelInventory.Controls.Remove(source);
            source.DeleteInventoryItem -= DeleteInventoryItem;
            source.EditInventoryItem -= EditInventoryItem;
            source.EquipInventoryItem -= EquipInventoryItem;
            Character.Inventory.Remove(source.Item);
            Character.CurrentWeight -= source.Item.Weight;
            RefreshWeightLabel();
            RefreshCategories();
        }

        private void EditInventoryItem(InventoryItem source, EventArgs e)
        {
            _itemToEdit = source;
            ButtonAddItem_Click(source, e);
            textBoxNewItemName.Text = source.Item.Name;
            comboBoxNewItemCategory.Text = source.Item.Category;
            textBoxNewItemCost.Text = source.Item.CostToString();
            textBoxNewItemWeight.Text = source.Item.Weight.ToString();
            richTextBoxNewItemDescription.Text = source.Item.Description;
        }

        private void EquipInventoryItem(InventoryItem source, EventArgs e)
        {
            _commandExecutor.EquipItem(Character, source.Item);
            EquipmentItem itemForm = new EquipmentItem(source.Item);
            flowLayoutPanelEquipment.Controls.Add(itemForm);
            flowLayoutPanelInventory.Controls.Remove(source);
            source.DeleteInventoryItem -= DeleteInventoryItem;
            source.EditInventoryItem -= EditInventoryItem;
            source.EquipInventoryItem -= EquipInventoryItem;
            itemForm.UnequipEquipmentItem += UnequipEquipmentItem;
        }

        private void UnequipEquipmentItem(EquipmentItem source, EventArgs e)
        {
            _commandExecutor.UnequipItem(Character, source.Item);
            InventoryItem itemForm = new InventoryItem(source.Item);
            flowLayoutPanelInventory.Controls.Add(itemForm);
            flowLayoutPanelEquipment.Controls.Remove(source);
            itemForm.DeleteInventoryItem += DeleteInventoryItem;
            itemForm.EditInventoryItem += EditInventoryItem;
            itemForm.EquipInventoryItem += EquipInventoryItem;
            source.UnequipEquipmentItem -= UnequipEquipmentItem;
        }

        private bool SaveInventoryItem()
        {
            return _commandExecutor.EditCharacterItem(Character, _itemToEdit.Item, textBoxNewItemName.Text, comboBoxNewItemCategory.Text,
                textBoxNewItemCost.Text, textBoxNewItemWeight.Text, richTextBoxNewItemDescription.Text);
        }

        private void ResetNewItemPanel()
        {
            textBoxNewItemName.Text = string.Empty;
            textBoxNewItemCost.Text = string.Empty;
            textBoxNewItemWeight.Text = string.Empty;
            richTextBoxNewItemDescription.Text = string.Empty;
            comboBoxNewItemCategory.Text = string.Empty;
            panelNewItem.Visible = false;
            panelItemList.Visible = true;
        }

        private void ButtonNewItemDiscard_Click(object sender, EventArgs e)
        {
            ResetNewItemPanel();
        }

        public async void NewItemWrongSave()
        {
            textBoxNewItemName.BackColor = Color.FromArgb(255, 243, 214);
            comboBoxNewItemCategory.BackColor = Color.FromArgb(255, 243, 214);
            textBoxNewItemCost.BackColor = Color.FromArgb(255, 243, 214);
            textBoxNewItemWeight.BackColor = Color.FromArgb(255, 243, 214);
            await Task.Delay(1000);
            textBoxNewItemName.BackColor = Color.FromArgb(247, 233, 204);
            comboBoxNewItemCategory.BackColor = Color.FromArgb(247, 233, 204);
            textBoxNewItemCost.BackColor = Color.FromArgb(247, 233, 204);
            textBoxNewItemWeight.BackColor = Color.FromArgb(247, 233, 204);
        }

        private void ButtonNewItemSave_Click(object sender, EventArgs e)
        {
            if (_itemToEdit is null)
            {
                Item item = _commandExecutor.AddCharacterItem(Character, textBoxNewItemName.Text, comboBoxNewItemCategory.Text, textBoxNewItemCost.Text,
                    textBoxNewItemWeight.Text, richTextBoxNewItemDescription.Text);
                if (item == null)
                {
                    NewItemWrongSave();
                    return;
                }
                InventoryItem itemForm = new InventoryItem(item);
                flowLayoutPanelInventory.Controls.Add(itemForm);
                itemForm.DeleteInventoryItem += DeleteInventoryItem;
                itemForm.EditInventoryItem += EditInventoryItem;
                itemForm.EquipInventoryItem += EquipInventoryItem;
            }
            else
            {
                if (!SaveInventoryItem())
                {
                    NewItemWrongSave();
                    return;
                }
                _itemToEdit.UpdateLabels();
                _itemToEdit = null;
            }
            ResetNewItemPanel();
            RefreshWeightLabel();
            RefreshCategories();
        }

        private void ResetNewSpellPanel()
        {
            textBoxNewSpellName.Text = string.Empty;
            comboBoxNewSpellLevel.SelectedIndex = 0;
            comboBoxNewSpellSchool.SelectedIndex = 0;
            textBoxNewSpellRange.Text = string.Empty;
            textBoxNewSpellDuration.Text = string.Empty;
            textBoxNewSpellCastingTIme.Text = string.Empty;
            checkBoxNewSpellV.Checked = false;
            checkBoxNewSpellS.Checked = false;
            checkBoxNewSpellM.Checked = false;
            checkBoxNewSpellConcetration.Checked = false;
            checkBoxNewSpellRitual.Checked = false;
            panelNewSpell.Visible = false;
            panelSpellList.Visible = true;
            richTextBoxNewSpellDescription.Text = string.Empty;
        }

        private void ButtonNewSpellDiscard_Click(object sender, EventArgs e)
        {
            ResetNewSpellPanel();
        }
        public async void NewSpellWrongSave()
        {
            textBoxNewSpellName.BackColor = Color.FromArgb(255, 243, 214);
            comboBoxNewSpellLevel.BackColor = Color.FromArgb(255, 243, 214);
            comboBoxNewSpellSchool.BackColor = Color.FromArgb(255, 243, 214);
            textBoxNewSpellRange.BackColor = Color.FromArgb(255, 243, 214);
            textBoxNewSpellDuration.BackColor = Color.FromArgb(255, 243, 214);
            textBoxNewSpellCastingTIme.BackColor = Color.FromArgb(255, 243, 214);
            await Task.Delay(1000);
            textBoxNewSpellName.BackColor = Color.FromArgb(247, 233, 204);
            comboBoxNewSpellLevel.BackColor = Color.FromArgb(247, 233, 204);
            comboBoxNewSpellSchool.BackColor = Color.FromArgb(247, 233, 204);
            textBoxNewSpellRange.BackColor = Color.FromArgb(247, 233, 204);
            textBoxNewSpellDuration.BackColor = Color.FromArgb(247, 233, 204);
            textBoxNewSpellCastingTIme.BackColor = Color.FromArgb(247, 233, 204);
        }

        private void ButtonNewSpellSave_Click(object sender, EventArgs e)
        {
            if (_spellToEdit == null)
            {
                Spell spell = _commandExecutor.AddCharacterSpell(Character, textBoxNewSpellName.Text, comboBoxNewSpellLevel.Text, comboBoxNewSpellSchool.Text,
                    textBoxNewSpellRange.Text, checkBoxNewSpellV.Checked, checkBoxNewSpellS.Checked, checkBoxNewSpellM.Checked, textBoxNewSpellCastingTIme.Text,
                    textBoxNewSpellDuration.Text, checkBoxNewSpellConcetration.Checked, checkBoxNewSpellRitual.Checked, richTextBoxNewSpellDescription.Text);
                if (spell == null)
                {
                    NewSpellWrongSave();
                    return;
                }
                LearntSpell spellForm = new LearntSpell(spell);
                spellForm.DeleteLearntSpell += DeleteLearntSpell;
                spellForm.EditLearntSpell += EditLearntSpell;
                flowLayoutPanelSpells.Controls.Add(spellForm);
            }
            else
            {
                if (!SaveLearntSpell())
                {
                    NewSpellWrongSave();
                    return;
                }
                _spellToEdit.UpdateLabels();
                _spellToEdit = null;
            }
            comboBoxSpellLevelFilter.SelectedIndex = 0;
            comboBoxSpellSchoolFilter.SelectedIndex = 0;
            SpellFilterChanged();
            ResetNewSpellPanel();
        }

        private void EditLearntSpell(LearntSpell source, EventArgs e)
        {
            ButtonAddSpell_Click(source, e);
            _spellToEdit = source;
            textBoxNewSpellName.Text = source.Spell.Name;
            comboBoxNewSpellLevel.SelectedIndex = (int)source.Spell.Level;
            comboBoxNewSpellSchool.SelectedIndex = (int)source.Spell.School;
            textBoxNewSpellRange.Text = source.Spell.Range;
            textBoxNewSpellDuration.Text = source.Spell.Duration;
            textBoxNewSpellCastingTIme.Text = source.Spell.CastingTime;
            checkBoxNewSpellV.Checked = source.Spell.Componenets.Item1;
            checkBoxNewSpellS.Checked = source.Spell.Componenets.Item2;
            checkBoxNewSpellM.Checked = source.Spell.Componenets.Item3;
            checkBoxNewSpellRitual.Checked = source.Spell.Ritual;
            checkBoxNewSpellConcetration.Checked = source.Spell.Concentration;
            richTextBoxNewSpellDescription.Text = source.Spell.Description;
        }

        private bool SaveLearntSpell()
        {
            return _commandExecutor.EditCharacterSpell(Character, _spellToEdit.Spell, textBoxNewSpellName.Text, comboBoxNewSpellLevel.Text, comboBoxNewSpellSchool.Text,
                    textBoxNewSpellRange.Text, checkBoxNewSpellV.Checked, checkBoxNewSpellS.Checked, checkBoxNewSpellM.Checked, textBoxNewSpellCastingTIme.Text,
                    textBoxNewSpellDuration.Text, checkBoxNewSpellConcetration.Checked, checkBoxNewSpellRitual.Checked, richTextBoxNewSpellDescription.Text);
        }

        private void DeleteLearntSpell(LearntSpell source, EventArgs e)
        {
            flowLayoutPanelSpells.Controls.Remove(source);
            source.DeleteLearntSpell -= DeleteLearntSpell;
            source.EditLearntSpell -= EditLearntSpell;
            Character.Spells.Remove(source.Spell);
        }

        private void TextBoxNewItemWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ButtonIncreasePP_Click(object sender, EventArgs e)
        {
            _commandExecutor.ChangeCharacterMoney(Character, 0, true);
            RefreshMoneyLabels();
        }

        private void ButtonDecreasePP_Click(object sender, EventArgs e)
        {
            _commandExecutor.ChangeCharacterMoney(Character, 0, false);
            RefreshMoneyLabels();
        }

        private void ButtonIncreaseGP_Click(object sender, EventArgs e)
        {
            _commandExecutor.ChangeCharacterMoney(Character, 1, true);
            RefreshMoneyLabels();
        }

        private void ButtonDecreaseGP_Click(object sender, EventArgs e)
        {
            _commandExecutor.ChangeCharacterMoney(Character, 1, false);
            RefreshMoneyLabels();
        }

        private void ButtonIncreaseEP_Click(object sender, EventArgs e)
        {
            _commandExecutor.ChangeCharacterMoney(Character, 2, true);
            RefreshMoneyLabels();
        }

        private void ButtonDecreaseEP_Click(object sender, EventArgs e)
        {
            _commandExecutor.ChangeCharacterMoney(Character, 2, false);
            RefreshMoneyLabels();
        }

        private void ButtonIncreaseSP_Click(object sender, EventArgs e)
        {
            _commandExecutor.ChangeCharacterMoney(Character, 3, true);
            RefreshMoneyLabels();
        }

        private void ButtonDecreaseSP_Click(object sender, EventArgs e)
        {
            _commandExecutor.ChangeCharacterMoney(Character, 3, false);
            RefreshMoneyLabels();
        }

        private void ButtonIncreaseCP_Click(object sender, EventArgs e)
        {
            _commandExecutor.ChangeCharacterMoney(Character, 4, true);
            RefreshMoneyLabels();
        }

        private void ButtonDecreaseCP_Click(object sender, EventArgs e)
        {
            _commandExecutor.ChangeCharacterMoney(Character, 4, false);
            RefreshMoneyLabels();
        }

        private void RefreshMoneyLabels()
        {
            _money[0].Text = $"PP: {Character.Money[0]}";
            _money[1].Text = $"GP: {Character.Money[1]}";
            _money[2].Text = $"EP: {Character.Money[2]}";
            _money[3].Text = $"SP: {Character.Money[3]}";
            _money[4].Text = $"CP: {Character.Money[4]}";
        }

        private void RefreshWeightLabel()
        {
            labelWeight.Text = $"{Character.CurrentWeight} / {Character.MaxWeight}";
        }

        private void RefreshHpLabels()
        {
            labelHpCurrent.Text = $"{Character.CurrentHp}";
            labelHpMaximum.Text = $"{Character.MaxHp}";
            labelTemporaryHp.Text = $"{Character.TemporaryHp}";
            textBoxHp.Text = string.Empty;
        }

        private void ButtonDamage_Click(object sender, EventArgs e)
        {
            _commandExecutor.DamageCharacter(Character, textBoxHp.Text);
            RefreshHpLabels();
        }

        private void ButtonHeal_Click(object sender, EventArgs e)
        {
            _commandExecutor.HealCharacter(Character, textBoxHp.Text);
            RefreshHpLabels();
        }

        private void ButtonIncreaseMax_Click(object sender, EventArgs e)
        {
            _commandExecutor.ChangeMaxCharacterHp(Character, textBoxHp.Text, true);
            RefreshHpLabels();
        }

        private void ButtonDecreaseMax_Click(object sender, EventArgs e)
        {
            _commandExecutor.ChangeMaxCharacterHp(Character, textBoxHp.Text, false);
            RefreshHpLabels();
        }

        private void ButtonSetTemporary_Click(object sender, EventArgs e)
        {
            _commandExecutor.SetCharacterTemporaryHp(Character, textBoxHp.Text);
            RefreshHpLabels();
        }

        private void TextBoxHp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ButtonWeightIncrease_Click(object sender, EventArgs e)
        {
            _commandExecutor.ChangeCharacterMaxWeight(Character, true);
            RefreshWeightLabel();
        }

        private void ButtonWeightDecrease_Click(object sender, EventArgs e)
        {
            _commandExecutor.ChangeCharacterMaxWeight(Character, false);
            RefreshWeightLabel();
        }

        private void ComboBoxItemCategoryFIlter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string category = comboBoxItemCategoryFilter.SelectedItem as string;
            foreach (InventoryItem itemHeader in flowLayoutPanelInventory.Controls)
            {
                if (itemHeader.Item.Category == category || category == "All")
                {
                    itemHeader.Visible = true;
                }
                else
                {
                    itemHeader.Visible = false;
                }
            }
        }

        private void SpellFilterChanged()
        {
            SpellLevel level = _commandExecutor.ParseSpellLevel(comboBoxSpellLevelFilter.SelectedItem as string);
            SpellSchool school = _commandExecutor.ParseSpellSchool(comboBoxSpellSchoolFilter.SelectedItem as string);
            foreach (LearntSpell spellHeader in flowLayoutPanelSpells.Controls)
            {
                if ((spellHeader.Spell.Level == level || level == SpellLevel.None)
                    && (spellHeader.Spell.School == school || school == SpellSchool.None))
                {
                    spellHeader.Visible = true;
                }
                else
                {
                    spellHeader.Visible = false;
                }
            }
        }

        private void ComboBoxSpellLevelFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SpellFilterChanged();
        }

        private void ComboBoxSpellSchoolFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SpellFilterChanged();
        }
    }
}
