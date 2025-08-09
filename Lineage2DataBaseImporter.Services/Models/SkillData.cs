// using System.Xml.Serialization;
// XmlSerializer serializer = new XmlSerializer(typeof(List));
// using (StringReader reader = new StringReader(xml))
// {
//    var test = (List)serializer.Deserialize(reader);
// }

using System.Xml.Serialization;

[XmlRoot(ElementName = "table")]
public class Table
{

    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }

    [XmlText]
    public string Text { get; set; }
}

[XmlRoot(ElementName = "set")]
public class Set
{

    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }

    [XmlAttribute(AttributeName = "val")]
    public string Val { get; set; }

    [XmlAttribute(AttributeName = "stat")]
    public string Stat { get; set; }
}

[XmlRoot(ElementName = "enchant1")]
public class Enchant1
{

    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }

    [XmlAttribute(AttributeName = "val")]
    public string Val { get; set; }
}

[XmlRoot(ElementName = "skill")]
public class Skill
{

    [XmlElement(ElementName = "enchant1")]
    public List<Enchant1> Enchant1 { get; set; }

    [XmlElement(ElementName = "enchant2")]
    public List<Enchant2> Enchant2 { get; set; }

    [XmlElement(ElementName = "for")]
    public For For { get; set; }

    [XmlElement(ElementName = "enchant1for")]
    public Enchant1for Enchant1for { get; set; }

    [XmlElement(ElementName = "enchant2for")]
    public Enchant2for Enchant2for { get; set; }

    [XmlAttribute(AttributeName = "id")]
    public int Id { get; set; }

    [XmlAttribute(AttributeName = "levels")]
    public int Levels { get; set; }

    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }

    [XmlAttribute(AttributeName = "enchantLevels1")]
    public int EnchantLevels1 { get; set; }

    [XmlAttribute(AttributeName = "enchantLevels2")]
    public int EnchantLevels2 { get; set; }

    [XmlText]
    public string Text { get; set; }

    [XmlElement(ElementName = "table")]
    public List<Table> Table { get; set; }

    [XmlElement(ElementName = "set")]
    public List<Set> Set { get; set; }

    [XmlElement(ElementName = "cond")]
    public Cond Cond { get; set; }
}

[XmlRoot(ElementName = "enchant2")]
public class Enchant2
{

    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }

    [XmlAttribute(AttributeName = "val")]
    public string Val { get; set; }
}

[XmlRoot(ElementName = "effect")]
public class Effect
{

    [XmlElement(ElementName = "basemul")]
    public List<Basemul> Basemul { get; set; }

    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }

    [XmlAttribute(AttributeName = "time")]
    public int Time { get; set; }

    [XmlAttribute(AttributeName = "val")]
    public int Val { get; set; }

    [XmlAttribute(AttributeName = "stackOrder")]
    public int StackOrder { get; set; }

    [XmlAttribute(AttributeName = "stackType")]
    public string StackType { get; set; }

    [XmlElement(ElementName = "mul")]
    public List<Mul> Mul { get; set; }

    [XmlAttribute(AttributeName = "effectPower")]
    public int EffectPower { get; set; }

    [XmlAttribute(AttributeName = "effectType")]
    public string EffectType { get; set; }

    [XmlAttribute(AttributeName = "noicon")]
    public int Noicon { get; set; }

    [XmlElement(ElementName = "add")]
    public List<Add> Add { get; set; }

    [XmlAttribute(AttributeName = "abnormal")]
    public string Abnormal { get; set; }

    [XmlElement(ElementName = "addMul")]
    public AddMul AddMul { get; set; }

    [XmlAttribute(AttributeName = "self")]
    public int Self { get; set; }

    [XmlElement(ElementName = "sub")]
    public Sub Sub { get; set; }
}

[XmlRoot(ElementName = "for")]
public class For
{

    [XmlElement(ElementName = "effect")]
    public List<Effect> Effect { get; set; }

    [XmlElement(ElementName = "add")]
    public List<Add> Add { get; set; }

    [XmlElement(ElementName = "addMul")]
    public List<AddMul> AddMul { get; set; }

    [XmlElement(ElementName = "mul")]
    public Mul Mul { get; set; }
}

[XmlRoot(ElementName = "mul")]
public class Mul
{

    [XmlAttribute(AttributeName = "stat")]
    public string Stat { get; set; }

    [XmlAttribute(AttributeName = "val")]
    public double Val { get; set; }

    [XmlElement(ElementName = "using")]
    public Using Using { get; set; }

    [XmlElement(ElementName = "player")]
    public Player Player { get; set; }

    [XmlElement(ElementName = "and")]
    public And And { get; set; }
}

[XmlRoot(ElementName = "enchant1for")]
public class Enchant1for
{

    [XmlElement(ElementName = "effect")]
    public List<Effect> Effect { get; set; }
}

[XmlRoot(ElementName = "enchant2for")]
public class Enchant2for
{

    [XmlElement(ElementName = "effect")]
    public List<Effect> Effect { get; set; }
}

[XmlRoot(ElementName = "add")]
public class Add
{

    [XmlAttribute(AttributeName = "stat")]
    public string Stat { get; set; }

    [XmlAttribute(AttributeName = "val")]
    public int Val { get; set; }

    [XmlElement(ElementName = "using")]
    public Using Using { get; set; }

    [XmlElement(ElementName = "player")]
    public Player Player { get; set; }
}

[XmlRoot(ElementName = "addMul")]
public class AddMul
{

    [XmlAttribute(AttributeName = "stat")]
    public string Stat { get; set; }

    [XmlAttribute(AttributeName = "val")]
    public int Val { get; set; }
}

[XmlRoot(ElementName = "using")]
public class Using
{

    [XmlAttribute(AttributeName = "kind")]
    public string Kind { get; set; }
}

[XmlRoot(ElementName = "basemul")]
public class Basemul
{

    [XmlElement(ElementName = "using")]
    public Using Using { get; set; }

    [XmlAttribute(AttributeName = "stat")]
    public string Stat { get; set; }

    [XmlAttribute(AttributeName = "val")]
    public double Val { get; set; }

    [XmlElement(ElementName = "player")]
    public Player Player { get; set; }

    [XmlElement(ElementName = "and")]
    public And And { get; set; }
}

[XmlRoot(ElementName = "player")]
public class Player
{

    [XmlAttribute(AttributeName = "riding")]
    public bool Riding { get; set; }

    [XmlAttribute(AttributeName = "flying")]
    public bool Flying { get; set; }

    [XmlAttribute(AttributeName = "hp")]
    public int Hp { get; set; }

    [XmlAttribute(AttributeName = "front")]
    public bool Front { get; set; }

    [XmlAttribute(AttributeName = "behind")]
    public bool Behind { get; set; }
}

[XmlRoot(ElementName = "cond")]
public class Cond
{

    [XmlElement(ElementName = "player")]
    public Player Player { get; set; }

    [XmlAttribute(AttributeName = "msgId")]
    public int MsgId { get; set; }

    [XmlAttribute(AttributeName = "addName")]
    public int AddName { get; set; }
}

[XmlRoot(ElementName = "sub")]
public class Sub
{

    [XmlAttribute(AttributeName = "stat")]
    public string Stat { get; set; }

    [XmlAttribute(AttributeName = "val")]
    public int Val { get; set; }
}

[XmlRoot(ElementName = "subDiv")]
public class SubDiv
{

    [XmlAttribute(AttributeName = "stat")]
    public string Stat { get; set; }

    [XmlAttribute(AttributeName = "val")]
    public int Val { get; set; }
}

[XmlRoot(ElementName = "and")]
public class And
{

    [XmlElement(ElementName = "player")]
    public List<Player> Player { get; set; }
}

[XmlRoot(ElementName = "list")]
public class List
{

    [XmlElement(ElementName = "skill")]
    public List<Skill> Skill { get; set; }
}

