using System;
using System.Configuration;
using System.Windows.Forms;

namespace StringConverter
{
    /// <summary>
    /// String Converted Form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ConverterForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConverterForm" /> class.
        /// </summary>
        public ConverterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btnEncrypt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            this.lnkConvertedString.Visible = false;
            this.lnkError.Visible = false;
            var secureKey = this.txtHashKey.Text;
            var stringToEncrypt = this.txtString.Text;

            try
            {
                this.lnkConvertedString.Text = SecureString.Encrypt(stringToEncrypt, secureKey);
                this.lnkConvertedString.Visible = true;
            }
            catch (Exception ex)
            {
                this.lnkError.Text = ex.Message;
                this.toolTip.SetToolTip(this.lnkError, "Failed to encrypt.");
                this.lnkError.Visible = true;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnDecrypt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            this.lnkConvertedString.Visible = false;
            this.lnkError.Visible = false;
            var secureKey = this.txtHashKey.Text;
            var stringToDecrypt = this.txtString.Text;

            try
            {
                this.lnkConvertedString.Text = SecureString.Decrypt(stringToDecrypt, secureKey);
                this.lnkConvertedString.Visible = true;
            }
            catch (Exception ex)
            {
                this.lnkError.Text = ex.Message;
                this.toolTip.SetToolTip(this.lnkError, "Failed to decrypt.");
                this.lnkError.Visible = true;
            }
        }

        /// <summary>
        /// Handles the Click event of the lnkConvertedString control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void lnkConvertedString_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl is LinkLabel)
            {
                Clipboard.SetDataObject(((LinkLabel)this.ActiveControl).Text, true);
            }
        }

        /// <summary>
        /// Handles the DoubleClick event of the txtString control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void txtString_DoubleClick(object sender, EventArgs e)
        {
            this.txtString.SelectAll();
            this.txtString.Focus(); //you need to call this to show selection if it doesn't has focus
        }

        /// <summary>
        /// Handles the Click event of the btnReset control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtHashKey.Text = ConfigurationManager.AppSettings["HashKey"] ?? "My Hash Key";
            this.txtString.Text = string.Empty;

            this.lnkConvertedString.Text = "Converted String";
            this.lnkConvertedString.Visible = false;

            this.lnkError.Text = "Error";
            this.lnkError.Visible = false;
        }

        private void ConverterForm_Load(object sender, EventArgs e)
        {
            this.txtHashKey.Text = ConfigurationManager.AppSettings["HashKey"] ?? "My Hash Key";
        }
    }
}
