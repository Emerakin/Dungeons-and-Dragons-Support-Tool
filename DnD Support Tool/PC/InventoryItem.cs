using System;
using System.Windows.Forms;
using BackendLogic.PC;

namespace Formulars.PC
{
    public partial class InventoryItem : UserControl
    {
        public Item Item { get; set; }
        private int _originalHeight;

        public delegate void DeleteInventoryItemEventHandler(InventoryItem source, EventArgs args);
        public event DeleteInventoryItemEventHandler DeleteInventoryItem;
        public delegate void EditInventoryItemEventHandler(InventoryItem source, EventArgs args);
        public event EditInventoryItemEventHandler EditInventoryItem;
        public delegate void EquipInventoryItemEventHandler(InventoryItem source, EventArgs args);
        public event EquipInventoryItemEventHandler EquipInventoryItem;

        public InventoryItem()
        {
            InitializeComponent();
            _originalHeight = Height;
            Height = 31;
        }

        public InventoryItem(Item item)
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
            EquipInventoryItem?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            EditInventoryItem?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteInventoryItem?.Invoke(this, EventArgs.Empty);
        }
    }
}
