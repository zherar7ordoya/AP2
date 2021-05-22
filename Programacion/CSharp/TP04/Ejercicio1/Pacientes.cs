using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Ejercicio1 {
  public partial class Pacientes : Form {
    //////////////////////////////////////////////////////////// INICIALIZACIÓN
    public Pacientes() { InitializeComponent(); }

    private void Pacientes_Load(object sender, EventArgs e) {
      LinkedList<PayoffNode> PayLL = new LinkedList<PayoffNode>();
      Random Rnd = new Random();
      for (int K = 1; K <= 10; K++) {
        var T = new Ejercicio1.PayoffNode();
        T.Category = "Account==" + K;
        T.GreekType = "Greek==" + K;
        T.DealNo = K;
        T.Strategy = "Strategy==" + K;
        for (int DP = 1; DP <= 21; DP++) {
          T.Data[DP] = Rnd.Next(10, 99);
        }
        PayLL.AddLast(T);
      }
      List<PayoffNode> qP = (from P in PayLL
                             // where P.Category == "Account==4" && P.DealNo == 4 && P.GreekType == "Greek==4" && P.Strategy == "Strategy==4"
                             select new PayoffNode() {
                               Category = P.Category,
                               DealNo = P.DealNo,
                               GreekType = P.GreekType,
                               Strategy = P.Strategy,
                               Data1 = P.Data[1],
                               Data2 = P.Data[2],
                               Data3 = P.Data[3],
                             }).ToList();

      PayoffTable.DataSource = qP;
    }
    ///////////////////////////////////////////////////////////////// CONTROLES

    ///////////////////////////////////////////////////////////////// FUNCIONES

  }
}

