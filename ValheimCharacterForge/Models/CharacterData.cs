using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValheimCharacterForge.Models
{
    public class Vector3
    {
        public float X;
        public float Y;
        public float Z;
    }

    public class CharacterData
    {
        public string Beard = "";
        public List<Biome> Biomes;
        public int Builds;
        public int Crafts;
        public int Deaths;
        public string FileName = "";
        public List<Food> Foods;
        public string GuardianPower;
        public float GuardianPowerCooldown;
        public string Hair = "";
        public Vector3 HairColor;
        public float Hp;
        public long Id;
        public List<Item> Inventory;
        public bool IsFirstSpawn;
        public int Kills;
        public List<string> KnownMaterials;
        public float MaxHp = 0;
        public int Model;
        public string Name = "";
        public string Path = "";
        public List<string> Recipes;
        public List<string> ShownTutorials;
        public List<Skill> Skills;
        public Vector3 SkinColor;
        public float Stamina;
        public string StartSeed = "";
        public Dictionary<string, int> Stations = new Dictionary<string, int>();
        public Dictionary<string, string> Texts = new Dictionary<string, string>();
        public float TimeSinceDeath;
        public List<string> Trophies;
        public List<string> Uniques;
        public Dictionary<long, World> WorldsData = new Dictionary<long, World>();
        public int DataVersion;
        public int SkillsVersion;
        public int InventoryVersion;
        public int CharacterVersion;

        public enum Biome
        {
            None,
            Meadows,
            Swamp,
            Mountain = 4,
            BlackForest = 8,
            Plains = 16,
            AshLands = 32,
            DeepNorth = 64,
            Ocean = 256,
            Mistlands = 512,
            BiomesMax
        }

        public enum SkillName
        {
            None,
            Swords,
            Knives,
            Clubs,
            Polearms,
            Spears,
            Blocking,
            Axes,
            Bows,
            FireMagic,
            FrostMagic,
            Unarmed,
            Pickaxes,
            WoodCutting,
            Jump = 100,
            Sneak,
            Run,
            Swim,
            All = 999
        }

        public class World
        {
            public Vector3 DeathPoint = new Vector3();
            public bool HasCustomSpawnPoint;
            public bool HasDeathPoint;
            public bool HasLogoutPoint;
            public Vector3 HomePoint = new Vector3();
            public Vector3 LogoutPoint = new Vector3();
            public byte[] MapData;
            public Vector3 SpawnPoint = new Vector3();
        }

        public class Item
        {
            public long CrafterId;
            public string CrafterName;
            public float Durability;
            public bool Equipped;
            public string Name;
            public Tuple<int, int> Pos;
            public int Quality;
            public int Stack;
            public int Variant;
        }

        public class Food
        {
            public float HpLeft;
            public string Name;
            public float StaminaLeft;
        }

        public class Skill
        {
            public float Level;
            public SkillName SkillName;
            public float Something;
        }
    }
}
