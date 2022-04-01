namespace demo;

public struct EmailAddress : IEquatable<string>
{
    string _mValue;
    
    public EmailAddress(string emailAddress)
    {
        _mValue = emailAddress;
    }
    
    public bool IsValid()
    {
        return _mValue.IndexOf('@') > -1;
    }
    
    public static bool operator ==(EmailAddress left, EmailAddress right)
    {
        throw new NotImplementedException();
    }
    public static bool operator !=(EmailAddress left, EmailAddress right)
        => !(left == right);
    
    public static bool operator ==(string left, EmailAddress right)
    {
        throw new NotImplementedException();
    }
    public static bool operator !=(string left, EmailAddress right)
        => !(left == right);
    
    public static bool operator ==(EmailAddress left, string right)
    {
        throw new NotImplementedException();
    }
    public static bool operator !=(EmailAddress left, string right)
        => !(left == right);
    
    public static implicit operator string(EmailAddress email)
        => email._mValue;
    public static implicit operator EmailAddress(string email)
        => new EmailAddress(email);
        
    public override bool Equals(object obj)
    {
        throw new NotImplementedException();
    } 
    public override int GetHashCode()
        => _mValue.GetHashCode();
        
    public override string ToString()
    {
        return _mValue;
    }
}
