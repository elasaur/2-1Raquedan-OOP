namespace navbar
{
    public partial class Form1 : Form
    {
        private Panel? contentPanel;
        private Button? activeButton;

        public Form1()
        {
            InitializeComponent();
            InitializeContentPanel();
        }

        private void InitializeContentPanel()
        {
            contentPanel = new Panel();
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.BackColor = Color.White;
            contentPanel.Location = new Point(navbarPanel.Width, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1304, 985);
            Controls.Add(contentPanel);
            Controls.SetChildIndex(contentPanel, 0);
        }

        private void LoadPage(UserControl page)
        {
            contentPanel!.Controls.Clear();
            page.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(page);
        }

        private void HighlightButton(Button clickedButton)
        {
            if (activeButton != null)
            {
                activeButton.BackColor = Color.Transparent;
                activeButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
                activeButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            }

            clickedButton.BackColor = Color.FromArgb(220, 200, 180);
            clickedButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 210, 190);
            clickedButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 180, 160);
            activeButton = clickedButton;
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            LoadPage(new InventoryPage());
            HighlightButton((Button)sender);
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            LoadPage(new StaffPage());
            HighlightButton((Button)sender);
        }

        private void btn_receipt_Click(object sender, EventArgs e)
        {
            LoadPage(new ReceiptPage());
            HighlightButton((Button)sender);
        }

        private void btn_cashbox_Click(object sender, EventArgs e)
        {
            LoadPage(new CashboxPage());
            HighlightButton((Button)sender);
        }

        private void btn_ticket_Click(object sender, EventArgs e)
        {
            LoadPage(new TicketPage());
            HighlightButton((Button)sender);
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            LoadPage(new DashboardPage());
            HighlightButton((Button)sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPage(new TicketPage());
            HighlightButton(btn_ticket);
        }

        private void navbarPanel_Paint_1(object sender, PaintEventArgs e) { }
        private void bottomMarker_Paint(object sender, PaintEventArgs e) { }
    }

    public class InventoryPage : UserControl
    {
        public InventoryPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Label label = new Label();
            label.Text = "This is the Inventory Page";
            label.Font = new Font("Segoe UI", 16);
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(label);
        }
    }

    public class StaffPage : UserControl
    {
        public StaffPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Label label = new Label();
            label.Text = "This is the Staff Page";
            label.Font = new Font("Segoe UI", 16);
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(label);
        }
    }

    public class ReceiptPage : UserControl
    {
        public ReceiptPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Label label = new Label();
            label.Text = "This is the Receipt Page";
            label.Font = new Font("Segoe UI", 16);
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(label);
        }
    }

    public class CashboxPage : UserControl
    {
        public CashboxPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Label label = new Label();
            label.Text = "This is the Cashbox Page";
            label.Font = new Font("Segoe UI", 16);
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(label);
        }
    }

    public class TicketPage : UserControl
    {
        public TicketPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Label label = new Label();
            label.Text = "This is the Ticket Page";
            label.Font = new Font("Segoe UI", 16);
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(label);
        }
    }

    public class DashboardPage : UserControl
    {
        public DashboardPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Label label = new Label();
            label.Text = "This is the Dashboard Page";
            label.Font = new Font("Segoe UI", 16);
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(label);
        }
    }
}