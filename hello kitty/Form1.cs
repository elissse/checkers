using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace hello_kitty
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            StartPlaying();

        }

        const int fieldSize = 8;
        const int squareSize = 60;

        int currentPlayer;

        List<Button> oneSteps = new List<Button>();

        int countEatSteps = 0;
        Button prevSquare;
        Button pressedSquare;
        bool canContinue = false;

        bool isMoving;

        int[,] field = new int[fieldSize, fieldSize];

        Button[,] checkers = new Button[fieldSize, fieldSize];

        Image whiteFigure;
        Image blackFigure;
        Image whiteDame;
        Image blackDame;

        public Form1()
        {
            InitializeComponent();

            whiteFigure = new Bitmap(new Bitmap(@"D:\Downloads\y.png"), new Size(squareSize - 15, squareSize - 15));
            blackFigure = new Bitmap(new Bitmap(@"D:\Downloads\yp.png"), new Size(squareSize - 15, squareSize - 15));
            whiteDame = new Bitmap(new Bitmap(@"D:\Downloads\b.png"), new Size(squareSize - 15, squareSize - 15));
            blackDame = new Bitmap(new Bitmap(@"D:\Downloads\ppp.png"), new Size(squareSize - 15, squareSize - 15));

            this.Text = "Checkers";

            Init();
        }

        public void Init()
        {
            
            currentPlayer = 1;
            isMoving = false;
            prevSquare = null;


            field = new int[fieldSize, fieldSize] {
                { 0,1,0,1,0,1,0,1 },
                { 1,0,1,0,1,0,1,0 },
                { 0,1,0,1,0,1,0,1 },
                { 0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0 },
                { 2,0,2,0,2,0,2,0 },
                { 0,2,0,2,0,2,0,2 },
                { 2,0,2,0,2,0,2,0 }
            };

            CreateField();
        }

        public void ResetMove()
        {

            bool player1 = false;
            bool player2 = false;

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    if (field[i, j] == 1)
                        player1 = true;
                    if (field[i, j] == 2)
                        player2 = true;
                }
            }
            if (!player1 || !player2)
            {
                this.Controls.Clear();
                Init();
            }

        }

        public void CreateField()
        {
            this.Width = (fieldSize + 9) * squareSize;
            this.Height = (fieldSize + 3) * squareSize;

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    Button checker = new Button();
                    checker.Location = new Point(j * squareSize + 40, i * squareSize + 40);
                    checker.Size = new Size(squareSize, squareSize);
                    checker.Click += new EventHandler(OnFigurePress);
                    if (field[i, j] == 1)
                        checker.Image = whiteFigure;
                    else if (field[i, j] == 2) checker.Image = blackFigure;

                    checker.BackColor = GetPrevSquareColor(checker);
                    checker.ForeColor = Color.MidnightBlue;

                    checkers[i, j] = checker;

                    this.Controls.Add(checker);

                }
            }
        }

        public void SwitchPlayer()
        {
            currentPlayer = currentPlayer == 1 ? 2 : 1;
            ResetMove();
        }

        public Color GetPrevSquareColor(Button prevSquare)
        {
            if ((prevSquare.Location.Y / squareSize % 2) != 0)
            {
                if ((prevSquare.Location.X / squareSize % 2) == 0)
                {
                    return Color.HotPink;
                }
            }
            if ((prevSquare.Location.Y / squareSize) % 2 == 0)
            {
                if ((prevSquare.Location.X / squareSize) % 2 != 0)
                {
                    return Color.HotPink;
                }
            }
            return Color.LavenderBlush;
        }
        /*public void ComputerPlayer()
        {
            bool f = false;
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                {
                    if (field[i, j] == 2 && DeterminePath(i, j))
                    {
                        Button checker = new Button();
                        checker.Location = new Point(j * squareSize + 20, i * squareSize + 20);
                        checker.Size = new Size(squareSize, squareSize);
                        checker.PerformClick();
                        f = true;
                        break;
                    }
                    if 
                }
        }*/

        public void OnFigurePress(object sender, EventArgs e)
        {
            if (prevSquare != null)
                prevSquare.BackColor = GetPrevSquareColor(prevSquare);

            pressedSquare = sender as Button;

            if (field[pressedSquare.Location.Y / squareSize, pressedSquare.Location.X / squareSize] != 0 && field[pressedSquare.Location.Y / squareSize, pressedSquare.Location.X / squareSize] == currentPlayer)
            {
                CloseSteps();
                pressedSquare.BackColor = Color.MidnightBlue;
              //  DeactivateAllCheckers();
                pressedSquare.Enabled = true;
                countEatSteps = 0;
                if (pressedSquare.Text == " ")
                    ShowSteps(pressedSquare.Location.Y / squareSize, pressedSquare.Location.X / squareSize, false);
                else ShowSteps(pressedSquare.Location.Y / squareSize, pressedSquare.Location.X / squareSize);

                if (isMoving)
                {
                    CloseSteps();
                    pressedSquare.BackColor = GetPrevSquareColor(pressedSquare);
                    ShowPossibleSteps();
                    isMoving = false;
                }
                else
                    isMoving = true;
            }
            else
            {
                if (isMoving)
                {
                    canContinue = false;
                    if (prevSquare.Text == " " && Math.Abs(pressedSquare.Location.X / squareSize - prevSquare.Location.X / squareSize) > 1 && DidEatSomeone(pressedSquare, prevSquare))
                    {
                        canContinue = true;
                        DeleteEaten(pressedSquare, prevSquare);
                    }
                    else if (prevSquare.Text != " " && Math.Abs(pressedSquare.Location.X / squareSize - prevSquare.Location.X / squareSize) > 1)
                    {
                        canContinue = true;
                        DeleteEaten(pressedSquare, prevSquare);
                    }

                    int temp = field[pressedSquare.Location.Y / squareSize, pressedSquare.Location.X / squareSize];
                    field[pressedSquare.Location.Y / squareSize, pressedSquare.Location.X / squareSize] = field[prevSquare.Location.Y / squareSize, prevSquare.Location.X / squareSize];
                    field[prevSquare.Location.Y / squareSize, prevSquare.Location.X / squareSize] = temp;
                    pressedSquare.Image = prevSquare.Image;
                    prevSquare.Image = null;
                    pressedSquare.Text = prevSquare.Text;
                    prevSquare.Text = "";
                    MagicalTransformation(pressedSquare);
                    countEatSteps = 0;
                    isMoving = false;
                    CloseSteps();
                  //  DeactivateAllCheckers();
                    if (pressedSquare.Text == " ")
                        ShowSteps(pressedSquare.Location.Y / squareSize, pressedSquare.Location.X / squareSize, false);
                    else ShowSteps(pressedSquare.Location.Y / squareSize, pressedSquare.Location.X / squareSize);
                    if (countEatSteps == 0 || !canContinue)
                    {
                        CloseSteps();
                        SwitchPlayer();
                        ShowPossibleSteps();
                        canContinue = false;
                    }
                    else if (canContinue)
                    {
                        pressedSquare.BackColor = Color.MidnightBlue;
                        pressedSquare.Enabled = true;
                        isMoving = true;
                    }
                }
            }

            prevSquare = pressedSquare;
        }

        public void ShowPossibleSteps()
        {
            bool isOneStep = true;
            bool isEatStep = false;
         //   DeactivateAllCheckers();
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    if (field[i, j] == currentPlayer)
                    {
                        if (checkers[i, j].Text == " ")
                            isOneStep = false;
                        else isOneStep = true;
                        if (YouCanEat(i, j, isOneStep, new int[2] { 0, 0 }))
                        {
                            isEatStep = true;
                            checkers[i, j].Enabled = true;
                        }
                    }
                }
            }
            if (!isEatStep)
                ActivateAllCheckers();
        }
        public bool DidEatSomeone(Button endChecker, Button startChecker)
        {
            int count = Math.Abs(endChecker.Location.Y / squareSize - startChecker.Location.Y / squareSize);
            int startIndexX = endChecker.Location.Y / squareSize - startChecker.Location.Y / squareSize;
            int startIndexY = endChecker.Location.X / squareSize - startChecker.Location.X / squareSize;
            startIndexX = startIndexX < 0 ? -1 : 1;
            startIndexY = startIndexY < 0 ? -1 : 1;
            int currentCount = 0;
            bool didEat = false;
            int i = startChecker.Location.Y / squareSize + startIndexX;
            int j = startChecker.Location.X / squareSize + startIndexY;
            while (currentCount < count - 1)
            {
                if (startChecker.Image == whiteDame && field[i, j] == 2 || startChecker.Image == blackDame && field[i, j] == 1) didEat = true;
                i += startIndexX;
                j += startIndexY;
                currentCount++;
            }
            return didEat;
        }
        public void MagicalTransformation(Button checker)
        {
            if (field[checker.Location.Y / squareSize, checker.Location.X / squareSize] == 1 && checker.Location.Y / squareSize == fieldSize - 1)
            {
                if (checker.Image == whiteFigure)
                    checker.Image = whiteDame;
                else checker.Image = blackDame;
                checker.Text = " ";

            }
            if (field[checker.Location.Y / squareSize, checker.Location.X / squareSize] == 2 && checker.Location.Y / squareSize == 0)
            {
                if (checker.Image == whiteFigure)
                    checker.Image = whiteDame;
                else checker.Image = blackDame;
                checker.Text = " ";
            }
        }

        int pinkEaten = 0, blueEaten = 0;
        public void DeleteEaten(Button endChecker, Button startChecker)
        {
            int count = Math.Abs(endChecker.Location.Y / squareSize - startChecker.Location.Y / squareSize);
            int startIndexX = endChecker.Location.Y / squareSize - startChecker.Location.Y / squareSize;
            int startIndexY = endChecker.Location.X / squareSize - startChecker.Location.X / squareSize;
            startIndexX = startIndexX < 0 ? -1 : 1;
            startIndexY = startIndexY < 0 ? -1 : 1;
            int currentCount = 0;
            int i = startChecker.Location.Y / squareSize + startIndexX;
            int j = startChecker.Location.X / squareSize + startIndexY;
            while (currentCount < count - 1)
            {
                if (field[i, j] == 1) blueEaten++;
                else if (field[i, j] == 2) pinkEaten++;
                if (blueEaten == 12) WinnerAndRestart(player2.Text);
                else if (pinkEaten == 12) WinnerAndRestart(player1.Text);
                score1.Text = pinkEaten + "";
                score2.Text = blueEaten + "";
                field[i, j] = 0;
                checkers[i, j].Image = null;
                checkers[i, j].Text = "";
                i += startIndexX;
                j += startIndexY;
                currentCount++;
            }

        }

        public void ShowSteps(int CurrentI, int CurrentJ, bool isOnestep = true)
        {
            oneSteps.Clear();
            MoveDiagonally(CurrentI, CurrentJ, isOnestep);
            if (countEatSteps > 0)
                CloseOneSteps(oneSteps);
        }


        public void MoveDiagonally(int CurrentI, int CurrentJ, bool isOneStep = false)
        {
            int j = CurrentJ + 1;
            for (int i = CurrentI - 1; i >= 0; i--)
            {
                if (currentPlayer == 1 && isOneStep && !canContinue) break;
                if (IsInside(i, j))
                {
                    if (!DeterminePath(i, j))
                        break;
                }
                if (j < 7)
                    j++;
                else break;

                if (isOneStep)
                    break;
            }

            j = CurrentJ - 1;
            for (int i = CurrentI - 1; i >= 0; i--)
            {
                if (currentPlayer == 1 && isOneStep && !canContinue) break;
                if (IsInside(i, j))
                {
                    if (!DeterminePath(i, j))
                        break;
                }
                if (j > 0)
                    j--;
                else break;

                if (isOneStep)
                    break;
            }

            j = CurrentJ - 1;
            for (int i = CurrentI + 1; i < 8; i++)
            {
                if (currentPlayer == 2 && isOneStep && !canContinue) break;
                if (IsInside(i, j))
                {
                    if (!DeterminePath(i, j))
                        break;
                }
                if (j > 0)
                    j--;
                else break;

                if (isOneStep)
                    break;
            }

            j = CurrentJ + 1;
            for (int i = CurrentI + 1; i < 8; i++)
            {
                if (currentPlayer == 2 && isOneStep && !canContinue) break;
                if (IsInside(i, j))
                {
                    if (!DeterminePath(i, j))
                        break;
                }
                if (j < 7)
                    j++;
                else break;

                if (isOneStep)
                    break;
            }
        }

        public bool DeterminePath(int i, int j)
        {

            if (field[i, j] == 0 && !canContinue)
            {
                checkers[i, j].BackColor = Color.LightSkyBlue;
                checkers[i, j].Enabled = true;
                oneSteps.Add(checkers[i, j]);
            }
            else
            {

                if (field[i, j] != currentPlayer)
                {
                    if (pressedSquare.Text == " ")
                        ShowEat(i, j, false);
                    else ShowEat(i, j);
                }

                return false;
            }
            return true;
        }

        public void CloseOneSteps(List<Button> oneSteps)
        {
            if (oneSteps.Count > 0)
            {
                for (int i = 0; i < oneSteps.Count; i++)
                {
                    oneSteps[i].BackColor = GetPrevSquareColor(oneSteps[i]);
                    oneSteps[i].Enabled = false;
                }
            }
        }
        public void ShowEat(int i, int j, bool isOneStep = true)
        {
            int dirX = i - pressedSquare.Location.Y / squareSize;
            int dirY = j - pressedSquare.Location.X / squareSize;
            dirX = dirX < 0 ? -1 : 1;
            dirY = dirY < 0 ? -1 : 1;
            int il = i;
            int jl = j;
            bool isEmpty = true;

            while (IsInside(il, jl))
            {
                if (field[il, jl] != 0 && field[il, jl] != currentPlayer)
                {
                    isEmpty = false;
                    break;
                }
                il += dirX;
                jl += dirY;

                if (isOneStep)
                    break;
            }

            if (isEmpty)
                return;
            List<Button> toClose = new List<Button>();
            bool closeSimple = false;
            int ik = il + dirX;
            int jk = jl + dirY;

            while (IsInside(ik, jk))
            {
                if (field[ik, jk] == 0)
                {
                    if (YouCanEat(ik, jk, isOneStep, new int[2] { dirX, dirY }))
                    {
                        closeSimple = true;
                    }
                    else
                    {
                        toClose.Add(checkers[ik, jk]);
                    }
                    checkers[ik, jk].BackColor = Color.LightSkyBlue;
                    checkers[ik, jk].Enabled = true;
                    countEatSteps++;
                }
                else break;
                if (isOneStep)
                    break;
                jk += dirY;
                ik += dirX;
            }

            if (closeSimple && toClose.Count > 0)
            {
                CloseOneSteps(toClose);
            }

        }

        public bool YouCanEat(int CurrentI, int CurrentJ, bool isOneStep, int[] dir)
        {
            bool eatStep = false;
            int j = CurrentJ + 1;

            for (int i = CurrentI - 1; i >= 0; i--)
            {
                if (currentPlayer == 1 && isOneStep && !canContinue) break;
                if (dir[0] == 1 && dir[1] == -1 && !isOneStep) break;
                if (IsInside(i, j))
                {
                    if (field[i, j] != 0 && field[i, j] != currentPlayer)
                    {
                        eatStep = true;
                        if (!IsInside(i - 1, j + 1))
                            eatStep = false;
                        else if (field[i - 1, j + 1] != 0)
                            eatStep = false;
                        else return eatStep;
                    }
                }
                if (j < 7)
                    j++;
                else break;

                if (isOneStep)
                    break;
            }

            j = CurrentJ - 1;
            for (int i = CurrentI - 1; i >= 0; i--)
            {
                if (currentPlayer == 1 && isOneStep && !canContinue) break;
                if (dir[0] == 1 && dir[1] == 1 && !isOneStep) break;
                if (IsInside(i, j))
                {
                    if (field[i, j] != 0 && field[i, j] != currentPlayer)
                    {
                        eatStep = true;
                        if (!IsInside(i - 1, j - 1))
                            eatStep = false;
                        else if (field[i - 1, j - 1] != 0)
                            eatStep = false;
                        else return eatStep;
                    }
                }
                if (j > 0)
                    j--;
                else break;

                if (isOneStep)
                    break;
            }

            j = CurrentJ - 1;
            for (int i = CurrentI + 1; i < 8; i++)
            {
                if (currentPlayer == 2 && isOneStep && !canContinue) break;
                if (dir[0] == -1 && dir[1] == 1 && !isOneStep) break;
                if (IsInside(i, j))
                {
                    if (field[i, j] != 0 && field[i, j] != currentPlayer)
                    {
                        eatStep = true;
                        if (!IsInside(i + 1, j - 1))
                            eatStep = false;
                        else if (field[i + 1, j - 1] != 0)
                            eatStep = false;
                        else return eatStep;
                    }
                }
                if (j > 0)
                    j--;
                else break;

                if (isOneStep)
                    break;
            }

            j = CurrentJ + 1;
            for (int i = CurrentI + 1; i < 8; i++)
            {
                if (currentPlayer == 2 && isOneStep && !canContinue) break;
                if (dir[0] == -1 && dir[1] == -1 && !isOneStep) break;
                if (IsInside(i, j))
                {
                    if (field[i, j] != 0 && field[i, j] != currentPlayer)
                    {
                        eatStep = true;
                        if (!IsInside(i + 1, j + 1))
                            eatStep = false;
                        else if (field[i + 1, j + 1] != 0)
                            eatStep = false;
                        else return eatStep;
                    }
                }
                if (j < 7)
                    j++;
                else break;

                if (isOneStep)
                    break;
            }

            return eatStep;
        }

        public void StartPlaying()
        {
            startPlaying.Parent = this;
            startPlaying.BringToFront();
            start.Click += (sender2, e2) =>
            {
                startPlaying.Visible = false;
            };

        }

        public void Hovering(Button checker)
        {

            checker.MouseHover += (sender2, e2) =>
            {
                PictureBox p = sender2 as PictureBox;
                if (p.Image != null) p.BackColor = Color.FromArgb(255, 64, 64, 64);
            };

            checker.MouseLeave += (sender2, e2) =>
            {
                PictureBox p = sender2 as PictureBox;
                if (p.Image != null) p.BackColor = Color.HotPink;
            };
        }
        public void CloseSteps()
        {
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    checkers[i, j].BackColor = GetPrevSquareColor(checkers[i, j]);
                }
            }
        }

        public bool IsInside(int ti, int tj)
        {
            if (ti >= fieldSize || tj >= fieldSize || ti < 0 || tj < 0)
            {
                return false;
            }
            return true;
        }

        public void ActivateAllCheckers()
        {
            for (int i = 1; i < fieldSize; i += 2)
            {
                for (int j = 0; j < fieldSize; j += 2)
                {
                    checkers[i, j].Enabled = true;
                }
            }
            for (int i = 0; i < fieldSize; i += 2)
            {
                for (int j = 1; j < fieldSize; j += 2)
                {
                    checkers[i, j].Enabled = true;
                }
            }
        }
        public void DeactivateUselessCheckers()
        {
            for (int i = 0; i < fieldSize; i += 2)
            {
                for (int j = 1; j < fieldSize; j += 2)
                {
                    checkers[i, j].Enabled = false;
                }
            }
            for (int i = 1; i < fieldSize; i += 2)
            {
                for (int j = 0; j < fieldSize; j += 2)
                {
                    checkers[i, j].Enabled = false;
                }
            }
        }
        public void GameOver(int blueEaten, int pinkEaten)
        {
            /* if (blueEaten >= 12)
             {
                 winnerDeclaration.Text = "YOU WIN " + name2.Text + "!!!";
                 statingOver.Text = "press to play again";
                 endOfTheGame.Visible = true;
             }
             else if (pinkEaten >= 12)
             {
                 winnerDeclaration.Text = "YOU WIN " + name1.Text + "!!!";
                 statingOver.Text = "press to play again";
                 endOfTheGame.Visible = true;
             }*/
        }

    
        public void DeactivateAllCheckers()
        {
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    checkers[i, j].Enabled = false;
                }
            }
        }

        public void WinnerAndRestart(string nameOfTheWinner)
        {
            endOfTheGame.Parent = this;
            endOfTheGame.Visible = true;
            endOfTheGame.BringToFront();
            winnerDeclaration.Text = "You win, " + nameOfTheWinner + "!!!!!!!!!";

        }

        private void endOfTheGame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statingOver_TextChanged(object sender, EventArgs e)
        {
            endOfTheGame.Visible = false;
        }

        private void playAgain_KeyPress(object sender, KeyPressEventArgs e)
        {
            endOfTheGame.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void name1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TextBox t = sender as TextBox;
                if (t.Text != "" && name1.Text != name2.Text)
                {
                    t.ReadOnly = true;
                    if (t.Name == "name2")
                        t.BackColor = Color.Violet;
                    else
                        t.BackColor = Color.RoyalBlue;
                    t.ForeColor = Color.LavenderBlush;
                }
                else
                {
                    if (t.Text == "")
                        MessageBox.Show("Enter your NAME!!! Right this moment! Instantly! Immediately!");
                    if (name1.Text == name2.Text)
                        MessageBox.Show("I don't care if you actually have the same name. The names of players must be diffrent.");
                }
            }
        }


    }
}
