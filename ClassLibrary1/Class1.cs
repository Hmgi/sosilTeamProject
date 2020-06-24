using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel.Design.Serialization;

namespace ClassLibrary1
{
    public enum PacketType
    {
        초기화 = 0,
        확장 = 1,
        선택 = 2,
        상세정보 = 3,
        다운로드 = 4,
        암호화
           
    }

    public enum PacketSendERROR
    {
        정상 = 0,
        에러
    }
    [Serializable]
    public class Packet
    {
        public int Length;
        public int Type;
        public string path;
        public DirectoryInfo dir;
        public FileInfo fi;

        public Packet()
        {
            this.Length = 0;
            this.Type = 0;
        }

        public static byte[] Serialize(Object o)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();
        }

        public static Object Desserialize(byte[] bt)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            foreach (byte b in bt)
            {
                ms.WriteByte(b);
            }
            ms.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            Object obj = bf.Deserialize(ms);
            ms.Close();
            return obj;
        }
    }
    [Serializable]
    public class Initialize : Packet
    {
        
    }
    [Serializable]
    public class Login : Packet
    {
       
    }
    [Serializable]
    public class Select : Packet
    {

    }
    [Serializable]
    public class Detail : Packet
    {

    }
    [Serializable]
    public class Download : Packet
    {
        public Download(string path)
        {
            this.path = path;
            this.fi = new FileInfo(path);
        }
    }
    [Serializable]
    public class Doubleclick : Packet
    {
    }
    public class Class1
    {
    }
}
