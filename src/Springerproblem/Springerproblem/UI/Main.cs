using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Springerproblem
{
    public partial class Form1 : Form
    {
        // Brettdimensionen
        private int N = 8;

        // Das Schachbrett
        private int[,] Brett;

        // Die möglichen Springerzüge (x & y)
        private int[,] SpringerZuege =
        {
            { 2, -1 }, { 1, -2 }, { -2, -1 }, { -2, 1 },
            { 1, 2 },  { 2, 1  }, { -1, 2  }, { -1, -2},
        };
        // Züge
        private int zugNummer = 0;

        private ulong zugCount = 0;

        // Sind wir mit dem Algo fertig?
        private bool fertig = false;

        // Der Algorithmus
        private enum Algorithmus
        {
            BruteForce,
            Warnsdorf
        }

        public Form1()
        {
            InitializeComponent();
            Text += Version;

            // Springerproblem!
            this.N = (int)numericUpDownN.Value;
            this.Brett = new int[N,N];
            GeneriereSchachbrett();
        }

        private void GeneriereSchachbrett()
        {
            // TODO: Dynamische Form!
            var breite = N * 50;
            var höhe = breite;

            brettPanel.Size = new Size(breite, höhe);

            // Obj1: Umgebendes Objekt
            // Obj2: Zentriertes Objekt
            // centralPoint = (Obj1.Breite / 2 - Obj2.Breite / 2); 
            //                (Obj1.Länge / 2 - Obj2.Länge / 2)
            brettPanel.Location = new Point(brettGrpBx.Width / 2 - brettPanel.Width / 2,
                                              brettGrpBx.Height / 2 - brettPanel.Height / 2);

      
            // Rendern
            // TODO: DataGridView nutzen!
            Bitmap bm = new Bitmap(breite, höhe);
            Graphics g = Graphics.FromImage(bm);
            SolidBrush sbSchwarz = new SolidBrush(Color.Black);
            SolidBrush sbWeiß = new SolidBrush(Color.White);
            SolidBrush sbRot = new SolidBrush(Color.Red);

            for (int idxSpalten = N - 1; idxSpalten >= 0; idxSpalten--)
            {
                for (int idxZeilen = 0; idxZeilen < N; idxZeilen++)
                {
                    var feld = "abcdefghijklmnopqrstuvwxyz"[idxSpalten] + (N - idxZeilen).ToString();

                    if (idxSpalten % 2 == 0 && idxZeilen % 2 == 0 ||
                        idxSpalten % 2 != 0 && idxZeilen % 2 != 0)
                    {
                        g.FillRectangle(sbWeiß, idxSpalten * 50, idxZeilen * 50,50,50 );
                        g.DrawString(feld, DefaultFont, sbSchwarz, idxSpalten * 50, idxZeilen * 50);
                        g.DrawString(Brett[N - 1 - idxZeilen,idxSpalten].ToString(), DefaultFont, sbRot, idxSpalten * 50 + 20, idxZeilen * 50 + 20);
                    }
                    else
                    {
                        g.FillRectangle(sbSchwarz, idxSpalten * 50, idxZeilen * 50, 50, 50);
                        g.DrawString(feld, DefaultFont, sbWeiß, idxSpalten * 50, idxZeilen * 50);
                        g.DrawString(Brett[N - 1 - idxZeilen, idxSpalten].ToString(), DefaultFont, sbRot, idxSpalten * 50 + 20, idxZeilen * 50 + 20);
                    }
                }
            }

            brettPanel.BackgroundImage = bm;

        }


        private void Springe(int x, int y)
        {
            if (!ZugValide(x, y) || fertig)
                return;

            // Aha! Valider Springerzug. Ausführen!
            Brett[x, y] = ++zugNummer;

            // Prüfen, ob wir fertig sein!
            if (zugNummer == N * N)
            {
                fertig = true;
                GeneriereSchachbrett();
            }

            int[] hitListe = getZuege(x,y);

            for (int i = 0; i < 8; i++)
            {
                int j = hitListe[i];
                Springe(x + SpringerZuege[j, 0], y + SpringerZuege[j, 1]);
            }

            // Sackgasse => Zug zurücknehmen
            Brett[x, y] = 0;
            zugNummer--;
        }

        private int[] getZuege(int x, int y)
        {
            int[] zugMoeglichkeiten = new int[8];
            for (int i = 0; i < 8; i++)
                zugMoeglichkeiten[i] = getZugMoeglichkeiten(x + SpringerZuege[i, 0], y + SpringerZuege[i, 1]);

            int[] hitListe = new int[8];
            int j = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int k = 0; k < zugMoeglichkeiten.Length; k++)
                {
                    if (zugMoeglichkeiten[k] == i)
                        hitListe[j++] = k;
                }
            }
            return hitListe;
        }

        private int getZugMoeglichkeiten(int x, int y)
        {
            int tmp = 0;
            for (int i = 0; i < 8; i++)
                tmp += (ZugValide(x + SpringerZuege[i, 0], y + SpringerZuege[i, 1]) ? 1 : 0);
            return tmp;
        }

        private bool ZugValide(int x, int y) => (x < N && x >= 0)
                                                && (y < N && y >= 0)
                                                && Brett[x, y] == 0;

        // Wandelt x,y zu Schachnotation um
        // (0,0) => a1
        private String KoordinatenZuFeld(int x, int y) => "abcdefghijklmnopqrstuvwxyz"[x] + (y + 1).ToString();

        // (a1) => (0,0)
        // (a2) => (0,1)
        private Int32[] FeldZuKoordinate(String feld)
        {
            int[] ret = new int[2];
            int xKoordinate;
            if(Int32.TryParse(feld[1].ToString(), out xKoordinate))
                ret[0] = xKoordinate - 1;
            else
                MessageBox.Show("Falsche x-Koordinate!");
            ret[1] = "abcdefghijklmnopqrstuvwxyz".IndexOf(feld[0]);

            return ret;
        }

        private void numericUpDownN_ValueChanged(object sender, EventArgs e)
        {
            N = (int) numericUpDownN.Value;
            Brett = new int[N, N];
            GeneriereSchachbrett();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            
            var koordinaten = FeldZuKoordinate(startFeldBx.Text);
            var startX = koordinaten[0];
            var startY = koordinaten[1];
            if(ZugValide(startX, startY))
                Springe(startX, startY);
            else
            {
                MessageBox.Show("Dein Startfeld ist nicht Teil des Schachbretts (N=" + N + ")!", "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Springe(0, 0);
            }
            fertig = false;
        }


        // 1.0.0.0
        private String Version => Assembly
                                  .GetExecutingAssembly()
                                  .GetName().Version.ToString().Substring(0, 5);
    }
}
