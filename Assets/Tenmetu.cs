using System.Collections;
using UnityEngine;

//Unity�V�[����ɔz�u���ꂽ�I�u�W�F�N�g�iCube�Ȃǁj��5�b�ԁA**1�b���Ƃɓ_�Łi�\���E��\���j**�����Ă��������B
//�_�Œ���Debug.Log�ŁuVisible�v�܂��́uInvisible�v�ƕ\�����Ă��������B
//�_�ł�5��I�������A�ŏI�I�ɕ\�����ꂽ��Ԃɖ߂��ďI�����܂��B



public class Tenmetu : MonoBehaviour
{
    //�Q�[���I�u�W�F�N�g���擾���A�_�ł̂��߂̃v���O�����������B

    private Renderer rend;
    [Header("�_�ł̉�")]
    public float ten;
    void Start()
    {
        rend= GetComponent<Renderer>();
       
    }




    // IEnumerator Startarart()
    //{
    //�P�b��ɕ\�������Ayield return�������Ȃ��ƃG���[�o���
    // yield return new WaitForSeconds(1.0f);
    // Debug.Log("InVisible");
    // this.gameObject.SetActive(false);
    // yield return new WaitForSeconds(2.0f);
    // Debug.Log("Visible");
    // this.gameObject.SetActive(true);
    // yield return new WaitForSeconds(3.0f);
    // Debug.Log("inVisible");
    // this.gameObject.SetActive(false);
    // yield return new WaitForSeconds(4.0f);
    // Debug.Log("visible");
    // this.gameObject.SetActive(true);
    // yield return new WaitForSeconds(5.0f);
    // Debug.Log("InVisible");


    // }

    IEnumerator BlinkCoroutine()
    {
        bool inVisible = true;

        for (int i = 0; i < ten; i++)
        {
            //false���܂�����i���ځj
            inVisible = !inVisible;
            //�\���A��\�������؂�ւ���
            rend.enabled = inVisible;
            Debug.Log(inVisible ? "Visible" : "Invisible");

            //�P�b��ɂ܂�������Ăяo���B
            //���b��Ɂc�Ƃ��������������炱����Ăяo�����B
            yield return new WaitForSeconds(1f);
        }
        rend.enabled = true;
        Debug.Log("Visible");
    }

    

    // Update is called once per frame
    void Update()
    {
        //�Ăяo���Ƃ��ɂ͂�����g���B
        // StartCoroutine(Startarart());
        //Start�̒��ɏ����ƈ�񂵂��Ăяo����Ȃ��̂Œ��ӁI�I
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(BlinkCoroutine());
        }
    }
}
