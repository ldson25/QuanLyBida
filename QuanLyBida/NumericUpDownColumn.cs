using System;
using System.Windows.Forms;

namespace QuanLyBida
{
    public class DataGridViewNumericUpDownColumn : DataGridViewColumn
    {
        public DataGridViewNumericUpDownColumn() : base(new DataGridViewNumericUpDownCell()) { }

        public override DataGridViewCell CellTemplate
        {
            get => base.CellTemplate;
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(DataGridViewNumericUpDownCell)))
                    throw new InvalidCastException("Must be a DataGridViewNumericUpDownCell");
                base.CellTemplate = value;
            }
        }
    }

    public class DataGridViewNumericUpDownCell : DataGridViewTextBoxCell
    {
        public DataGridViewNumericUpDownCell() : base() { }

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            NumericUpDownEditingControl ctl = DataGridView.EditingControl as NumericUpDownEditingControl;

            if (this.Value != null && this.Value != DBNull.Value)
                ctl.Value = Convert.ToDecimal(this.Value);
            else
                ctl.Value = 1;
        }

        public override Type EditType => typeof(NumericUpDownEditingControl);
        public override Type ValueType => typeof(int);
        public override object DefaultNewRowValue => 1;
    }

    class NumericUpDownEditingControl : NumericUpDown, IDataGridViewEditingControl
    {
        DataGridView dataGridView;
        bool valueChanged = false;
        int rowIndex;

        public NumericUpDownEditingControl()
        {
            Minimum = 1;
            Maximum = 1000;
            DecimalPlaces = 0;
            ThousandsSeparator = true;
            TextAlign = HorizontalAlignment.Center;
        }

        public object EditingControlFormattedValue
        {
            get => Value.ToString("F0");
            set
            {
                if (value is string s)
                {
                    if (decimal.TryParse(s, out var v)) Value = v;
                    else Value = 1;
                }
            }
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context) => EditingControlFormattedValue;

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle style)
        {
            Font = style.Font;
            ForeColor = style.ForeColor;
            BackColor = style.BackColor;
        }

        public int EditingControlRowIndex { get => rowIndex; set => rowIndex = value; }
        public bool RepositionEditingControlOnValueChange => false;

        public DataGridView EditingControlDataGridView { get => dataGridView; set => dataGridView = value; }

        public bool EditingControlValueChanged { get => valueChanged; set => valueChanged = value; }

        public Cursor EditingPanelCursor => base.Cursor;

        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            switch (keyData & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return !dataGridViewWantsInputKey;
            }
        }

        public void PrepareEditingControlForEdit(bool selectAll) { }

        protected override void OnValueChanged(EventArgs e)
        {
            valueChanged = true;
            EditingControlDataGridView?.NotifyCurrentCellDirty(true);
            base.OnValueChanged(e);
        }
    }
}
