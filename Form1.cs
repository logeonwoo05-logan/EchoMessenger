namespace EchoMessenger
{
    public partial class EchoMessenger : Form
    {
        public EchoMessenger()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // TextBox에 입력된 텍스트를 가져와서 변수에 저장
            string typed_msg = myTxtBox.Text;

            // 가져온 문자열을 ListBox의 Items으로 추가
            lstMsgWindow.Items.Add(typed_msg);

            // 다음 입력을 위해 TextBox의 내용을 비우기
            myTxtBox.Clear();
        }
    }
}
