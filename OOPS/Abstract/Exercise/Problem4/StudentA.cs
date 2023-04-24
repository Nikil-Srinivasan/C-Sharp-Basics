public class StudentA : Mark
{
    public int MathMark { private set; get; }
    public int PhysicsMark { private set; get; }
    public int ChemistryMark { private set; get; }

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