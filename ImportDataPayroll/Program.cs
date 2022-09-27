﻿using ImportDataPayroll.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
//using System.Threading.Tasks;

namespace ImportDataPayroll
{
    class Program
    {
       // static string conn_sql;

        static void Main(string[] args)
        {
            getMenu();

           // conn_sql = ConfigurationManager.AppSettings["ConnectionString_SQLSERVER"].ToString();

            Console.WriteLine();
            Console.WriteLine();

            inputMenu();

            Console.ReadKey();
            Console.WriteLine("Finish Program");
        }

        public static void getMenu()
        {
            Console.WriteLine("===================================================");
            Console.WriteLine("                       Table                      ");
            Console.WriteLine("===================================================");

            Console.WriteLine("ALL PAYROLL");
            Console.WriteLine("1 PAY_ADDRESS");
            Console.WriteLine("2 PAY_ADVANCE");
            Console.WriteLine("3 PAY_ADVANCE_CLEAR");
            Console.WriteLine("4 PAY_ADVANCE_HISTORY");
            Console.WriteLine("5 PAY_BONUS_HISTORY");
            Console.WriteLine("6 PAY_CARDINFO");
            Console.WriteLine("7 PAY_COMPANY_BANK");
            Console.WriteLine("8 PAY_COURSE");
            Console.WriteLine("9 PAY_DAILY");
            Console.WriteLine("10 PAY_DECREASE");
            Console.WriteLine("11 PAY_DECREASE_YEAR");
            Console.WriteLine("12 PAY_DECREASETAX");
            Console.WriteLine("13 PAY_DEPT");
            Console.WriteLine("14 PAY_EMPY");
            Console.WriteLine("15 PAY_EMP_COURSE");
            Console.WriteLine("16 PAY_EMP_LOAN");
            Console.WriteLine("17 PAY_EMP_LOAN_TIME");
            Console.WriteLine("18 PAY_EMP_OFFER");
            Console.WriteLine("19 PAY_EMP_OT_TIME");
            Console.WriteLine("20 PAY_EMPEDU");
            Console.WriteLine("21 PAY_EXPORT_LOGS");
            Console.WriteLine("22 PAY_GROUP");
            Console.WriteLine("23 PAY_HISTORYPOSITION");
            Console.WriteLine("24 PAY_HISTORYSALARY");
            Console.WriteLine("25 PAY_INCDED");
            Console.WriteLine("26 PAY_INCDED_IMP");
            Console.WriteLine("27 PAY_INCDED_REG");
            Console.WriteLine("28 PAY_INCDED_TMP");
            Console.WriteLine("29 PAY_INCOME_DECERASE");
            Console.WriteLine("30 PAY_INCOMEXEMPT");
            Console.WriteLine("31 PAY_IP_ACCESS");
            Console.WriteLine("32 PAY_IP_USER_ALLOW");
            Console.WriteLine("33 PAY_JOB");
            Console.WriteLine("34 PAY_JOB_COST");
            Console.WriteLine("35 PAY_JOB_PERIOD");
            Console.WriteLine("36 PAY_LEAVEWP");
            Console.WriteLine("37 PAY_LOAN_DETAIL");
            Console.WriteLine("38 PAY_LOGALERT");
            Console.WriteLine("39 PAY_MTHINCDED");
            Console.WriteLine("40 PAY_OFFER_LABORLAW");
            Console.WriteLine("41 PAY_OFFER_OTHERCOST");
            Console.WriteLine("42 PAY_OFFER_PERSONALTAX");
            Console.WriteLine("43 PAY_OT");
            Console.WriteLine("44 PAY_PERMISSION");
            Console.WriteLine("45 PAY_POSITION");
            Console.WriteLine("46 PAY_PROVIDENTFUND");
            Console.WriteLine("47 PAY_PVDCOVER");
            Console.WriteLine("48 PAY_SETCOMPANY");
            Console.WriteLine("49 PAY_SETPVDCOVER");
            Console.WriteLine("50 PAY_SOCIALCOST");
            Console.WriteLine("51 PAY_TIME");
            Console.WriteLine("52 PAY_TIME_HOLIDAY");
            Console.WriteLine("53 PAY_TIME_RAW");
            Console.WriteLine("54 PAY_TRANSDEPT");
            Console.WriteLine("55 PAY_WORKINFO");
            Console.WriteLine("56 PAY_YRINCDED");
            Console.WriteLine("57 SUPREME_USER");
            Console.WriteLine("58 EMP");
            Console.WriteLine("59 DEPT");

            Console.WriteLine("");
            Console.WriteLine("ALL PETTYCASH");
            Console.WriteLine("60 PTY_CASH");
            Console.WriteLine("61 PTY_EXCELCONFIG");
            Console.WriteLine("62 PTY_HISWD");
            Console.WriteLine("63 PTY_PAYTYPE");
            Console.WriteLine("64 PTY_PERMISSION");
            Console.WriteLine("65 PTY_REFUND");
            Console.WriteLine("66 PTY_SUMCASH");
            Console.WriteLine("67 PTY_SUMWDRESERVE");
            Console.WriteLine("68 PTY_WDRESERVE");
            Console.WriteLine("69 PTY_WDRESERVE_DETAIL");
            Console.WriteLine("70 PTY_WITHDRAWALS_DAILY");

            Console.WriteLine("");
            Console.WriteLine("ALL FINANCE_BILL");
            Console.WriteLine("71 FINANCE_BILL_ACC");
            Console.WriteLine("72 FINANCE_BILL_M");
            Console.WriteLine("73 FINANCE_BILL_D");
            Console.WriteLine("74 FINANCE_BILL_PAY_M");
            Console.WriteLine("75 FINANCE_BILL_PAY_D");
            Console.WriteLine("76 FINANCE_BILL_VENDER");

            Console.WriteLine("");
            Console.WriteLine("ALL TAXFINANCE");
            Console.WriteLine("77 TAX_DETAIL5");
            Console.WriteLine("78 TAX_SUBTRACT5");
            Console.WriteLine("79 NGAR");
            Console.WriteLine("80 NGAR_TRACKING");
            Console.WriteLine("81 NGAR_PROD");
            Console.WriteLine("82 NGAR_STOCK_IN");
            Console.WriteLine("83 TAXFINANCE_PERMISSION");

            Console.WriteLine("");
            Console.WriteLine("ALL HAMSCO");
            Console.WriteLine("84 EMP");
            Console.WriteLine("85 REQUISITION");
            Console.WriteLine("86 REQUISITION_CONFIG");
            Console.WriteLine("87 REQUISITION_STATUS_TRACKING");
            Console.WriteLine("88 REQUISITION_TIME_PROCESS");
            Console.WriteLine("89 REQUISITION_TRACKING");
            Console.WriteLine("90 REQUISITION_TS");
            Console.WriteLine("91 REQUISITION_TS_FOLLOW");
            Console.WriteLine("92 REQUISITION2");
            Console.WriteLine("93 BILLING");
            Console.WriteLine("94 BILL_DETAIL");
            Console.WriteLine("95 CPI");
            Console.WriteLine("96 CPI_CONTRACT");
            Console.WriteLine("97 CPI_PRODUCT");
            Console.WriteLine("98 CPII");
            Console.WriteLine("99 REQ_BETWEEN_MNG");
            Console.WriteLine("100 REQ_BILL");
            Console.WriteLine("101 REQ_BILL1");
            Console.WriteLine("102 REQ_BILL3");
            Console.WriteLine("103 REQ_BILLNEW");
            Console.WriteLine("104 REQ_BILLNEW2");
            Console.WriteLine("105 REQ_COLLECT_BILL");
            Console.WriteLine("106 REQ_CONTRACT");
            Console.WriteLine("107 REQ_COUNT_LOGSHEET");
            Console.WriteLine("108 BRAND");
            Console.WriteLine("109 BRAND_EXCHANGE_RATE");
            Console.WriteLine("110 REQ_GWD");
            Console.WriteLine("111 REQ_GWD_REF");
            Console.WriteLine("112 REQ_REMARKS");
            Console.WriteLine("113 REQ_STATUS");
            Console.WriteLine("114 REQ_TAXCN");
            Console.WriteLine("115 REQ_TS_CONTRACT");
            Console.WriteLine("116 REQ_TS_GAR_PO");
            Console.WriteLine("117 REQ_TS_PROD");
            Console.WriteLine("118 EMP");
            Console.WriteLine("119 PRODUCT");
            Console.WriteLine("120 PROD_CHANGE");
            Console.WriteLine("121 PAYMENT_METHOD");
            Console.WriteLine("122 ZONE_BKK");
            Console.WriteLine("123 RSV_FOC");
            Console.WriteLine("124 SALE_VAC_SHARING");
            Console.WriteLine("125 PROVINCE_SALE");
            Console.WriteLine("126 ZONE_SALE");
            Console.WriteLine("127 HOSPITAL");
            Console.WriteLine("128 CONSIGNMENT_DATA");
            Console.WriteLine("129 CONSIGNMENT_PROD");
            Console.WriteLine("130 PROD_CONFIG_MASTER");
            Console.WriteLine("131 PROD_CONFIG_DETAIL");
            Console.WriteLine("132 CONFIG_MASTER");
            Console.WriteLine("133 CONFIG_DETAIL");
            Console.WriteLine("134 PERSON_ADDR");
            Console.WriteLine("135 ORG_ADDR");
            Console.WriteLine("136 CUSTOMER");

            Console.WriteLine("137 SUPPLIER");
            Console.WriteLine("138 PO_MASTER");
            Console.WriteLine("139 SUPREME_USER");

        }

        public static void inputMenu()
        {
            Console.Write("Select Table : ");
            string mudule = Console.ReadLine();

            switch (mudule)
            {
                case "ALL PAYROLL":
                    Payroll.Import_PAY_ADDRESS();
                    Payroll.Import_PAY_ADVANCE();
                    Payroll.Import_PAY_ADVANCE_CLEAR();
                    Payroll.Import_PAY_ADVANCE_HISTORY();
                    Payroll.Import_PAY_BONUS_HISTORY();
                    Payroll.Import_PAY_CARDINFO();
                    Payroll.Import_PAY_COMPANY_BANK();
                    Payroll.Import_PAY_COURSE();
                    Payroll.Import_PAY_DAILY();
                    Payroll.Import_PAY_DECREASE();
                    Payroll.Import_PAY_DECREASE_YEAR();
                    Payroll.Import_PAY_DECREASETAX();
                    Payroll.Import_PAY_DEPT();
                    Payroll.Import_PAY_EMP();
                    Payroll.Import_PAY_EMP_COURSE();
                    Payroll.Import_PAY_EMP_LOAN();
                    Payroll.Import_PAY_EMP_LOAN_TIME();
                    Payroll.Import_PAY_EMP_OFFER();
                    Payroll.Import_PAY_EMP_OT_TIME();
                    Payroll.Import_PAY_EMPEDU();
                    Payroll.Import_PAY_EXPORT_LOGS();
                    Payroll.Import_PAY_GROUP();
                    Payroll.Import_PAY_HISTORYPOSITION();
                    Payroll.Import_PAY_HISTORYSALARY();
                    Payroll.Import_PAY_INCDED();
                    Payroll.Import_PAY_INCDED_IMP();
                    Payroll.Import_PAY_INCDED_REG();
                    Payroll.Import_PAY_INCDED_TMP();
                    Payroll.Import_PAY_INCOME_DECERASE();
                    Payroll.Import_PAY_INCOMEXEMPT();
                    Payroll.Import_PAY_IP_ACCESS();
                    Payroll.Import_PAY_IP_USER_ALLOW();
                    Payroll.Import_PAY_JOB();
                    Payroll.Import_PAY_JOB_COST();
                    Payroll.Import_PAY_JOB_PERIOD();
                    Payroll.Import_PAY_LEAVEWP();
                    Payroll.Import_PAY_LOAN_DETAIL();
                    Payroll.Import_PAY_LOGALERT();
                    Payroll.Import_PAY_MTHINCDED();
                    Payroll.Import_PAY_OFFER_LABORLAW();
                    Payroll.Import_PAY_OFFER_OTHERCOST();
                    Payroll.Import_PAY_OFFER_PERSONALTAX();
                    Payroll.Import_PAY_OT();
                    Payroll.Import_PAY_PERMISSION();
                    Payroll.Import_PAY_POSITION();
                    Payroll.Import_PAY_PROVIDENTFUND();
                    Payroll.Import_PAY_PVDCOVER();
                    Payroll.Import_PAY_SETPVDCOVER();
                    Payroll.Import_PAY_SETCOMPANY();
                    Payroll.Import_PAY_SOCIALCOST();
                    Payroll.Import_PAY_TIME();
                    Payroll.Import_PAY_TIME_HOLIDAY();
                    Payroll.Import_PAY_TIME_RAW();
                    Payroll.Import_PAY_TRANSDEPT();
                    Payroll.Import_PAY_WORKINFO();
                    Payroll.Import_PAY_YRINCDED();
                    Payroll.Import_SUPREME_USER();
                    Payroll.Import_EMP();
                    Payroll.Import_DEPT();
                    break;
                
                case "1": Payroll.Import_PAY_ADDRESS(); break;
                case "2": Payroll.Import_PAY_ADVANCE(); break;
                case "3": Payroll.Import_PAY_ADVANCE_CLEAR(); break;
                case "4": Payroll.Import_PAY_ADVANCE_HISTORY(); break;
                case "5": Payroll.Import_PAY_BONUS_HISTORY(); break;
                case "6": Payroll.Import_PAY_CARDINFO(); break;
                case "7": Payroll.Import_PAY_COMPANY_BANK(); break;
                case "8": Payroll.Import_PAY_COURSE(); break;
                case "9": Payroll.Import_PAY_DAILY(); break;
                case "10": Payroll.Import_PAY_DECREASE(); break;
                case "11": Payroll.Import_PAY_DECREASE_YEAR(); break;
                case "12": Payroll.Import_PAY_DECREASETAX(); break;
                case "13": Payroll.Import_PAY_DEPT(); break;
                case "14": Payroll.Import_PAY_EMP(); break;
                case "15": Payroll.Import_PAY_EMP_COURSE(); break;
                case "16": Payroll.Import_PAY_EMP_LOAN(); break;
                case "17": Payroll.Import_PAY_EMP_LOAN_TIME(); break;
                case "18": Payroll.Import_PAY_EMP_OFFER(); break;
                case "19": Payroll.Import_PAY_EMP_OT_TIME(); break;
                case "20": Payroll.Import_PAY_EMPEDU(); break;
                case "21": Payroll.Import_PAY_EXPORT_LOGS(); break;
                case "22": Payroll.Import_PAY_GROUP(); break;
                case "23": Payroll.Import_PAY_HISTORYPOSITION(); break;
                case "24": Payroll.Import_PAY_HISTORYSALARY(); break;
                case "25": Payroll.Import_PAY_INCDED(); break;
                case "26": Payroll.Import_PAY_INCDED_IMP(); break;
                case "27": Payroll.Import_PAY_INCDED_REG(); break;
                case "28": Payroll.Import_PAY_INCDED_TMP(); break;
                case "29": Payroll.Import_PAY_INCOME_DECERASE(); break;
                case "30": Payroll.Import_PAY_INCOMEXEMPT(); break;
                case "31": Payroll.Import_PAY_IP_ACCESS(); break;
                case "32": Payroll.Import_PAY_IP_USER_ALLOW(); break;
                case "33": Payroll.Import_PAY_JOB(); break;
                case "34": Payroll.Import_PAY_JOB_COST(); break;
                case "35": Payroll.Import_PAY_JOB_PERIOD(); break;
                case "36": Payroll.Import_PAY_LEAVEWP(); break;
                case "37": Payroll.Import_PAY_LOAN_DETAIL(); break;
                case "38": Payroll.Import_PAY_LOGALERT(); break;
                case "39": Payroll.Import_PAY_MTHINCDED(); break;
                case "40": Payroll.Import_PAY_OFFER_LABORLAW(); break;
                case "41": Payroll.Import_PAY_OFFER_OTHERCOST(); break;
                case "42": Payroll.Import_PAY_OFFER_PERSONALTAX(); break;
                case "43": Payroll.Import_PAY_OT(); break;
                case "44": Payroll.Import_PAY_PERMISSION(); break;
                case "45": Payroll.Import_PAY_POSITION(); break;
                case "46": Payroll.Import_PAY_PROVIDENTFUND(); break;
                case "47": Payroll.Import_PAY_PVDCOVER(); break;
                case "48": Payroll.Import_PAY_SETCOMPANY(); break;
                case "49": Payroll.Import_PAY_SETPVDCOVER(); break;
                case "50": Payroll.Import_PAY_SOCIALCOST(); break;
                case "51": Payroll.Import_PAY_TIME(); break;
                case "52": Payroll.Import_PAY_TIME_HOLIDAY(); break;
                case "53": Payroll.Import_PAY_TIME_RAW(); break;
                case "54": Payroll.Import_PAY_TRANSDEPT(); break;
                case "55": Payroll.Import_PAY_WORKINFO(); break;
                case "56": Payroll.Import_PAY_YRINCDED(); break;
                case "57": Payroll.Import_SUPREME_USER(); break;
                case "58": Payroll.Import_EMP(); break;
                case "59": Payroll.Import_DEPT(); break;

                case "ALL PETTYCASH":
                    PettyCash.Import_PTY_CASH();
                    PettyCash.Import_PTY_EXCELCONFIG();
                    PettyCash.Import_PTY_HISWD();
                    PettyCash.Import_PTY_PAYTYPE();
                    PettyCash.Import_PTY_PERMISSION();
                    PettyCash.Import_PTY_REFUND();
                    PettyCash.Import_PTY_SUMCASH();
                    PettyCash.Import_PTY_SUMWDRESERVE();
                    PettyCash.Import_PTY_WDRESERVE();
                    PettyCash.Import_PTY_WDRESERVE_DETAIL();
                    PettyCash.Import_PTY_WITHDRAWALS_DAILY();

                    break;

                case "60": PettyCash.Import_PTY_CASH(); break;
                case "61": PettyCash.Import_PTY_EXCELCONFIG(); break;
                case "62": PettyCash.Import_PTY_HISWD(); break;
                case "63": PettyCash.Import_PTY_PAYTYPE(); break;
                case "64": PettyCash.Import_PTY_PERMISSION(); break;
                case "65": PettyCash.Import_PTY_REFUND(); break;
                case "66": PettyCash.Import_PTY_SUMCASH(); break;
                case "67": PettyCash.Import_PTY_SUMWDRESERVE(); break;
                case "68": PettyCash.Import_PTY_WDRESERVE(); break;
                case "69": PettyCash.Import_PTY_WDRESERVE_DETAIL(); break;
                case "70": PettyCash.Import_PTY_WITHDRAWALS_DAILY(); break;


                case "ALL FINANCE_BILL":
                    FinanceBill.Import_FINANCE_BILL_ACC();
                    FinanceBill.Import_FINANCE_BILL_M();
                    FinanceBill.Import_FINANCE_BILL_D();
                    FinanceBill.Import_FINANCE_BILL_PAY_M();
                    FinanceBill.Import_FINANCE_BILL_PAY_D();
                    FinanceBill.Import_FINANCE_BILL_VENDER();
                    break;

                case "71": FinanceBill.Import_FINANCE_BILL_ACC(); break;
                case "72": FinanceBill.Import_FINANCE_BILL_M(); break;
                case "73": FinanceBill.Import_FINANCE_BILL_D(); break;
                case "74": FinanceBill.Import_FINANCE_BILL_PAY_M(); break;
                case "75": FinanceBill.Import_FINANCE_BILL_PAY_D(); break;
                case "76": FinanceBill.Import_FINANCE_BILL_VENDER(); break;


                case "ALL TAXFINANCE":
                    TaxFinance.Import_TAX_DETAIL5();
                    TaxFinance.Import_TAX_SUBTRACT5();
                    TaxFinance.Import_NGAR();
                    TaxFinance.Import_NGAR_TRACKING();
                    TaxFinance.Import_NGAR_PROD();
                    TaxFinance.Import_NGAR_STOCK_IN();
                    TaxFinance.Import_TAXFINANCE_PERMISSION();
                    break;

                case "77": TaxFinance.Import_TAX_DETAIL5(); break;
                case "78": TaxFinance.Import_TAX_SUBTRACT5(); break;
                case "79": TaxFinance.Import_NGAR(); break;
                case "80": TaxFinance.Import_NGAR_TRACKING(); break;
                case "81": TaxFinance.Import_NGAR_PROD(); break;
                case "82": TaxFinance.Import_NGAR_STOCK_IN(); break;
                case "83": TaxFinance.Import_TAXFINANCE_PERMISSION(); break;


                case "ALL HAMSCO":
                    Hamsco.Import_EMP();
                    Hamsco.Import_REQUISITION();
                    Hamsco.Import_REQUISITION_CONFIG();
                    Hamsco.Import_REQUISITION_STATUS_TRACKING();
                    Hamsco.Import_REQUISITION_TIME_PROCESS();
                    Hamsco.Import_REQUISITION_TRACKING();
                    Hamsco.Import_REQUISITION_TS();
                    Hamsco.Import_REQUISITION_TS_FOLLOW();
                    Hamsco.Import_REQUISITION2();
                    Hamsco.Import_BILLING();
                    Hamsco.Import_BILL_DETAIL();
                    Hamsco.Import_CPI();
                    Hamsco.Import_CPI_CONTRACT();
                    Hamsco.Import_CPI_PRODUCT();
                    Hamsco.Import_CPII();
                    Hamsco.Import_REQ_BETWEEN_MNG();
                    Hamsco.Import_REQ_BILL();
                    Hamsco.Import_REQ_BILL1();
                    Hamsco.Import_REQ_BILL3();
                    Hamsco.Import_REQ_BILLNEW();
                    Hamsco.Import_REQ_BILLNEW2();
                    Hamsco.Import_REQ_COLLECT_BILL();
                    Hamsco.Import_REQ_CONTRACT();
                    Hamsco.Import_REQ_COUNT_LOGSHEET();
                    Hamsco.Import_BRAND();
                    Hamsco.Import_BRAND_EXCHANGE_RATE();
                    Hamsco.Import_REQ_GWD();
                    Hamsco.Import_REQ_GWD_REF();
                    Hamsco.Import_REQ_REMARKS();
                    Hamsco.Import_REQ_STATUS();

                    Hamsco.Import_REQ_TAXCN(); 
                    Hamsco.Import_REQ_TS_CONTRACT(); 
                    Hamsco.Import_REQ_TS_GAR_PO(); 
                    Hamsco.Import_REQ_TS_PROD(); 
                   
                    Hamsco.Import_PRODUCT(); 
                    Hamsco.Import_PROD_CHANGE(); 
                    Hamsco.Import_PAYMENT_METHOD(); 
                    Hamsco.Import_ZONE_BKK(); 
                    Hamsco.Import_RSV_FOC(); 

                    Hamsco.Import_SALE_VAC_SHARING(); 
                    Hamsco.Import_PROVINCE_SALE();  
                    Hamsco.Import_ZONE_SALE();  
                    Hamsco.Import_HOSPITAL();  
                    Hamsco.Import_CONSIGNMENT_DATA();  
                    Hamsco.Import_CONSIGNMENT_PROD();  
                    Hamsco.Import_PROD_CONFIG_MASTER();  
                    Hamsco.Import_PROD_CONFIG_DETAIL(); 
                    Hamsco.Import_CONFIG_MASTER(); 
                    Hamsco.Import_CONFIG_DETAIL(); 
                    Hamsco.Import_PERSON_ADDR();  
                    Hamsco.Import_ORG_ADDR();  
                    Hamsco.Import_CUSTOMER(); 

                    Hamsco.Import_SUPPLIER(); 
                    Hamsco.Import_PO_MASTER(); 
                    Hamsco.Import_CUSTOMER(); 

                    break;

                case "84": Hamsco.Import_EMP(); break;
                case "85": Hamsco.Import_REQUISITION(); break;
                case "86": Hamsco.Import_REQUISITION_CONFIG(); break;
                case "87": Hamsco.Import_REQUISITION_STATUS_TRACKING(); break;
                case "88": Hamsco.Import_REQUISITION_TIME_PROCESS(); break;
                case "89": Hamsco.Import_REQUISITION_TRACKING(); break;
                case "90": Hamsco.Import_REQUISITION_TS(); break;
                case "91": Hamsco.Import_REQUISITION_TS_FOLLOW(); break;
                case "92": Hamsco.Import_REQUISITION2(); break;
                case "93": Hamsco.Import_BILLING(); break;
                case "94": Hamsco.Import_BILL_DETAIL(); break;
                case "95": Hamsco.Import_CPI(); break;
                case "96": Hamsco.Import_CPI_CONTRACT(); break;
                case "97": Hamsco.Import_CPI_PRODUCT(); break;
                case "98": Hamsco.Import_CPII(); break;
                case "99": Hamsco.Import_REQ_BETWEEN_MNG(); break;
                case "100": Hamsco.Import_REQ_BILL(); break;
                case "101": Hamsco.Import_REQ_BILL1(); break;
                case "102": Hamsco.Import_REQ_BILL3(); break;
                case "103": Hamsco.Import_REQ_BILLNEW(); break;
                case "104": Hamsco.Import_REQ_BILLNEW2(); break;
                case "105": Hamsco.Import_REQ_COLLECT_BILL(); break;
                case "106": Hamsco.Import_REQ_CONTRACT(); break;
                case "107": Hamsco.Import_REQ_COUNT_LOGSHEET(); break;
                case "108": Hamsco.Import_BRAND(); break;
                case "109": Hamsco.Import_BRAND_EXCHANGE_RATE(); break;
                case "110": Hamsco.Import_REQ_GWD(); break;
                case "111": Hamsco.Import_REQ_GWD_REF(); break;
                case "112": Hamsco.Import_REQ_REMARKS(); break;
                case "113": Hamsco.Import_REQ_STATUS(); break;

                case "114": Hamsco.Import_REQ_TAXCN(); break;
                case "115": Hamsco.Import_REQ_TS_CONTRACT(); break;
                case "116": Hamsco.Import_REQ_TS_GAR_PO(); break;
                case "117": Hamsco.Import_REQ_TS_PROD(); break;
                case "119": Hamsco.Import_PRODUCT(); break;
                case "120": Hamsco.Import_PROD_CHANGE(); break;
                case "121": Hamsco.Import_PAYMENT_METHOD(); break;
                case "122": Hamsco.Import_ZONE_BKK(); break;
                case "123": Hamsco.Import_RSV_FOC(); break;

                case "124": Hamsco.Import_SALE_VAC_SHARING(); break;
                case "125": Hamsco.Import_PROVINCE_SALE(); break;
                case "126": Hamsco.Import_ZONE_SALE(); break;
                case "127": Hamsco.Import_HOSPITAL(); break;
                case "128": Hamsco.Import_CONSIGNMENT_DATA(); break;
                case "129": Hamsco.Import_CONSIGNMENT_PROD(); break;
                case "130": Hamsco.Import_PROD_CONFIG_MASTER(); break;
                case "131": Hamsco.Import_PROD_CONFIG_DETAIL(); break;
                case "132": Hamsco.Import_CONFIG_MASTER(); break;
                case "133": Hamsco.Import_CONFIG_DETAIL(); break;
                case "134": Hamsco.Import_PERSON_ADDR(); break;
                case "135": Hamsco.Import_ORG_ADDR(); break;
                case "136": Hamsco.Import_CUSTOMER(); break;

                case "137": Hamsco.Import_PERSON_ADDR(); break;
                case "138": Hamsco.Import_PO_MASTER(); break;
                case "139": Hamsco.Import_SUPREME_USER(); break;
                defaule:
                    break;
            }

            Console.WriteLine();

            inputMenu();
        }

       


        
    }
}
