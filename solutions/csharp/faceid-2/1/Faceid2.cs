public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods
    public bool Equals(FacialFeatures? otherObject)
    {
        if (otherObject is null) { return false; }
        if (!this.EyeColor.Equals(otherObject.EyeColor)) { return false; }
        if (!this.PhiltrumWidth.Equals(otherObject.PhiltrumWidth)) { return false; }

        return true;
    }

    public int GetHashCode()
    {
        return HashCode.Combine(this.EyeColor,this.PhiltrumWidth);
    }
}
//=====================================================================================================================
public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods

    public bool Equals(Identity? otherObject)
    {
        if (otherObject is null) { return false; }
        //if (!this.Email.Equals(otherObject.Email)) { return false; }
        if (!this.FacialFeatures.Equals(otherObject.FacialFeatures)) { return false; }
        
        return true;
    }

    public int GetHashCode()
    {
        return HashCode.Combine(this.FacialFeatures);
    }
}
//========================================================================================================================
public class Authenticator
{
    private Identity _registeredIdentity = null;
    
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        return faceA.Equals(faceB);
    }

    public bool IsAdmin(Identity identity)
    {
        if (!identity.Email.Equals("admin@exerc.ism")) { return false; }
        if (!identity.FacialFeatures.Equals(new FacialFeatures("green",0.9m))) { return false; }

        return true;
    }

    public bool Register(Identity identity)
    {
        if (_registeredIdentity is null)
        {
            _registeredIdentity = identity;
            return true;
        }

        if (_registeredIdentity.Equals(identity)) { return false; }

        _registeredIdentity = identity;
        return true;
        
        //throw new NotImplementedException("Please implement the Authenticator.Register() method");
    }

    public bool IsRegistered(Identity identity)
    {
        if (this._registeredIdentity.Equals(identity)) { return true; }

        return false;
        //throw new NotImplementedException("Please implement the Authenticator.IsRegistered() method");
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return identityA.GetHashCode().Equals(identityB.GetHashCode());
        //throw new NotImplementedException("Please implement the Authenticator.AreSameObject() method");
    }
}
