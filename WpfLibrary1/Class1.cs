using System;

namespace Lib_5
{
    public class Pair
    {
        public class Car
        {
            int _stamp { get; set; }//�����
            int _cylinders { get; set; }//���-�� ���������
            int _power { get; set; }//��������
                                    //������� �������������� ����� ���. �������� � ������

            public void SetParams(int stamp, int cylinders, int power)
            {
                _cylinders = cylinders;
                _stamp = stamp;
                _power = power;
            }

            public void GetParams(out int stamp, out int cylinders, out int power)
            {
                cylinders = _cylinders;
                stamp = _stamp;
                power = _power;
            }
        }
    }
}
