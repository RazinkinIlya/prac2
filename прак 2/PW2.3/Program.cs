Console.WriteLine("Выберите язык текста \n 1- Английский \n 2-Русский");
int type = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ваш текст");
CaesarCipher Cipher = new CaesarCipher();
string text = Convert.ToString(Console.ReadLine());
text = text.ToLower();
char[] textToArray = text.ToCharArray();
if ( type == 2) { 

Cipher.CaesarConvertRu(textToArray);
}
else  { 
Cipher.CaesarConvertEn(textToArray);
}


Console.ReadKey();

class CaesarCipher
{
    private char[] alphabetRu = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();
    private char[] alphabetEn = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    private int alphabetCount, alphabetCountChanged, j;
    private string newText;
    public void CaesarConvertRu(char[] textToArray)
    { 
        for (int i = 0; i < textToArray.Length; i++)
        {
            for ( j = 0; j < alphabetRu.Length; j++)
            {
                if (textToArray[i] == alphabetRu[j])
                {
                    break;
                }
            }

            if (j != 33)
            {
                alphabetCount = j; 
                alphabetCountChanged = alphabetCount + 3; 

                if (alphabetCountChanged > 32)
                {
                    alphabetCountChanged = alphabetCountChanged - 33;
                }

                textToArray[i] = alphabetRu[alphabetCountChanged]; 
            }
        }

        newText = new string(textToArray);
        Console.WriteLine(newText);
    }
    public void CaesarConvertEn(char[] textToArray)
    {
        for (int i = 0; i < textToArray.Length; i++)
        {
            for (j = 0; j < alphabetEn.Length; j++)
            {
                if (textToArray[i] == alphabetEn[j])
                {
                    break;
                }
            }

            if (j != 26)
            {
                alphabetCount = j;
                alphabetCountChanged = alphabetCount + 3;

                if (alphabetCountChanged > 25)
                {
                    alphabetCountChanged = alphabetCountChanged - 26;
                }

                textToArray[i] = alphabetEn[alphabetCountChanged];
            }
        }

        newText = new string(textToArray);
        Console.WriteLine(newText);
    }

}