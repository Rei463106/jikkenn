using UnityEngine;
using UnityEngine.InputSystem;

public class InputSys : MonoBehaviour
{
    void Start()
    {

    }


    void Update()
    {
        //���݂̃L�[�{�[�h���
        var current = Keyboard.current;
        //�L�[�{�[�h�ڑ��`�F�b�N
        if (current == null) return;

        //a�L�[��������Ă��邩�ǂ����̎擾
        var aKey = current.aKey;
        //a�L�[�������ꂽ�u�Ԃ��ǂ���
        if (aKey.wasPressedThisFrame) Debug.Log("a�L�[�������ꂽ");
        //a�L�[�𗣂����u�Ԃ��ǂ���
        if (aKey.wasReleasedThisFrame) Debug.Log("a�L�[�𗣂���");
        //a�L�[��������Ă��邩�ǂ���
        if (aKey.isPressed) Debug.Log("a�L�[��������Ă���");


        //���݂̃}�E�X�̏��
        var current2 = Mouse.current;
        if (current2 == null) return;
        //�}�E�X�J�[�\���̈ʒu�擾
        var cursorPosition = current2.position.ReadValue();
        Debug.Log(cursorPosition);
        //���{�^���̓��͎擾
        var leftButton = current2.leftButton;
        //���{�^����������Ă��邩�ۂ��̓L�[�̎��Ɠ���
    }
}
