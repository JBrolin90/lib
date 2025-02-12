using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jbLib.DataTableGrid
{
    public partial class ObservableDataRow
    {

        private readonly DataRow row;

        public int? Int0
        {
            get => row[0] == DBNull.Value ? null : (int)row[0];
            set => row[0] = value is null ? DBNull.Value : value;
        }
        public string? String0
        {
            get => row[0] == DBNull.Value ? null : (string)row[0];
            set => row[0] = value is null ? DBNull.Value : value;
        }
        public double? Double0
        {
            get => row[0] == DBNull.Value ? null : (double)row[0];
            set => row[0] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime0
        {
            get => row[0] == DBNull.Value ? null : (DateTime)row[0];
            set => row[0] = value is null ? DBNull.Value : value;
        }
        public int? Int1
        {
            get => row[1] == DBNull.Value ? null : (int)row[1];
            set => row[1] = value is null ? DBNull.Value : value;
        }
        public string? String1
        {
            get => row[1] == DBNull.Value ? null : (string)row[1];
            set => row[1] = value is null ? DBNull.Value : value;
        }
        public double? Double1
        {
            get => row[1] == DBNull.Value ? null : (double)row[1];
            set => row[1] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime1
        {
            get => row[1] == DBNull.Value ? null : (DateTime)row[1];
            set => row[1] = value is null ? DBNull.Value : value;
        }
        public int? Int2
        {
            get => row[2] == DBNull.Value ? null : (int)row[2];
            set => row[2] = value is null ? DBNull.Value : value;
        }
        public string? String2
        {
            get => row[2] == DBNull.Value ? null : (string)row[2];
            set => row[2] = value is null ? DBNull.Value : value;
        }
        public double? Double2
        {
            get => row[2] == DBNull.Value ? null : (double)row[2];
            set => row[2] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime2
        {
            get => row[2] == DBNull.Value ? null : (DateTime)row[2];
            set => row[2] = value is null ? DBNull.Value : value;
        }
        public int? Int3
        {
            get => row[3] == DBNull.Value ? null : (int)row[3];
            set => row[3] = value is null ? DBNull.Value : value;
        }
        public string? String3
        {
            get => row[3] == DBNull.Value ? null : (string)row[3];
            set => row[3] = value is null ? DBNull.Value : value;
        }
        public double? Double3
        {
            get => row[3] == DBNull.Value ? null : (double)row[3];
            set => row[3] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime3
        {
            get => row[3] == DBNull.Value ? null : (DateTime)row[3];
            set => row[3] = value is null ? DBNull.Value : value;
        }
        public int? Int4
        {
            get => row[4] == DBNull.Value ? null : (int)row[4];
            set => row[4] = value is null ? DBNull.Value : value;
        }
        public string? String4
        {
            get => row[4] == DBNull.Value ? null : (string)row[4];
            set => row[4] = value is null ? DBNull.Value : value;
        }
        public double? Double4
        {
            get => row[4] == DBNull.Value ? null : (double)row[4];
            set => row[4] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime4
        {
            get => row[4] == DBNull.Value ? null : (DateTime)row[4];
            set => row[4] = value is null ? DBNull.Value : value;
        }
        public int? Int5
        {
            get => row[5] == DBNull.Value ? null : (int)row[5];
            set => row[5] = value is null ? DBNull.Value : value;
        }
        public string? String5
        {
            get => row[5] == DBNull.Value ? null : (string)row[5];
            set => row[5] = value is null ? DBNull.Value : value;
        }
        public double? Double5
        {
            get => row[5] == DBNull.Value ? null : (double)row[5];
            set => row[5] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime5
        {
            get => row[5] == DBNull.Value ? null : (DateTime)row[5];
            set => row[5] = value is null ? DBNull.Value : value;
        }
        public int? Int6
        {
            get => row[6] == DBNull.Value ? null : (int)row[6];
            set => row[6] = value is null ? DBNull.Value : value;
        }
        public string? String6
        {
            get => row[6] == DBNull.Value ? null : (string)row[6];
            set => row[6] = value is null ? DBNull.Value : value;
        }
        public double? Double6
        {
            get => row[6] == DBNull.Value ? null : (double)row[6];
            set => row[6] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime6
        {
            get => row[6] == DBNull.Value ? null : (DateTime)row[6];
            set => row[6] = value is null ? DBNull.Value : value;
        }
        public int? Int7
        {
            get => row[7] == DBNull.Value ? null : (int)row[7];
            set => row[7] = value is null ? DBNull.Value : value;
        }
        public string? String7
        {
            get => row[7] == DBNull.Value ? null : (string)row[7];
            set => row[7] = value is null ? DBNull.Value : value;
        }
        public double? Double7
        {
            get => row[7] == DBNull.Value ? null : (double)row[7];
            set => row[7] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime7
        {
            get => row[7] == DBNull.Value ? null : (DateTime)row[7];
            set => row[7] = value is null ? DBNull.Value : value;
        }
        public int? Int8
        {
            get => row[8] == DBNull.Value ? null : (int)row[8];
            set => row[8] = value is null ? DBNull.Value : value;
        }
        public string? String8
        {
            get => row[8] == DBNull.Value ? null : (string)row[8];
            set => row[8] = value is null ? DBNull.Value : value;
        }
        public double? Double8
        {
            get => row[8] == DBNull.Value ? null : (double)row[8];
            set => row[8] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime8
        {
            get => row[8] == DBNull.Value ? null : (DateTime)row[8];
            set => row[8] = value is null ? DBNull.Value : value;
        }
        public int? Int9
        {
            get => row[9] == DBNull.Value ? null : (int)row[9];
            set => row[9] = value is null ? DBNull.Value : value;
        }
        public string? String9
        {
            get => row[9] == DBNull.Value ? null : (string)row[9];
            set => row[9] = value is null ? DBNull.Value : value;
        }
        public double? Double9
        {
            get => row[9] == DBNull.Value ? null : (double)row[9];
            set => row[9] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime9
        {
            get => row[9] == DBNull.Value ? null : (DateTime)row[9];
            set => row[9] = value is null ? DBNull.Value : value;
        }
        public int? Int10
        {
            get => row[10] == DBNull.Value ? null : (int)row[10];
            set => row[10] = value is null ? DBNull.Value : value;
        }
        public string? String10
        {
            get => row[10] == DBNull.Value ? null : (string)row[10];
            set => row[10] = value is null ? DBNull.Value : value;
        }
        public double? Double10
        {
            get => row[10] == DBNull.Value ? null : (double)row[10];
            set => row[10] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime10
        {
            get => row[10] == DBNull.Value ? null : (DateTime)row[10];
            set => row[10] = value is null ? DBNull.Value : value;
        }
        public int? Int11
        {
            get => row[11] == DBNull.Value ? null : (int)row[11];
            set => row[11] = value is null ? DBNull.Value : value;
        }
        public string? String11
        {
            get => row[11] == DBNull.Value ? null : (string)row[11];
            set => row[11] = value is null ? DBNull.Value : value;
        }
        public double? Double11
        {
            get => row[11] == DBNull.Value ? null : (double)row[11];
            set => row[11] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime11
        {
            get => row[11] == DBNull.Value ? null : (DateTime)row[11];
            set => row[11] = value is null ? DBNull.Value : value;
        }
        public int? Int12
        {
            get => row[12] == DBNull.Value ? null : (int)row[12];
            set => row[12] = value is null ? DBNull.Value : value;
        }
        public string? String12
        {
            get => row[12] == DBNull.Value ? null : (string)row[12];
            set => row[12] = value is null ? DBNull.Value : value;
        }
        public double? Double12
        {
            get => row[12] == DBNull.Value ? null : (double)row[12];
            set => row[12] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime12
        {
            get => row[12] == DBNull.Value ? null : (DateTime)row[12];
            set => row[12] = value is null ? DBNull.Value : value;
        }
        public int? Int13
        {
            get => row[13] == DBNull.Value ? null : (int)row[13];
            set => row[13] = value is null ? DBNull.Value : value;
        }
        public string? String13
        {
            get => row[13] == DBNull.Value ? null : (string)row[13];
            set => row[13] = value is null ? DBNull.Value : value;
        }
        public double? Double13
        {
            get => row[13] == DBNull.Value ? null : (double)row[13];
            set => row[13] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime13
        {
            get => row[13] == DBNull.Value ? null : (DateTime)row[13];
            set => row[13] = value is null ? DBNull.Value : value;
        }
        public int? Int14
        {
            get => row[14] == DBNull.Value ? null : (int)row[14];
            set => row[14] = value is null ? DBNull.Value : value;
        }
        public string? String14
        {
            get => row[14] == DBNull.Value ? null : (string)row[14];
            set => row[14] = value is null ? DBNull.Value : value;
        }
        public double? Double14
        {
            get => row[14] == DBNull.Value ? null : (double)row[14];
            set => row[14] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime14
        {
            get => row[14] == DBNull.Value ? null : (DateTime)row[14];
            set => row[14] = value is null ? DBNull.Value : value;
        }
        public int? Int15
        {
            get => row[15] == DBNull.Value ? null : (int)row[15];
            set => row[15] = value is null ? DBNull.Value : value;
        }
        public string? String15
        {
            get => row[15] == DBNull.Value ? null : (string)row[15];
            set => row[15] = value is null ? DBNull.Value : value;
        }
        public double? Double15
        {
            get => row[15] == DBNull.Value ? null : (double)row[15];
            set => row[15] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime15
        {
            get => row[15] == DBNull.Value ? null : (DateTime)row[15];
            set => row[15] = value is null ? DBNull.Value : value;
        }
        public int? Int16
        {
            get => row[16] == DBNull.Value ? null : (int)row[16];
            set => row[16] = value is null ? DBNull.Value : value;
        }
        public string? String16
        {
            get => row[16] == DBNull.Value ? null : (string)row[16];
            set => row[16] = value is null ? DBNull.Value : value;
        }
        public double? Double16
        {
            get => row[16] == DBNull.Value ? null : (double)row[16];
            set => row[16] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime16
        {
            get => row[16] == DBNull.Value ? null : (DateTime)row[16];
            set => row[16] = value is null ? DBNull.Value : value;
        }
        public int? Int17
        {
            get => row[17] == DBNull.Value ? null : (int)row[17];
            set => row[17] = value is null ? DBNull.Value : value;
        }
        public string? String17
        {
            get => row[17] == DBNull.Value ? null : (string)row[17];
            set => row[17] = value is null ? DBNull.Value : value;
        }
        public double? Double17
        {
            get => row[17] == DBNull.Value ? null : (double)row[17];
            set => row[17] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime17
        {
            get => row[17] == DBNull.Value ? null : (DateTime)row[17];
            set => row[17] = value is null ? DBNull.Value : value;
        }
        public int? Int18
        {
            get => row[18] == DBNull.Value ? null : (int)row[18];
            set => row[18] = value is null ? DBNull.Value : value;
        }
        public string? String18
        {
            get => row[18] == DBNull.Value ? null : (string)row[18];
            set => row[18] = value is null ? DBNull.Value : value;
        }
        public double? Double18
        {
            get => row[18] == DBNull.Value ? null : (double)row[18];
            set => row[18] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime18
        {
            get => row[18] == DBNull.Value ? null : (DateTime)row[18];
            set => row[18] = value is null ? DBNull.Value : value;
        }
        public int? Int19
        {
            get => row[19] == DBNull.Value ? null : (int)row[19];
            set => row[19] = value is null ? DBNull.Value : value;
        }
        public string? String19
        {
            get => row[19] == DBNull.Value ? null : (string)row[19];
            set => row[19] = value is null ? DBNull.Value : value;
        }
        public double? Double19
        {
            get => row[19] == DBNull.Value ? null : (double)row[19];
            set => row[19] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime19
        {
            get => row[19] == DBNull.Value ? null : (DateTime)row[19];
            set => row[19] = value is null ? DBNull.Value : value;
        }
        public int? Int20
        {
            get => row[20] == DBNull.Value ? null : (int)row[20];
            set => row[20] = value is null ? DBNull.Value : value;
        }
        public string? String20
        {
            get => row[20] == DBNull.Value ? null : (string)row[20];
            set => row[20] = value is null ? DBNull.Value : value;
        }
        public double? Double20
        {
            get => row[20] == DBNull.Value ? null : (double)row[20];
            set => row[20] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime20
        {
            get => row[20] == DBNull.Value ? null : (DateTime)row[20];
            set => row[20] = value is null ? DBNull.Value : value;
        }
        public int? Int21
        {
            get => row[21] == DBNull.Value ? null : (int)row[21];
            set => row[21] = value is null ? DBNull.Value : value;
        }
        public string? String21
        {
            get => row[21] == DBNull.Value ? null : (string)row[21];
            set => row[21] = value is null ? DBNull.Value : value;
        }
        public double? Double21
        {
            get => row[21] == DBNull.Value ? null : (double)row[21];
            set => row[21] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime21
        {
            get => row[21] == DBNull.Value ? null : (DateTime)row[21];
            set => row[21] = value is null ? DBNull.Value : value;
        }
        public int? Int22
        {
            get => row[22] == DBNull.Value ? null : (int)row[22];
            set => row[22] = value is null ? DBNull.Value : value;
        }
        public string? String22
        {
            get => row[22] == DBNull.Value ? null : (string)row[22];
            set => row[22] = value is null ? DBNull.Value : value;
        }
        public double? Double22
        {
            get => row[22] == DBNull.Value ? null : (double)row[22];
            set => row[22] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime22
        {
            get => row[22] == DBNull.Value ? null : (DateTime)row[22];
            set => row[22] = value is null ? DBNull.Value : value;
        }
        public int? Int23
        {
            get => row[23] == DBNull.Value ? null : (int)row[23];
            set => row[23] = value is null ? DBNull.Value : value;
        }
        public string? String23
        {
            get => row[23] == DBNull.Value ? null : (string)row[23];
            set => row[23] = value is null ? DBNull.Value : value;
        }
        public double? Double23
        {
            get => row[23] == DBNull.Value ? null : (double)row[23];
            set => row[23] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime23
        {
            get => row[23] == DBNull.Value ? null : (DateTime)row[23];
            set => row[23] = value is null ? DBNull.Value : value;
        }
        public int? Int24
        {
            get => row[24] == DBNull.Value ? null : (int)row[24];
            set => row[24] = value is null ? DBNull.Value : value;
        }
        public string? String24
        {
            get => row[24] == DBNull.Value ? null : (string)row[24];
            set => row[24] = value is null ? DBNull.Value : value;
        }
        public double? Double24
        {
            get => row[24] == DBNull.Value ? null : (double)row[24];
            set => row[24] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime24
        {
            get => row[24] == DBNull.Value ? null : (DateTime)row[24];
            set => row[24] = value is null ? DBNull.Value : value;
        }
        public int? Int25
        {
            get => row[25] == DBNull.Value ? null : (int)row[25];
            set => row[25] = value is null ? DBNull.Value : value;
        }
        public string? String25
        {
            get => row[25] == DBNull.Value ? null : (string)row[25];
            set => row[25] = value is null ? DBNull.Value : value;
        }
        public double? Double25
        {
            get => row[25] == DBNull.Value ? null : (double)row[25];
            set => row[25] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime25
        {
            get => row[25] == DBNull.Value ? null : (DateTime)row[25];
            set => row[25] = value is null ? DBNull.Value : value;
        }
        public int? Int26
        {
            get => row[26] == DBNull.Value ? null : (int)row[26];
            set => row[26] = value is null ? DBNull.Value : value;
        }
        public string? String26
        {
            get => row[26] == DBNull.Value ? null : (string)row[26];
            set => row[26] = value is null ? DBNull.Value : value;
        }
        public double? Double26
        {
            get => row[26] == DBNull.Value ? null : (double)row[26];
            set => row[26] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime26
        {
            get => row[26] == DBNull.Value ? null : (DateTime)row[26];
            set => row[26] = value is null ? DBNull.Value : value;
        }
        public int? Int27
        {
            get => row[27] == DBNull.Value ? null : (int)row[27];
            set => row[27] = value is null ? DBNull.Value : value;
        }
        public string? String27
        {
            get => row[27] == DBNull.Value ? null : (string)row[27];
            set => row[27] = value is null ? DBNull.Value : value;
        }
        public double? Double27
        {
            get => row[27] == DBNull.Value ? null : (double)row[27];
            set => row[27] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime27
        {
            get => row[27] == DBNull.Value ? null : (DateTime)row[27];
            set => row[27] = value is null ? DBNull.Value : value;
        }
        public int? Int28
        {
            get => row[28] == DBNull.Value ? null : (int)row[28];
            set => row[28] = value is null ? DBNull.Value : value;
        }
        public string? String28
        {
            get => row[28] == DBNull.Value ? null : (string)row[28];
            set => row[28] = value is null ? DBNull.Value : value;
        }
        public double? Double28
        {
            get => row[28] == DBNull.Value ? null : (double)row[28];
            set => row[28] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime28
        {
            get => row[28] == DBNull.Value ? null : (DateTime)row[28];
            set => row[28] = value is null ? DBNull.Value : value;
        }
        public int? Int29
        {
            get => row[29] == DBNull.Value ? null : (int)row[29];
            set => row[29] = value is null ? DBNull.Value : value;
        }
        public string? String29
        {
            get => row[29] == DBNull.Value ? null : (string)row[29];
            set => row[29] = value is null ? DBNull.Value : value;
        }
        public double? Double29
        {
            get => row[29] == DBNull.Value ? null : (double)row[29];
            set => row[29] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime29
        {
            get => row[29] == DBNull.Value ? null : (DateTime)row[29];
            set => row[29] = value is null ? DBNull.Value : value;
        }
        public int? Int30
        {
            get => row[30] == DBNull.Value ? null : (int)row[30];
            set => row[30] = value is null ? DBNull.Value : value;
        }
        public string? String30
        {
            get => row[30] == DBNull.Value ? null : (string)row[30];
            set => row[30] = value is null ? DBNull.Value : value;
        }
        public double? Double30
        {
            get => row[30] == DBNull.Value ? null : (double)row[30];
            set => row[30] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime30
        {
            get => row[30] == DBNull.Value ? null : (DateTime)row[30];
            set => row[30] = value is null ? DBNull.Value : value;
        }
        public int? Int31
        {
            get => row[31] == DBNull.Value ? null : (int)row[31];
            set => row[31] = value is null ? DBNull.Value : value;
        }
        public string? String31
        {
            get => row[31] == DBNull.Value ? null : (string)row[31];
            set => row[31] = value is null ? DBNull.Value : value;
        }
        public double? Double31
        {
            get => row[31] == DBNull.Value ? null : (double)row[31];
            set => row[31] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime31
        {
            get => row[31] == DBNull.Value ? null : (DateTime)row[31];
            set => row[31] = value is null ? DBNull.Value : value;
        }
        public int? Int32
        {
            get => row[32] == DBNull.Value ? null : (int)row[32];
            set => row[32] = value is null ? DBNull.Value : value;
        }
        public string? String32
        {
            get => row[32] == DBNull.Value ? null : (string)row[32];
            set => row[32] = value is null ? DBNull.Value : value;
        }
        public double? Double32
        {
            get => row[32] == DBNull.Value ? null : (double)row[32];
            set => row[32] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime32
        {
            get => row[32] == DBNull.Value ? null : (DateTime)row[32];
            set => row[32] = value is null ? DBNull.Value : value;
        }
        public int? Int33
        {
            get => row[33] == DBNull.Value ? null : (int)row[33];
            set => row[33] = value is null ? DBNull.Value : value;
        }
        public string? String33
        {
            get => row[33] == DBNull.Value ? null : (string)row[33];
            set => row[33] = value is null ? DBNull.Value : value;
        }
        public double? Double33
        {
            get => row[33] == DBNull.Value ? null : (double)row[33];
            set => row[33] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime33
        {
            get => row[33] == DBNull.Value ? null : (DateTime)row[33];
            set => row[33] = value is null ? DBNull.Value : value;
        }
        public int? Int34
        {
            get => row[34] == DBNull.Value ? null : (int)row[34];
            set => row[34] = value is null ? DBNull.Value : value;
        }
        public string? String34
        {
            get => row[34] == DBNull.Value ? null : (string)row[34];
            set => row[34] = value is null ? DBNull.Value : value;
        }
        public double? Double34
        {
            get => row[34] == DBNull.Value ? null : (double)row[34];
            set => row[34] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime34
        {
            get => row[34] == DBNull.Value ? null : (DateTime)row[34];
            set => row[34] = value is null ? DBNull.Value : value;
        }
        public int? Int35
        {
            get => row[35] == DBNull.Value ? null : (int)row[35];
            set => row[35] = value is null ? DBNull.Value : value;
        }
        public string? String35
        {
            get => row[35] == DBNull.Value ? null : (string)row[35];
            set => row[35] = value is null ? DBNull.Value : value;
        }
        public double? Double35
        {
            get => row[35] == DBNull.Value ? null : (double)row[35];
            set => row[35] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime35
        {
            get => row[35] == DBNull.Value ? null : (DateTime)row[35];
            set => row[35] = value is null ? DBNull.Value : value;
        }
        public int? Int36
        {
            get => row[36] == DBNull.Value ? null : (int)row[36];
            set => row[36] = value is null ? DBNull.Value : value;
        }
        public string? String36
        {
            get => row[36] == DBNull.Value ? null : (string)row[36];
            set => row[36] = value is null ? DBNull.Value : value;
        }
        public double? Double36
        {
            get => row[36] == DBNull.Value ? null : (double)row[36];
            set => row[36] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime36
        {
            get => row[36] == DBNull.Value ? null : (DateTime)row[36];
            set => row[36] = value is null ? DBNull.Value : value;
        }
        public int? Int37
        {
            get => row[37] == DBNull.Value ? null : (int)row[37];
            set => row[37] = value is null ? DBNull.Value : value;
        }
        public string? String37
        {
            get => row[37] == DBNull.Value ? null : (string)row[37];
            set => row[37] = value is null ? DBNull.Value : value;
        }
        public double? Double37
        {
            get => row[37] == DBNull.Value ? null : (double)row[37];
            set => row[37] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime37
        {
            get => row[37] == DBNull.Value ? null : (DateTime)row[37];
            set => row[37] = value is null ? DBNull.Value : value;
        }
        public int? Int38
        {
            get => row[38] == DBNull.Value ? null : (int)row[38];
            set => row[38] = value is null ? DBNull.Value : value;
        }
        public string? String38
        {
            get => row[38] == DBNull.Value ? null : (string)row[38];
            set => row[38] = value is null ? DBNull.Value : value;
        }
        public double? Double38
        {
            get => row[38] == DBNull.Value ? null : (double)row[38];
            set => row[38] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime38
        {
            get => row[38] == DBNull.Value ? null : (DateTime)row[38];
            set => row[38] = value is null ? DBNull.Value : value;
        }
        public int? Int39
        {
            get => row[39] == DBNull.Value ? null : (int)row[39];
            set => row[39] = value is null ? DBNull.Value : value;
        }
        public string? String39
        {
            get => row[39] == DBNull.Value ? null : (string)row[39];
            set => row[39] = value is null ? DBNull.Value : value;
        }
        public double? Double39
        {
            get => row[39] == DBNull.Value ? null : (double)row[39];
            set => row[39] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime39
        {
            get => row[39] == DBNull.Value ? null : (DateTime)row[39];
            set => row[39] = value is null ? DBNull.Value : value;
        }
        public int? Int40
        {
            get => row[40] == DBNull.Value ? null : (int)row[40];
            set => row[40] = value is null ? DBNull.Value : value;
        }
        public string? String40
        {
            get => row[40] == DBNull.Value ? null : (string)row[40];
            set => row[40] = value is null ? DBNull.Value : value;
        }
        public double? Double40
        {
            get => row[40] == DBNull.Value ? null : (double)row[40];
            set => row[40] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime40
        {
            get => row[40] == DBNull.Value ? null : (DateTime)row[40];
            set => row[40] = value is null ? DBNull.Value : value;
        }
        public int? Int41
        {
            get => row[41] == DBNull.Value ? null : (int)row[41];
            set => row[41] = value is null ? DBNull.Value : value;
        }
        public string? String41
        {
            get => row[41] == DBNull.Value ? null : (string)row[41];
            set => row[41] = value is null ? DBNull.Value : value;
        }
        public double? Double41
        {
            get => row[41] == DBNull.Value ? null : (double)row[41];
            set => row[41] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime41
        {
            get => row[41] == DBNull.Value ? null : (DateTime)row[41];
            set => row[41] = value is null ? DBNull.Value : value;
        }
        public int? Int42
        {
            get => row[42] == DBNull.Value ? null : (int)row[42];
            set => row[42] = value is null ? DBNull.Value : value;
        }
        public string? String42
        {
            get => row[42] == DBNull.Value ? null : (string)row[42];
            set => row[42] = value is null ? DBNull.Value : value;
        }
        public double? Double42
        {
            get => row[42] == DBNull.Value ? null : (double)row[42];
            set => row[42] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime42
        {
            get => row[42] == DBNull.Value ? null : (DateTime)row[42];
            set => row[42] = value is null ? DBNull.Value : value;
        }
        public int? Int43
        {
            get => row[43] == DBNull.Value ? null : (int)row[43];
            set => row[43] = value is null ? DBNull.Value : value;
        }
        public string? String43
        {
            get => row[43] == DBNull.Value ? null : (string)row[43];
            set => row[43] = value is null ? DBNull.Value : value;
        }
        public double? Double43
        {
            get => row[43] == DBNull.Value ? null : (double)row[43];
            set => row[43] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime43
        {
            get => row[43] == DBNull.Value ? null : (DateTime)row[43];
            set => row[43] = value is null ? DBNull.Value : value;
        }
        public int? Int44
        {
            get => row[44] == DBNull.Value ? null : (int)row[44];
            set => row[44] = value is null ? DBNull.Value : value;
        }
        public string? String44
        {
            get => row[44] == DBNull.Value ? null : (string)row[44];
            set => row[44] = value is null ? DBNull.Value : value;
        }
        public double? Double44
        {
            get => row[44] == DBNull.Value ? null : (double)row[44];
            set => row[44] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime44
        {
            get => row[44] == DBNull.Value ? null : (DateTime)row[44];
            set => row[44] = value is null ? DBNull.Value : value;
        }
        public int? Int45
        {
            get => row[45] == DBNull.Value ? null : (int)row[45];
            set => row[45] = value is null ? DBNull.Value : value;
        }
        public string? String45
        {
            get => row[45] == DBNull.Value ? null : (string)row[45];
            set => row[45] = value is null ? DBNull.Value : value;
        }
        public double? Double45
        {
            get => row[45] == DBNull.Value ? null : (double)row[45];
            set => row[45] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime45
        {
            get => row[45] == DBNull.Value ? null : (DateTime)row[45];
            set => row[45] = value is null ? DBNull.Value : value;
        }
        public int? Int46
        {
            get => row[46] == DBNull.Value ? null : (int)row[46];
            set => row[46] = value is null ? DBNull.Value : value;
        }
        public string? String46
        {
            get => row[46] == DBNull.Value ? null : (string)row[46];
            set => row[46] = value is null ? DBNull.Value : value;
        }
        public double? Double46
        {
            get => row[46] == DBNull.Value ? null : (double)row[46];
            set => row[46] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime46
        {
            get => row[46] == DBNull.Value ? null : (DateTime)row[46];
            set => row[46] = value is null ? DBNull.Value : value;
        }
        public int? Int47
        {
            get => row[47] == DBNull.Value ? null : (int)row[47];
            set => row[47] = value is null ? DBNull.Value : value;
        }
        public string? String47
        {
            get => row[47] == DBNull.Value ? null : (string)row[47];
            set => row[47] = value is null ? DBNull.Value : value;
        }
        public double? Double47
        {
            get => row[47] == DBNull.Value ? null : (double)row[47];
            set => row[47] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime47
        {
            get => row[47] == DBNull.Value ? null : (DateTime)row[47];
            set => row[47] = value is null ? DBNull.Value : value;
        }
        public int? Int48
        {
            get => row[48] == DBNull.Value ? null : (int)row[48];
            set => row[48] = value is null ? DBNull.Value : value;
        }
        public string? String48
        {
            get => row[48] == DBNull.Value ? null : (string)row[48];
            set => row[48] = value is null ? DBNull.Value : value;
        }
        public double? Double48
        {
            get => row[48] == DBNull.Value ? null : (double)row[48];
            set => row[48] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime48
        {
            get => row[48] == DBNull.Value ? null : (DateTime)row[48];
            set => row[48] = value is null ? DBNull.Value : value;
        }
        public int? Int49
        {
            get => row[49] == DBNull.Value ? null : (int)row[49];
            set => row[49] = value is null ? DBNull.Value : value;
        }
        public string? String49
        {
            get => row[49] == DBNull.Value ? null : (string)row[49];
            set => row[49] = value is null ? DBNull.Value : value;
        }
        public double? Double49
        {
            get => row[49] == DBNull.Value ? null : (double)row[49];
            set => row[49] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime49
        {
            get => row[49] == DBNull.Value ? null : (DateTime)row[49];
            set => row[49] = value is null ? DBNull.Value : value;
        }
        public int? Int50
        {
            get => row[50] == DBNull.Value ? null : (int)row[50];
            set => row[50] = value is null ? DBNull.Value : value;
        }
        public string? String50
        {
            get => row[50] == DBNull.Value ? null : (string)row[50];
            set => row[50] = value is null ? DBNull.Value : value;
        }
        public double? Double50
        {
            get => row[50] == DBNull.Value ? null : (double)row[50];
            set => row[50] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime50
        {
            get => row[50] == DBNull.Value ? null : (DateTime)row[50];
            set => row[50] = value is null ? DBNull.Value : value;
        }
        public int? Int51
        {
            get => row[51] == DBNull.Value ? null : (int)row[51];
            set => row[51] = value is null ? DBNull.Value : value;
        }
        public string? String51
        {
            get => row[51] == DBNull.Value ? null : (string)row[51];
            set => row[51] = value is null ? DBNull.Value : value;
        }
        public double? Double51
        {
            get => row[51] == DBNull.Value ? null : (double)row[51];
            set => row[51] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime51
        {
            get => row[51] == DBNull.Value ? null : (DateTime)row[51];
            set => row[51] = value is null ? DBNull.Value : value;
        }
        public int? Int52
        {
            get => row[52] == DBNull.Value ? null : (int)row[52];
            set => row[52] = value is null ? DBNull.Value : value;
        }
        public string? String52
        {
            get => row[52] == DBNull.Value ? null : (string)row[52];
            set => row[52] = value is null ? DBNull.Value : value;
        }
        public double? Double52
        {
            get => row[52] == DBNull.Value ? null : (double)row[52];
            set => row[52] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime52
        {
            get => row[52] == DBNull.Value ? null : (DateTime)row[52];
            set => row[52] = value is null ? DBNull.Value : value;
        }
        public int? Int53
        {
            get => row[53] == DBNull.Value ? null : (int)row[53];
            set => row[53] = value is null ? DBNull.Value : value;
        }
        public string? String53
        {
            get => row[53] == DBNull.Value ? null : (string)row[53];
            set => row[53] = value is null ? DBNull.Value : value;
        }
        public double? Double53
        {
            get => row[53] == DBNull.Value ? null : (double)row[53];
            set => row[53] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime53
        {
            get => row[53] == DBNull.Value ? null : (DateTime)row[53];
            set => row[53] = value is null ? DBNull.Value : value;
        }
        public int? Int54
        {
            get => row[54] == DBNull.Value ? null : (int)row[54];
            set => row[54] = value is null ? DBNull.Value : value;
        }
        public string? String54
        {
            get => row[54] == DBNull.Value ? null : (string)row[54];
            set => row[54] = value is null ? DBNull.Value : value;
        }
        public double? Double54
        {
            get => row[54] == DBNull.Value ? null : (double)row[54];
            set => row[54] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime54
        {
            get => row[54] == DBNull.Value ? null : (DateTime)row[54];
            set => row[54] = value is null ? DBNull.Value : value;
        }
        public int? Int55
        {
            get => row[55] == DBNull.Value ? null : (int)row[55];
            set => row[55] = value is null ? DBNull.Value : value;
        }
        public string? String55
        {
            get => row[55] == DBNull.Value ? null : (string)row[55];
            set => row[55] = value is null ? DBNull.Value : value;
        }
        public double? Double55
        {
            get => row[55] == DBNull.Value ? null : (double)row[55];
            set => row[55] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime55
        {
            get => row[55] == DBNull.Value ? null : (DateTime)row[55];
            set => row[55] = value is null ? DBNull.Value : value;
        }
        public int? Int56
        {
            get => row[56] == DBNull.Value ? null : (int)row[56];
            set => row[56] = value is null ? DBNull.Value : value;
        }
        public string? String56
        {
            get => row[56] == DBNull.Value ? null : (string)row[56];
            set => row[56] = value is null ? DBNull.Value : value;
        }
        public double? Double56
        {
            get => row[56] == DBNull.Value ? null : (double)row[56];
            set => row[56] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime56
        {
            get => row[56] == DBNull.Value ? null : (DateTime)row[56];
            set => row[56] = value is null ? DBNull.Value : value;
        }
        public int? Int57
        {
            get => row[57] == DBNull.Value ? null : (int)row[57];
            set => row[57] = value is null ? DBNull.Value : value;
        }
        public string? String57
        {
            get => row[57] == DBNull.Value ? null : (string)row[57];
            set => row[57] = value is null ? DBNull.Value : value;
        }
        public double? Double57
        {
            get => row[57] == DBNull.Value ? null : (double)row[57];
            set => row[57] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime57
        {
            get => row[57] == DBNull.Value ? null : (DateTime)row[57];
            set => row[57] = value is null ? DBNull.Value : value;
        }
        public int? Int58
        {
            get => row[58] == DBNull.Value ? null : (int)row[58];
            set => row[58] = value is null ? DBNull.Value : value;
        }
        public string? String58
        {
            get => row[58] == DBNull.Value ? null : (string)row[58];
            set => row[58] = value is null ? DBNull.Value : value;
        }
        public double? Double58
        {
            get => row[58] == DBNull.Value ? null : (double)row[58];
            set => row[58] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime58
        {
            get => row[58] == DBNull.Value ? null : (DateTime)row[58];
            set => row[58] = value is null ? DBNull.Value : value;
        }
        public int? Int59
        {
            get => row[59] == DBNull.Value ? null : (int)row[59];
            set => row[59] = value is null ? DBNull.Value : value;
        }
        public string? String59
        {
            get => row[59] == DBNull.Value ? null : (string)row[59];
            set => row[59] = value is null ? DBNull.Value : value;
        }
        public double? Double59
        {
            get => row[59] == DBNull.Value ? null : (double)row[59];
            set => row[59] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime59
        {
            get => row[59] == DBNull.Value ? null : (DateTime)row[59];
            set => row[59] = value is null ? DBNull.Value : value;
        }
        public int? Int60
        {
            get => row[60] == DBNull.Value ? null : (int)row[60];
            set => row[60] = value is null ? DBNull.Value : value;
        }
        public string? String60
        {
            get => row[60] == DBNull.Value ? null : (string)row[60];
            set => row[60] = value is null ? DBNull.Value : value;
        }
        public double? Double60
        {
            get => row[60] == DBNull.Value ? null : (double)row[60];
            set => row[60] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime60
        {
            get => row[60] == DBNull.Value ? null : (DateTime)row[60];
            set => row[60] = value is null ? DBNull.Value : value;
        }
        public int? Int61
        {
            get => row[61] == DBNull.Value ? null : (int)row[61];
            set => row[61] = value is null ? DBNull.Value : value;
        }
        public string? String61
        {
            get => row[61] == DBNull.Value ? null : (string)row[61];
            set => row[61] = value is null ? DBNull.Value : value;
        }
        public double? Double61
        {
            get => row[61] == DBNull.Value ? null : (double)row[61];
            set => row[61] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime61
        {
            get => row[61] == DBNull.Value ? null : (DateTime)row[61];
            set => row[61] = value is null ? DBNull.Value : value;
        }
        public int? Int62
        {
            get => row[62] == DBNull.Value ? null : (int)row[62];
            set => row[62] = value is null ? DBNull.Value : value;
        }
        public string? String62
        {
            get => row[62] == DBNull.Value ? null : (string)row[62];
            set => row[62] = value is null ? DBNull.Value : value;
        }
        public double? Double62
        {
            get => row[62] == DBNull.Value ? null : (double)row[62];
            set => row[62] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime62
        {
            get => row[62] == DBNull.Value ? null : (DateTime)row[62];
            set => row[62] = value is null ? DBNull.Value : value;
        }
        public int? Int63
        {
            get => row[63] == DBNull.Value ? null : (int)row[63];
            set => row[63] = value is null ? DBNull.Value : value;
        }
        public string? String63
        {
            get => row[63] == DBNull.Value ? null : (string)row[63];
            set => row[63] = value is null ? DBNull.Value : value;
        }
        public double? Double63
        {
            get => row[63] == DBNull.Value ? null : (double)row[63];
            set => row[63] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime63
        {
            get => row[63] == DBNull.Value ? null : (DateTime)row[63];
            set => row[63] = value is null ? DBNull.Value : value;
        }
        public int? Int64
        {
            get => row[64] == DBNull.Value ? null : (int)row[64];
            set => row[64] = value is null ? DBNull.Value : value;
        }
        public string? String64
        {
            get => row[64] == DBNull.Value ? null : (string)row[64];
            set => row[64] = value is null ? DBNull.Value : value;
        }
        public double? Double64
        {
            get => row[64] == DBNull.Value ? null : (double)row[64];
            set => row[64] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime64
        {
            get => row[64] == DBNull.Value ? null : (DateTime)row[64];
            set => row[64] = value is null ? DBNull.Value : value;
        }
        public int? Int65
        {
            get => row[65] == DBNull.Value ? null : (int)row[65];
            set => row[65] = value is null ? DBNull.Value : value;
        }
        public string? String65
        {
            get => row[65] == DBNull.Value ? null : (string)row[65];
            set => row[65] = value is null ? DBNull.Value : value;
        }
        public double? Double65
        {
            get => row[65] == DBNull.Value ? null : (double)row[65];
            set => row[65] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime65
        {
            get => row[65] == DBNull.Value ? null : (DateTime)row[65];
            set => row[65] = value is null ? DBNull.Value : value;
        }
        public int? Int66
        {
            get => row[66] == DBNull.Value ? null : (int)row[66];
            set => row[66] = value is null ? DBNull.Value : value;
        }
        public string? String66
        {
            get => row[66] == DBNull.Value ? null : (string)row[66];
            set => row[66] = value is null ? DBNull.Value : value;
        }
        public double? Double66
        {
            get => row[66] == DBNull.Value ? null : (double)row[66];
            set => row[66] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime66
        {
            get => row[66] == DBNull.Value ? null : (DateTime)row[66];
            set => row[66] = value is null ? DBNull.Value : value;
        }
        public int? Int67
        {
            get => row[67] == DBNull.Value ? null : (int)row[67];
            set => row[67] = value is null ? DBNull.Value : value;
        }
        public string? String67
        {
            get => row[67] == DBNull.Value ? null : (string)row[67];
            set => row[67] = value is null ? DBNull.Value : value;
        }
        public double? Double67
        {
            get => row[67] == DBNull.Value ? null : (double)row[67];
            set => row[67] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime67
        {
            get => row[67] == DBNull.Value ? null : (DateTime)row[67];
            set => row[67] = value is null ? DBNull.Value : value;
        }
        public int? Int68
        {
            get => row[68] == DBNull.Value ? null : (int)row[68];
            set => row[68] = value is null ? DBNull.Value : value;
        }
        public string? String68
        {
            get => row[68] == DBNull.Value ? null : (string)row[68];
            set => row[68] = value is null ? DBNull.Value : value;
        }
        public double? Double68
        {
            get => row[68] == DBNull.Value ? null : (double)row[68];
            set => row[68] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime68
        {
            get => row[68] == DBNull.Value ? null : (DateTime)row[68];
            set => row[68] = value is null ? DBNull.Value : value;
        }
        public int? Int69
        {
            get => row[69] == DBNull.Value ? null : (int)row[69];
            set => row[69] = value is null ? DBNull.Value : value;
        }
        public string? String69
        {
            get => row[69] == DBNull.Value ? null : (string)row[69];
            set => row[69] = value is null ? DBNull.Value : value;
        }
        public double? Double69
        {
            get => row[69] == DBNull.Value ? null : (double)row[69];
            set => row[69] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime69
        {
            get => row[69] == DBNull.Value ? null : (DateTime)row[69];
            set => row[69] = value is null ? DBNull.Value : value;
        }
        public int? Int70
        {
            get => row[70] == DBNull.Value ? null : (int)row[70];
            set => row[70] = value is null ? DBNull.Value : value;
        }
        public string? String70
        {
            get => row[70] == DBNull.Value ? null : (string)row[70];
            set => row[70] = value is null ? DBNull.Value : value;
        }
        public double? Double70
        {
            get => row[70] == DBNull.Value ? null : (double)row[70];
            set => row[70] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime70
        {
            get => row[70] == DBNull.Value ? null : (DateTime)row[70];
            set => row[70] = value is null ? DBNull.Value : value;
        }
        public int? Int71
        {
            get => row[71] == DBNull.Value ? null : (int)row[71];
            set => row[71] = value is null ? DBNull.Value : value;
        }
        public string? String71
        {
            get => row[71] == DBNull.Value ? null : (string)row[71];
            set => row[71] = value is null ? DBNull.Value : value;
        }
        public double? Double71
        {
            get => row[71] == DBNull.Value ? null : (double)row[71];
            set => row[71] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime71
        {
            get => row[71] == DBNull.Value ? null : (DateTime)row[71];
            set => row[71] = value is null ? DBNull.Value : value;
        }
        public int? Int72
        {
            get => row[72] == DBNull.Value ? null : (int)row[72];
            set => row[72] = value is null ? DBNull.Value : value;
        }
        public string? String72
        {
            get => row[72] == DBNull.Value ? null : (string)row[72];
            set => row[72] = value is null ? DBNull.Value : value;
        }
        public double? Double72
        {
            get => row[72] == DBNull.Value ? null : (double)row[72];
            set => row[72] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime72
        {
            get => row[72] == DBNull.Value ? null : (DateTime)row[72];
            set => row[72] = value is null ? DBNull.Value : value;
        }
        public int? Int73
        {
            get => row[73] == DBNull.Value ? null : (int)row[73];
            set => row[73] = value is null ? DBNull.Value : value;
        }
        public string? String73
        {
            get => row[73] == DBNull.Value ? null : (string)row[73];
            set => row[73] = value is null ? DBNull.Value : value;
        }
        public double? Double73
        {
            get => row[73] == DBNull.Value ? null : (double)row[73];
            set => row[73] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime73
        {
            get => row[73] == DBNull.Value ? null : (DateTime)row[73];
            set => row[73] = value is null ? DBNull.Value : value;
        }
        public int? Int74
        {
            get => row[74] == DBNull.Value ? null : (int)row[74];
            set => row[74] = value is null ? DBNull.Value : value;
        }
        public string? String74
        {
            get => row[74] == DBNull.Value ? null : (string)row[74];
            set => row[74] = value is null ? DBNull.Value : value;
        }
        public double? Double74
        {
            get => row[74] == DBNull.Value ? null : (double)row[74];
            set => row[74] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime74
        {
            get => row[74] == DBNull.Value ? null : (DateTime)row[74];
            set => row[74] = value is null ? DBNull.Value : value;
        }
        public int? Int75
        {
            get => row[75] == DBNull.Value ? null : (int)row[75];
            set => row[75] = value is null ? DBNull.Value : value;
        }
        public string? String75
        {
            get => row[75] == DBNull.Value ? null : (string)row[75];
            set => row[75] = value is null ? DBNull.Value : value;
        }
        public double? Double75
        {
            get => row[75] == DBNull.Value ? null : (double)row[75];
            set => row[75] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime75
        {
            get => row[75] == DBNull.Value ? null : (DateTime)row[75];
            set => row[75] = value is null ? DBNull.Value : value;
        }
        public int? Int76
        {
            get => row[76] == DBNull.Value ? null : (int)row[76];
            set => row[76] = value is null ? DBNull.Value : value;
        }
        public string? String76
        {
            get => row[76] == DBNull.Value ? null : (string)row[76];
            set => row[76] = value is null ? DBNull.Value : value;
        }
        public double? Double76
        {
            get => row[76] == DBNull.Value ? null : (double)row[76];
            set => row[76] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime76
        {
            get => row[76] == DBNull.Value ? null : (DateTime)row[76];
            set => row[76] = value is null ? DBNull.Value : value;
        }
        public int? Int77
        {
            get => row[77] == DBNull.Value ? null : (int)row[77];
            set => row[77] = value is null ? DBNull.Value : value;
        }
        public string? String77
        {
            get => row[77] == DBNull.Value ? null : (string)row[77];
            set => row[77] = value is null ? DBNull.Value : value;
        }
        public double? Double77
        {
            get => row[77] == DBNull.Value ? null : (double)row[77];
            set => row[77] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime77
        {
            get => row[77] == DBNull.Value ? null : (DateTime)row[77];
            set => row[77] = value is null ? DBNull.Value : value;
        }
        public int? Int78
        {
            get => row[78] == DBNull.Value ? null : (int)row[78];
            set => row[78] = value is null ? DBNull.Value : value;
        }
        public string? String78
        {
            get => row[78] == DBNull.Value ? null : (string)row[78];
            set => row[78] = value is null ? DBNull.Value : value;
        }
        public double? Double78
        {
            get => row[78] == DBNull.Value ? null : (double)row[78];
            set => row[78] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime78
        {
            get => row[78] == DBNull.Value ? null : (DateTime)row[78];
            set => row[78] = value is null ? DBNull.Value : value;
        }
        public int? Int79
        {
            get => row[79] == DBNull.Value ? null : (int)row[79];
            set => row[79] = value is null ? DBNull.Value : value;
        }
        public string? String79
        {
            get => row[79] == DBNull.Value ? null : (string)row[79];
            set => row[79] = value is null ? DBNull.Value : value;
        }
        public double? Double79
        {
            get => row[79] == DBNull.Value ? null : (double)row[79];
            set => row[79] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime79
        {
            get => row[79] == DBNull.Value ? null : (DateTime)row[79];
            set => row[79] = value is null ? DBNull.Value : value;
        }
        public int? Int80
        {
            get => row[80] == DBNull.Value ? null : (int)row[80];
            set => row[80] = value is null ? DBNull.Value : value;
        }
        public string? String80
        {
            get => row[80] == DBNull.Value ? null : (string)row[80];
            set => row[80] = value is null ? DBNull.Value : value;
        }
        public double? Double80
        {
            get => row[80] == DBNull.Value ? null : (double)row[80];
            set => row[80] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime80
        {
            get => row[80] == DBNull.Value ? null : (DateTime)row[80];
            set => row[80] = value is null ? DBNull.Value : value;
        }
        public int? Int81
        {
            get => row[81] == DBNull.Value ? null : (int)row[81];
            set => row[81] = value is null ? DBNull.Value : value;
        }
        public string? String81
        {
            get => row[81] == DBNull.Value ? null : (string)row[81];
            set => row[81] = value is null ? DBNull.Value : value;
        }
        public double? Double81
        {
            get => row[81] == DBNull.Value ? null : (double)row[81];
            set => row[81] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime81
        {
            get => row[81] == DBNull.Value ? null : (DateTime)row[81];
            set => row[81] = value is null ? DBNull.Value : value;
        }
        public int? Int82
        {
            get => row[82] == DBNull.Value ? null : (int)row[82];
            set => row[82] = value is null ? DBNull.Value : value;
        }
        public string? String82
        {
            get => row[82] == DBNull.Value ? null : (string)row[82];
            set => row[82] = value is null ? DBNull.Value : value;
        }
        public double? Double82
        {
            get => row[82] == DBNull.Value ? null : (double)row[82];
            set => row[82] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime82
        {
            get => row[82] == DBNull.Value ? null : (DateTime)row[82];
            set => row[82] = value is null ? DBNull.Value : value;
        }
        public int? Int83
        {
            get => row[83] == DBNull.Value ? null : (int)row[83];
            set => row[83] = value is null ? DBNull.Value : value;
        }
        public string? String83
        {
            get => row[83] == DBNull.Value ? null : (string)row[83];
            set => row[83] = value is null ? DBNull.Value : value;
        }
        public double? Double83
        {
            get => row[83] == DBNull.Value ? null : (double)row[83];
            set => row[83] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime83
        {
            get => row[83] == DBNull.Value ? null : (DateTime)row[83];
            set => row[83] = value is null ? DBNull.Value : value;
        }
        public int? Int84
        {
            get => row[84] == DBNull.Value ? null : (int)row[84];
            set => row[84] = value is null ? DBNull.Value : value;
        }
        public string? String84
        {
            get => row[84] == DBNull.Value ? null : (string)row[84];
            set => row[84] = value is null ? DBNull.Value : value;
        }
        public double? Double84
        {
            get => row[84] == DBNull.Value ? null : (double)row[84];
            set => row[84] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime84
        {
            get => row[84] == DBNull.Value ? null : (DateTime)row[84];
            set => row[84] = value is null ? DBNull.Value : value;
        }
        public int? Int85
        {
            get => row[85] == DBNull.Value ? null : (int)row[85];
            set => row[85] = value is null ? DBNull.Value : value;
        }
        public string? String85
        {
            get => row[85] == DBNull.Value ? null : (string)row[85];
            set => row[85] = value is null ? DBNull.Value : value;
        }
        public double? Double85
        {
            get => row[85] == DBNull.Value ? null : (double)row[85];
            set => row[85] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime85
        {
            get => row[85] == DBNull.Value ? null : (DateTime)row[85];
            set => row[85] = value is null ? DBNull.Value : value;
        }
        public int? Int86
        {
            get => row[86] == DBNull.Value ? null : (int)row[86];
            set => row[86] = value is null ? DBNull.Value : value;
        }
        public string? String86
        {
            get => row[86] == DBNull.Value ? null : (string)row[86];
            set => row[86] = value is null ? DBNull.Value : value;
        }
        public double? Double86
        {
            get => row[86] == DBNull.Value ? null : (double)row[86];
            set => row[86] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime86
        {
            get => row[86] == DBNull.Value ? null : (DateTime)row[86];
            set => row[86] = value is null ? DBNull.Value : value;
        }
        public int? Int87
        {
            get => row[87] == DBNull.Value ? null : (int)row[87];
            set => row[87] = value is null ? DBNull.Value : value;
        }
        public string? String87
        {
            get => row[87] == DBNull.Value ? null : (string)row[87];
            set => row[87] = value is null ? DBNull.Value : value;
        }
        public double? Double87
        {
            get => row[87] == DBNull.Value ? null : (double)row[87];
            set => row[87] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime87
        {
            get => row[87] == DBNull.Value ? null : (DateTime)row[87];
            set => row[87] = value is null ? DBNull.Value : value;
        }
        public int? Int88
        {
            get => row[88] == DBNull.Value ? null : (int)row[88];
            set => row[88] = value is null ? DBNull.Value : value;
        }
        public string? String88
        {
            get => row[88] == DBNull.Value ? null : (string)row[88];
            set => row[88] = value is null ? DBNull.Value : value;
        }
        public double? Double88
        {
            get => row[88] == DBNull.Value ? null : (double)row[88];
            set => row[88] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime88
        {
            get => row[88] == DBNull.Value ? null : (DateTime)row[88];
            set => row[88] = value is null ? DBNull.Value : value;
        }
        public int? Int89
        {
            get => row[89] == DBNull.Value ? null : (int)row[89];
            set => row[89] = value is null ? DBNull.Value : value;
        }
        public string? String89
        {
            get => row[89] == DBNull.Value ? null : (string)row[89];
            set => row[89] = value is null ? DBNull.Value : value;
        }
        public double? Double89
        {
            get => row[89] == DBNull.Value ? null : (double)row[89];
            set => row[89] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime89
        {
            get => row[89] == DBNull.Value ? null : (DateTime)row[89];
            set => row[89] = value is null ? DBNull.Value : value;
        }
        public int? Int90
        {
            get => row[90] == DBNull.Value ? null : (int)row[90];
            set => row[90] = value is null ? DBNull.Value : value;
        }
        public string? String90
        {
            get => row[90] == DBNull.Value ? null : (string)row[90];
            set => row[90] = value is null ? DBNull.Value : value;
        }
        public double? Double90
        {
            get => row[90] == DBNull.Value ? null : (double)row[90];
            set => row[90] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime90
        {
            get => row[90] == DBNull.Value ? null : (DateTime)row[90];
            set => row[90] = value is null ? DBNull.Value : value;
        }
        public int? Int91
        {
            get => row[91] == DBNull.Value ? null : (int)row[91];
            set => row[91] = value is null ? DBNull.Value : value;
        }
        public string? String91
        {
            get => row[91] == DBNull.Value ? null : (string)row[91];
            set => row[91] = value is null ? DBNull.Value : value;
        }
        public double? Double91
        {
            get => row[91] == DBNull.Value ? null : (double)row[91];
            set => row[91] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime91
        {
            get => row[91] == DBNull.Value ? null : (DateTime)row[91];
            set => row[91] = value is null ? DBNull.Value : value;
        }
        public int? Int92
        {
            get => row[92] == DBNull.Value ? null : (int)row[92];
            set => row[92] = value is null ? DBNull.Value : value;
        }
        public string? String92
        {
            get => row[92] == DBNull.Value ? null : (string)row[92];
            set => row[92] = value is null ? DBNull.Value : value;
        }
        public double? Double92
        {
            get => row[92] == DBNull.Value ? null : (double)row[92];
            set => row[92] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime92
        {
            get => row[92] == DBNull.Value ? null : (DateTime)row[92];
            set => row[92] = value is null ? DBNull.Value : value;
        }
        public int? Int93
        {
            get => row[93] == DBNull.Value ? null : (int)row[93];
            set => row[93] = value is null ? DBNull.Value : value;
        }
        public string? String93
        {
            get => row[93] == DBNull.Value ? null : (string)row[93];
            set => row[93] = value is null ? DBNull.Value : value;
        }
        public double? Double93
        {
            get => row[93] == DBNull.Value ? null : (double)row[93];
            set => row[93] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime93
        {
            get => row[93] == DBNull.Value ? null : (DateTime)row[93];
            set => row[93] = value is null ? DBNull.Value : value;
        }
        public int? Int94
        {
            get => row[94] == DBNull.Value ? null : (int)row[94];
            set => row[94] = value is null ? DBNull.Value : value;
        }
        public string? String94
        {
            get => row[94] == DBNull.Value ? null : (string)row[94];
            set => row[94] = value is null ? DBNull.Value : value;
        }
        public double? Double94
        {
            get => row[94] == DBNull.Value ? null : (double)row[94];
            set => row[94] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime94
        {
            get => row[94] == DBNull.Value ? null : (DateTime)row[94];
            set => row[94] = value is null ? DBNull.Value : value;
        }
        public int? Int95
        {
            get => row[95] == DBNull.Value ? null : (int)row[95];
            set => row[95] = value is null ? DBNull.Value : value;
        }
        public string? String95
        {
            get => row[95] == DBNull.Value ? null : (string)row[95];
            set => row[95] = value is null ? DBNull.Value : value;
        }
        public double? Double95
        {
            get => row[95] == DBNull.Value ? null : (double)row[95];
            set => row[95] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime95
        {
            get => row[95] == DBNull.Value ? null : (DateTime)row[95];
            set => row[95] = value is null ? DBNull.Value : value;
        }
        public int? Int96
        {
            get => row[96] == DBNull.Value ? null : (int)row[96];
            set => row[96] = value is null ? DBNull.Value : value;
        }
        public string? String96
        {
            get => row[96] == DBNull.Value ? null : (string)row[96];
            set => row[96] = value is null ? DBNull.Value : value;
        }
        public double? Double96
        {
            get => row[96] == DBNull.Value ? null : (double)row[96];
            set => row[96] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime96
        {
            get => row[96] == DBNull.Value ? null : (DateTime)row[96];
            set => row[96] = value is null ? DBNull.Value : value;
        }
        public int? Int97
        {
            get => row[97] == DBNull.Value ? null : (int)row[97];
            set => row[97] = value is null ? DBNull.Value : value;
        }
        public string? String97
        {
            get => row[97] == DBNull.Value ? null : (string)row[97];
            set => row[97] = value is null ? DBNull.Value : value;
        }
        public double? Double97
        {
            get => row[97] == DBNull.Value ? null : (double)row[97];
            set => row[97] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime97
        {
            get => row[97] == DBNull.Value ? null : (DateTime)row[97];
            set => row[97] = value is null ? DBNull.Value : value;
        }
        public int? Int98
        {
            get => row[98] == DBNull.Value ? null : (int)row[98];
            set => row[98] = value is null ? DBNull.Value : value;
        }
        public string? String98
        {
            get => row[98] == DBNull.Value ? null : (string)row[98];
            set => row[98] = value is null ? DBNull.Value : value;
        }
        public double? Double98
        {
            get => row[98] == DBNull.Value ? null : (double)row[98];
            set => row[98] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime98
        {
            get => row[98] == DBNull.Value ? null : (DateTime)row[98];
            set => row[98] = value is null ? DBNull.Value : value;
        }
        public int? Int99
        {
            get => row[99] == DBNull.Value ? null : (int)row[99];
            set => row[99] = value is null ? DBNull.Value : value;
        }
        public string? String99
        {
            get => row[99] == DBNull.Value ? null : (string)row[99];
            set => row[99] = value is null ? DBNull.Value : value;
        }
        public double? Double99
        {
            get => row[99] == DBNull.Value ? null : (double)row[99];
            set => row[99] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime99
        {
            get => row[99] == DBNull.Value ? null : (DateTime)row[99];
            set => row[99] = value is null ? DBNull.Value : value;
        }
        public int? Int100
        {
            get => row[100] == DBNull.Value ? null : (int)row[100];
            set => row[100] = value is null ? DBNull.Value : value;
        }
        public string? String100
        {
            get => row[100] == DBNull.Value ? null : (string)row[100];
            set => row[100] = value is null ? DBNull.Value : value;
        }
        public double? Double100
        {
            get => row[100] == DBNull.Value ? null : (double)row[100];
            set => row[100] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime100
        {
            get => row[100] == DBNull.Value ? null : (DateTime)row[100];
            set => row[100] = value is null ? DBNull.Value : value;
        }
        public int? Int101
        {
            get => row[101] == DBNull.Value ? null : (int)row[101];
            set => row[101] = value is null ? DBNull.Value : value;
        }
        public string? String101
        {
            get => row[101] == DBNull.Value ? null : (string)row[101];
            set => row[101] = value is null ? DBNull.Value : value;
        }
        public double? Double101
        {
            get => row[101] == DBNull.Value ? null : (double)row[101];
            set => row[101] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime101
        {
            get => row[101] == DBNull.Value ? null : (DateTime)row[101];
            set => row[101] = value is null ? DBNull.Value : value;
        }
        public int? Int102
        {
            get => row[102] == DBNull.Value ? null : (int)row[102];
            set => row[102] = value is null ? DBNull.Value : value;
        }
        public string? String102
        {
            get => row[102] == DBNull.Value ? null : (string)row[102];
            set => row[102] = value is null ? DBNull.Value : value;
        }
        public double? Double102
        {
            get => row[102] == DBNull.Value ? null : (double)row[102];
            set => row[102] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime102
        {
            get => row[102] == DBNull.Value ? null : (DateTime)row[102];
            set => row[102] = value is null ? DBNull.Value : value;
        }
        public int? Int103
        {
            get => row[103] == DBNull.Value ? null : (int)row[103];
            set => row[103] = value is null ? DBNull.Value : value;
        }
        public string? String103
        {
            get => row[103] == DBNull.Value ? null : (string)row[103];
            set => row[103] = value is null ? DBNull.Value : value;
        }
        public double? Double103
        {
            get => row[103] == DBNull.Value ? null : (double)row[103];
            set => row[103] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime103
        {
            get => row[103] == DBNull.Value ? null : (DateTime)row[103];
            set => row[103] = value is null ? DBNull.Value : value;
        }
        public int? Int104
        {
            get => row[104] == DBNull.Value ? null : (int)row[104];
            set => row[104] = value is null ? DBNull.Value : value;
        }
        public string? String104
        {
            get => row[104] == DBNull.Value ? null : (string)row[104];
            set => row[104] = value is null ? DBNull.Value : value;
        }
        public double? Double104
        {
            get => row[104] == DBNull.Value ? null : (double)row[104];
            set => row[104] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime104
        {
            get => row[104] == DBNull.Value ? null : (DateTime)row[104];
            set => row[104] = value is null ? DBNull.Value : value;
        }
        public int? Int105
        {
            get => row[105] == DBNull.Value ? null : (int)row[105];
            set => row[105] = value is null ? DBNull.Value : value;
        }
        public string? String105
        {
            get => row[105] == DBNull.Value ? null : (string)row[105];
            set => row[105] = value is null ? DBNull.Value : value;
        }
        public double? Double105
        {
            get => row[105] == DBNull.Value ? null : (double)row[105];
            set => row[105] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime105
        {
            get => row[105] == DBNull.Value ? null : (DateTime)row[105];
            set => row[105] = value is null ? DBNull.Value : value;
        }
        public int? Int106
        {
            get => row[106] == DBNull.Value ? null : (int)row[106];
            set => row[106] = value is null ? DBNull.Value : value;
        }
        public string? String106
        {
            get => row[106] == DBNull.Value ? null : (string)row[106];
            set => row[106] = value is null ? DBNull.Value : value;
        }
        public double? Double106
        {
            get => row[106] == DBNull.Value ? null : (double)row[106];
            set => row[106] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime106
        {
            get => row[106] == DBNull.Value ? null : (DateTime)row[106];
            set => row[106] = value is null ? DBNull.Value : value;
        }
        public int? Int107
        {
            get => row[107] == DBNull.Value ? null : (int)row[107];
            set => row[107] = value is null ? DBNull.Value : value;
        }
        public string? String107
        {
            get => row[107] == DBNull.Value ? null : (string)row[107];
            set => row[107] = value is null ? DBNull.Value : value;
        }
        public double? Double107
        {
            get => row[107] == DBNull.Value ? null : (double)row[107];
            set => row[107] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime107
        {
            get => row[107] == DBNull.Value ? null : (DateTime)row[107];
            set => row[107] = value is null ? DBNull.Value : value;
        }
        public int? Int108
        {
            get => row[108] == DBNull.Value ? null : (int)row[108];
            set => row[108] = value is null ? DBNull.Value : value;
        }
        public string? String108
        {
            get => row[108] == DBNull.Value ? null : (string)row[108];
            set => row[108] = value is null ? DBNull.Value : value;
        }
        public double? Double108
        {
            get => row[108] == DBNull.Value ? null : (double)row[108];
            set => row[108] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime108
        {
            get => row[108] == DBNull.Value ? null : (DateTime)row[108];
            set => row[108] = value is null ? DBNull.Value : value;
        }
        public int? Int109
        {
            get => row[109] == DBNull.Value ? null : (int)row[109];
            set => row[109] = value is null ? DBNull.Value : value;
        }
        public string? String109
        {
            get => row[109] == DBNull.Value ? null : (string)row[109];
            set => row[109] = value is null ? DBNull.Value : value;
        }
        public double? Double109
        {
            get => row[109] == DBNull.Value ? null : (double)row[109];
            set => row[109] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime109
        {
            get => row[109] == DBNull.Value ? null : (DateTime)row[109];
            set => row[109] = value is null ? DBNull.Value : value;
        }
        public int? Int110
        {
            get => row[110] == DBNull.Value ? null : (int)row[110];
            set => row[110] = value is null ? DBNull.Value : value;
        }
        public string? String110
        {
            get => row[110] == DBNull.Value ? null : (string)row[110];
            set => row[110] = value is null ? DBNull.Value : value;
        }
        public double? Double110
        {
            get => row[110] == DBNull.Value ? null : (double)row[110];
            set => row[110] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime110
        {
            get => row[110] == DBNull.Value ? null : (DateTime)row[110];
            set => row[110] = value is null ? DBNull.Value : value;
        }
        public int? Int111
        {
            get => row[111] == DBNull.Value ? null : (int)row[111];
            set => row[111] = value is null ? DBNull.Value : value;
        }
        public string? String111
        {
            get => row[111] == DBNull.Value ? null : (string)row[111];
            set => row[111] = value is null ? DBNull.Value : value;
        }
        public double? Double111
        {
            get => row[111] == DBNull.Value ? null : (double)row[111];
            set => row[111] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime111
        {
            get => row[111] == DBNull.Value ? null : (DateTime)row[111];
            set => row[111] = value is null ? DBNull.Value : value;
        }
        public int? Int112
        {
            get => row[112] == DBNull.Value ? null : (int)row[112];
            set => row[112] = value is null ? DBNull.Value : value;
        }
        public string? String112
        {
            get => row[112] == DBNull.Value ? null : (string)row[112];
            set => row[112] = value is null ? DBNull.Value : value;
        }
        public double? Double112
        {
            get => row[112] == DBNull.Value ? null : (double)row[112];
            set => row[112] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime112
        {
            get => row[112] == DBNull.Value ? null : (DateTime)row[112];
            set => row[112] = value is null ? DBNull.Value : value;
        }
        public int? Int113
        {
            get => row[113] == DBNull.Value ? null : (int)row[113];
            set => row[113] = value is null ? DBNull.Value : value;
        }
        public string? String113
        {
            get => row[113] == DBNull.Value ? null : (string)row[113];
            set => row[113] = value is null ? DBNull.Value : value;
        }
        public double? Double113
        {
            get => row[113] == DBNull.Value ? null : (double)row[113];
            set => row[113] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime113
        {
            get => row[113] == DBNull.Value ? null : (DateTime)row[113];
            set => row[113] = value is null ? DBNull.Value : value;
        }
        public int? Int114
        {
            get => row[114] == DBNull.Value ? null : (int)row[114];
            set => row[114] = value is null ? DBNull.Value : value;
        }
        public string? String114
        {
            get => row[114] == DBNull.Value ? null : (string)row[114];
            set => row[114] = value is null ? DBNull.Value : value;
        }
        public double? Double114
        {
            get => row[114] == DBNull.Value ? null : (double)row[114];
            set => row[114] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime114
        {
            get => row[114] == DBNull.Value ? null : (DateTime)row[114];
            set => row[114] = value is null ? DBNull.Value : value;
        }
        public int? Int115
        {
            get => row[115] == DBNull.Value ? null : (int)row[115];
            set => row[115] = value is null ? DBNull.Value : value;
        }
        public string? String115
        {
            get => row[115] == DBNull.Value ? null : (string)row[115];
            set => row[115] = value is null ? DBNull.Value : value;
        }
        public double? Double115
        {
            get => row[115] == DBNull.Value ? null : (double)row[115];
            set => row[115] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime115
        {
            get => row[115] == DBNull.Value ? null : (DateTime)row[115];
            set => row[115] = value is null ? DBNull.Value : value;
        }
        public int? Int116
        {
            get => row[116] == DBNull.Value ? null : (int)row[116];
            set => row[116] = value is null ? DBNull.Value : value;
        }
        public string? String116
        {
            get => row[116] == DBNull.Value ? null : (string)row[116];
            set => row[116] = value is null ? DBNull.Value : value;
        }
        public double? Double116
        {
            get => row[116] == DBNull.Value ? null : (double)row[116];
            set => row[116] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime116
        {
            get => row[116] == DBNull.Value ? null : (DateTime)row[116];
            set => row[116] = value is null ? DBNull.Value : value;
        }
        public int? Int117
        {
            get => row[117] == DBNull.Value ? null : (int)row[117];
            set => row[117] = value is null ? DBNull.Value : value;
        }
        public string? String117
        {
            get => row[117] == DBNull.Value ? null : (string)row[117];
            set => row[117] = value is null ? DBNull.Value : value;
        }
        public double? Double117
        {
            get => row[117] == DBNull.Value ? null : (double)row[117];
            set => row[117] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime117
        {
            get => row[117] == DBNull.Value ? null : (DateTime)row[117];
            set => row[117] = value is null ? DBNull.Value : value;
        }
        public int? Int118
        {
            get => row[118] == DBNull.Value ? null : (int)row[118];
            set => row[118] = value is null ? DBNull.Value : value;
        }
        public string? String118
        {
            get => row[118] == DBNull.Value ? null : (string)row[118];
            set => row[118] = value is null ? DBNull.Value : value;
        }
        public double? Double118
        {
            get => row[118] == DBNull.Value ? null : (double)row[118];
            set => row[118] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime118
        {
            get => row[118] == DBNull.Value ? null : (DateTime)row[118];
            set => row[118] = value is null ? DBNull.Value : value;
        }
        public int? Int119
        {
            get => row[119] == DBNull.Value ? null : (int)row[119];
            set => row[119] = value is null ? DBNull.Value : value;
        }
        public string? String119
        {
            get => row[119] == DBNull.Value ? null : (string)row[119];
            set => row[119] = value is null ? DBNull.Value : value;
        }
        public double? Double119
        {
            get => row[119] == DBNull.Value ? null : (double)row[119];
            set => row[119] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime119
        {
            get => row[119] == DBNull.Value ? null : (DateTime)row[119];
            set => row[119] = value is null ? DBNull.Value : value;
        }
        public int? Int120
        {
            get => row[120] == DBNull.Value ? null : (int)row[120];
            set => row[120] = value is null ? DBNull.Value : value;
        }
        public string? String120
        {
            get => row[120] == DBNull.Value ? null : (string)row[120];
            set => row[120] = value is null ? DBNull.Value : value;
        }
        public double? Double120
        {
            get => row[120] == DBNull.Value ? null : (double)row[120];
            set => row[120] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime120
        {
            get => row[120] == DBNull.Value ? null : (DateTime)row[120];
            set => row[120] = value is null ? DBNull.Value : value;
        }
        public int? Int121
        {
            get => row[121] == DBNull.Value ? null : (int)row[121];
            set => row[121] = value is null ? DBNull.Value : value;
        }
        public string? String121
        {
            get => row[121] == DBNull.Value ? null : (string)row[121];
            set => row[121] = value is null ? DBNull.Value : value;
        }
        public double? Double121
        {
            get => row[121] == DBNull.Value ? null : (double)row[121];
            set => row[121] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime121
        {
            get => row[121] == DBNull.Value ? null : (DateTime)row[121];
            set => row[121] = value is null ? DBNull.Value : value;
        }
        public int? Int122
        {
            get => row[122] == DBNull.Value ? null : (int)row[122];
            set => row[122] = value is null ? DBNull.Value : value;
        }
        public string? String122
        {
            get => row[122] == DBNull.Value ? null : (string)row[122];
            set => row[122] = value is null ? DBNull.Value : value;
        }
        public double? Double122
        {
            get => row[122] == DBNull.Value ? null : (double)row[122];
            set => row[122] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime122
        {
            get => row[122] == DBNull.Value ? null : (DateTime)row[122];
            set => row[122] = value is null ? DBNull.Value : value;
        }
        public int? Int123
        {
            get => row[123] == DBNull.Value ? null : (int)row[123];
            set => row[123] = value is null ? DBNull.Value : value;
        }
        public string? String123
        {
            get => row[123] == DBNull.Value ? null : (string)row[123];
            set => row[123] = value is null ? DBNull.Value : value;
        }
        public double? Double123
        {
            get => row[123] == DBNull.Value ? null : (double)row[123];
            set => row[123] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime123
        {
            get => row[123] == DBNull.Value ? null : (DateTime)row[123];
            set => row[123] = value is null ? DBNull.Value : value;
        }
        public int? Int124
        {
            get => row[124] == DBNull.Value ? null : (int)row[124];
            set => row[124] = value is null ? DBNull.Value : value;
        }
        public string? String124
        {
            get => row[124] == DBNull.Value ? null : (string)row[124];
            set => row[124] = value is null ? DBNull.Value : value;
        }
        public double? Double124
        {
            get => row[124] == DBNull.Value ? null : (double)row[124];
            set => row[124] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime124
        {
            get => row[124] == DBNull.Value ? null : (DateTime)row[124];
            set => row[124] = value is null ? DBNull.Value : value;
        }
        public int? Int125
        {
            get => row[125] == DBNull.Value ? null : (int)row[125];
            set => row[125] = value is null ? DBNull.Value : value;
        }
        public string? String125
        {
            get => row[125] == DBNull.Value ? null : (string)row[125];
            set => row[125] = value is null ? DBNull.Value : value;
        }
        public double? Double125
        {
            get => row[125] == DBNull.Value ? null : (double)row[125];
            set => row[125] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime125
        {
            get => row[125] == DBNull.Value ? null : (DateTime)row[125];
            set => row[125] = value is null ? DBNull.Value : value;
        }
        public int? Int126
        {
            get => row[126] == DBNull.Value ? null : (int)row[126];
            set => row[126] = value is null ? DBNull.Value : value;
        }
        public string? String126
        {
            get => row[126] == DBNull.Value ? null : (string)row[126];
            set => row[126] = value is null ? DBNull.Value : value;
        }
        public double? Double126
        {
            get => row[126] == DBNull.Value ? null : (double)row[126];
            set => row[126] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime126
        {
            get => row[126] == DBNull.Value ? null : (DateTime)row[126];
            set => row[126] = value is null ? DBNull.Value : value;
        }
        public int? Int127
        {
            get => row[127] == DBNull.Value ? null : (int)row[127];
            set => row[127] = value is null ? DBNull.Value : value;
        }
        public string? String127
        {
            get => row[127] == DBNull.Value ? null : (string)row[127];
            set => row[127] = value is null ? DBNull.Value : value;
        }
        public double? Double127
        {
            get => row[127] == DBNull.Value ? null : (double)row[127];
            set => row[127] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime127
        {
            get => row[127] == DBNull.Value ? null : (DateTime)row[127];
            set => row[127] = value is null ? DBNull.Value : value;
        }
        public int? Int128
        {
            get => row[128] == DBNull.Value ? null : (int)row[128];
            set => row[128] = value is null ? DBNull.Value : value;
        }
        public string? String128
        {
            get => row[128] == DBNull.Value ? null : (string)row[128];
            set => row[128] = value is null ? DBNull.Value : value;
        }
        public double? Double128
        {
            get => row[128] == DBNull.Value ? null : (double)row[128];
            set => row[128] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime128
        {
            get => row[128] == DBNull.Value ? null : (DateTime)row[128];
            set => row[128] = value is null ? DBNull.Value : value;
        }
        public int? Int129
        {
            get => row[129] == DBNull.Value ? null : (int)row[129];
            set => row[129] = value is null ? DBNull.Value : value;
        }
        public string? String129
        {
            get => row[129] == DBNull.Value ? null : (string)row[129];
            set => row[129] = value is null ? DBNull.Value : value;
        }
        public double? Double129
        {
            get => row[129] == DBNull.Value ? null : (double)row[129];
            set => row[129] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime129
        {
            get => row[129] == DBNull.Value ? null : (DateTime)row[129];
            set => row[129] = value is null ? DBNull.Value : value;
        }
        public int? Int130
        {
            get => row[130] == DBNull.Value ? null : (int)row[130];
            set => row[130] = value is null ? DBNull.Value : value;
        }
        public string? String130
        {
            get => row[130] == DBNull.Value ? null : (string)row[130];
            set => row[130] = value is null ? DBNull.Value : value;
        }
        public double? Double130
        {
            get => row[130] == DBNull.Value ? null : (double)row[130];
            set => row[130] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime130
        {
            get => row[130] == DBNull.Value ? null : (DateTime)row[130];
            set => row[130] = value is null ? DBNull.Value : value;
        }
        public int? Int131
        {
            get => row[131] == DBNull.Value ? null : (int)row[131];
            set => row[131] = value is null ? DBNull.Value : value;
        }
        public string? String131
        {
            get => row[131] == DBNull.Value ? null : (string)row[131];
            set => row[131] = value is null ? DBNull.Value : value;
        }
        public double? Double131
        {
            get => row[131] == DBNull.Value ? null : (double)row[131];
            set => row[131] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime131
        {
            get => row[131] == DBNull.Value ? null : (DateTime)row[131];
            set => row[131] = value is null ? DBNull.Value : value;
        }
        public int? Int132
        {
            get => row[132] == DBNull.Value ? null : (int)row[132];
            set => row[132] = value is null ? DBNull.Value : value;
        }
        public string? String132
        {
            get => row[132] == DBNull.Value ? null : (string)row[132];
            set => row[132] = value is null ? DBNull.Value : value;
        }
        public double? Double132
        {
            get => row[132] == DBNull.Value ? null : (double)row[132];
            set => row[132] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime132
        {
            get => row[132] == DBNull.Value ? null : (DateTime)row[132];
            set => row[132] = value is null ? DBNull.Value : value;
        }
        public int? Int133
        {
            get => row[133] == DBNull.Value ? null : (int)row[133];
            set => row[133] = value is null ? DBNull.Value : value;
        }
        public string? String133
        {
            get => row[133] == DBNull.Value ? null : (string)row[133];
            set => row[133] = value is null ? DBNull.Value : value;
        }
        public double? Double133
        {
            get => row[133] == DBNull.Value ? null : (double)row[133];
            set => row[133] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime133
        {
            get => row[133] == DBNull.Value ? null : (DateTime)row[133];
            set => row[133] = value is null ? DBNull.Value : value;
        }
        public int? Int134
        {
            get => row[134] == DBNull.Value ? null : (int)row[134];
            set => row[134] = value is null ? DBNull.Value : value;
        }
        public string? String134
        {
            get => row[134] == DBNull.Value ? null : (string)row[134];
            set => row[134] = value is null ? DBNull.Value : value;
        }
        public double? Double134
        {
            get => row[134] == DBNull.Value ? null : (double)row[134];
            set => row[134] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime134
        {
            get => row[134] == DBNull.Value ? null : (DateTime)row[134];
            set => row[134] = value is null ? DBNull.Value : value;
        }
        public int? Int135
        {
            get => row[135] == DBNull.Value ? null : (int)row[135];
            set => row[135] = value is null ? DBNull.Value : value;
        }
        public string? String135
        {
            get => row[135] == DBNull.Value ? null : (string)row[135];
            set => row[135] = value is null ? DBNull.Value : value;
        }
        public double? Double135
        {
            get => row[135] == DBNull.Value ? null : (double)row[135];
            set => row[135] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime135
        {
            get => row[135] == DBNull.Value ? null : (DateTime)row[135];
            set => row[135] = value is null ? DBNull.Value : value;
        }
        public int? Int136
        {
            get => row[136] == DBNull.Value ? null : (int)row[136];
            set => row[136] = value is null ? DBNull.Value : value;
        }
        public string? String136
        {
            get => row[136] == DBNull.Value ? null : (string)row[136];
            set => row[136] = value is null ? DBNull.Value : value;
        }
        public double? Double136
        {
            get => row[136] == DBNull.Value ? null : (double)row[136];
            set => row[136] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime136
        {
            get => row[136] == DBNull.Value ? null : (DateTime)row[136];
            set => row[136] = value is null ? DBNull.Value : value;
        }
        public int? Int137
        {
            get => row[137] == DBNull.Value ? null : (int)row[137];
            set => row[137] = value is null ? DBNull.Value : value;
        }
        public string? String137
        {
            get => row[137] == DBNull.Value ? null : (string)row[137];
            set => row[137] = value is null ? DBNull.Value : value;
        }
        public double? Double137
        {
            get => row[137] == DBNull.Value ? null : (double)row[137];
            set => row[137] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime137
        {
            get => row[137] == DBNull.Value ? null : (DateTime)row[137];
            set => row[137] = value is null ? DBNull.Value : value;
        }
        public int? Int138
        {
            get => row[138] == DBNull.Value ? null : (int)row[138];
            set => row[138] = value is null ? DBNull.Value : value;
        }
        public string? String138
        {
            get => row[138] == DBNull.Value ? null : (string)row[138];
            set => row[138] = value is null ? DBNull.Value : value;
        }
        public double? Double138
        {
            get => row[138] == DBNull.Value ? null : (double)row[138];
            set => row[138] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime138
        {
            get => row[138] == DBNull.Value ? null : (DateTime)row[138];
            set => row[138] = value is null ? DBNull.Value : value;
        }
        public int? Int139
        {
            get => row[139] == DBNull.Value ? null : (int)row[139];
            set => row[139] = value is null ? DBNull.Value : value;
        }
        public string? String139
        {
            get => row[139] == DBNull.Value ? null : (string)row[139];
            set => row[139] = value is null ? DBNull.Value : value;
        }
        public double? Double139
        {
            get => row[139] == DBNull.Value ? null : (double)row[139];
            set => row[139] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime139
        {
            get => row[139] == DBNull.Value ? null : (DateTime)row[139];
            set => row[139] = value is null ? DBNull.Value : value;
        }
        public int? Int140
        {
            get => row[140] == DBNull.Value ? null : (int)row[140];
            set => row[140] = value is null ? DBNull.Value : value;
        }
        public string? String140
        {
            get => row[140] == DBNull.Value ? null : (string)row[140];
            set => row[140] = value is null ? DBNull.Value : value;
        }
        public double? Double140
        {
            get => row[140] == DBNull.Value ? null : (double)row[140];
            set => row[140] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime140
        {
            get => row[140] == DBNull.Value ? null : (DateTime)row[140];
            set => row[140] = value is null ? DBNull.Value : value;
        }
        public int? Int141
        {
            get => row[141] == DBNull.Value ? null : (int)row[141];
            set => row[141] = value is null ? DBNull.Value : value;
        }
        public string? String141
        {
            get => row[141] == DBNull.Value ? null : (string)row[141];
            set => row[141] = value is null ? DBNull.Value : value;
        }
        public double? Double141
        {
            get => row[141] == DBNull.Value ? null : (double)row[141];
            set => row[141] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime141
        {
            get => row[141] == DBNull.Value ? null : (DateTime)row[141];
            set => row[141] = value is null ? DBNull.Value : value;
        }
        public int? Int142
        {
            get => row[142] == DBNull.Value ? null : (int)row[142];
            set => row[142] = value is null ? DBNull.Value : value;
        }
        public string? String142
        {
            get => row[142] == DBNull.Value ? null : (string)row[142];
            set => row[142] = value is null ? DBNull.Value : value;
        }
        public double? Double142
        {
            get => row[142] == DBNull.Value ? null : (double)row[142];
            set => row[142] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime142
        {
            get => row[142] == DBNull.Value ? null : (DateTime)row[142];
            set => row[142] = value is null ? DBNull.Value : value;
        }
        public int? Int143
        {
            get => row[143] == DBNull.Value ? null : (int)row[143];
            set => row[143] = value is null ? DBNull.Value : value;
        }
        public string? String143
        {
            get => row[143] == DBNull.Value ? null : (string)row[143];
            set => row[143] = value is null ? DBNull.Value : value;
        }
        public double? Double143
        {
            get => row[143] == DBNull.Value ? null : (double)row[143];
            set => row[143] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime143
        {
            get => row[143] == DBNull.Value ? null : (DateTime)row[143];
            set => row[143] = value is null ? DBNull.Value : value;
        }
        public int? Int144
        {
            get => row[144] == DBNull.Value ? null : (int)row[144];
            set => row[144] = value is null ? DBNull.Value : value;
        }
        public string? String144
        {
            get => row[144] == DBNull.Value ? null : (string)row[144];
            set => row[144] = value is null ? DBNull.Value : value;
        }
        public double? Double144
        {
            get => row[144] == DBNull.Value ? null : (double)row[144];
            set => row[144] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime144
        {
            get => row[144] == DBNull.Value ? null : (DateTime)row[144];
            set => row[144] = value is null ? DBNull.Value : value;
        }
        public int? Int145
        {
            get => row[145] == DBNull.Value ? null : (int)row[145];
            set => row[145] = value is null ? DBNull.Value : value;
        }
        public string? String145
        {
            get => row[145] == DBNull.Value ? null : (string)row[145];
            set => row[145] = value is null ? DBNull.Value : value;
        }
        public double? Double145
        {
            get => row[145] == DBNull.Value ? null : (double)row[145];
            set => row[145] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime145
        {
            get => row[145] == DBNull.Value ? null : (DateTime)row[145];
            set => row[145] = value is null ? DBNull.Value : value;
        }
        public int? Int146
        {
            get => row[146] == DBNull.Value ? null : (int)row[146];
            set => row[146] = value is null ? DBNull.Value : value;
        }
        public string? String146
        {
            get => row[146] == DBNull.Value ? null : (string)row[146];
            set => row[146] = value is null ? DBNull.Value : value;
        }
        public double? Double146
        {
            get => row[146] == DBNull.Value ? null : (double)row[146];
            set => row[146] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime146
        {
            get => row[146] == DBNull.Value ? null : (DateTime)row[146];
            set => row[146] = value is null ? DBNull.Value : value;
        }
        public int? Int147
        {
            get => row[147] == DBNull.Value ? null : (int)row[147];
            set => row[147] = value is null ? DBNull.Value : value;
        }
        public string? String147
        {
            get => row[147] == DBNull.Value ? null : (string)row[147];
            set => row[147] = value is null ? DBNull.Value : value;
        }
        public double? Double147
        {
            get => row[147] == DBNull.Value ? null : (double)row[147];
            set => row[147] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime147
        {
            get => row[147] == DBNull.Value ? null : (DateTime)row[147];
            set => row[147] = value is null ? DBNull.Value : value;
        }
        public int? Int148
        {
            get => row[148] == DBNull.Value ? null : (int)row[148];
            set => row[148] = value is null ? DBNull.Value : value;
        }
        public string? String148
        {
            get => row[148] == DBNull.Value ? null : (string)row[148];
            set => row[148] = value is null ? DBNull.Value : value;
        }
        public double? Double148
        {
            get => row[148] == DBNull.Value ? null : (double)row[148];
            set => row[148] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime148
        {
            get => row[148] == DBNull.Value ? null : (DateTime)row[148];
            set => row[148] = value is null ? DBNull.Value : value;
        }
        public int? Int149
        {
            get => row[149] == DBNull.Value ? null : (int)row[149];
            set => row[149] = value is null ? DBNull.Value : value;
        }
        public string? String149
        {
            get => row[149] == DBNull.Value ? null : (string)row[149];
            set => row[149] = value is null ? DBNull.Value : value;
        }
        public double? Double149
        {
            get => row[149] == DBNull.Value ? null : (double)row[149];
            set => row[149] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime149
        {
            get => row[149] == DBNull.Value ? null : (DateTime)row[149];
            set => row[149] = value is null ? DBNull.Value : value;
        }
        public int? Int150
        {
            get => row[150] == DBNull.Value ? null : (int)row[150];
            set => row[150] = value is null ? DBNull.Value : value;
        }
        public string? String150
        {
            get => row[150] == DBNull.Value ? null : (string)row[150];
            set => row[150] = value is null ? DBNull.Value : value;
        }
        public double? Double150
        {
            get => row[150] == DBNull.Value ? null : (double)row[150];
            set => row[150] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime150
        {
            get => row[150] == DBNull.Value ? null : (DateTime)row[150];
            set => row[150] = value is null ? DBNull.Value : value;
        }
        public int? Int151
        {
            get => row[151] == DBNull.Value ? null : (int)row[151];
            set => row[151] = value is null ? DBNull.Value : value;
        }
        public string? String151
        {
            get => row[151] == DBNull.Value ? null : (string)row[151];
            set => row[151] = value is null ? DBNull.Value : value;
        }
        public double? Double151
        {
            get => row[151] == DBNull.Value ? null : (double)row[151];
            set => row[151] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime151
        {
            get => row[151] == DBNull.Value ? null : (DateTime)row[151];
            set => row[151] = value is null ? DBNull.Value : value;
        }
        public int? Int152
        {
            get => row[152] == DBNull.Value ? null : (int)row[152];
            set => row[152] = value is null ? DBNull.Value : value;
        }
        public string? String152
        {
            get => row[152] == DBNull.Value ? null : (string)row[152];
            set => row[152] = value is null ? DBNull.Value : value;
        }
        public double? Double152
        {
            get => row[152] == DBNull.Value ? null : (double)row[152];
            set => row[152] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime152
        {
            get => row[152] == DBNull.Value ? null : (DateTime)row[152];
            set => row[152] = value is null ? DBNull.Value : value;
        }
        public int? Int153
        {
            get => row[153] == DBNull.Value ? null : (int)row[153];
            set => row[153] = value is null ? DBNull.Value : value;
        }
        public string? String153
        {
            get => row[153] == DBNull.Value ? null : (string)row[153];
            set => row[153] = value is null ? DBNull.Value : value;
        }
        public double? Double153
        {
            get => row[153] == DBNull.Value ? null : (double)row[153];
            set => row[153] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime153
        {
            get => row[153] == DBNull.Value ? null : (DateTime)row[153];
            set => row[153] = value is null ? DBNull.Value : value;
        }
        public int? Int154
        {
            get => row[154] == DBNull.Value ? null : (int)row[154];
            set => row[154] = value is null ? DBNull.Value : value;
        }
        public string? String154
        {
            get => row[154] == DBNull.Value ? null : (string)row[154];
            set => row[154] = value is null ? DBNull.Value : value;
        }
        public double? Double154
        {
            get => row[154] == DBNull.Value ? null : (double)row[154];
            set => row[154] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime154
        {
            get => row[154] == DBNull.Value ? null : (DateTime)row[154];
            set => row[154] = value is null ? DBNull.Value : value;
        }
        public int? Int155
        {
            get => row[155] == DBNull.Value ? null : (int)row[155];
            set => row[155] = value is null ? DBNull.Value : value;
        }
        public string? String155
        {
            get => row[155] == DBNull.Value ? null : (string)row[155];
            set => row[155] = value is null ? DBNull.Value : value;
        }
        public double? Double155
        {
            get => row[155] == DBNull.Value ? null : (double)row[155];
            set => row[155] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime155
        {
            get => row[155] == DBNull.Value ? null : (DateTime)row[155];
            set => row[155] = value is null ? DBNull.Value : value;
        }
        public int? Int156
        {
            get => row[156] == DBNull.Value ? null : (int)row[156];
            set => row[156] = value is null ? DBNull.Value : value;
        }
        public string? String156
        {
            get => row[156] == DBNull.Value ? null : (string)row[156];
            set => row[156] = value is null ? DBNull.Value : value;
        }
        public double? Double156
        {
            get => row[156] == DBNull.Value ? null : (double)row[156];
            set => row[156] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime156
        {
            get => row[156] == DBNull.Value ? null : (DateTime)row[156];
            set => row[156] = value is null ? DBNull.Value : value;
        }
        public int? Int157
        {
            get => row[157] == DBNull.Value ? null : (int)row[157];
            set => row[157] = value is null ? DBNull.Value : value;
        }
        public string? String157
        {
            get => row[157] == DBNull.Value ? null : (string)row[157];
            set => row[157] = value is null ? DBNull.Value : value;
        }
        public double? Double157
        {
            get => row[157] == DBNull.Value ? null : (double)row[157];
            set => row[157] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime157
        {
            get => row[157] == DBNull.Value ? null : (DateTime)row[157];
            set => row[157] = value is null ? DBNull.Value : value;
        }
        public int? Int158
        {
            get => row[158] == DBNull.Value ? null : (int)row[158];
            set => row[158] = value is null ? DBNull.Value : value;
        }
        public string? String158
        {
            get => row[158] == DBNull.Value ? null : (string)row[158];
            set => row[158] = value is null ? DBNull.Value : value;
        }
        public double? Double158
        {
            get => row[158] == DBNull.Value ? null : (double)row[158];
            set => row[158] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime158
        {
            get => row[158] == DBNull.Value ? null : (DateTime)row[158];
            set => row[158] = value is null ? DBNull.Value : value;
        }
        public int? Int159
        {
            get => row[159] == DBNull.Value ? null : (int)row[159];
            set => row[159] = value is null ? DBNull.Value : value;
        }
        public string? String159
        {
            get => row[159] == DBNull.Value ? null : (string)row[159];
            set => row[159] = value is null ? DBNull.Value : value;
        }
        public double? Double159
        {
            get => row[159] == DBNull.Value ? null : (double)row[159];
            set => row[159] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime159
        {
            get => row[159] == DBNull.Value ? null : (DateTime)row[159];
            set => row[159] = value is null ? DBNull.Value : value;
        }
        public int? Int160
        {
            get => row[160] == DBNull.Value ? null : (int)row[160];
            set => row[160] = value is null ? DBNull.Value : value;
        }
        public string? String160
        {
            get => row[160] == DBNull.Value ? null : (string)row[160];
            set => row[160] = value is null ? DBNull.Value : value;
        }
        public double? Double160
        {
            get => row[160] == DBNull.Value ? null : (double)row[160];
            set => row[160] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime160
        {
            get => row[160] == DBNull.Value ? null : (DateTime)row[160];
            set => row[160] = value is null ? DBNull.Value : value;
        }
        public int? Int161
        {
            get => row[161] == DBNull.Value ? null : (int)row[161];
            set => row[161] = value is null ? DBNull.Value : value;
        }
        public string? String161
        {
            get => row[161] == DBNull.Value ? null : (string)row[161];
            set => row[161] = value is null ? DBNull.Value : value;
        }
        public double? Double161
        {
            get => row[161] == DBNull.Value ? null : (double)row[161];
            set => row[161] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime161
        {
            get => row[161] == DBNull.Value ? null : (DateTime)row[161];
            set => row[161] = value is null ? DBNull.Value : value;
        }
        public int? Int162
        {
            get => row[162] == DBNull.Value ? null : (int)row[162];
            set => row[162] = value is null ? DBNull.Value : value;
        }
        public string? String162
        {
            get => row[162] == DBNull.Value ? null : (string)row[162];
            set => row[162] = value is null ? DBNull.Value : value;
        }
        public double? Double162
        {
            get => row[162] == DBNull.Value ? null : (double)row[162];
            set => row[162] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime162
        {
            get => row[162] == DBNull.Value ? null : (DateTime)row[162];
            set => row[162] = value is null ? DBNull.Value : value;
        }
        public int? Int163
        {
            get => row[163] == DBNull.Value ? null : (int)row[163];
            set => row[163] = value is null ? DBNull.Value : value;
        }
        public string? String163
        {
            get => row[163] == DBNull.Value ? null : (string)row[163];
            set => row[163] = value is null ? DBNull.Value : value;
        }
        public double? Double163
        {
            get => row[163] == DBNull.Value ? null : (double)row[163];
            set => row[163] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime163
        {
            get => row[163] == DBNull.Value ? null : (DateTime)row[163];
            set => row[163] = value is null ? DBNull.Value : value;
        }
        public int? Int164
        {
            get => row[164] == DBNull.Value ? null : (int)row[164];
            set => row[164] = value is null ? DBNull.Value : value;
        }
        public string? String164
        {
            get => row[164] == DBNull.Value ? null : (string)row[164];
            set => row[164] = value is null ? DBNull.Value : value;
        }
        public double? Double164
        {
            get => row[164] == DBNull.Value ? null : (double)row[164];
            set => row[164] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime164
        {
            get => row[164] == DBNull.Value ? null : (DateTime)row[164];
            set => row[164] = value is null ? DBNull.Value : value;
        }
        public int? Int165
        {
            get => row[165] == DBNull.Value ? null : (int)row[165];
            set => row[165] = value is null ? DBNull.Value : value;
        }
        public string? String165
        {
            get => row[165] == DBNull.Value ? null : (string)row[165];
            set => row[165] = value is null ? DBNull.Value : value;
        }
        public double? Double165
        {
            get => row[165] == DBNull.Value ? null : (double)row[165];
            set => row[165] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime165
        {
            get => row[165] == DBNull.Value ? null : (DateTime)row[165];
            set => row[165] = value is null ? DBNull.Value : value;
        }
        public int? Int166
        {
            get => row[166] == DBNull.Value ? null : (int)row[166];
            set => row[166] = value is null ? DBNull.Value : value;
        }
        public string? String166
        {
            get => row[166] == DBNull.Value ? null : (string)row[166];
            set => row[166] = value is null ? DBNull.Value : value;
        }
        public double? Double166
        {
            get => row[166] == DBNull.Value ? null : (double)row[166];
            set => row[166] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime166
        {
            get => row[166] == DBNull.Value ? null : (DateTime)row[166];
            set => row[166] = value is null ? DBNull.Value : value;
        }
        public int? Int167
        {
            get => row[167] == DBNull.Value ? null : (int)row[167];
            set => row[167] = value is null ? DBNull.Value : value;
        }
        public string? String167
        {
            get => row[167] == DBNull.Value ? null : (string)row[167];
            set => row[167] = value is null ? DBNull.Value : value;
        }
        public double? Double167
        {
            get => row[167] == DBNull.Value ? null : (double)row[167];
            set => row[167] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime167
        {
            get => row[167] == DBNull.Value ? null : (DateTime)row[167];
            set => row[167] = value is null ? DBNull.Value : value;
        }
        public int? Int168
        {
            get => row[168] == DBNull.Value ? null : (int)row[168];
            set => row[168] = value is null ? DBNull.Value : value;
        }
        public string? String168
        {
            get => row[168] == DBNull.Value ? null : (string)row[168];
            set => row[168] = value is null ? DBNull.Value : value;
        }
        public double? Double168
        {
            get => row[168] == DBNull.Value ? null : (double)row[168];
            set => row[168] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime168
        {
            get => row[168] == DBNull.Value ? null : (DateTime)row[168];
            set => row[168] = value is null ? DBNull.Value : value;
        }
        public int? Int169
        {
            get => row[169] == DBNull.Value ? null : (int)row[169];
            set => row[169] = value is null ? DBNull.Value : value;
        }
        public string? String169
        {
            get => row[169] == DBNull.Value ? null : (string)row[169];
            set => row[169] = value is null ? DBNull.Value : value;
        }
        public double? Double169
        {
            get => row[169] == DBNull.Value ? null : (double)row[169];
            set => row[169] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime169
        {
            get => row[169] == DBNull.Value ? null : (DateTime)row[169];
            set => row[169] = value is null ? DBNull.Value : value;
        }
        public int? Int170
        {
            get => row[170] == DBNull.Value ? null : (int)row[170];
            set => row[170] = value is null ? DBNull.Value : value;
        }
        public string? String170
        {
            get => row[170] == DBNull.Value ? null : (string)row[170];
            set => row[170] = value is null ? DBNull.Value : value;
        }
        public double? Double170
        {
            get => row[170] == DBNull.Value ? null : (double)row[170];
            set => row[170] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime170
        {
            get => row[170] == DBNull.Value ? null : (DateTime)row[170];
            set => row[170] = value is null ? DBNull.Value : value;
        }
        public int? Int171
        {
            get => row[171] == DBNull.Value ? null : (int)row[171];
            set => row[171] = value is null ? DBNull.Value : value;
        }
        public string? String171
        {
            get => row[171] == DBNull.Value ? null : (string)row[171];
            set => row[171] = value is null ? DBNull.Value : value;
        }
        public double? Double171
        {
            get => row[171] == DBNull.Value ? null : (double)row[171];
            set => row[171] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime171
        {
            get => row[171] == DBNull.Value ? null : (DateTime)row[171];
            set => row[171] = value is null ? DBNull.Value : value;
        }
        public int? Int172
        {
            get => row[172] == DBNull.Value ? null : (int)row[172];
            set => row[172] = value is null ? DBNull.Value : value;
        }
        public string? String172
        {
            get => row[172] == DBNull.Value ? null : (string)row[172];
            set => row[172] = value is null ? DBNull.Value : value;
        }
        public double? Double172
        {
            get => row[172] == DBNull.Value ? null : (double)row[172];
            set => row[172] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime172
        {
            get => row[172] == DBNull.Value ? null : (DateTime)row[172];
            set => row[172] = value is null ? DBNull.Value : value;
        }
        public int? Int173
        {
            get => row[173] == DBNull.Value ? null : (int)row[173];
            set => row[173] = value is null ? DBNull.Value : value;
        }
        public string? String173
        {
            get => row[173] == DBNull.Value ? null : (string)row[173];
            set => row[173] = value is null ? DBNull.Value : value;
        }
        public double? Double173
        {
            get => row[173] == DBNull.Value ? null : (double)row[173];
            set => row[173] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime173
        {
            get => row[173] == DBNull.Value ? null : (DateTime)row[173];
            set => row[173] = value is null ? DBNull.Value : value;
        }
        public int? Int174
        {
            get => row[174] == DBNull.Value ? null : (int)row[174];
            set => row[174] = value is null ? DBNull.Value : value;
        }
        public string? String174
        {
            get => row[174] == DBNull.Value ? null : (string)row[174];
            set => row[174] = value is null ? DBNull.Value : value;
        }
        public double? Double174
        {
            get => row[174] == DBNull.Value ? null : (double)row[174];
            set => row[174] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime174
        {
            get => row[174] == DBNull.Value ? null : (DateTime)row[174];
            set => row[174] = value is null ? DBNull.Value : value;
        }
        public int? Int175
        {
            get => row[175] == DBNull.Value ? null : (int)row[175];
            set => row[175] = value is null ? DBNull.Value : value;
        }
        public string? String175
        {
            get => row[175] == DBNull.Value ? null : (string)row[175];
            set => row[175] = value is null ? DBNull.Value : value;
        }
        public double? Double175
        {
            get => row[175] == DBNull.Value ? null : (double)row[175];
            set => row[175] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime175
        {
            get => row[175] == DBNull.Value ? null : (DateTime)row[175];
            set => row[175] = value is null ? DBNull.Value : value;
        }
        public int? Int176
        {
            get => row[176] == DBNull.Value ? null : (int)row[176];
            set => row[176] = value is null ? DBNull.Value : value;
        }
        public string? String176
        {
            get => row[176] == DBNull.Value ? null : (string)row[176];
            set => row[176] = value is null ? DBNull.Value : value;
        }
        public double? Double176
        {
            get => row[176] == DBNull.Value ? null : (double)row[176];
            set => row[176] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime176
        {
            get => row[176] == DBNull.Value ? null : (DateTime)row[176];
            set => row[176] = value is null ? DBNull.Value : value;
        }
        public int? Int177
        {
            get => row[177] == DBNull.Value ? null : (int)row[177];
            set => row[177] = value is null ? DBNull.Value : value;
        }
        public string? String177
        {
            get => row[177] == DBNull.Value ? null : (string)row[177];
            set => row[177] = value is null ? DBNull.Value : value;
        }
        public double? Double177
        {
            get => row[177] == DBNull.Value ? null : (double)row[177];
            set => row[177] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime177
        {
            get => row[177] == DBNull.Value ? null : (DateTime)row[177];
            set => row[177] = value is null ? DBNull.Value : value;
        }
        public int? Int178
        {
            get => row[178] == DBNull.Value ? null : (int)row[178];
            set => row[178] = value is null ? DBNull.Value : value;
        }
        public string? String178
        {
            get => row[178] == DBNull.Value ? null : (string)row[178];
            set => row[178] = value is null ? DBNull.Value : value;
        }
        public double? Double178
        {
            get => row[178] == DBNull.Value ? null : (double)row[178];
            set => row[178] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime178
        {
            get => row[178] == DBNull.Value ? null : (DateTime)row[178];
            set => row[178] = value is null ? DBNull.Value : value;
        }
        public int? Int179
        {
            get => row[179] == DBNull.Value ? null : (int)row[179];
            set => row[179] = value is null ? DBNull.Value : value;
        }
        public string? String179
        {
            get => row[179] == DBNull.Value ? null : (string)row[179];
            set => row[179] = value is null ? DBNull.Value : value;
        }
        public double? Double179
        {
            get => row[179] == DBNull.Value ? null : (double)row[179];
            set => row[179] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime179
        {
            get => row[179] == DBNull.Value ? null : (DateTime)row[179];
            set => row[179] = value is null ? DBNull.Value : value;
        }
        public int? Int180
        {
            get => row[180] == DBNull.Value ? null : (int)row[180];
            set => row[180] = value is null ? DBNull.Value : value;
        }
        public string? String180
        {
            get => row[180] == DBNull.Value ? null : (string)row[180];
            set => row[180] = value is null ? DBNull.Value : value;
        }
        public double? Double180
        {
            get => row[180] == DBNull.Value ? null : (double)row[180];
            set => row[180] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime180
        {
            get => row[180] == DBNull.Value ? null : (DateTime)row[180];
            set => row[180] = value is null ? DBNull.Value : value;
        }
        public int? Int181
        {
            get => row[181] == DBNull.Value ? null : (int)row[181];
            set => row[181] = value is null ? DBNull.Value : value;
        }
        public string? String181
        {
            get => row[181] == DBNull.Value ? null : (string)row[181];
            set => row[181] = value is null ? DBNull.Value : value;
        }
        public double? Double181
        {
            get => row[181] == DBNull.Value ? null : (double)row[181];
            set => row[181] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime181
        {
            get => row[181] == DBNull.Value ? null : (DateTime)row[181];
            set => row[181] = value is null ? DBNull.Value : value;
        }
        public int? Int182
        {
            get => row[182] == DBNull.Value ? null : (int)row[182];
            set => row[182] = value is null ? DBNull.Value : value;
        }
        public string? String182
        {
            get => row[182] == DBNull.Value ? null : (string)row[182];
            set => row[182] = value is null ? DBNull.Value : value;
        }
        public double? Double182
        {
            get => row[182] == DBNull.Value ? null : (double)row[182];
            set => row[182] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime182
        {
            get => row[182] == DBNull.Value ? null : (DateTime)row[182];
            set => row[182] = value is null ? DBNull.Value : value;
        }
        public int? Int183
        {
            get => row[183] == DBNull.Value ? null : (int)row[183];
            set => row[183] = value is null ? DBNull.Value : value;
        }
        public string? String183
        {
            get => row[183] == DBNull.Value ? null : (string)row[183];
            set => row[183] = value is null ? DBNull.Value : value;
        }
        public double? Double183
        {
            get => row[183] == DBNull.Value ? null : (double)row[183];
            set => row[183] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime183
        {
            get => row[183] == DBNull.Value ? null : (DateTime)row[183];
            set => row[183] = value is null ? DBNull.Value : value;
        }
        public int? Int184
        {
            get => row[184] == DBNull.Value ? null : (int)row[184];
            set => row[184] = value is null ? DBNull.Value : value;
        }
        public string? String184
        {
            get => row[184] == DBNull.Value ? null : (string)row[184];
            set => row[184] = value is null ? DBNull.Value : value;
        }
        public double? Double184
        {
            get => row[184] == DBNull.Value ? null : (double)row[184];
            set => row[184] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime184
        {
            get => row[184] == DBNull.Value ? null : (DateTime)row[184];
            set => row[184] = value is null ? DBNull.Value : value;
        }
        public int? Int185
        {
            get => row[185] == DBNull.Value ? null : (int)row[185];
            set => row[185] = value is null ? DBNull.Value : value;
        }
        public string? String185
        {
            get => row[185] == DBNull.Value ? null : (string)row[185];
            set => row[185] = value is null ? DBNull.Value : value;
        }
        public double? Double185
        {
            get => row[185] == DBNull.Value ? null : (double)row[185];
            set => row[185] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime185
        {
            get => row[185] == DBNull.Value ? null : (DateTime)row[185];
            set => row[185] = value is null ? DBNull.Value : value;
        }
        public int? Int186
        {
            get => row[186] == DBNull.Value ? null : (int)row[186];
            set => row[186] = value is null ? DBNull.Value : value;
        }
        public string? String186
        {
            get => row[186] == DBNull.Value ? null : (string)row[186];
            set => row[186] = value is null ? DBNull.Value : value;
        }
        public double? Double186
        {
            get => row[186] == DBNull.Value ? null : (double)row[186];
            set => row[186] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime186
        {
            get => row[186] == DBNull.Value ? null : (DateTime)row[186];
            set => row[186] = value is null ? DBNull.Value : value;
        }
        public int? Int187
        {
            get => row[187] == DBNull.Value ? null : (int)row[187];
            set => row[187] = value is null ? DBNull.Value : value;
        }
        public string? String187
        {
            get => row[187] == DBNull.Value ? null : (string)row[187];
            set => row[187] = value is null ? DBNull.Value : value;
        }
        public double? Double187
        {
            get => row[187] == DBNull.Value ? null : (double)row[187];
            set => row[187] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime187
        {
            get => row[187] == DBNull.Value ? null : (DateTime)row[187];
            set => row[187] = value is null ? DBNull.Value : value;
        }
        public int? Int188
        {
            get => row[188] == DBNull.Value ? null : (int)row[188];
            set => row[188] = value is null ? DBNull.Value : value;
        }
        public string? String188
        {
            get => row[188] == DBNull.Value ? null : (string)row[188];
            set => row[188] = value is null ? DBNull.Value : value;
        }
        public double? Double188
        {
            get => row[188] == DBNull.Value ? null : (double)row[188];
            set => row[188] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime188
        {
            get => row[188] == DBNull.Value ? null : (DateTime)row[188];
            set => row[188] = value is null ? DBNull.Value : value;
        }
        public int? Int189
        {
            get => row[189] == DBNull.Value ? null : (int)row[189];
            set => row[189] = value is null ? DBNull.Value : value;
        }
        public string? String189
        {
            get => row[189] == DBNull.Value ? null : (string)row[189];
            set => row[189] = value is null ? DBNull.Value : value;
        }
        public double? Double189
        {
            get => row[189] == DBNull.Value ? null : (double)row[189];
            set => row[189] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime189
        {
            get => row[189] == DBNull.Value ? null : (DateTime)row[189];
            set => row[189] = value is null ? DBNull.Value : value;
        }
        public int? Int190
        {
            get => row[190] == DBNull.Value ? null : (int)row[190];
            set => row[190] = value is null ? DBNull.Value : value;
        }
        public string? String190
        {
            get => row[190] == DBNull.Value ? null : (string)row[190];
            set => row[190] = value is null ? DBNull.Value : value;
        }
        public double? Double190
        {
            get => row[190] == DBNull.Value ? null : (double)row[190];
            set => row[190] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime190
        {
            get => row[190] == DBNull.Value ? null : (DateTime)row[190];
            set => row[190] = value is null ? DBNull.Value : value;
        }
        public int? Int191
        {
            get => row[191] == DBNull.Value ? null : (int)row[191];
            set => row[191] = value is null ? DBNull.Value : value;
        }
        public string? String191
        {
            get => row[191] == DBNull.Value ? null : (string)row[191];
            set => row[191] = value is null ? DBNull.Value : value;
        }
        public double? Double191
        {
            get => row[191] == DBNull.Value ? null : (double)row[191];
            set => row[191] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime191
        {
            get => row[191] == DBNull.Value ? null : (DateTime)row[191];
            set => row[191] = value is null ? DBNull.Value : value;
        }
        public int? Int192
        {
            get => row[192] == DBNull.Value ? null : (int)row[192];
            set => row[192] = value is null ? DBNull.Value : value;
        }
        public string? String192
        {
            get => row[192] == DBNull.Value ? null : (string)row[192];
            set => row[192] = value is null ? DBNull.Value : value;
        }
        public double? Double192
        {
            get => row[192] == DBNull.Value ? null : (double)row[192];
            set => row[192] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime192
        {
            get => row[192] == DBNull.Value ? null : (DateTime)row[192];
            set => row[192] = value is null ? DBNull.Value : value;
        }
        public int? Int193
        {
            get => row[193] == DBNull.Value ? null : (int)row[193];
            set => row[193] = value is null ? DBNull.Value : value;
        }
        public string? String193
        {
            get => row[193] == DBNull.Value ? null : (string)row[193];
            set => row[193] = value is null ? DBNull.Value : value;
        }
        public double? Double193
        {
            get => row[193] == DBNull.Value ? null : (double)row[193];
            set => row[193] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime193
        {
            get => row[193] == DBNull.Value ? null : (DateTime)row[193];
            set => row[193] = value is null ? DBNull.Value : value;
        }
        public int? Int194
        {
            get => row[194] == DBNull.Value ? null : (int)row[194];
            set => row[194] = value is null ? DBNull.Value : value;
        }
        public string? String194
        {
            get => row[194] == DBNull.Value ? null : (string)row[194];
            set => row[194] = value is null ? DBNull.Value : value;
        }
        public double? Double194
        {
            get => row[194] == DBNull.Value ? null : (double)row[194];
            set => row[194] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime194
        {
            get => row[194] == DBNull.Value ? null : (DateTime)row[194];
            set => row[194] = value is null ? DBNull.Value : value;
        }
        public int? Int195
        {
            get => row[195] == DBNull.Value ? null : (int)row[195];
            set => row[195] = value is null ? DBNull.Value : value;
        }
        public string? String195
        {
            get => row[195] == DBNull.Value ? null : (string)row[195];
            set => row[195] = value is null ? DBNull.Value : value;
        }
        public double? Double195
        {
            get => row[195] == DBNull.Value ? null : (double)row[195];
            set => row[195] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime195
        {
            get => row[195] == DBNull.Value ? null : (DateTime)row[195];
            set => row[195] = value is null ? DBNull.Value : value;
        }
        public int? Int196
        {
            get => row[196] == DBNull.Value ? null : (int)row[196];
            set => row[196] = value is null ? DBNull.Value : value;
        }
        public string? String196
        {
            get => row[196] == DBNull.Value ? null : (string)row[196];
            set => row[196] = value is null ? DBNull.Value : value;
        }
        public double? Double196
        {
            get => row[196] == DBNull.Value ? null : (double)row[196];
            set => row[196] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime196
        {
            get => row[196] == DBNull.Value ? null : (DateTime)row[196];
            set => row[196] = value is null ? DBNull.Value : value;
        }
        public int? Int197
        {
            get => row[197] == DBNull.Value ? null : (int)row[197];
            set => row[197] = value is null ? DBNull.Value : value;
        }
        public string? String197
        {
            get => row[197] == DBNull.Value ? null : (string)row[197];
            set => row[197] = value is null ? DBNull.Value : value;
        }
        public double? Double197
        {
            get => row[197] == DBNull.Value ? null : (double)row[197];
            set => row[197] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime197
        {
            get => row[197] == DBNull.Value ? null : (DateTime)row[197];
            set => row[197] = value is null ? DBNull.Value : value;
        }
        public int? Int198
        {
            get => row[198] == DBNull.Value ? null : (int)row[198];
            set => row[198] = value is null ? DBNull.Value : value;
        }
        public string? String198
        {
            get => row[198] == DBNull.Value ? null : (string)row[198];
            set => row[198] = value is null ? DBNull.Value : value;
        }
        public double? Double198
        {
            get => row[198] == DBNull.Value ? null : (double)row[198];
            set => row[198] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime198
        {
            get => row[198] == DBNull.Value ? null : (DateTime)row[198];
            set => row[198] = value is null ? DBNull.Value : value;
        }
        public int? Int199
        {
            get => row[199] == DBNull.Value ? null : (int)row[199];
            set => row[199] = value is null ? DBNull.Value : value;
        }
        public string? String199
        {
            get => row[199] == DBNull.Value ? null : (string)row[199];
            set => row[199] = value is null ? DBNull.Value : value;
        }
        public double? Double199
        {
            get => row[199] == DBNull.Value ? null : (double)row[199];
            set => row[199] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime199
        {
            get => row[199] == DBNull.Value ? null : (DateTime)row[199];
            set => row[199] = value is null ? DBNull.Value : value;
        }
        public int? Int200
        {
            get => row[200] == DBNull.Value ? null : (int)row[200];
            set => row[200] = value is null ? DBNull.Value : value;
        }
        public string? String200
        {
            get => row[200] == DBNull.Value ? null : (string)row[200];
            set => row[200] = value is null ? DBNull.Value : value;
        }
        public double? Double200
        {
            get => row[200] == DBNull.Value ? null : (double)row[200];
            set => row[200] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime200
        {
            get => row[200] == DBNull.Value ? null : (DateTime)row[200];
            set => row[200] = value is null ? DBNull.Value : value;
        }
        public int? Int201
        {
            get => row[201] == DBNull.Value ? null : (int)row[201];
            set => row[201] = value is null ? DBNull.Value : value;
        }
        public string? String201
        {
            get => row[201] == DBNull.Value ? null : (string)row[201];
            set => row[201] = value is null ? DBNull.Value : value;
        }
        public double? Double201
        {
            get => row[201] == DBNull.Value ? null : (double)row[201];
            set => row[201] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime201
        {
            get => row[201] == DBNull.Value ? null : (DateTime)row[201];
            set => row[201] = value is null ? DBNull.Value : value;
        }
        public int? Int202
        {
            get => row[202] == DBNull.Value ? null : (int)row[202];
            set => row[202] = value is null ? DBNull.Value : value;
        }
        public string? String202
        {
            get => row[202] == DBNull.Value ? null : (string)row[202];
            set => row[202] = value is null ? DBNull.Value : value;
        }
        public double? Double202
        {
            get => row[202] == DBNull.Value ? null : (double)row[202];
            set => row[202] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime202
        {
            get => row[202] == DBNull.Value ? null : (DateTime)row[202];
            set => row[202] = value is null ? DBNull.Value : value;
        }
        public int? Int203
        {
            get => row[203] == DBNull.Value ? null : (int)row[203];
            set => row[203] = value is null ? DBNull.Value : value;
        }
        public string? String203
        {
            get => row[203] == DBNull.Value ? null : (string)row[203];
            set => row[203] = value is null ? DBNull.Value : value;
        }
        public double? Double203
        {
            get => row[203] == DBNull.Value ? null : (double)row[203];
            set => row[203] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime203
        {
            get => row[203] == DBNull.Value ? null : (DateTime)row[203];
            set => row[203] = value is null ? DBNull.Value : value;
        }
        public int? Int204
        {
            get => row[204] == DBNull.Value ? null : (int)row[204];
            set => row[204] = value is null ? DBNull.Value : value;
        }
        public string? String204
        {
            get => row[204] == DBNull.Value ? null : (string)row[204];
            set => row[204] = value is null ? DBNull.Value : value;
        }
        public double? Double204
        {
            get => row[204] == DBNull.Value ? null : (double)row[204];
            set => row[204] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime204
        {
            get => row[204] == DBNull.Value ? null : (DateTime)row[204];
            set => row[204] = value is null ? DBNull.Value : value;
        }
        public int? Int205
        {
            get => row[205] == DBNull.Value ? null : (int)row[205];
            set => row[205] = value is null ? DBNull.Value : value;
        }
        public string? String205
        {
            get => row[205] == DBNull.Value ? null : (string)row[205];
            set => row[205] = value is null ? DBNull.Value : value;
        }
        public double? Double205
        {
            get => row[205] == DBNull.Value ? null : (double)row[205];
            set => row[205] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime205
        {
            get => row[205] == DBNull.Value ? null : (DateTime)row[205];
            set => row[205] = value is null ? DBNull.Value : value;
        }
        public int? Int206
        {
            get => row[206] == DBNull.Value ? null : (int)row[206];
            set => row[206] = value is null ? DBNull.Value : value;
        }
        public string? String206
        {
            get => row[206] == DBNull.Value ? null : (string)row[206];
            set => row[206] = value is null ? DBNull.Value : value;
        }
        public double? Double206
        {
            get => row[206] == DBNull.Value ? null : (double)row[206];
            set => row[206] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime206
        {
            get => row[206] == DBNull.Value ? null : (DateTime)row[206];
            set => row[206] = value is null ? DBNull.Value : value;
        }
        public int? Int207
        {
            get => row[207] == DBNull.Value ? null : (int)row[207];
            set => row[207] = value is null ? DBNull.Value : value;
        }
        public string? String207
        {
            get => row[207] == DBNull.Value ? null : (string)row[207];
            set => row[207] = value is null ? DBNull.Value : value;
        }
        public double? Double207
        {
            get => row[207] == DBNull.Value ? null : (double)row[207];
            set => row[207] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime207
        {
            get => row[207] == DBNull.Value ? null : (DateTime)row[207];
            set => row[207] = value is null ? DBNull.Value : value;
        }
        public int? Int208
        {
            get => row[208] == DBNull.Value ? null : (int)row[208];
            set => row[208] = value is null ? DBNull.Value : value;
        }
        public string? String208
        {
            get => row[208] == DBNull.Value ? null : (string)row[208];
            set => row[208] = value is null ? DBNull.Value : value;
        }
        public double? Double208
        {
            get => row[208] == DBNull.Value ? null : (double)row[208];
            set => row[208] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime208
        {
            get => row[208] == DBNull.Value ? null : (DateTime)row[208];
            set => row[208] = value is null ? DBNull.Value : value;
        }
        public int? Int209
        {
            get => row[209] == DBNull.Value ? null : (int)row[209];
            set => row[209] = value is null ? DBNull.Value : value;
        }
        public string? String209
        {
            get => row[209] == DBNull.Value ? null : (string)row[209];
            set => row[209] = value is null ? DBNull.Value : value;
        }
        public double? Double209
        {
            get => row[209] == DBNull.Value ? null : (double)row[209];
            set => row[209] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime209
        {
            get => row[209] == DBNull.Value ? null : (DateTime)row[209];
            set => row[209] = value is null ? DBNull.Value : value;
        }
        public int? Int210
        {
            get => row[210] == DBNull.Value ? null : (int)row[210];
            set => row[210] = value is null ? DBNull.Value : value;
        }
        public string? String210
        {
            get => row[210] == DBNull.Value ? null : (string)row[210];
            set => row[210] = value is null ? DBNull.Value : value;
        }
        public double? Double210
        {
            get => row[210] == DBNull.Value ? null : (double)row[210];
            set => row[210] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime210
        {
            get => row[210] == DBNull.Value ? null : (DateTime)row[210];
            set => row[210] = value is null ? DBNull.Value : value;
        }
        public int? Int211
        {
            get => row[211] == DBNull.Value ? null : (int)row[211];
            set => row[211] = value is null ? DBNull.Value : value;
        }
        public string? String211
        {
            get => row[211] == DBNull.Value ? null : (string)row[211];
            set => row[211] = value is null ? DBNull.Value : value;
        }
        public double? Double211
        {
            get => row[211] == DBNull.Value ? null : (double)row[211];
            set => row[211] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime211
        {
            get => row[211] == DBNull.Value ? null : (DateTime)row[211];
            set => row[211] = value is null ? DBNull.Value : value;
        }
        public int? Int212
        {
            get => row[212] == DBNull.Value ? null : (int)row[212];
            set => row[212] = value is null ? DBNull.Value : value;
        }
        public string? String212
        {
            get => row[212] == DBNull.Value ? null : (string)row[212];
            set => row[212] = value is null ? DBNull.Value : value;
        }
        public double? Double212
        {
            get => row[212] == DBNull.Value ? null : (double)row[212];
            set => row[212] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime212
        {
            get => row[212] == DBNull.Value ? null : (DateTime)row[212];
            set => row[212] = value is null ? DBNull.Value : value;
        }
        public int? Int213
        {
            get => row[213] == DBNull.Value ? null : (int)row[213];
            set => row[213] = value is null ? DBNull.Value : value;
        }
        public string? String213
        {
            get => row[213] == DBNull.Value ? null : (string)row[213];
            set => row[213] = value is null ? DBNull.Value : value;
        }
        public double? Double213
        {
            get => row[213] == DBNull.Value ? null : (double)row[213];
            set => row[213] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime213
        {
            get => row[213] == DBNull.Value ? null : (DateTime)row[213];
            set => row[213] = value is null ? DBNull.Value : value;
        }
        public int? Int214
        {
            get => row[214] == DBNull.Value ? null : (int)row[214];
            set => row[214] = value is null ? DBNull.Value : value;
        }
        public string? String214
        {
            get => row[214] == DBNull.Value ? null : (string)row[214];
            set => row[214] = value is null ? DBNull.Value : value;
        }
        public double? Double214
        {
            get => row[214] == DBNull.Value ? null : (double)row[214];
            set => row[214] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime214
        {
            get => row[214] == DBNull.Value ? null : (DateTime)row[214];
            set => row[214] = value is null ? DBNull.Value : value;
        }
        public int? Int215
        {
            get => row[215] == DBNull.Value ? null : (int)row[215];
            set => row[215] = value is null ? DBNull.Value : value;
        }
        public string? String215
        {
            get => row[215] == DBNull.Value ? null : (string)row[215];
            set => row[215] = value is null ? DBNull.Value : value;
        }
        public double? Double215
        {
            get => row[215] == DBNull.Value ? null : (double)row[215];
            set => row[215] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime215
        {
            get => row[215] == DBNull.Value ? null : (DateTime)row[215];
            set => row[215] = value is null ? DBNull.Value : value;
        }
        public int? Int216
        {
            get => row[216] == DBNull.Value ? null : (int)row[216];
            set => row[216] = value is null ? DBNull.Value : value;
        }
        public string? String216
        {
            get => row[216] == DBNull.Value ? null : (string)row[216];
            set => row[216] = value is null ? DBNull.Value : value;
        }
        public double? Double216
        {
            get => row[216] == DBNull.Value ? null : (double)row[216];
            set => row[216] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime216
        {
            get => row[216] == DBNull.Value ? null : (DateTime)row[216];
            set => row[216] = value is null ? DBNull.Value : value;
        }
        public int? Int217
        {
            get => row[217] == DBNull.Value ? null : (int)row[217];
            set => row[217] = value is null ? DBNull.Value : value;
        }
        public string? String217
        {
            get => row[217] == DBNull.Value ? null : (string)row[217];
            set => row[217] = value is null ? DBNull.Value : value;
        }
        public double? Double217
        {
            get => row[217] == DBNull.Value ? null : (double)row[217];
            set => row[217] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime217
        {
            get => row[217] == DBNull.Value ? null : (DateTime)row[217];
            set => row[217] = value is null ? DBNull.Value : value;
        }
        public int? Int218
        {
            get => row[218] == DBNull.Value ? null : (int)row[218];
            set => row[218] = value is null ? DBNull.Value : value;
        }
        public string? String218
        {
            get => row[218] == DBNull.Value ? null : (string)row[218];
            set => row[218] = value is null ? DBNull.Value : value;
        }
        public double? Double218
        {
            get => row[218] == DBNull.Value ? null : (double)row[218];
            set => row[218] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime218
        {
            get => row[218] == DBNull.Value ? null : (DateTime)row[218];
            set => row[218] = value is null ? DBNull.Value : value;
        }
        public int? Int219
        {
            get => row[219] == DBNull.Value ? null : (int)row[219];
            set => row[219] = value is null ? DBNull.Value : value;
        }
        public string? String219
        {
            get => row[219] == DBNull.Value ? null : (string)row[219];
            set => row[219] = value is null ? DBNull.Value : value;
        }
        public double? Double219
        {
            get => row[219] == DBNull.Value ? null : (double)row[219];
            set => row[219] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime219
        {
            get => row[219] == DBNull.Value ? null : (DateTime)row[219];
            set => row[219] = value is null ? DBNull.Value : value;
        }
        public int? Int220
        {
            get => row[220] == DBNull.Value ? null : (int)row[220];
            set => row[220] = value is null ? DBNull.Value : value;
        }
        public string? String220
        {
            get => row[220] == DBNull.Value ? null : (string)row[220];
            set => row[220] = value is null ? DBNull.Value : value;
        }
        public double? Double220
        {
            get => row[220] == DBNull.Value ? null : (double)row[220];
            set => row[220] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime220
        {
            get => row[220] == DBNull.Value ? null : (DateTime)row[220];
            set => row[220] = value is null ? DBNull.Value : value;
        }
        public int? Int221
        {
            get => row[221] == DBNull.Value ? null : (int)row[221];
            set => row[221] = value is null ? DBNull.Value : value;
        }
        public string? String221
        {
            get => row[221] == DBNull.Value ? null : (string)row[221];
            set => row[221] = value is null ? DBNull.Value : value;
        }
        public double? Double221
        {
            get => row[221] == DBNull.Value ? null : (double)row[221];
            set => row[221] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime221
        {
            get => row[221] == DBNull.Value ? null : (DateTime)row[221];
            set => row[221] = value is null ? DBNull.Value : value;
        }
        public int? Int222
        {
            get => row[222] == DBNull.Value ? null : (int)row[222];
            set => row[222] = value is null ? DBNull.Value : value;
        }
        public string? String222
        {
            get => row[222] == DBNull.Value ? null : (string)row[222];
            set => row[222] = value is null ? DBNull.Value : value;
        }
        public double? Double222
        {
            get => row[222] == DBNull.Value ? null : (double)row[222];
            set => row[222] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime222
        {
            get => row[222] == DBNull.Value ? null : (DateTime)row[222];
            set => row[222] = value is null ? DBNull.Value : value;
        }
        public int? Int223
        {
            get => row[223] == DBNull.Value ? null : (int)row[223];
            set => row[223] = value is null ? DBNull.Value : value;
        }
        public string? String223
        {
            get => row[223] == DBNull.Value ? null : (string)row[223];
            set => row[223] = value is null ? DBNull.Value : value;
        }
        public double? Double223
        {
            get => row[223] == DBNull.Value ? null : (double)row[223];
            set => row[223] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime223
        {
            get => row[223] == DBNull.Value ? null : (DateTime)row[223];
            set => row[223] = value is null ? DBNull.Value : value;
        }
        public int? Int224
        {
            get => row[224] == DBNull.Value ? null : (int)row[224];
            set => row[224] = value is null ? DBNull.Value : value;
        }
        public string? String224
        {
            get => row[224] == DBNull.Value ? null : (string)row[224];
            set => row[224] = value is null ? DBNull.Value : value;
        }
        public double? Double224
        {
            get => row[224] == DBNull.Value ? null : (double)row[224];
            set => row[224] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime224
        {
            get => row[224] == DBNull.Value ? null : (DateTime)row[224];
            set => row[224] = value is null ? DBNull.Value : value;
        }
        public int? Int225
        {
            get => row[225] == DBNull.Value ? null : (int)row[225];
            set => row[225] = value is null ? DBNull.Value : value;
        }
        public string? String225
        {
            get => row[225] == DBNull.Value ? null : (string)row[225];
            set => row[225] = value is null ? DBNull.Value : value;
        }
        public double? Double225
        {
            get => row[225] == DBNull.Value ? null : (double)row[225];
            set => row[225] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime225
        {
            get => row[225] == DBNull.Value ? null : (DateTime)row[225];
            set => row[225] = value is null ? DBNull.Value : value;
        }
        public int? Int226
        {
            get => row[226] == DBNull.Value ? null : (int)row[226];
            set => row[226] = value is null ? DBNull.Value : value;
        }
        public string? String226
        {
            get => row[226] == DBNull.Value ? null : (string)row[226];
            set => row[226] = value is null ? DBNull.Value : value;
        }
        public double? Double226
        {
            get => row[226] == DBNull.Value ? null : (double)row[226];
            set => row[226] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime226
        {
            get => row[226] == DBNull.Value ? null : (DateTime)row[226];
            set => row[226] = value is null ? DBNull.Value : value;
        }
        public int? Int227
        {
            get => row[227] == DBNull.Value ? null : (int)row[227];
            set => row[227] = value is null ? DBNull.Value : value;
        }
        public string? String227
        {
            get => row[227] == DBNull.Value ? null : (string)row[227];
            set => row[227] = value is null ? DBNull.Value : value;
        }
        public double? Double227
        {
            get => row[227] == DBNull.Value ? null : (double)row[227];
            set => row[227] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime227
        {
            get => row[227] == DBNull.Value ? null : (DateTime)row[227];
            set => row[227] = value is null ? DBNull.Value : value;
        }
        public int? Int228
        {
            get => row[228] == DBNull.Value ? null : (int)row[228];
            set => row[228] = value is null ? DBNull.Value : value;
        }
        public string? String228
        {
            get => row[228] == DBNull.Value ? null : (string)row[228];
            set => row[228] = value is null ? DBNull.Value : value;
        }
        public double? Double228
        {
            get => row[228] == DBNull.Value ? null : (double)row[228];
            set => row[228] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime228
        {
            get => row[228] == DBNull.Value ? null : (DateTime)row[228];
            set => row[228] = value is null ? DBNull.Value : value;
        }
        public int? Int229
        {
            get => row[229] == DBNull.Value ? null : (int)row[229];
            set => row[229] = value is null ? DBNull.Value : value;
        }
        public string? String229
        {
            get => row[229] == DBNull.Value ? null : (string)row[229];
            set => row[229] = value is null ? DBNull.Value : value;
        }
        public double? Double229
        {
            get => row[229] == DBNull.Value ? null : (double)row[229];
            set => row[229] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime229
        {
            get => row[229] == DBNull.Value ? null : (DateTime)row[229];
            set => row[229] = value is null ? DBNull.Value : value;
        }
        public int? Int230
        {
            get => row[230] == DBNull.Value ? null : (int)row[230];
            set => row[230] = value is null ? DBNull.Value : value;
        }
        public string? String230
        {
            get => row[230] == DBNull.Value ? null : (string)row[230];
            set => row[230] = value is null ? DBNull.Value : value;
        }
        public double? Double230
        {
            get => row[230] == DBNull.Value ? null : (double)row[230];
            set => row[230] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime230
        {
            get => row[230] == DBNull.Value ? null : (DateTime)row[230];
            set => row[230] = value is null ? DBNull.Value : value;
        }
        public int? Int231
        {
            get => row[231] == DBNull.Value ? null : (int)row[231];
            set => row[231] = value is null ? DBNull.Value : value;
        }
        public string? String231
        {
            get => row[231] == DBNull.Value ? null : (string)row[231];
            set => row[231] = value is null ? DBNull.Value : value;
        }
        public double? Double231
        {
            get => row[231] == DBNull.Value ? null : (double)row[231];
            set => row[231] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime231
        {
            get => row[231] == DBNull.Value ? null : (DateTime)row[231];
            set => row[231] = value is null ? DBNull.Value : value;
        }
        public int? Int232
        {
            get => row[232] == DBNull.Value ? null : (int)row[232];
            set => row[232] = value is null ? DBNull.Value : value;
        }
        public string? String232
        {
            get => row[232] == DBNull.Value ? null : (string)row[232];
            set => row[232] = value is null ? DBNull.Value : value;
        }
        public double? Double232
        {
            get => row[232] == DBNull.Value ? null : (double)row[232];
            set => row[232] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime232
        {
            get => row[232] == DBNull.Value ? null : (DateTime)row[232];
            set => row[232] = value is null ? DBNull.Value : value;
        }
        public int? Int233
        {
            get => row[233] == DBNull.Value ? null : (int)row[233];
            set => row[233] = value is null ? DBNull.Value : value;
        }
        public string? String233
        {
            get => row[233] == DBNull.Value ? null : (string)row[233];
            set => row[233] = value is null ? DBNull.Value : value;
        }
        public double? Double233
        {
            get => row[233] == DBNull.Value ? null : (double)row[233];
            set => row[233] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime233
        {
            get => row[233] == DBNull.Value ? null : (DateTime)row[233];
            set => row[233] = value is null ? DBNull.Value : value;
        }
        public int? Int234
        {
            get => row[234] == DBNull.Value ? null : (int)row[234];
            set => row[234] = value is null ? DBNull.Value : value;
        }
        public string? String234
        {
            get => row[234] == DBNull.Value ? null : (string)row[234];
            set => row[234] = value is null ? DBNull.Value : value;
        }
        public double? Double234
        {
            get => row[234] == DBNull.Value ? null : (double)row[234];
            set => row[234] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime234
        {
            get => row[234] == DBNull.Value ? null : (DateTime)row[234];
            set => row[234] = value is null ? DBNull.Value : value;
        }
        public int? Int235
        {
            get => row[235] == DBNull.Value ? null : (int)row[235];
            set => row[235] = value is null ? DBNull.Value : value;
        }
        public string? String235
        {
            get => row[235] == DBNull.Value ? null : (string)row[235];
            set => row[235] = value is null ? DBNull.Value : value;
        }
        public double? Double235
        {
            get => row[235] == DBNull.Value ? null : (double)row[235];
            set => row[235] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime235
        {
            get => row[235] == DBNull.Value ? null : (DateTime)row[235];
            set => row[235] = value is null ? DBNull.Value : value;
        }
        public int? Int236
        {
            get => row[236] == DBNull.Value ? null : (int)row[236];
            set => row[236] = value is null ? DBNull.Value : value;
        }
        public string? String236
        {
            get => row[236] == DBNull.Value ? null : (string)row[236];
            set => row[236] = value is null ? DBNull.Value : value;
        }
        public double? Double236
        {
            get => row[236] == DBNull.Value ? null : (double)row[236];
            set => row[236] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime236
        {
            get => row[236] == DBNull.Value ? null : (DateTime)row[236];
            set => row[236] = value is null ? DBNull.Value : value;
        }
        public int? Int237
        {
            get => row[237] == DBNull.Value ? null : (int)row[237];
            set => row[237] = value is null ? DBNull.Value : value;
        }
        public string? String237
        {
            get => row[237] == DBNull.Value ? null : (string)row[237];
            set => row[237] = value is null ? DBNull.Value : value;
        }
        public double? Double237
        {
            get => row[237] == DBNull.Value ? null : (double)row[237];
            set => row[237] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime237
        {
            get => row[237] == DBNull.Value ? null : (DateTime)row[237];
            set => row[237] = value is null ? DBNull.Value : value;
        }
        public int? Int238
        {
            get => row[238] == DBNull.Value ? null : (int)row[238];
            set => row[238] = value is null ? DBNull.Value : value;
        }
        public string? String238
        {
            get => row[238] == DBNull.Value ? null : (string)row[238];
            set => row[238] = value is null ? DBNull.Value : value;
        }
        public double? Double238
        {
            get => row[238] == DBNull.Value ? null : (double)row[238];
            set => row[238] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime238
        {
            get => row[238] == DBNull.Value ? null : (DateTime)row[238];
            set => row[238] = value is null ? DBNull.Value : value;
        }
        public int? Int239
        {
            get => row[239] == DBNull.Value ? null : (int)row[239];
            set => row[239] = value is null ? DBNull.Value : value;
        }
        public string? String239
        {
            get => row[239] == DBNull.Value ? null : (string)row[239];
            set => row[239] = value is null ? DBNull.Value : value;
        }
        public double? Double239
        {
            get => row[239] == DBNull.Value ? null : (double)row[239];
            set => row[239] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime239
        {
            get => row[239] == DBNull.Value ? null : (DateTime)row[239];
            set => row[239] = value is null ? DBNull.Value : value;
        }
        public int? Int240
        {
            get => row[240] == DBNull.Value ? null : (int)row[240];
            set => row[240] = value is null ? DBNull.Value : value;
        }
        public string? String240
        {
            get => row[240] == DBNull.Value ? null : (string)row[240];
            set => row[240] = value is null ? DBNull.Value : value;
        }
        public double? Double240
        {
            get => row[240] == DBNull.Value ? null : (double)row[240];
            set => row[240] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime240
        {
            get => row[240] == DBNull.Value ? null : (DateTime)row[240];
            set => row[240] = value is null ? DBNull.Value : value;
        }
        public int? Int241
        {
            get => row[241] == DBNull.Value ? null : (int)row[241];
            set => row[241] = value is null ? DBNull.Value : value;
        }
        public string? String241
        {
            get => row[241] == DBNull.Value ? null : (string)row[241];
            set => row[241] = value is null ? DBNull.Value : value;
        }
        public double? Double241
        {
            get => row[241] == DBNull.Value ? null : (double)row[241];
            set => row[241] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime241
        {
            get => row[241] == DBNull.Value ? null : (DateTime)row[241];
            set => row[241] = value is null ? DBNull.Value : value;
        }
        public int? Int242
        {
            get => row[242] == DBNull.Value ? null : (int)row[242];
            set => row[242] = value is null ? DBNull.Value : value;
        }
        public string? String242
        {
            get => row[242] == DBNull.Value ? null : (string)row[242];
            set => row[242] = value is null ? DBNull.Value : value;
        }
        public double? Double242
        {
            get => row[242] == DBNull.Value ? null : (double)row[242];
            set => row[242] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime242
        {
            get => row[242] == DBNull.Value ? null : (DateTime)row[242];
            set => row[242] = value is null ? DBNull.Value : value;
        }
        public int? Int243
        {
            get => row[243] == DBNull.Value ? null : (int)row[243];
            set => row[243] = value is null ? DBNull.Value : value;
        }
        public string? String243
        {
            get => row[243] == DBNull.Value ? null : (string)row[243];
            set => row[243] = value is null ? DBNull.Value : value;
        }
        public double? Double243
        {
            get => row[243] == DBNull.Value ? null : (double)row[243];
            set => row[243] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime243
        {
            get => row[243] == DBNull.Value ? null : (DateTime)row[243];
            set => row[243] = value is null ? DBNull.Value : value;
        }
        public int? Int244
        {
            get => row[244] == DBNull.Value ? null : (int)row[244];
            set => row[244] = value is null ? DBNull.Value : value;
        }
        public string? String244
        {
            get => row[244] == DBNull.Value ? null : (string)row[244];
            set => row[244] = value is null ? DBNull.Value : value;
        }
        public double? Double244
        {
            get => row[244] == DBNull.Value ? null : (double)row[244];
            set => row[244] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime244
        {
            get => row[244] == DBNull.Value ? null : (DateTime)row[244];
            set => row[244] = value is null ? DBNull.Value : value;
        }
        public int? Int245
        {
            get => row[245] == DBNull.Value ? null : (int)row[245];
            set => row[245] = value is null ? DBNull.Value : value;
        }
        public string? String245
        {
            get => row[245] == DBNull.Value ? null : (string)row[245];
            set => row[245] = value is null ? DBNull.Value : value;
        }
        public double? Double245
        {
            get => row[245] == DBNull.Value ? null : (double)row[245];
            set => row[245] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime245
        {
            get => row[245] == DBNull.Value ? null : (DateTime)row[245];
            set => row[245] = value is null ? DBNull.Value : value;
        }
        public int? Int246
        {
            get => row[246] == DBNull.Value ? null : (int)row[246];
            set => row[246] = value is null ? DBNull.Value : value;
        }
        public string? String246
        {
            get => row[246] == DBNull.Value ? null : (string)row[246];
            set => row[246] = value is null ? DBNull.Value : value;
        }
        public double? Double246
        {
            get => row[246] == DBNull.Value ? null : (double)row[246];
            set => row[246] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime246
        {
            get => row[246] == DBNull.Value ? null : (DateTime)row[246];
            set => row[246] = value is null ? DBNull.Value : value;
        }
        public int? Int247
        {
            get => row[247] == DBNull.Value ? null : (int)row[247];
            set => row[247] = value is null ? DBNull.Value : value;
        }
        public string? String247
        {
            get => row[247] == DBNull.Value ? null : (string)row[247];
            set => row[247] = value is null ? DBNull.Value : value;
        }
        public double? Double247
        {
            get => row[247] == DBNull.Value ? null : (double)row[247];
            set => row[247] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime247
        {
            get => row[247] == DBNull.Value ? null : (DateTime)row[247];
            set => row[247] = value is null ? DBNull.Value : value;
        }
        public int? Int248
        {
            get => row[248] == DBNull.Value ? null : (int)row[248];
            set => row[248] = value is null ? DBNull.Value : value;
        }
        public string? String248
        {
            get => row[248] == DBNull.Value ? null : (string)row[248];
            set => row[248] = value is null ? DBNull.Value : value;
        }
        public double? Double248
        {
            get => row[248] == DBNull.Value ? null : (double)row[248];
            set => row[248] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime248
        {
            get => row[248] == DBNull.Value ? null : (DateTime)row[248];
            set => row[248] = value is null ? DBNull.Value : value;
        }
        public int? Int249
        {
            get => row[249] == DBNull.Value ? null : (int)row[249];
            set => row[249] = value is null ? DBNull.Value : value;
        }
        public string? String249
        {
            get => row[249] == DBNull.Value ? null : (string)row[249];
            set => row[249] = value is null ? DBNull.Value : value;
        }
        public double? Double249
        {
            get => row[249] == DBNull.Value ? null : (double)row[249];
            set => row[249] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime249
        {
            get => row[249] == DBNull.Value ? null : (DateTime)row[249];
            set => row[249] = value is null ? DBNull.Value : value;
        }
        public int? Int250
        {
            get => row[250] == DBNull.Value ? null : (int)row[250];
            set => row[250] = value is null ? DBNull.Value : value;
        }
        public string? String250
        {
            get => row[250] == DBNull.Value ? null : (string)row[250];
            set => row[250] = value is null ? DBNull.Value : value;
        }
        public double? Double250
        {
            get => row[250] == DBNull.Value ? null : (double)row[250];
            set => row[250] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime250
        {
            get => row[250] == DBNull.Value ? null : (DateTime)row[250];
            set => row[250] = value is null ? DBNull.Value : value;
        }
        public int? Int251
        {
            get => row[251] == DBNull.Value ? null : (int)row[251];
            set => row[251] = value is null ? DBNull.Value : value;
        }
        public string? String251
        {
            get => row[251] == DBNull.Value ? null : (string)row[251];
            set => row[251] = value is null ? DBNull.Value : value;
        }
        public double? Double251
        {
            get => row[251] == DBNull.Value ? null : (double)row[251];
            set => row[251] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime251
        {
            get => row[251] == DBNull.Value ? null : (DateTime)row[251];
            set => row[251] = value is null ? DBNull.Value : value;
        }
        public int? Int252
        {
            get => row[252] == DBNull.Value ? null : (int)row[252];
            set => row[252] = value is null ? DBNull.Value : value;
        }
        public string? String252
        {
            get => row[252] == DBNull.Value ? null : (string)row[252];
            set => row[252] = value is null ? DBNull.Value : value;
        }
        public double? Double252
        {
            get => row[252] == DBNull.Value ? null : (double)row[252];
            set => row[252] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime252
        {
            get => row[252] == DBNull.Value ? null : (DateTime)row[252];
            set => row[252] = value is null ? DBNull.Value : value;
        }
        public int? Int253
        {
            get => row[253] == DBNull.Value ? null : (int)row[253];
            set => row[253] = value is null ? DBNull.Value : value;
        }
        public string? String253
        {
            get => row[253] == DBNull.Value ? null : (string)row[253];
            set => row[253] = value is null ? DBNull.Value : value;
        }
        public double? Double253
        {
            get => row[253] == DBNull.Value ? null : (double)row[253];
            set => row[253] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime253
        {
            get => row[253] == DBNull.Value ? null : (DateTime)row[253];
            set => row[253] = value is null ? DBNull.Value : value;
        }
        public int? Int254
        {
            get => row[254] == DBNull.Value ? null : (int)row[254];
            set => row[254] = value is null ? DBNull.Value : value;
        }
        public string? String254
        {
            get => row[254] == DBNull.Value ? null : (string)row[254];
            set => row[254] = value is null ? DBNull.Value : value;
        }
        public double? Double254
        {
            get => row[254] == DBNull.Value ? null : (double)row[254];
            set => row[254] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime254
        {
            get => row[254] == DBNull.Value ? null : (DateTime)row[254];
            set => row[254] = value is null ? DBNull.Value : value;
        }
        public int? Int255
        {
            get => row[255] == DBNull.Value ? null : (int)row[255];
            set => row[255] = value is null ? DBNull.Value : value;
        }
        public string? String255
        {
            get => row[255] == DBNull.Value ? null : (string)row[255];
            set => row[255] = value is null ? DBNull.Value : value;
        }
        public double? Double255
        {
            get => row[255] == DBNull.Value ? null : (double)row[255];
            set => row[255] = value is null ? DBNull.Value : value;
        }
        public DateTime? DateTime255
        {
            get => row[255] == DBNull.Value ? null : (DateTime)row[255];
            set => row[255] = value is null ? DBNull.Value : value;
        }

    }
}
