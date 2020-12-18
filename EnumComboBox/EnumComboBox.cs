using  Ghorbani_tools.CommonConsts;
using System;
using System.Windows.Forms;

namespace EnumComboBox
{
    public class EnumComboBox : ComboBox
    {

        private Enum _enumObject;
        public Enum EnumObject
        {
            get
            {
                return this._enumObject;
            }
            set
            {
                if (value != null)
                {
                    this._enumObject = value;
                    this.FillCombo();
                }
            }
        }
        public EnumComboBox()
        {
            this.DropDownStyle = ComboBoxStyle.DropDownList;

            this.SelectedIndexChanged += new EventHandler(EnumComboBoxSelectedIndexChanged);
        }

        private void EnumComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this._enumObject = (Enum)this.SelectedItem;
            }
            catch
            {
                this._enumObject = null;

            }
        }





        public bool IsValid
        {
            get
            {
                return this.SelectedItem.ToString() != Messages.Information.PlzChoose;
            }
        }

        public string DisplayResult
        {
            get
            {
                return IsValid ? this._enumObject.ToString().Replace("_", " ") : Messages.Information.PlzChoose;
            }
        }

        private void FillCombo()
        {
            Type TT = this._enumObject.GetType();
            object EnumObj = Activator.CreateInstance(TT);
            this.Items.Clear();

            foreach (int i in Enum.GetValues(EnumObj.GetType()))
            {
                object o = Enum.ToObject(EnumObj.GetType(), i);
                this.Items.Add(o);
            }
            Items.Insert(0, Messages.Information.PlzChoose);

            this.SelectedIndex = 0;
        }

    }
}
