public class StudentB : Mark
{
    public int MathMark { set; get; }
    public int PhysicsMark { set; get; }
    public int ChemistryMark { set; get; }
    public int TamilMark { set; get; }

    public StudentB(int mathMark, int physicsMark, int chemistryMark, int tamilMark)
    {
        MathMark = mathMark;
        PhysicsMark = physicsMark;
        ChemistryMark = chemistryMark;
        TamilMark = tamilMark;
    }
    public override float getPercentage()
    {
        return (MathMark + PhysicsMark + ChemistryMark + TamilMark) / 4.0f;
    }
}