abstract class Character
{
    private string _characterType;
    
    protected Character(string characterType)
    {
        _characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        throw new NotImplementedException("Please implement the Character.Vulnerable() method");
    }

    public override string ToString() => $"Character is a {_characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override bool Vulnerable() => false; 
    
    public override int DamagePoints(Character target) => target.Vulnerable() ? 10 : 6;
}
class Wizard : Character
{
    private bool _preparedSpell;
    public Wizard() : base("Wizard")
    {
        _preparedSpell = false;
    }

    public override bool Vulnerable() => (_preparedSpell) ? false : true;
    
    public override int DamagePoints(Character target) => _preparedSpell ? 12 : 3;

    public void PrepareSpell() => _preparedSpell = true;
}
