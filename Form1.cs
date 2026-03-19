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
            string typed_msg = txtMessage.Text;

            // 1. 입력 방어: 비어있거나 공백만 있으면 전송 안 함
            if (string.IsNullOrWhiteSpace(typed_msg))
            {
                txtMessage.Clear();
                txtMessage.Focus();
                return; // 아래 코드를 실행하지 않고 여기서 멈춤
            }

            // 2. 메시지 추가 및 입력창 비우기 (1단계와 동일)
            lstMsgWindow.Items.Add(typed_msg);
            txtMessage.Clear();

            // 3. 포커스 이동: 마우스 클릭 없이 바로 다음 타자 칠 수 있게 커서 깜빡임 유지
            txtMessage.Focus();
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            // 사용자가 누른 키가 Enter 키라면
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick(); // 전송 버튼을 마우스로 누른 것과 똑같이 동작시킴
            }// 사용자가 누른 키가 Enter 키라면
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick(); // 전송 버튼을 마우스로 누른 것과 똑같이 동작시킴
            }
        }
    }
}
