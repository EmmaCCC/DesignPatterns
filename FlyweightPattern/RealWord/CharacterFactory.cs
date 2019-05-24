using System;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern.RealWord
{
    public class CharacterFactory
    {
        /// <summary>
        /// 维护一个字符共享（共享基元）池
        /// </summary>
        private Dictionary<char, Character> characters = new Dictionary<char, Character>();

        public Character GetCharacter(char c)
        {
            Character ch = null;
          
            //有这个字符就返回
            if (characters.ContainsKey(c))
            {
                ch = characters[c];
            }
            else
            {
                //没有就创建，然后存储，为了后来共享使用
                switch (c)
                {
                    case 'A':
                        {
                            ch = new Characters.CharacterA();
                            characters.Add('A', ch);
                            break;
                        }
                    case 'B':
                        {
                            ch = new Characters.CharacterB();
                            characters.Add('B', ch);
                            break;
                        }
                        //....
                }
            }
            return ch;
        }
    }
}
