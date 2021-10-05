using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndersonE_Assignment2
{
    public partial class Form1 : Form
    {
        public static List<Cereal> cereals = ListManager.LoadCereal();
        public static List<Cereal> modCereals = new List<Cereal>();

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            RepopulateCereals(cereals);
            modCereals = cereals;
            ZeroOutComboBoxes();
        }








        #region buttons!
        private void btn_sirl_Click(object sender, EventArgs e)
        {
            BtnPressMfr();
            BtnPressType(); 
            DetermineFilter(); 
            Grid_Cereal_Update();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ClearTxtBoxFields();
            Reset_RadioBtns();
            ZeroOutComboBoxes(); 
            RepopulateCereals(cereals);
            modCereals = cereals; 
        }
        #endregion


        #region Radio Clicks

        /// <summary>
        /// Triggered when the 'Greatest Calories' button is pressed. checks to make sure the Checked condition is true, then runs GreatestCals() method. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rad_gCal_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_gCal.Checked == true)
                GreatestCals();
        }

        /// <summary>
        /// Triggered when the 'Lowest Calories' button is pressed. checks to make sure the Checked condition is true, then runs LowestCals() method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rad_LCal_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_LCal.Checked == true)
                LowestCals();
        }

        private void rad_GProtein_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_GProtein.Checked == true)
                GreatestProtein();
        }

        private void rad_LProtein_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_LProtein.Checked == true)
                LowestProtein();
        }

        private void rad_GFat_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_GFat.Checked == true)
                GreatestFat();
        }

        private void rad_LFat_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_LFat.Checked == true)
                LowestFat();
        }

        private void rad_GSodium_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_GSodium.Checked == true)
                GreatestSodium();
        }

        private void rad_LSodium_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_LSodium.Checked == true)
                LowestSodium();
        }

        private void rad_GFiber_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_GFiber.Checked == true)
                GreatestFiber();
        }

        private void rad_LFiber_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_LFiber.Checked == true)
                LowestFiber();
        }

        private void rad_GCarbs_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_GCarbs.Checked == true)
                GreatestCarbs();
        }

        private void rad_LCarbs_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_LCarbs.Checked == true)
                LowestCarbs();
        }

        private void rad_GSugars_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_GSugars.Checked == true)
                GreatestSugars();
        }

        private void rad_LSugars_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_LSugars.Checked == true)
                LowestSugars();
        }

        private void rad_GPotass_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_GPotass.Checked == true)
                GreatestPotass();
        }

        private void rad_LPotass_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_LPotass.Checked == true)
                LowestPotass();
        }

        private void rad_GVita_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_GVita.Checked == true)
                GreatestVita();
        }

        private void rad_LVita_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_LVita.Checked == true)
                LowestVita();
        }

        private void rad_GShelf_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_GShelf.Checked == true)
                GreatestShelf();
        }

        private void rad_LShelf_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_LShelf.Checked == true)
                LowestShelf();
        }

        private void rad_GWeight_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_GWeight.Checked == true)
                GreatestWeight();
        }

        private void rad_LWeight_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_LWeight.Checked == true)
                LowestWeight();
        }

        private void rad_GCups_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_GCups.Checked == true)
                GreatestCups();
        }

        private void rad_LCups_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_LCups.Checked == true)
                LowestCups();
        }

        private void rad_GRating_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_GRating.Checked == true)
                GreatestRating();
        }

        private void Rad_LRating_CheckedChanged(object sender, EventArgs e)
        {
            if (Rad_LRating.Checked == true)
                LowestRating();
        }

        #endregion


        #region sorting methods

        #region sorting Cals

        private void GreatestCals()
        {
            modCereals = cereals.OrderByDescending(x => Convert.ToInt32(x.CerealCals)).ToList();
        }

        private void LowestCals()
        {
            modCereals = cereals.OrderBy(x => Convert.ToInt32(x.CerealCals)).ToList();
        }
        #endregion

        #region sorting protein
        private void GreatestProtein()
        {
            modCereals = cereals.OrderByDescending(x => Convert.ToInt32(x.CerealProtein)).ToList();
        }

        private void LowestProtein()
        {
            modCereals = cereals.OrderBy(x => Convert.ToInt32(x.CerealProtein)).ToList();
        }
        #endregion

        #region Sorting Fat
        private void GreatestFat()
        {
            modCereals = cereals.OrderByDescending(x => Convert.ToInt32(x.CerealFat)).ToList();
        }

        private void LowestFat()
        {
            modCereals = cereals.OrderBy(x => Convert.ToInt32(x.CerealFat)).ToList();
        }
        #endregion

        #region Sorting Sodium
        private void GreatestSodium()
        {
            modCereals = cereals.OrderByDescending(x => Convert.ToDouble(x.CerealSodium)).ToList();
        }

        private void LowestSodium()
        {
            modCereals = cereals.OrderBy(x => Convert.ToDouble(x.CerealSodium)).ToList();
        }
        #endregion

        #region Sorting Fiber

        private void GreatestFiber()
        {
            modCereals = cereals.OrderByDescending(x => Convert.ToDouble(x.CerealFiber)).ToList();
        }

        private void LowestFiber()
        {
            modCereals = cereals.OrderBy(x => Convert.ToDouble(x.CerealFiber)).ToList();
        }
        #endregion

        #region Sorting Carbs

        private void GreatestCarbs()
        {
            modCereals = cereals.OrderByDescending(x => Convert.ToDouble(x.CerealCarbs)).ToList();
        }

        private void LowestCarbs()
        {
            modCereals = cereals.OrderBy(x => Convert.ToDouble(x.CerealCarbs)).ToList();
        }
        #endregion

        #region Sorting Sugar

        private void GreatestSugars()
        {
            modCereals = cereals.OrderByDescending(x => Convert.ToDouble(x.CerealSugars)).ToList();
        }

        private void LowestSugars()
        {
            modCereals = cereals.OrderBy(x => Convert.ToDouble(x.CerealSugars)).ToList();
        }
        #endregion

        #region Sorting Potassium

        private void GreatestPotass()
        {
            modCereals = cereals.OrderByDescending(x => Convert.ToDouble(x.CerealPotass)).ToList();
        }

        private void LowestPotass()
        {
            modCereals = cereals.OrderBy(x => Convert.ToDouble(x.CerealPotass)).ToList();
        }
        #endregion

        #region Sorting Vitamins

        private void GreatestVita()
        {
            modCereals = cereals.OrderByDescending(x => Convert.ToDouble(x.CerealVitamins)).ToList();
        }

        private void LowestVita()
        {
            modCereals = cereals.OrderBy(x => Convert.ToDouble(x.CerealVitamins)).ToList();
        }
        #endregion

        #region Sorting Shelf Life

        private void GreatestShelf()
        {
            modCereals = cereals.OrderByDescending(x => Convert.ToDouble(x.CerealShelf)).ToList();
        }

        private void LowestShelf()
        {
            modCereals = cereals.OrderBy(x => Convert.ToDouble(x.CerealShelf)).ToList();
        }
        #endregion

        #region Sorting Weight
        private void GreatestWeight()
        {
            modCereals = cereals.OrderByDescending(x => Convert.ToDouble(x.CerealWeight)).ToList();
        }

        private void LowestWeight()
        {
            modCereals = cereals.OrderBy(x => Convert.ToDouble(x.CerealWeight)).ToList();
        }
        #endregion

        #region Sorting Cups

        private void GreatestCups()
        {
            modCereals = cereals.OrderByDescending(x => Convert.ToDouble(x.CerealCups)).ToList();
        }

        private void LowestCups()
        {
            modCereals = cereals.OrderBy(x => Convert.ToDouble(x.CerealCups)).ToList();
        }
        #endregion

        #region Sorting Rating
        private void GreatestRating()
        {
            modCereals = cereals.OrderByDescending(x => Convert.ToDouble(x.CerealRating)).ToList();
        }

        private void LowestRating()
        {
            modCereals = cereals.OrderBy(x => Convert.ToDouble(x.CerealRating)).ToList();
        }
        #endregion

        #endregion

        #region Manufacturer Methods

        private void FilteredByManufacturer(string key)
        {
            modCereals = modCereals.Where(x => x.CerealMfr == key).ToList();
        }

        private string DetermineMfrKey()
        {
            return Cmb_Mfr.SelectedItem.ToString();
        }

        private void BtnPressMfr()
        {
            string key = DetermineMfrKey();
            if (key != "All")
                FilteredByManufacturer(key);
        }
        #endregion

        #region Cereal Type Methods

        private void FilteredbyType(string key)
        {
            modCereals = modCereals.Where(x => x.CerealType == key).ToList();
        }

        private string DetermineTypeKey()
        {
            return cmb_Type.SelectedItem.ToString();
        }

        private void BtnPressType()
        {
            string key = DetermineTypeKey();
            if (key != "All")
                FilteredbyType(key);
        }

        #endregion

        #region min/max Methods

        /// <summary>
        /// clears the text boxes to empty strings. 
        /// </summary>
        private void ClearTxtBoxFields()
        {
            this.txt_Max.Text = string.Empty;
            this.txt_Min.Text = string.Empty;
        }

        /// <summary>
        /// checks that max box value is greater than min box. Will have already checked values are numbers. 
        /// </summary>
        /// <returns></returns>
        private bool MaxBoxBigger()
        {
            return (Convert.ToDouble(txt_Max) > Convert.ToDouble(txt_Min));
        }

        private void VerifyFloat(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void txt_Min_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyFloat(sender, e);
        }

        private void txt_Max_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyFloat(sender, e);
        }

        private bool EmptyString(string input)
        {
            if (input.Length == 0)
                return true;
            return false; 
        } 

        private bool CheckEmptyTxtBox()
        {
            if (EmptyString(txt_Max.Text) && EmptyString(txt_Min.Text))
                return true;
            return false; 
        }

        private void DetermineFilter()
        {
            if (!CheckEmptyTxtBox())
            {
                if (rad_gCal.Checked == true || rad_LCal.Checked == true)
                    FilterByCals();
                else if (rad_GProtein.Checked == true || rad_LProtein.Checked == true)
                    FilterByProtein();
                else if (rad_GFat.Checked == true || rad_LFat.Checked == true)
                    FilterByFat();
                else if (rad_GSodium.Checked == true || rad_LSodium.Checked == true)
                    FilterBySodium();
                else if (rad_GFiber.Checked == true || rad_LFiber.Checked == true)
                    FilterByFiber();
                else if (rad_GCarbs.Checked == true || rad_LCarbs.Checked == true)
                    FilterByCarbs();
                else if (rad_GSugars.Checked == true || rad_LSugars.Checked == true)
                    FilterbySugars();
                else if (rad_GPotass.Checked == true || rad_LPotass.Checked == true)
                    FilterByPotass();
                else if (rad_GVita.Checked == true || rad_LVita.Checked == true)
                    FilterByVitamins();
                else if (rad_GShelf.Checked == true || rad_LShelf.Checked == true)
                    FilterByShelf();
                else if (rad_GWeight.Checked == true || rad_LWeight.Checked == true)
                    FilterByWeight();
                else if (rad_GCups.Checked == true || rad_LCups.Checked == true)
                    FilterByCups();
                else if (rad_GRating.Checked == true || Rad_LRating.Checked == true)
                    filterByRating();
            }
        }

        #region Min/Max Filters

        private void FilterByCals()
        {
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealCals)) >= (Convert.ToDouble(txt_Min.Text))).ToList();
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealCals)) <= (Convert.ToDouble(txt_Max.Text))).ToList(); 
        }

        private void FilterByProtein()
        {
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealProtein)) >= (Convert.ToDouble(txt_Min.Text))).ToList();
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealProtein)) <= (Convert.ToDouble(txt_Max.Text))).ToList();
        }

        private void FilterByFat()
        {
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealFat)) >= (Convert.ToDouble(txt_Min.Text))).ToList();
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealFat)) <= (Convert.ToDouble(txt_Max.Text))).ToList();
        }

        private void FilterBySodium()
        {
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealSodium)) >= (Convert.ToDouble(txt_Min.Text))).ToList();
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealSodium)) <= (Convert.ToDouble(txt_Max.Text))).ToList();
        }

        private void FilterByFiber()
        {
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealFiber)) >= (Convert.ToDouble(txt_Min.Text))).ToList();
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealFiber)) <= (Convert.ToDouble(txt_Max.Text))).ToList();
        }
        
        private void FilterByCarbs()
        {
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealCarbs)) >= (Convert.ToDouble(txt_Min.Text))).ToList();
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealCarbs)) <= (Convert.ToDouble(txt_Max.Text))).ToList();
        }

        private void FilterbySugars()
        {
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealSugars)) >= (Convert.ToDouble(txt_Min.Text))).ToList();
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealSugars)) <= (Convert.ToDouble(txt_Max.Text))).ToList();
        }

        private void FilterByPotass()
        {
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealPotass)) >= (Convert.ToDouble(txt_Min.Text))).ToList();
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealPotass)) <= (Convert.ToDouble(txt_Max.Text))).ToList();
        }

        private void FilterByVitamins()
        {
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealVitamins)) >= (Convert.ToDouble(txt_Min.Text))).ToList();
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealVitamins)) <= (Convert.ToDouble(txt_Max.Text))).ToList();
        }

        private void FilterByShelf()
        {
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealShelf)) >= (Convert.ToDouble(txt_Min.Text))).ToList();
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealShelf)) <= (Convert.ToDouble(txt_Max.Text))).ToList();
        }

        private void FilterByWeight()
        {
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealWeight)) >= (Convert.ToDouble(txt_Min.Text))).ToList();
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealWeight)) <= (Convert.ToDouble(txt_Max.Text))).ToList();
        }

        private void FilterByCups()
        {
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealCups)) >= (Convert.ToDouble(txt_Min.Text))).ToList();
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealCups)) <= (Convert.ToDouble(txt_Max.Text))).ToList();

        }

        private void filterByRating()
        {
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealRating)) >= (Convert.ToDouble(txt_Min.Text))).ToList();
            modCereals = modCereals.Where(x => (Convert.ToDouble(x.CerealRating)) <= (Convert.ToDouble(txt_Max.Text))).ToList();
        }

        #endregion
        #endregion


        #region Helper methods
        /// <summary>
        /// quick method that places cereal list into Grid_Cereals
        /// </summary>
        private void RepopulateCereals(List<Cereal> sirl)
        {
            Grid_Cereals.Rows.Clear(); 

            foreach (var crl in sirl)
            {

                Grid_Cereals.Rows.Add(crl.CerealName, crl.CerealMfr, crl.CerealType, crl.CerealCals, crl.CerealProtein, crl.CerealFat, crl.CerealSodium,
                    crl.CerealFiber, crl.CerealCarbs, crl.CerealSugars, crl.CerealPotass, crl.CerealVitamins, crl.CerealShelf, crl.CerealWeight, crl.CerealCups, crl.CerealRating);

            }
            Grid_Cereals.Update(); 
            Grid_Cereals.Refresh(); 
        }

        /// <summary>
        /// repopulates the GridView with modCereals list. 
        /// </summary>
        private void Grid_Cereal_Update()
        {
            RepopulateCereals(modCereals);
        }

        /// <summary>
        /// method to reset all radio buttons to being unchecked. 
        /// </summary>
        private void Reset_RadioBtns()
        {
            rad_gCal.Checked = false;
            rad_GCarbs.Checked = false;
            rad_GCups.Checked = false;
            rad_GFat.Checked = false;
            rad_GFiber.Checked = false;
            rad_GPotass.Checked = false;
            rad_GProtein.Checked = false;
            rad_GRating.Checked = false;
            rad_GShelf.Checked = false;
            rad_GSodium.Checked = false;
            rad_GSugars.Checked = false;
            rad_GVita.Checked = false;


            rad_LCal.Checked = false;
            rad_LCarbs.Checked = false;
            rad_LCups.Checked = false;
            rad_LFat.Checked = false;
            rad_LFiber.Checked = false;
            rad_LPotass.Checked = false;
            rad_LProtein.Checked = false;
            rad_LShelf.Checked = false;
            rad_LSodium.Checked = false;
            rad_LSugars.Checked = false;
            rad_LVita.Checked = false;
            Rad_LRating.Checked = false;

        }

        /// <summary>
        /// Sets the base value of combo boxes to index zero which is the item "All"
        /// </summary>
        private void ZeroOutComboBoxes()
        {
            Cmb_Mfr.SelectedIndex = 0;
            cmb_Type.SelectedIndex = 0;
        }




        #endregion


    }
}
