using System.Collections.Generic;
using System.Xml.Serialization;

namespace openrmf_msg_template.Models
{

    public class STIG_INFO {

        public STIG_INFO (){
            SI_DATA = new List<SI_DATA>();
        }

        [XmlElement("SI_DATA")]
        public List<SI_DATA> SI_DATA { get; set;}
    }
}