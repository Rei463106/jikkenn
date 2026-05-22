using UnityEngine;

public class ExpansionMessod : MonoBehaviour
{
    private Person _person;

    private void Start()
    {
        _person = new Person("éÑ",3);
        Debug.Log(_person);
    }
}

public class Person
{
    private string _name;
    private int _age;

    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }

    public override string ToString()
    {
        return $"{_name}ÇÕ{_age}çŒÇ≈Ç∑ÅB";
    }
}