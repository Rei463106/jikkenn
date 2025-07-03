using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    [Header("�v���C���[�̍ő�HP")]
    public int maxHP = 10;

    [Header("�v���C���[�̌��݂�HP")]
    private int currentHP;

    //�X���C�_�[��������p
    public Slider hpSlider;

    // Start is called before the first frame update
    void Start()
    {
        //�����ݒ�
        currentHP = maxHP;
        hpSlider.maxValue = maxHP;
        hpSlider.value = currentHP;
    }

    public void TakeDamege(int damege)
    {
        //HP�����炷����
        currentHP -= damege;
        if (currentHP < 0)
        {
            currentHP = 0;//�}�C�i�X�ɂȂ�Ȃ��悤�Ɂc
        }
        hpSlider.value = currentHP;
        if (currentHP == 0)
        {
            Debug.Log("�Q�[���I�[�o�[�I�I");
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            TakeDamege(1);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
