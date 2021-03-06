namespace Server.Items
{
    public class OfficialSealingWax : Item
    {
        [Constructable]
        public OfficialSealingWax()
            : base(0x1426)
        {
            LootType = LootType.Blessed;
            Weight = 1.0;
            Hue = 0x84;
        }

        public OfficialSealingWax(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber
        {
            get { return 1072744; }
        } // Official Sealing Wax

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadInt();
        }
    }
}