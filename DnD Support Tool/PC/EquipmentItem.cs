using System;
using System.Windows.Forms;
using BackendLogic.PC;

namespace Formulars.PC
{
    public partial class EquipmentItem : UserControl
    {
        public Item Item { get; set; }
        private int _originalHeight;

        public delegate void UnequipEquipmentItemEventHandler(EquipmentItem source, EventArgs args);
        public event UnequipEquipmentItemEventHandler UnequipEquipmentItem;

        public EquipmentItem()
        {
            InitializeComponent();
            _originalHeight = Height;
            Height = 31;
        }

        public EquipmentItem(Item item)
        {
            InitializeComponent();
            Item = item;
            _originalHeight = Height;
            Height = 31;
            UpdateLabels();
        }

        public void UpdateLabels()
        {
            labelName.Text = Item.Name;
            labelCategory.Text = Item.Category;
            labelCost.Text = Item.CostToString();
            labelWeight.Text = Item.Weight.ToString() + " lb";
            richTextBoxDescription.Text = Item.Description;
        }

        private void LabelName_Click(object sender, EventArgs e)
        {
            if (Height == 31)
            {
                Height = _originalHeight;
            }
            else
            {
                Height = 31;
            }
        }

        private void ButtonEquip_Click(object sender, EventArgs e)
        {
            UnequipEquipmentItem?.Invoke(this, EventArgs.Empty);
        }
    }
}
