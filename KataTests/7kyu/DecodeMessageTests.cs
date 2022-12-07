namespace sevenkyu;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

[TestFixture]
public class DecodeMessageTest
{
    [Test]
    public void Test1()
    {
        string[] input = { "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ" ,
                "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой" ,
                "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть" ,
                "если особенно упорно подойдешь к делу" ,
                "" ,
                "будет Трудно конечнО" ,
                "Код ведЬ не из простых" ,
                "очень ХОРОШИЙ код" ,
                "то у тебя все получится" ,
                "и я буДу Писать тЕбЕ еще" ,
                "" ,
                "чао" };

        string result = DecodeMessage.Message(input);

        string output = "Писать ХОРОШИЙ Код Трудно Но Ты НЕ Сдавайся Старайся Все Упрощать";
        Assert.That(result, Is.EqualTo(output));
    }
}