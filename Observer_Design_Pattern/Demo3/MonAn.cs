using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3
{
    public class MonAn : Observer
    {
        private string _name;

        private List<ChatDinhDuong> chatDinhDuongList = new List<ChatDinhDuong>();

        public string Name { get => _name; set => _name = value; }

        public MonAn()  {}

        public void MonAnThem(int[] arr)
        {
            //lưu ý thứ tự truyền vào array phải khớp với lúc monAn.Add()
            int i = 0;
            foreach(ChatDinhDuong chat in chatDinhDuongList)
            {
                chat.Value = arr[i++];
            }

        }
        public override void Update()
        {
            foreach(ChatDinhDuong chatDinhDuong in chatDinhDuongList)
            {
                chatDinhDuong.Update();
            }
        }

        public void AddChatDinhDuong(ChatDinhDuong chat)
        {
            chatDinhDuongList.Add(chat);
        }

        public void RemoveChatDinhDuong(ChatDinhDuong chat)
        {
            chatDinhDuongList.Remove(chat);
        }
    }
}
