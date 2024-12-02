namespace WeaponDisplayGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbX_TextChanged(object sender, EventArgs e)
        {
            output_command();
        }

        private void output_command()
        {
            try
            {
                int x = Convert.ToInt32(tbX.Text);
                int y = Convert.ToInt32(tbY.Text);
                int z = Convert.ToInt32(tbZ.Text);
                string side = cbSide.Text;
                string weapon_type = cbWeaponType.Text;

                Console.WriteLine(generate_command(x, y, z, side, weapon_type));
                lbCommand.Text = generate_command(x, y, z, side, weapon_type);
            }
            catch (Exception ex)
            {
            }
        }

        private string generate_command(double x, double y, double z, string side, string weapon_type)
        {
            var TRIDENT_ANCHOR = new Dictionary<string, object>
            {
                { "-X", new List<double> { 90, 0.68, -0.21 } },
                { "-Z", new List<double> { 180, 0.21, 0.68 } },
                { "+X", new List<double> { 270, -0.68, 0.21 } },
                { "+Z", new List<double> { 0, -0.21, -0.68 } },
                { "Y", -1.35 },
                { "RightArm", new List<double> { -90, 240, -0.3 } }
            };
            var SWORD_ANCHOR = new Dictionary<string, object>
            {
                { "-X", new List<double> { 270, 0.96, 0.21 } },
                { "-Z", new List<double> { 0, -0.21, 0.96 } },
                { "+X", new List<double> { 90, -0.96, -0.21 } },
                { "+Z", new List<double> { 180, 0.21, -0.96 } },
                { "Y", -0.75 },
                { "RightArm", new List<double> { -279.5, 90, 0 } }
            };
            var MACE_ANCHOR = new Dictionary<string, object>
            {
                { "-X", new List<double> { 270, 0.83, 0.18 } },
                { "-Z", new List<double> { 0, -0.18, 0.83 } },
                { "+X", new List<double> { 90, -0.83, -0.18 } },
                { "+Z", new List<double> { 180, 0.18, -0.83 } },
                { "Y", -1.3 },
                { "RightArm", new List<double> { -99.8, 270, 0 } }
            };
            var AXE_ANCHOR = new Dictionary<string, object>
            {
                { "-X", new List<double> { 270, 0.85, 0.17 } },
                { "-Z", new List<double> { 0, -0.17, 0.85 } },
                { "+X", new List<double> { 90, -0.85, -0.17 } },
                { "+Z", new List<double> { 180, 0.17, -0.85 } },
                { "Y", -1.3 },
                { "RightArm", new List<double> { -100, 270, 0 } }
            };
            var BOW_ANCHOR = new Dictionary<string, object>
            {
                { "-X", new List<double> { 90, 0.52, -0.2 } },
                { "-Z", new List<double> { 180, 0.2, 0.52 } },
                { "+X", new List<double> { 270, -0.52, 0.2 } },
                { "+Z", new List<double> { 0, -0.2, -0.52 } },
                { "Y", -0.99 },
                { "RightArm", new List<double> { 180, 80, 85 } }
            };

            Dictionary<string, object> anchor;
            if (weapon_type == "Trident")
            {
                anchor = TRIDENT_ANCHOR;
            }
            else if (weapon_type == "Sword")
            {
                anchor = SWORD_ANCHOR;
            }
            else if (weapon_type == "Axe")
            {
                anchor = AXE_ANCHOR;
            }
            else if (weapon_type == "Mace")
            {
                anchor = MACE_ANCHOR;
            }
            else if (weapon_type == "Bow")
            {
                anchor = BOW_ANCHOR;
            }
            else
            {
                anchor = TRIDENT_ANCHOR;
            }

            string command = "";
            try
            {
                var anchor_data = (List<double>)anchor[side];
                x = Math.Round((x + 0.5) + anchor_data[1], 2);
                y = Math.Round(y + (double)anchor["Y"], 2);
                z = Math.Round((z + 0.5) + anchor_data[2], 2);
                List<double> right_arm = (List<double>)anchor["RightArm"];
                double rotation = Math.Round(anchor_data[0], 2);

                command = (
                    "summon armor_stand " + x + " " + y + " " + z
                    + " {ShowArms:1, Pose:{RightArm:[" + Math.Round(right_arm[0], 2) + "f, " + Math.Round(right_arm[1], 2) + "f, "
                    + Math.Round(right_arm[2], 2) + "f]}, Invisible:1, Rotation:[" + rotation
                    + "f, 0f], Invulnerable:0, NoGravity:1b}"
                );
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return command;
        }

        private void tbY_TextChanged(object sender, EventArgs e)
        {
            output_command();
        }

        private void tbZ_TextChanged(object sender, EventArgs e)
        {
            output_command();
        }

        private void cbSide_TextChanged(object sender, EventArgs e)
        {
            output_command();
        }

        private void cbWeaponType_TextChanged(object sender, EventArgs e)
        {
        }

        private async void btCopy_MouseUp(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(lbCommand.Text);
            lbCopied.Text = "Copied ✔️";

            await Task.Delay(1000);

            lbCopied.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cbWeaponType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbWeaponType.SelectedIndex == 0)
            {
                pbWeapon.BackgroundImage = Properties.Resources.trident;
            }
            else if (cbWeaponType.SelectedIndex == 1)
            {
                pbWeapon.BackgroundImage = Properties.Resources.mace;
            }
            else if (cbWeaponType.SelectedIndex == 2)
            {
                pbWeapon.BackgroundImage = Properties.Resources.axe;
            }
            else if (cbWeaponType.SelectedIndex == 3)
            {
                pbWeapon.BackgroundImage = Properties.Resources.sword;
            }
            else if (cbWeaponType.SelectedIndex == 4)
            {
                pbWeapon.BackgroundImage = Properties.Resources.bow;
            }

            output_command();
        }
    }
}
