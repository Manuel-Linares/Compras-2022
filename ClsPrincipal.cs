using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace wsCompras_Hgo
{
    public class ClsPrincipal
    {
        public MySqlConnection cnn;
        public MySqlDataAdapter _da; // Todos los datos van al mismo lugar
        private DataSet _ds;
        private DataTable _dt = new DataTable();

        public DataSet ConsultaProyectos(string con)
        {
            _da = new MySqlDataAdapter("SELECT * FROM proyecto WHERE status=1", con);
            _ds = new DataSet();
            _da.Fill(_ds, "proyecto");
            return _ds;
        }

        public DataSet ConsultaAreas(string con, int idProyecto)
        {
            _da = new MySqlDataAdapter("SELECT * FROM area WHERE proyectoid = " + idProyecto + " AND status=1", con);
            _ds = new DataSet();
            _da.Fill(_ds, "area");
            return _ds;
        }

        public DataSet ConsultaAreas(string con)
        {
            _da = new MySqlDataAdapter("SELECT * FROM area", con);
            _ds = new DataSet();
            _da.Fill(_ds, "area");
            return _ds;
        }

        public DataSet ConsultaCuentas(string con, int idCuenta)
        {
            _da = new MySqlDataAdapter("SELECT * FROM cuentas WHERE areaid = " + idCuenta + " AND status=1", con);
            _ds = new DataSet();
            _da.Fill(_ds, "cuentas");
            return _ds;
        }

        public DataSet ConsultaUnidades(string con)
        {
            _da = new MySqlDataAdapter("SELECT * FROM umedicion", con);
            _ds = new DataSet();
            _da.Fill(_ds, "unidades");
            return _ds;
        }

        public DataSet ConsultaPrioridad(string con)
        {
            _da = new MySqlDataAdapter("SELECT * FROM prioridad", con);
            _ds = new DataSet();
            _da.Fill(_ds, "prioridad");
            return _ds;
        }

        public DataSet ConsultaEstatus(string con, int tipo)
        {
            _da = new MySqlDataAdapter("SELECT * FROM status WHERE tipo =" + tipo, con);
            _ds = new DataSet();
            _da.Fill(_ds, "status");
            return _ds;
        }

        public DataSet ConsultaODC(string con)
        {
            _da = new MySqlDataAdapter("SELECT * FROM odecompra WHERE estatus='Autorizada RM'", con);
            _ds = new DataSet();
            _da.Fill(_ds, "odecompra");
            return _ds;
        }

        public DataSet ConsultaUsuarios(string con)
        {
            _da = new MySqlDataAdapter("SELECT DISTINCT `usuarios`.nombre, `COMPRAS`.userid  FROM `COMPRAS`, `usuarios` WHERE `COMPRAS`.userid = `usuarios`.id", con);
            _ds = new DataSet();
            _da.Fill(_ds, "usucompra");
            return _ds;
        }

        public DataSet ConsultaPrioridadCompras(string con)
        {
            _da = new MySqlDataAdapter("SELECT DISTINCT prioridad FROM `COMPRAS`", con);
            _ds = new DataSet();
            _da.Fill(_ds, "prioricompra");
            return _ds;
        }

        public DataSet IniciarSesion(string usu, string pass, string con)
        {
            _da = new MySqlDataAdapter("CALL acceder ('" + usu + "', '" + pass + "');", con);
            _ds = new DataSet();
            _da.Fill(_ds, "usuario");
            return _ds;
        }

        public DataSet listarRequis(string con, int usuario)
        {
            _da = new MySqlDataAdapter("SELECT * FROM REQUITODAS WHERE userid = " + usuario, con);
            _ds = new DataSet();
            _da.Fill(_ds, "REQUITODAS");
            return _ds;
        }

        public DataSet listarRequis(string con, int usuario, int puesto, int area, int plaza)
        {
            if (puesto.Equals(6) || puesto.Equals(10) || puesto.Equals(14) || puesto.Equals(26) || puesto.Equals(7) || puesto.Equals(9) || puesto.Equals(13) || puesto.Equals(15) || puesto.Equals(16) || puesto.Equals(17) || puesto.Equals(19) || puesto.Equals(23) || puesto.Equals(34) || puesto.Equals(39))
            {
                _da = new MySqlDataAdapter("SELECT A.FOLIO, A.`FECHA DE CREACIÓN`, C.nombre, A.CUENTA, A.ESTATUS, A.OBSERVACIONES, A.PRIORIDAD, A.`FECHA AUTORIZACIÓN` FROM REQUITODAS A, `area` B, usuarios C, plaza D WHERE A.area = B.area AND A.userid = C.id AND A.PLAZA = D.crit AND B.id = " + area + " AND D.id = " + plaza, con);
            }
            else
            {
                _da = new MySqlDataAdapter("SELECT A.FOLIO, A.`FECHA DE CREACIÓN`, C.nombre, A.CUENTA, A.ESTATUS, A.OBSERVACIONES, A.PRIORIDAD, A.`FECHA AUTORIZACIÓN` FROM REQUITODAS A, `area` B, usuarios C, plaza D WHERE A.area = B.area AND A.userid = C.id AND A.PLAZA = D.crit AND D.id = " + plaza + " AND A.userid = " + usuario, con);
            }

            _ds = new DataSet();
            _da.Fill(_ds, "REQUITODAS");
            return _ds;
        }

        public DataSet listarRequis(string con)
        {
            _da = new MySqlDataAdapter("SELECT * FROM REQUITODAS", con);
            _ds = new DataSet();
            _da.Fill(_ds, "REQUITODAS");
            return _ds;
        }

        public DataSet listarRequisFinalizadas(string con, int usuario)
        {
            _da = new MySqlDataAdapter("SELECT * FROM FINALIZADAS WHERE userid = " + usuario, con);
            _ds = new DataSet();
            _da.Fill(_ds, "FINALIZADAS");
            return _ds;
        }

        public DataSet listarRequisFinalizadas(string con)
        {
            _da = new MySqlDataAdapter("SELECT * FROM FINALIZADAS", con);
            _ds = new DataSet();
            _da.Fill(_ds, "FINALIZADAS");
            return _ds;
        }

        public DataSet listarComprasUsuario(string con, int usuario)
        {
            _da = new MySqlDataAdapter("SELECT * FROM COMPRASU WHERE userid = " + usuario, con);
            _ds = new DataSet();
            _da.Fill(_ds, "COMPRASU");
            return _ds;
        }

        public DataSet listarComprasUsuario(string con)
        {
            _da = new MySqlDataAdapter("SELECT * FROM COMPRASU", con);
            _ds = new DataSet();
            _da.Fill(_ds, "COMPRASU");
            return _ds;
        }

        public DataSet listarReembolsoServ(string con, int usuario)
        {
            _da = new MySqlDataAdapter("SELECT FOLIO, 'FECHA DE CREACIÓN', AREA, NOMBRE, CUENTA, OBSERVACIONES, 'OBSERVACIONES DIRECCIÓN', 'OBSERVACIONES RM', PRIORIDAD FROM REEMBOLSOSERVICIO WHERE userid = " + usuario, con);
            _ds = new DataSet();
            _da.Fill(_ds, "REEMBOLSOSERVICIO");
            return _ds;
        }

        public DataSet listarReembolsoServ(string con)
        {
            _da = new MySqlDataAdapter("SELECT FOLIO, 'FECHA DE CREACIÓN', AREA, NOMBRE, CUENTA, OBSERVACIONES, 'OBSERVACIONES DIRECCIÓN', 'OBSERVACIONES RM', PRIORIDAD FROM REEMBOLSOSERVICIO", con);
            _ds = new DataSet();
            _da.Fill(_ds, "REEMBOLSOSERVICIO");
            return _ds;
        }

        public DataSet listarRequiRev(string con, int usuario)
        {
            _da = new MySqlDataAdapter("SELECT * FROM REQUIREV WHERE userid = " + usuario, con);
            _ds = new DataSet();
            _da.Fill(_ds, "REQUIREV");
            return _ds;
        }

        public DataSet listarRequiNoAut(string con, int usuario)
        {
            _da = new MySqlDataAdapter("SELECT * FROM REQUINOAUT WHERE userid = " + usuario, con);
            _ds = new DataSet();
            _da.Fill(_ds, "REQUINOAUT");
            return _ds;
        }

        public DataSet listarPartidas(string con, int usuario)
        {
            _da = new MySqlDataAdapter("SELECT FOLIOREQUI as Requi, FOLIOPARTIDA as Folio,CANTIDAD as Cantidad, DESCRIPCION as Descripción, MEDICION as Medición, COMENTC as Comentarios, odc as 'Orden de Compra',factura as Factura, ORDENDEPAGO as 'Orden de pago'," +
                "FE_ULTIMAACT as 'Actualización', ESTATUS as Estatus FROM PARTIDAS_PENDIENTES order by Requi desc", con);
            _ds = new DataSet();
            _da.Fill(_ds, "PARTIDAS_PENDIENTES");
            return _ds;
        }

        public DataSet listarPartidasCompras(string con, int folio)
        {
            _da = new MySqlDataAdapter("SELECT FOLIOREQUI as Requi, FOLIOPARTIDA as Folio,CANTIDAD as Cantidad, DESCRIPCION as Descripción, MEDICION as Medición, COMENTC as Comentarios, odc as 'Orden de Compra',factura as Factura, ORDENDEPAGO as 'Orden de pago'," +
                "FE_ULTIMAACT as 'Actualización', ESTATUS as Estatus FROM PARTIDAS_PENDIENTES WHERE FOLIOREQUI = " + folio + " order by Requi desc", con);
            _ds = new DataSet();
            _da.Fill(_ds, "PARTIDAS_PENDIENTES");
            return _ds;
        }

        public DataSet listarDetalles(string con, int folio)
        {
            _da = new MySqlDataAdapter("CALL listarDetalles (" + folio + ");", con);
            _ds = new DataSet();
            _da.Fill(_ds, "DETALLES");
            return _ds;
        }

        public DataSet listarDetallesODC(string con, int folio)
        {
            _da = new MySqlDataAdapter("CALL listarDetallesodc (" + folio + ");", con);
            _ds = new DataSet();
            _da.Fill(_ds, "DETALLESODC");   
            return _ds;
        }

        public DataSet listarPartFinalizadas(string con, int usuario)
        {
            _da = new MySqlDataAdapter("SELECT * FROM REQUIS_FINALIZADAS", con);
            _ds = new DataSet();
            _da.Fill(_ds, "REQUIS_FINALIZADAS");
            return _ds;
        }

        public DataSet listarActPartidas(string con, int usuario)
        {
            _da = new MySqlDataAdapter("SELECT * FROM REQUIS_FINALIZADAS", con);
            _ds = new DataSet();
            _da.Fill(_ds, "REQUIS_FINALIZADAS");
            return _ds;
        }

        public DataSet listarRequiDG(string con, int plaz)
        {
            _da = new MySqlDataAdapter("SELECT FOLIO, NOMBRE, CUENTA, `FECHA CREACION`, `FECHA ESTIMADA`, PRESUPUESTO, `COSTO APROXIMADO`, PRIORIDAD FROM REQUIDG WHERE PLAZA=" + plaz, con);
            _ds = new DataSet();
            _da.Fill(_ds, "REQUIDG");
            return _ds;
        }

        public DataSet listarRequiDM(string con, int plaz)
        {
            _da = new MySqlDataAdapter("SELECT FOLIO, NOMBRE, CUENTA, `FECHA CREACION`, `FECHA ESTIMADA`, PRESUPUESTO, `COSTO APROXIMADO`, PRIORIDAD FROM REQUIAM WHERE PLAZA=" + plaz, con);
            _ds = new DataSet();
            _da.Fill(_ds, "REQUIAM");
            return _ds;
        }

        public DataSet listarRequiRRMM(string con, int plaz)
        {
            _da = new MySqlDataAdapter("SELECT FOLIO, CUENTA, `FECHA DE CREACIÓN`, PRESUPUESTO, `COSTO APROXIMADO`, PRIORIDAD FROM REQUIRM WHERE PLAZA=" + plaz, con);
            _ds = new DataSet();
            _da.Fill(_ds, "REQUIRM");
            return _ds;
        }

        public DataSet listarCompras(string con, string plaza)
        {
            _da = new MySqlDataAdapter("SELECT A.FOLIO, A.`FECHA DE CREACIÓN`,A.`FECHA AUTORIZACIÓN`, A.`FECHA NECESIDAD`, B.nombre AS USUARIO, A.`OBSERVACIONES`, A.`PRIORIDAD`,A.`CAUS`,A.`UMODIFICACION` AS 'ULTIMA MODIFICACIÓN' FROM COMPRAS A, usuarios B WHERE A.userid = B.id AND A.PLAZA = " + plaza + " ORDER BY A.FOLIO", con);
            _ds = new DataSet();
            _da.Fill(_ds, "COMPRAS");
            return _ds;
        }

        public DataSet listarCompras(string con, int id, string plaza)
        {
            _da = new MySqlDataAdapter("SELECT A.FOLIO, A.`FECHA DE CREACIÓN`,A.`FECHA AUTORIZACIÓN`, A.`FECHA NECESIDAD`, B.nombre AS USUARIO, A.`OBSERVACIONES`, A.`PRIORIDAD`,A.`CAUS`,A.`UMODIFICACION` AS 'ULTIMA MODIFICACIÓN' FROM COMPRAS A, usuarios B WHERE A.userid =" + id + " AND A.userid = B.id AND A.PLAZA = " + plaza + " ORDER BY A.FOLIO", con);
            _ds = new DataSet();
            _da.Fill(_ds, "COMPRAS");
            return _ds;
        }

        public DataSet listarPartPendientes(string con)
        {
            _da = new MySqlDataAdapter("SELECT `FOLIOREQUI` as 'Folio Requisición', `FOLIOPARTIDA` as 'Folio Partida', `CANTIDAD` as 'Cantidad', `DESCRIPCION` as 'Descripción', `MEDICION` as 'U. de Medición', `COMENTC` as 'Comentarios Compras', `odc` as 'Orden de Compra',`factura` as 'Factura',`ORDENDEPAGO` as 'Orden de Pago', `fe_ultimaact` as 'Última Actualización', `ESTATUS` as 'Estatus' FROM `PARTIDAS_PENDIENTES`", con);
            _ds = new DataSet();
            _da.Fill(_ds, "PARTIDAS_PENDIENTES");
            return _ds;
        }

        public DataSet listarPartPendientes(string con, int foliorequi, int foliopart)
        {
            if (foliorequi == 0)
            {
                _da = new MySqlDataAdapter("SELECT `FOLIOREQUI` as 'Folio Requisición', `FOLIOPARTIDA` as 'Folio Partida', `CANTIDAD` as 'Cantidad', `DESCRIPCION` as 'Descripción', `MEDICION` as 'U. de Medición', `COMENTC` as 'Comentarios Compras', `odc` as 'Orden de Compra',`factura` as 'Factura',`ORDENDEPAGO` as 'Orden de Pago', `fe_ultimaact` as 'Última Actualización', `ESTATUS` as 'Estatus' FROM `PARTIDAS_PENDIENTES` WHERE `FOLIOPARTIDA`=" + foliopart + " ", con);
            }
            else
            {
                _da = new MySqlDataAdapter("SELECT `FOLIOREQUI` as 'Folio Requisición', `FOLIOPARTIDA` as 'Folio Partida', `CANTIDAD` as 'Cantidad', `DESCRIPCION` as 'Descripción', `MEDICION` as 'U. de Medición', `COMENTC` as 'Comentarios Compras', `odc` as 'Orden de Compra',`factura` as 'Factura',`ORDENDEPAGO` as 'Orden de Pago', `fe_ultimaact` as 'Última Actualización', `ESTATUS` as 'Estatus' FROM `PARTIDAS_PENDIENTES` WHERE `FOLIOREQUI`=" + foliorequi + " ", con);
            }
            _ds = new DataSet();
            _da.Fill(_ds, "PARTIDAS_PENDIENTES");
            return _ds;
        }

        public DataSet listarODCRRMM(string con)
        {
            _da = new MySqlDataAdapter("SELECT A.id, A.fechacreacion, A.proveedor, B.area, A.centrocostos, A.observaciones FROM ODC_RRMM A, area B where A.area = B.id", con);
            _ds = new DataSet();
            _da.Fill(_ds, "ODC_RRMM");
            return _ds;
        }

        public DataSet listarODCAutorizadas(string con, int plaza)
        {
            _da = new MySqlDataAdapter("SELECT id as 'Folio ODC', fechacreacion as 'Fecha de creación', proveedor as Proveedor, area as AREA, centrocostos as 'Centro de costos'," +
                "observaciones as Observaciones, comite as Comité, coti1 as 'Cotización 1', coti2 as 'Cotización 2', coti3 as 'Cotización 3', fechaactrm as 'Autorización RM' FROM ODC_AUTORIZADAS WHERE plaza = " + plaza, con);
            _ds = new DataSet();
            _da.Fill(_ds, "ODC_AUTORIZADAS");
            return _ds;
        }

        public DataSet listarUsuarios(string con)
        {
            _da = new MySqlDataAdapter("SELECT * FROM USUARIOS_TODOS", con);
            _ds = new DataSet();
            _da.Fill(_ds, "USUARIOS_TODOS");
            return _ds;
        }

        public DataSet ConsultaPartidas(string con)
        {
            _da = new MySqlDataAdapter("SELECT * FROM detalle", con);
            _ds = new DataSet();
            _da.Fill(_ds, "detalles");
            return _ds;
        }

        public DataSet ConsultaProveedores(string con)
        {
            _da = new MySqlDataAdapter("SELECT * FROM proveedor", con);
            _ds = new DataSet();
            _da.Fill(_ds, "proveedores");
            return _ds;
        }

        public DataTable ConsultaDetalles(string con, int folio)
        {
            _da = new MySqlDataAdapter("SELECT * FROM detalle WHERE folio = " + folio, con);
            _da.Fill(_dt);
            return _dt;
        }

        public DataSet ConsultaUserLevel(string con)
        {
            _da = new MySqlDataAdapter("SELECT * FROM userlevels", con);
            _ds = new DataSet();
            _da.Fill(_ds, "userlevels");
            return _ds;
        }

        public DataSet ConsultaArea(string con)
        {
            _da = new MySqlDataAdapter("SELECT * FROM area", con);
            _ds = new DataSet();
            _da.Fill(_ds, "area");
            return _ds;
        }

        public DataSet ConsultaSubarea(string con, int area)
        {
            _da = new MySqlDataAdapter("SELECT * FROM subarea where area =" + area, con);
            _ds = new DataSet();
            _da.Fill(_ds, "subarea");
            return _ds;
        }

        public DataSet ConsultaPlaza(string con)
        {
            _da = new MySqlDataAdapter("SELECT * FROM plaza", con);
            _ds = new DataSet();
            _da.Fill(_ds, "plaza");
            return _ds;
        }

        public DataSet ConsultaPuesto(string con)
        {
            _da = new MySqlDataAdapter("SELECT * FROM puesto", con);
            _ds = new DataSet();
            _da.Fill(_ds, "puesto");
            return _ds;
        }

        public DataTable DatosProveedores(string con, int id)
        {
            _da = new MySqlDataAdapter("SELECT * FROM proveedor WHERE id = " + id, con);
            _da.Fill(_dt);
            return _dt;
        }

        public DataTable DatosRequi(string con, int folio)
        {
            _da = new MySqlDataAdapter("CALL listarRequi(" + folio + "); ", con);
            _da.Fill(_dt);
            return _dt;
        }

        public DataTable DatosODC(string con, int folio)
        {
            _da = new MySqlDataAdapter("CALL listarODC(" + folio + "); ", con);
            _da.Fill(_dt);
            return _dt;
        }

        public DataTable DatosCompras(string con, int folio)
        {
            _da = new MySqlDataAdapter("CALL listarCompras(" + folio + "); ", con);
            _da.Fill(_dt);
            return _dt;
        }

        public DataTable DatosPartida(string con, int folio)
        {
            _da = new MySqlDataAdapter("CALL listarPartidas(" + folio + "); ", con);
            _da.Fill(_dt);
            return _dt;
        }

        public DataTable DatosUsuario(string con, int id)
        {
            _da = new MySqlDataAdapter("CALL listarUsuario(" + id + "); ", con);
            _da.Fill(_dt);
            return _dt;
        }

    }
}