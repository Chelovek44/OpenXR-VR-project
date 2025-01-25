using UnityEngine;

public class CounterProblems : MonoBehaviour
{
    private int _cntOfProblems;

    private void Awake()
    {
        _cntOfProblems = 0;
    }

    public int CntOfProblems() => _cntOfProblems;

    public void AddProblem()
    {
        _cntOfProblems++;
    }
}