using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aejynmain.HelperMethod
{
    internal class DamageHelper
    {
        // Fees for each damage type
        private static readonly int ScratchesFee = 500;
        private static readonly int DentsFee = 1000;
        private static readonly int BrokenGlassFee = 2000;
        private static readonly int InteriorStainsFee = 500;
        private static readonly int TireDamageFee = 600;
        private static readonly int PaintDamageFee = 700;

        // Calculate total damage based on checked checkboxes
        public static decimal CalculateTotal(
            CheckBox cbScratches,
            CheckBox cbDents,
            CheckBox cbBrokenGlass,
            CheckBox cbInteriorStains,
            CheckBox cbTireDamage,
            CheckBox cbPaintDamage)
        {
            decimal total = 0;
            if (cbScratches.Checked) total += ScratchesFee;
            if (cbDents.Checked) total += DentsFee;
            if (cbBrokenGlass.Checked) total += BrokenGlassFee;
            if (cbInteriorStains.Checked) total += InteriorStainsFee;
            if (cbTireDamage.Checked) total += TireDamageFee;
            if (cbPaintDamage.Checked) total += PaintDamageFee;
            return total;
        }

        // Clear all checkboxes
        public static void ClearAll(
            CheckBox cbScratches,
            CheckBox cbDents,
            CheckBox cbBrokenGlass,
            CheckBox cbInteriorStains,
            CheckBox cbTireDamage,
            CheckBox cbPaintDamage)
        {
            cbScratches.Checked = false;
            cbDents.Checked = false;
            cbBrokenGlass.Checked = false;
            cbInteriorStains.Checked = false;
            cbTireDamage.Checked = false;
            cbPaintDamage.Checked = false;
        }
    }
}
