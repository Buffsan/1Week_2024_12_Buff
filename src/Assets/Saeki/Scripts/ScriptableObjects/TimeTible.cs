using UnityEngine;

[CreateAssetMenu(fileName ="timetible",menuName = "ScriptableObject/TimeTible", order = 1)]
public class TimeTible : ScriptableObject
{
    [Header("�o�����鎞��")]
    [Tooltip("���̒l�̓L�����N�^�[�̏o�����鎞�Ԃ�ݒ肵�܂��B")]
    [SerializeField]
    int spownTime;

    public int GetSpowntime => spownTime;

    [Header("�o���ʒu")]
    [SerializeField]
    SpownInfo[] spownInfos;

    [System.Serializable]
    public struct SpownInfo
    {
        [Tooltip("���̒l�̓L�����N�^�[�̏o���ʒu���`���܂��B")]
        [SerializeField]
        Transform spownPoint;
        [Tooltip("���̒l�͐�������G�I�u�W�F�N�g���`���܂��B")]
        [SerializeField]
        GameObject EnemyObject;

        public readonly Transform Point => spownPoint;
        public readonly GameObject Enemy => EnemyObject;
    }

    public int GetInfomationLength => spownInfos.Length;
    public SpownInfo GetSpownInfomation(int number) => spownInfos[number];
}
