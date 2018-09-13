using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieSearcher
{
    public partial class AutoResizingLabel : Label
    {
        #region  Public Constructors  

        public AutoResizingLabel()
        {
            this.AutoSize = false;
        }

        #endregion  Public Constructors  

        #region  Protected Overridden Methods  

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            this.FitToContents();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            this.FitToContents();
        }

        #endregion  Protected Overridden Methods  

        #region  Protected Virtual Methods  

        protected virtual void FitToContents()
        {
            Size size;

            size = this.GetPreferredSize(new Size(this.Width, 0));

            this.Height = size.Height;
        }

        #endregion  Protected Virtual Methods  

        #region  Public Properties  

        [DefaultValue(false), Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override bool AutoSize
        {
            get { return base.AutoSize; }
            set { base.AutoSize = value; }
        }

        #endregion  Public Properties  
    }
}

