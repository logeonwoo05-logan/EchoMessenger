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
            // 1. (과제3 추가) 텍스트를 가져올 때 Trim()을 붙여서 앞뒤의 쓸데없는 공백을 날려줍니다.
            string typed_msg = txtMessage.Text.Trim();

            // --- (과제4 추가) 글자 수 50자 제한 ---
            if (typed_msg.Length > 50)
            {
                MessageBox.Show("메시지는 50자를 초과할 수 없습니다.", "경고");
                return; // 전송 중단
            }


            // 2. (과제2 유지) 입력 방어: 비어있거나 공백만 있으면 전송 안 함.
            if (string.IsNullOrWhiteSpace(typed_msg))
            {
                txtMessage.Clear();
                txtMessage.Focus();
                return; // 아래 코드를 실행하지 않고 멈춤
            }

            // 3. (과제3 추가) 현재 시간 정보를 구해서 메시지 앞에 예쁘게 붙여줍니다.
            string final_msg = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} {typed_msg}";

            // 4. (과제1,2 유지) 시간까지 붙은 최종 메시지(final_msg)를 리스트박스에 넣고, 창을 비우고, 포커스를 줍니다.
            lstMsgWindow.Items.Add(final_msg);
            txtMessage.Clear();
            txtMessage.Focus();

            // 5. (과제3 추가) 리스트박스에 들어있는 항목 개수를 세서 라벨에 업데이트합니다.
            lblCount.Text = $"현재 대화: {lstMsgWindow.Items.Count}개";

            


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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 선택된 항목이 있는지 확인 (예외 처리)
            if (lstMsgWindow.SelectedIndex != -1)
            {
                lstMsgWindow.Items.RemoveAt(lstMsgWindow.SelectedIndex);
                lblCount.Text = $"현재 대화: {lstMsgWindow.Items.Count}개"; // 개수 갱신
            }
            else
            {
                MessageBox.Show("삭제할 메시지를 먼저 선택해주세요.", "알림");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstMsgWindow.Items.Clear(); // 전체 지우기
            lblCount.Text = $"현재 대화: {lstMsgWindow.Items.Count}개"; // 개수 갱신
        }
    }
}
