using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class NewMember : Member
    {
        public NewMember()
        {
            
        }
        public string whoRecommended { get; set; }//yeni üyeye özel kimin tavsiye ettiğini,nerden gördüğünü alıp bu değeri burada tutabilirz
    }
}
