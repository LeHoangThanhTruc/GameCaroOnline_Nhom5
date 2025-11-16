using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticTacToe
{
    public partial class GameBoard : Form
    {
        private Panel pnBanCo;

        private const int DESIRED_CELL_SIZE = 30; // Kích thước ô mong muốn (30x30)
        private int BOARD_SIZE = 0;               // Số ô thực tế (tính toán)
        private int CELL_SIZE = 0;                // Kích thước ô thực tế (đã điều chỉnh)

        // Đảm bảo tên biến trùng với tên Control trong Designer

        private Button[,] boardButtons;
        private int[,] gameBoard;

        // Các biến trạng thái cần thiết (để tránh lỗi biên dịch)
        private int currentPlayer = 1;
        private bool isGameOver = false;

        // ... (Constructor)


        public GameBoard()
        {
            InitializeComponent();
            this.Load += (sender, e) => InitializeGameBoard();
            this.Resize += (sender, e) => InitializeGameBoard(); // Gọi lại khi Resize


        }

        private void InitializeGameBoard()
        {
            // Sử dụng PnBanCo
            int panelSize = Math.Min(PnBanCo.Width, PnBanCo.Height);

            BOARD_SIZE = panelSize / DESIRED_CELL_SIZE;
            CELL_SIZE = panelSize / BOARD_SIZE;

            boardButtons = new Button[BOARD_SIZE, BOARD_SIZE];
            gameBoard = new int[BOARD_SIZE, BOARD_SIZE];

            PnBanCo.Controls.Clear(); // Xóa các ô cũ (quan trọng khi Resize)
            PnBanCo.Size = new Size(panelSize, panelSize); // Điều chỉnh Panel thành hình vuông
            PnBanCo.Location = new Point((this.PnBanCo.Parent.Width - panelSize) / 2, (this.PnBanCo.Parent.Height - panelSize) / 2); // Tùy chọn: căn giữa Panel trong cột của TLP

            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    Button cell = new Button();
                    cell.Size = new Size(CELL_SIZE, CELL_SIZE);
                    cell.Location = new Point(j * CELL_SIZE, i * CELL_SIZE);
                    cell.Tag = new Point(i, j);

                    // Thiết lập Style cơ bản
                    cell.FlatStyle = FlatStyle.Flat;
                    cell.FlatAppearance.BorderColor = Color.LightGray;
                    cell.FlatAppearance.BorderSize = 1;
                    cell.Font = new Font(this.Font.FontFamily, 12, FontStyle.Bold);
                    cell.Cursor = Cursors.Hand;

                    // Tạm thời tắt sự kiện Click để chỉ xem giao diện
                    // cell.Click += Cell_Click; 

                    PnBanCo.Controls.Add(cell);
                    boardButtons[i, j] = cell;
                    gameBoard[i, j] = 0;
                }
            }
        }

        private void PnBanCo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
