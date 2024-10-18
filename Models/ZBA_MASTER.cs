using System.ComponentModel.DataAnnotations;

namespace ZAxisModule.Models
{
    public class ZBA_MASTER
    {
        [Key]
        public decimal? ZBAID { get; set; }
        public string? ZBACODE { get; set; }
        public string? ZBATYPE { get; set; }
        public string? ZBANAME { get; set; }
        public DateTime? OPENDATE { get; set; }
        public DateTime? CLOSEDATE { get; set; }
        public decimal? PARENTID { get; set; }
        public string? ZBAEMPHEAD { get; set; }
        public string? MAILZONE { get; set; }
        public string? ZBACLASS { get; set; }
        public string? ZBASTATUS { get; set; }
        public string? FRANCHISE { get; set; }
        public string? BRZONE { get; set; }
        public DateTime? LASTUPDATED { get; set; }
        public string? MODIFIED { get; set; }
        public string? LOCALCURR { get; set; }
        public decimal? VATPER { get; set; }
        public string? VATDESCR { get; set; }
        public string? ONLINERECTSHOOT { get; set; }
        public string? RECTADDITIONALEMAIL { get; set; }
        public string? RECTSMSEMPNO { get; set; }
        public decimal? RECTCATNTAPPL { get; set; }
        public string? IPSTAT { get; set; }
        public string? LOCALCMPNM { get; set; }
        public string? LOCALCMPADD { get; set; }
        public string? FAGRLCLCURR { get; set; }
        public string? WEBFLAG { get; set; }
        public decimal? FEAGRSCOPE { get; set; }
        public decimal? COMPID { get; set; }
        public string? WEBASSFRM { get; set; }
        public decimal? WEBORDR { get; set; }
        public string? WEBZBANM { get; set; }
        public string? ESIGN { get; set; }
        public string? PROINVCURR { get; set; }
        public decimal? REP_ORDER { get; set; }
        public string? GSTIN { get; set; }
        public string? ARN { get; set; }
        public string? USD_CNV { get; set; }
        public string? GSTNSEQ { get; set; }
        public string? GSTNSEQ_DBNT { get; set; }
        public string? TECHFORM_AVL { get; set; }
        public string? TALLYSTTHEAD { get; set; }
        public int? SMSZONE { get; set; }
        public string? TELLY_SEQ { get; set; }
        public string? VATAPL { get; set; }
        public decimal? VATAPLCHG { get; set; }
        public string? BNK_CHRG { get; set; }
        public decimal? SUBZNEGRPID { get; set; }
        public long? ZBA_AGM { get; set; }
        public int? AGRVRSN { get; set; }
        public int? BUS_AGM { get; set; }
        public int? IND_AGM { get; set; }
        public int? EDU_AGM { get; set; }
        public decimal? WEBDISPSEQ { get; set; }
        public decimal? DSRZONE { get; set; }
        public int? GMTMNT { get; set; }
        public string? RRPROC { get; set; }
        public string? ENQSMSEML_APL { get; set; }
        public decimal? TEFFEE { get; set; }
        public decimal? CMPDOCGRP { get; set; }
        public string? ZAXISAPP { get; set; }
        public string? WHTSAPPNO { get; set; }
        public string? CENTREMDL { get; set; }
        public string? GOOGLEREVLNK { get; set; }
        public string? WHATSAPPFLG { get; set; }
        public string? NEW_AGR_PRCS { get; set; }
        public string? LMTDSRVC { get; set; }
        public string? ADR_VLD { get; set; }
        public decimal? DSIPSEQ { get; set; }
    }
}
