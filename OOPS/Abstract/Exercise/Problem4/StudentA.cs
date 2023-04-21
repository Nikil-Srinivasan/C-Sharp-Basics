public class StudentA : Mark
{
    public int MathMark { set; get; }
    public int PhysicsMark { set; get; }
    public int ChemistryMark { set; get; }

    public StudentA(int mathMark, int physicsMark, int chemistryMark)
    {
        MathMark = mathMark;
        PhysicsMark = physicsMark;
        ChemistryMark = chemistryMark;
    }
    public override float getPercentage()
    {
        return (MathMark + PhysicsMark + ChemistryMark) / 3.0f;
    }
}