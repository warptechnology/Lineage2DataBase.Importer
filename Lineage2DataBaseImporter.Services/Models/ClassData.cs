using System.Xml.Serialization;

namespace Lineage2DataBaseImporter.Services.Models.Classes;

[XmlRoot(ElementName = "set")]
public class Set
{
    [XmlAttribute(AttributeName = "id")]
    public int Id { get; set; }

    [XmlAttribute(AttributeName = "baseLvl")]
    public int BaseLvl { get; set; }

    [XmlAttribute(AttributeName = "fists")]
    public int Fists { get; set; }

    [XmlAttribute(AttributeName = "str")]
    public int Str { get; set; }

    [XmlAttribute(AttributeName = "con")]
    public int Con { get; set; }

    [XmlAttribute(AttributeName = "dex")]
    public int Dex { get; set; }

    [XmlAttribute(AttributeName = "int")]
    public int Int { get; set; }

    [XmlAttribute(AttributeName = "wit")]
    public int Wit { get; set; }

    [XmlAttribute(AttributeName = "men")]
    public int Men { get; set; }

    [XmlAttribute(AttributeName = "pAtk")]
    public int PAtk { get; set; }

    [XmlAttribute(AttributeName = "pDef")]
    public int PDef { get; set; }

    [XmlAttribute(AttributeName = "mAtk")]
    public int MAtk { get; set; }

    [XmlAttribute(AttributeName = "mDef")]
    public int MDef { get; set; }

    [XmlAttribute(AttributeName = "runSpd")]
    public int RunSpd { get; set; }

    [XmlAttribute(AttributeName = "walkSpd")]
    public int WalkSpd { get; set; }

    [XmlAttribute(AttributeName = "swimSpd")]
    public int SwimSpd { get; set; }

    [XmlAttribute(AttributeName = "radius")]
    public int Radius { get; set; }

    [XmlAttribute(AttributeName = "radiusFemale")]
    public int RadiusFemale { get; set; }

    [XmlAttribute(AttributeName = "height")]
    public int Height { get; set; }

    [XmlAttribute(AttributeName = "heightFemale")]
    public int HeightFemale { get; set; }

    [XmlAttribute(AttributeName = "safeFallHeight")]
    public string SafeFallHeight { get; set; }

    [XmlAttribute(AttributeName = "hpTable")]
    public string HpTable { get; set; }

    [XmlAttribute(AttributeName = "mpTable")]
    public string MpTable { get; set; }

    [XmlAttribute(AttributeName = "cpTable")]
    public string CpTable { get; set; }

    [XmlAttribute(AttributeName = "hpRegenTable")]
    public string HpRegenTable { get; set; }

    [XmlAttribute(AttributeName = "mpRegenTable")]
    public string MpRegenTable { get; set; }

    [XmlAttribute(AttributeName = "cpRegenTable")]
    public string CpRegenTable { get; set; }
}

[XmlRoot(ElementName = "item")]
public class Item
{

    [XmlAttribute(AttributeName = "id")]
    public int Id { get; set; }

    [XmlAttribute(AttributeName = "count")]
    public int Count { get; set; }

    [XmlAttribute(AttributeName = "isEquipped")]
    public bool IsEquipped { get; set; }
}

[XmlRoot(ElementName = "items")]
public class Items
{

    [XmlElement(ElementName = "item")]
    public List<Item> Item { get; set; }
}

[XmlRoot(ElementName = "skill")]
public class Skill
{

    [XmlAttribute(AttributeName = "id")]
    public int Id { get; set; }

    [XmlAttribute(AttributeName = "lvl")]
    public int Lvl { get; set; }

    [XmlAttribute(AttributeName = "cost")]
    public int Cost { get; set; }

    [XmlAttribute(AttributeName = "minLvl")]
    public int MinLvl { get; set; }
}

[XmlRoot(ElementName = "skills")]
public class Skills
{

    [XmlElement(ElementName = "skill")]
    public List<Skill> Skill { get; set; }
}

[XmlRoot(ElementName = "spawn")]
public class Spawn
{

    [XmlAttribute(AttributeName = "x")]
    public int X { get; set; }

    [XmlAttribute(AttributeName = "y")]
    public int Y { get; set; }

    [XmlAttribute(AttributeName = "z")]
    public int Z { get; set; }
}

[XmlRoot(ElementName = "spawns")]
public class Spawns
{

    [XmlElement(ElementName = "spawn")]
    public List<Spawn> Spawn { get; set; }
}

[XmlRoot(ElementName = "class")]
public class ClassData
{

    [XmlElement(ElementName = "set")]
    public List<Set> Set { get; set; }

    [XmlElement(ElementName = "items")]
    public Items Items { get; set; }

    [XmlElement(ElementName = "skills")]
    public Skills Skills { get; set; }

    [XmlElement(ElementName = "spawns")]
    public Spawns Spawns { get; set; }
}

[XmlRoot(ElementName = "list")]
public class List
{

    [XmlElement(ElementName = "class")]
    public List<ClassData> Class { get; set; }
}

