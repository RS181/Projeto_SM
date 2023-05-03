using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomNumber : MonoBehaviour
{
    public manager_Turn C_manager_Turn;
    public List<Sprite> imgNumber = new List<Sprite>();
    public Image dice;
    public Text txt_number;
    public int number;
    void Start()
    {
        dice.sprite = imgNumber[0];
    }

    void Update()
    {

    }

    public void Bnt_random()
    {
        StartCoroutine("swapDice");
    }
    public static int Random_number()
    {
        int number_;
        number_ = Random.Range(1, 6);
        return number_;
    }

    public IEnumerator swapDice()
    {
        for (int i = 0; i < 20; i++)
        {
            int randomAnim = Random_number();
            dice.sprite = imgNumber[randomAnim];
            print("i :" + i);


            if (i == 19)
            {
                print("run");
                number = Random_number();
                txt_number.text = number.ToString();
                dice.sprite = imgNumber[number - 1];
                C_manager_Turn.runTurn(number);
                StopCoroutine("swapDice");

            }
            yield return new WaitForSeconds(0.05f);


        }
    }
}
