using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern.RealWord
{
    /// <summary>
    /// 取药单，简单管理一下访问者要访问的药品，访问者需要参看药单访问所有药品
    /// </summary>
    public class Prescription
    {
        private List<Medicine> medicines = new List<Medicine>();

        public void AcceptVisitor(Visitor visitor)
        {
            foreach (var medicine in medicines)
            {
                medicine.Accept(visitor);
            }
        }

        /// <summary>
        /// 添加药品
        /// </summary>
        /// <param name="medicine"></param>
        public void AddMedicine(Medicine medicine)
        {
            medicines.Add(medicine);
        }

        /// <summary>
        /// 移除药品
        /// </summary>
        /// <param name="medicine"></param>
        public void RemoveMedicine(Medicine medicine)
        {
            medicines.Remove(medicine);
        }
    }
}
