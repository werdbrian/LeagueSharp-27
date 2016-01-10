using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClipperLib;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;

namespace NavMeshRemake
{
    using Polygon = System.Collections.Generic.List<IntPoint>;
    using PolygonSet = System.Collections.Generic.List<System.Collections.Generic.List<IntPoint>>;
    public static class StorageClass
    {
        public static PolygonSet unitCollisionPolygonSet = new PolygonSet() { new Polygon() { new IntPoint(16000, 16000), new IntPoint(0, 16000), new IntPoint(0, 0), new IntPoint(16000, 0) }, new Polygon() { new
IntPoint(215, 115), new IntPoint(215, 215), new IntPoint(115, 215), new IntPoint(115, 265), new IntPoint(15, 265), new IntPoint(15, 685), new IntPoint(65, 685), new IntPoint(65, 735), new IntPoint(89,
735), new IntPoint(89, 743), new IntPoint(115, 743), new IntPoint(115, 785), new IntPoint(139, 785), new IntPoint(139, 793), new IntPoint(209, 793), new IntPoint(209, 785), new IntPoint(215, 785), new
IntPoint(215, 835), new IntPoint(239, 835), new IntPoint(239, 843), new IntPoint(309, 843), new IntPoint(309, 835), new IntPoint(315, 835), new IntPoint(315, 885), new IntPoint(339, 885), new
IntPoint(339, 893), new IntPoint(365, 893), new IntPoint(365, 935), new IntPoint(389, 935), new IntPoint(389, 943), new IntPoint(415, 943), new IntPoint(415, 1085), new IntPoint(439, 1085), new
IntPoint(439, 1093), new IntPoint(465, 1093), new IntPoint(465, 4185), new IntPoint(489, 4185), new IntPoint(489, 4193), new IntPoint(515, 4193), new IntPoint(515, 4385), new IntPoint(539, 4385), new
IntPoint(539, 4393), new IntPoint(565, 4393), new IntPoint(565, 4535), new IntPoint(589, 4535), new IntPoint(589, 4543), new IntPoint(615, 4543), new IntPoint(615, 4735), new IntPoint(639, 4735), new
IntPoint(639, 4743), new IntPoint(665, 4743), new IntPoint(665, 5135), new IntPoint(689, 5135), new IntPoint(689, 5143), new IntPoint(715, 5143), new IntPoint(715, 5815), new IntPoint(665, 5815), new
IntPoint(665, 9385), new IntPoint(689, 9385), new IntPoint(689, 9391), new IntPoint(715, 9391), new IntPoint(715, 10835), new IntPoint(739, 10835), new IntPoint(739, 10841), new IntPoint(765, 10841),
new IntPoint(765, 11135), new IntPoint(789, 11135), new IntPoint(789, 11141), new IntPoint(815, 11141), new IntPoint(815, 11485), new IntPoint(839, 11485), new IntPoint(839, 11491), new IntPoint(865,
11491), new IntPoint(865, 11835), new IntPoint(889, 11835), new IntPoint(889, 11841), new IntPoint(915, 11841), new IntPoint(915, 12035), new IntPoint(939, 12035), new IntPoint(939, 12041), new
IntPoint(965, 12041), new IntPoint(965, 12285), new IntPoint(989, 12285), new IntPoint(989, 12291), new IntPoint(1015, 12291), new IntPoint(1015, 12435), new IntPoint(1039, 12435), new IntPoint(1039,
12441), new IntPoint(1065, 12441), new IntPoint(1065, 12535), new IntPoint(1089, 12535), new IntPoint(1089, 12541), new IntPoint(1115, 12541), new IntPoint(1115, 12635), new IntPoint(1139, 12635), new
IntPoint(1139, 12641), new IntPoint(1165, 12641), new IntPoint(1165, 12735), new IntPoint(1189, 12735), new IntPoint(1189, 12741), new IntPoint(1215, 12741), new IntPoint(1215, 12835), new
IntPoint(1239, 12835), new IntPoint(1239, 12841), new IntPoint(1265, 12841), new IntPoint(1265, 12885), new IntPoint(1289, 12885), new IntPoint(1289, 12891), new IntPoint(1315, 12891), new
IntPoint(1315, 12935), new IntPoint(1339, 12935), new IntPoint(1339, 12941), new IntPoint(1365, 12941), new IntPoint(1365, 12985), new IntPoint(1389, 12985), new IntPoint(1389, 12991), new
IntPoint(1415, 12991), new IntPoint(1415, 13035), new IntPoint(1439, 13035), new IntPoint(1439, 13041), new IntPoint(1465, 13041), new IntPoint(1465, 13085), new IntPoint(1489, 13085), new
IntPoint(1489, 13091), new IntPoint(1515, 13091), new IntPoint(1515, 13135), new IntPoint(1539, 13135), new IntPoint(1539, 13141), new IntPoint(1565, 13141), new IntPoint(1565, 13185), new
IntPoint(1589, 13185), new IntPoint(1589, 13191), new IntPoint(1615, 13191), new IntPoint(1615, 13235), new IntPoint(1639, 13235), new IntPoint(1639, 13241), new IntPoint(1665, 13241), new
IntPoint(1665, 13285), new IntPoint(1689, 13285), new IntPoint(1689, 13291), new IntPoint(1715, 13291), new IntPoint(1715, 13335), new IntPoint(1739, 13335), new IntPoint(1739, 13341), new
IntPoint(1815, 13341), new IntPoint(1815, 13385), new IntPoint(1839, 13385), new IntPoint(1839, 13391), new IntPoint(1865, 13391), new IntPoint(1865, 13435), new IntPoint(1889, 13435), new
IntPoint(1889, 13441), new IntPoint(1965, 13441), new IntPoint(1965, 13485), new IntPoint(1989, 13485), new IntPoint(1989, 13491), new IntPoint(2015, 13491), new IntPoint(2015, 13535), new
IntPoint(2039, 13535), new IntPoint(2039, 13541), new IntPoint(2115, 13541), new IntPoint(2115, 13585), new IntPoint(2139, 13585), new IntPoint(2139, 13591), new IntPoint(2165, 13591), new
IntPoint(2165, 13635), new IntPoint(2189, 13635), new IntPoint(2189, 13641), new IntPoint(2265, 13641), new IntPoint(2265, 13685), new IntPoint(2289, 13685), new IntPoint(2289, 13691), new
IntPoint(2365, 13691), new IntPoint(2365, 13735), new IntPoint(2389, 13735), new IntPoint(2389, 13741), new IntPoint(2465, 13741), new IntPoint(2465, 13785), new IntPoint(2489, 13785), new
IntPoint(2489, 13791), new IntPoint(2609, 13791), new IntPoint(2609, 13785), new IntPoint(2639, 13785), new IntPoint(2639, 13791), new IntPoint(2665, 13791), new IntPoint(2665, 13835), new
IntPoint(2689, 13835), new IntPoint(2689, 13841), new IntPoint(2759, 13841), new IntPoint(2759, 13835), new IntPoint(2789, 13835), new IntPoint(2789, 13841), new IntPoint(2815, 13841), new
IntPoint(2815, 13885), new IntPoint(2839, 13885), new IntPoint(2839, 13891), new IntPoint(2909, 13891), new IntPoint(2909, 13885), new IntPoint(2939, 13885), new IntPoint(2939, 13891), new
IntPoint(2965, 13891), new IntPoint(2965, 13935), new IntPoint(2989, 13935), new IntPoint(2989, 13941), new IntPoint(3109, 13941), new IntPoint(3109, 13935), new IntPoint(3139, 13935), new
IntPoint(3139, 13941), new IntPoint(3165, 13941), new IntPoint(3165, 13985), new IntPoint(3189, 13985), new IntPoint(3189, 13991), new IntPoint(3309, 13991), new IntPoint(3309, 13985), new
IntPoint(3339, 13985), new IntPoint(3339, 13991), new IntPoint(3365, 13991), new IntPoint(3365, 14035), new IntPoint(3389, 14035), new IntPoint(3389, 14041), new IntPoint(3809, 14041), new
IntPoint(3809, 14035), new IntPoint(3839, 14035), new IntPoint(3839, 14041), new IntPoint(3865, 14041), new IntPoint(3865, 14085), new IntPoint(3889, 14085), new IntPoint(3889, 14091), new
IntPoint(4759, 14091), new IntPoint(4759, 14085), new IntPoint(4789, 14085), new IntPoint(4789, 14091), new IntPoint(4815, 14091), new IntPoint(4815, 14135), new IntPoint(4839, 14135), new
IntPoint(4839, 14141), new IntPoint(7907, 14141), new IntPoint(7907, 14135), new IntPoint(7937, 14135), new IntPoint(7937, 14141), new IntPoint(7963, 14141), new IntPoint(7963, 14185), new
IntPoint(7987, 14185), new IntPoint(7987, 14191), new IntPoint(9457, 14191), new IntPoint(9457, 14141), new IntPoint(9857, 14141), new IntPoint(9857, 14135), new IntPoint(9887, 14135), new
IntPoint(9887, 14141), new IntPoint(9913, 14141), new IntPoint(9913, 14185), new IntPoint(9937, 14185), new IntPoint(9937, 14191), new IntPoint(10257, 14191), new IntPoint(10257, 14185), new
IntPoint(10287, 14185), new IntPoint(10287, 14191), new IntPoint(10313, 14191), new IntPoint(10313, 14235), new IntPoint(10337, 14235), new IntPoint(10337, 14241), new IntPoint(10363, 14241), new
IntPoint(10363, 14285), new IntPoint(10387, 14285), new IntPoint(10387, 14291), new IntPoint(10413, 14291), new IntPoint(10413, 14335), new IntPoint(10437, 14335), new IntPoint(10437, 14341), new
IntPoint(10513, 14341), new IntPoint(10513, 14385), new IntPoint(10537, 14385), new IntPoint(10537, 14391), new IntPoint(13357, 14391), new IntPoint(13357, 14341), new IntPoint(13757, 14341), new
IntPoint(13757, 14335), new IntPoint(13787, 14335), new IntPoint(13787, 14341), new IntPoint(13813, 14341), new IntPoint(13813, 14385), new IntPoint(13837, 14385), new IntPoint(13837, 14391), new
IntPoint(13863, 14391), new IntPoint(13863, 14435), new IntPoint(13887, 14435), new IntPoint(13887, 14441), new IntPoint(13913, 14441), new IntPoint(13913, 14485), new IntPoint(13937, 14485), new
IntPoint(13937, 14491), new IntPoint(13963, 14491), new IntPoint(13963, 14535), new IntPoint(13987, 14535), new IntPoint(13987, 14541), new IntPoint(14013, 14541), new IntPoint(14013, 14735), new
IntPoint(14037, 14735), new IntPoint(14037, 14741), new IntPoint(14063, 14741), new IntPoint(14063, 14775), new IntPoint(14383, 14775), new IntPoint(14383, 14741), new IntPoint(14457, 14741), new
IntPoint(14457, 14691), new IntPoint(14507, 14691), new IntPoint(14507, 14591), new IntPoint(14607, 14591), new IntPoint(14607, 14541), new IntPoint(14657, 14541), new IntPoint(14657, 14535), new
IntPoint(14701, 14535), new IntPoint(14701, 14415), new IntPoint(14657, 14415), new IntPoint(14657, 14371), new IntPoint(14633, 14371), new IntPoint(14633, 14365), new IntPoint(14607, 14365), new
IntPoint(14607, 14341), new IntPoint(14657, 14341), new IntPoint(14657, 14335), new IntPoint(14701, 14335), new IntPoint(14701, 14165), new IntPoint(14657, 14165), new IntPoint(14657, 14121), new
IntPoint(14633, 14121), new IntPoint(14633, 14115), new IntPoint(14607, 14115), new IntPoint(14607, 14071), new IntPoint(14583, 14071), new IntPoint(14583, 14065), new IntPoint(14557, 14065), new
IntPoint(14557, 14021), new IntPoint(14533, 14021), new IntPoint(14533, 14015), new IntPoint(14507, 14015), new IntPoint(14507, 13921), new IntPoint(14483, 13921), new IntPoint(14483, 13915), new
IntPoint(14457, 13915), new IntPoint(14457, 13821), new IntPoint(14433, 13821), new IntPoint(14433, 13815), new IntPoint(14407, 13815), new IntPoint(14407, 13671), new IntPoint(14383, 13671), new
IntPoint(14383, 13665), new IntPoint(14357, 13665), new IntPoint(14357, 12271), new IntPoint(14333, 12271), new IntPoint(14333, 12265), new IntPoint(14307, 12265), new IntPoint(14307, 10671), new
IntPoint(14283, 10671), new IntPoint(14283, 10665), new IntPoint(14257, 10665), new IntPoint(14257, 10371), new IntPoint(14233, 10371), new IntPoint(14233, 10365), new IntPoint(14207, 10365), new
IntPoint(14207, 10221), new IntPoint(14183, 10221), new IntPoint(14183, 10215), new IntPoint(14157, 10215), new IntPoint(14157, 9471), new IntPoint(14133, 9471), new IntPoint(14133, 9465), new
IntPoint(14107, 9465), new IntPoint(14107, 8991), new IntPoint(14157, 8991), new IntPoint(14157, 4373), new IntPoint(14133, 4373), new IntPoint(14133, 4365), new IntPoint(14107, 4365), new
IntPoint(14107, 3973), new IntPoint(14083, 3973), new IntPoint(14083, 3965), new IntPoint(14057, 3965), new IntPoint(14057, 3773), new IntPoint(14033, 3773), new IntPoint(14033, 3765), new
IntPoint(14007, 3765), new IntPoint(14007, 3623), new IntPoint(13983, 3623), new IntPoint(13983, 3615), new IntPoint(13957, 3615), new IntPoint(13957, 3323), new IntPoint(13933, 3323), new
IntPoint(13933, 3315), new IntPoint(13907, 3315), new IntPoint(13907, 3223), new IntPoint(13883, 3223), new IntPoint(13883, 3215), new IntPoint(13857, 3215), new IntPoint(13857, 3073), new
IntPoint(13833, 3073), new IntPoint(13833, 3065), new IntPoint(13807, 3065), new IntPoint(13807, 2923), new IntPoint(13783, 2923), new IntPoint(13783, 2915), new IntPoint(13757, 2915), new
IntPoint(13757, 2773), new IntPoint(13733, 2773), new IntPoint(13733, 2765), new IntPoint(13707, 2765), new IntPoint(13707, 2673), new IntPoint(13683, 2673), new IntPoint(13683, 2665), new
IntPoint(13657, 2665), new IntPoint(13657, 2573), new IntPoint(13633, 2573), new IntPoint(13633, 2565), new IntPoint(13607, 2565), new IntPoint(13607, 2473), new IntPoint(13583, 2473), new
IntPoint(13583, 2465), new IntPoint(13557, 2465), new IntPoint(13557, 2423), new IntPoint(13533, 2423), new IntPoint(13533, 2415), new IntPoint(13507, 2415), new IntPoint(13507, 2323), new
IntPoint(13483, 2323), new IntPoint(13483, 2315), new IntPoint(13457, 2315), new IntPoint(13457, 2273), new IntPoint(13433, 2273), new IntPoint(13433, 2265), new IntPoint(13407, 2265), new
IntPoint(13407, 2173), new IntPoint(13383, 2173), new IntPoint(13383, 2165), new IntPoint(13357, 2165), new IntPoint(13357, 2123), new IntPoint(13333, 2123), new IntPoint(13333, 2115), new
IntPoint(13307, 2115), new IntPoint(13307, 2073), new IntPoint(13283, 2073), new IntPoint(13283, 2065), new IntPoint(13257, 2065), new IntPoint(13257, 1973), new IntPoint(13233, 1973), new
IntPoint(13233, 1965), new IntPoint(13207, 1965), new IntPoint(13207, 1923), new IntPoint(13183, 1923), new IntPoint(13183, 1915), new IntPoint(13157, 1915), new IntPoint(13157, 1873), new
IntPoint(13133, 1873), new IntPoint(13133, 1865), new IntPoint(13107, 1865), new IntPoint(13107, 1823), new IntPoint(13083, 1823), new IntPoint(13083, 1815), new IntPoint(13057, 1815), new
IntPoint(13057, 1773), new IntPoint(13033, 1773), new IntPoint(13033, 1765), new IntPoint(13007, 1765), new IntPoint(13007, 1723), new IntPoint(12983, 1723), new IntPoint(12983, 1715), new
IntPoint(12957, 1715), new IntPoint(12957, 1673), new IntPoint(12933, 1673), new IntPoint(12933, 1665), new IntPoint(12907, 1665), new IntPoint(12907, 1623), new IntPoint(12883, 1623), new
IntPoint(12883, 1615), new IntPoint(12857, 1615), new IntPoint(12857, 1573), new IntPoint(12833, 1573), new IntPoint(12833, 1565), new IntPoint(12807, 1565), new IntPoint(12807, 1523), new
IntPoint(12783, 1523), new IntPoint(12783, 1515), new IntPoint(12757, 1515), new IntPoint(12757, 1473), new IntPoint(12733, 1473), new IntPoint(12733, 1465), new IntPoint(12707, 1465), new
IntPoint(12707, 1423), new IntPoint(12683, 1423), new IntPoint(12683, 1415), new IntPoint(12657, 1415), new IntPoint(12657, 1373), new IntPoint(12633, 1373), new IntPoint(12633, 1365), new
IntPoint(12607, 1365), new IntPoint(12607, 1323), new IntPoint(12583, 1323), new IntPoint(12583, 1315), new IntPoint(12507, 1315), new IntPoint(12507, 1273), new IntPoint(12483, 1273), new
IntPoint(12483, 1265), new IntPoint(12457, 1265), new IntPoint(12457, 1223), new IntPoint(12433, 1223), new IntPoint(12433, 1215), new IntPoint(12357, 1215), new IntPoint(12357, 1173), new
IntPoint(12333, 1173), new IntPoint(12333, 1165), new IntPoint(12307, 1165), new IntPoint(12307, 1123), new IntPoint(12283, 1123), new IntPoint(12283, 1115), new IntPoint(12107, 1115), new
IntPoint(12107, 1073), new IntPoint(12083, 1073), new IntPoint(12083, 1065), new IntPoint(11907, 1065), new IntPoint(11907, 1023), new IntPoint(11883, 1023), new IntPoint(11883, 1015), new
IntPoint(11757, 1015), new IntPoint(11757, 973), new IntPoint(11733, 973), new IntPoint(11733, 965), new IntPoint(11607, 965), new IntPoint(11607, 923), new IntPoint(11583, 923), new IntPoint(11583,
915), new IntPoint(11407, 915), new IntPoint(11407, 873), new IntPoint(11383, 873), new IntPoint(11383, 865), new IntPoint(10857, 865), new IntPoint(10857, 823), new IntPoint(10833, 823), new
IntPoint(10833, 815), new IntPoint(10457, 815), new IntPoint(10457, 773), new IntPoint(10433, 773), new IntPoint(10433, 765), new IntPoint(8707, 765), new IntPoint(8707, 723), new IntPoint(8683, 723),
new IntPoint(8683, 715), new IntPoint(4909, 715), new IntPoint(4909, 673), new IntPoint(4885, 673), new IntPoint(4885, 665), new IntPoint(4809, 665), new IntPoint(4809, 623), new IntPoint(4785, 623),
new IntPoint(4785, 615), new IntPoint(4759, 615), new IntPoint(4759, 573), new IntPoint(4735, 573), new IntPoint(4735, 565), new IntPoint(4659, 565), new IntPoint(4659, 523), new IntPoint(4635, 523),
new IntPoint(4635, 515), new IntPoint(1309, 515), new IntPoint(1309, 473), new IntPoint(1285, 473), new IntPoint(1285, 465), new IntPoint(1209, 465), new IntPoint(1209, 423), new IntPoint(1185, 423),
new IntPoint(1185, 415), new IntPoint(1109, 415), new IntPoint(1109, 373), new IntPoint(1085, 373), new IntPoint(1085, 365), new IntPoint(1009, 365), new IntPoint(1009, 323), new IntPoint(985, 323),
new IntPoint(985, 315), new IntPoint(909, 315), new IntPoint(909, 273), new IntPoint(885, 273), new IntPoint(885, 265), new IntPoint(859, 265), new IntPoint(859, 223), new IntPoint(835, 223), new
IntPoint(835, 215), new IntPoint(759, 215), new IntPoint(759, 173), new IntPoint(735, 173), new IntPoint(735, 165), new IntPoint(709, 165), new IntPoint(709, 123), new IntPoint(685, 123), new
IntPoint(685, 115) }, new Polygon() { new IntPoint(4315, 13785), new IntPoint(4339, 13785), new IntPoint(4339, 13791), new IntPoint(4365, 13791), new IntPoint(4365, 13835), new IntPoint(4389, 13835),
new IntPoint(4389, 13841), new IntPoint(4415, 13841), new IntPoint(4415, 13915), new IntPoint(4365, 13915), new IntPoint(4365, 13965), new IntPoint(4259, 13965), new IntPoint(4259, 13921), new
IntPoint(4235, 13921), new IntPoint(4235, 13915), new IntPoint(4209, 13915), new IntPoint(4209, 13821), new IntPoint(4185, 13821), new IntPoint(4185, 13785), new IntPoint(4189, 13785), new
IntPoint(4189, 13791), new IntPoint(4309, 13791), new IntPoint(4309, 13741), new IntPoint(4315, 13741) }, new Polygon() { new IntPoint(11337, 13491), new IntPoint(11363, 13491), new IntPoint(11363,
13535), new IntPoint(11387, 13535), new IntPoint(11387, 13541), new IntPoint(11413, 13541), new IntPoint(11413, 13635), new IntPoint(11437, 13635), new IntPoint(11437, 13641), new IntPoint(11463,
13641), new IntPoint(11463, 13665), new IntPoint(11413, 13665), new IntPoint(11413, 13815), new IntPoint(11363, 13815), new IntPoint(11363, 13865), new IntPoint(11157, 13865), new IntPoint(11157,
13821), new IntPoint(11133, 13821), new IntPoint(11133, 13815), new IntPoint(11107, 13815), new IntPoint(11107, 13771), new IntPoint(11083, 13771), new IntPoint(11083, 13765), new IntPoint(11057,
13765), new IntPoint(11057, 13621), new IntPoint(11033, 13621), new IntPoint(11033, 13585), new IntPoint(11037, 13585), new IntPoint(11037, 13591), new IntPoint(11107, 13591), new IntPoint(11107,
13541), new IntPoint(11157, 13541), new IntPoint(11157, 13491), new IntPoint(11307, 13491), new IntPoint(11307, 13485), new IntPoint(11337, 13485) }, new Polygon() { new IntPoint(10537, 13541), new
IntPoint(10563, 13541), new IntPoint(10563, 13715), new IntPoint(10513, 13715), new IntPoint(10513, 13765), new IntPoint(10407, 13765), new IntPoint(10407, 13721), new IntPoint(10383, 13721), new
IntPoint(10383, 13715), new IntPoint(10357, 13715), new IntPoint(10357, 13621), new IntPoint(10333, 13621), new IntPoint(10333, 13585), new IntPoint(10337, 13585), new IntPoint(10337, 13591), new
IntPoint(10407, 13591), new IntPoint(10407, 13541), new IntPoint(10507, 13541), new IntPoint(10507, 13535), new IntPoint(10537, 13535) }, new Polygon() { new IntPoint(13337, 12891), new
IntPoint(13363, 12891), new IntPoint(13363, 12935), new IntPoint(13387, 12935), new IntPoint(13387, 12941), new IntPoint(13413, 12941), new IntPoint(13413, 12985), new IntPoint(13437, 12985), new
IntPoint(13437, 12991), new IntPoint(13463, 12991), new IntPoint(13463, 13035), new IntPoint(13487, 13035), new IntPoint(13487, 13041), new IntPoint(13513, 13041), new IntPoint(13513, 13135), new
IntPoint(13537, 13135), new IntPoint(13537, 13141), new IntPoint(13563, 13141), new IntPoint(13563, 13365), new IntPoint(13513, 13365), new IntPoint(13513, 13415), new IntPoint(13463, 13415), new
IntPoint(13463, 13465), new IntPoint(13413, 13465), new IntPoint(13413, 13515), new IntPoint(13363, 13515), new IntPoint(13363, 13565), new IntPoint(13107, 13565), new IntPoint(13107, 13521), new
IntPoint(13083, 13521), new IntPoint(13083, 13515), new IntPoint(13007, 13515), new IntPoint(13007, 13471), new IntPoint(12983, 13471), new IntPoint(12983, 13465), new IntPoint(12957, 13465), new
IntPoint(12957, 13371), new IntPoint(12933, 13371), new IntPoint(12933, 13365), new IntPoint(12907, 13365), new IntPoint(12907, 13091), new IntPoint(12957, 13091), new IntPoint(12957, 12991), new
IntPoint(13057, 12991), new IntPoint(13057, 12941), new IntPoint(13107, 12941), new IntPoint(13107, 12891), new IntPoint(13307, 12891), new IntPoint(13307, 12885), new IntPoint(13337, 12885) }, new
Polygon() { new IntPoint(7987, 13291), new IntPoint(8013, 13291), new IntPoint(8013, 13385), new IntPoint(8037, 13385), new IntPoint(8037, 13391), new IntPoint(8063, 13391), new IntPoint(8063, 13465),
new IntPoint(8013, 13465), new IntPoint(8013, 13515), new IntPoint(7857, 13515), new IntPoint(7857, 13471), new IntPoint(7833, 13471), new IntPoint(7833, 13465), new IntPoint(7807, 13465), new
IntPoint(7807, 13371), new IntPoint(7783, 13371), new IntPoint(7783, 13335), new IntPoint(7787, 13335), new IntPoint(7787, 13341), new IntPoint(7857, 13341), new IntPoint(7857, 13291), new
IntPoint(7957, 13291), new IntPoint(7957, 13285), new IntPoint(7987, 13285) }, new Polygon() { new IntPoint(10387, 11091), new IntPoint(10413, 11091), new IntPoint(10413, 11135), new IntPoint(10437,
11135), new IntPoint(10437, 11141), new IntPoint(10463, 11141), new IntPoint(10463, 11315), new IntPoint(10413, 11315), new IntPoint(10413, 11415), new IntPoint(10363, 11415), new IntPoint(10363,
11465), new IntPoint(10313, 11465), new IntPoint(10313, 11565), new IntPoint(10263, 11565), new IntPoint(10263, 11765), new IntPoint(10213, 11765), new IntPoint(10213, 11915), new IntPoint(10163,
11915), new IntPoint(10163, 11965), new IntPoint(10113, 11965), new IntPoint(10113, 12315), new IntPoint(10063, 12315), new IntPoint(10063, 13165), new IntPoint(10013, 13165), new IntPoint(10013,
13215), new IntPoint(9857, 13215), new IntPoint(9857, 13171), new IntPoint(9833, 13171), new IntPoint(9833, 13165), new IntPoint(9807, 13165), new IntPoint(9807, 12371), new IntPoint(9783, 12371), new
IntPoint(9783, 12335), new IntPoint(9787, 12335), new IntPoint(9787, 12341), new IntPoint(9857, 12341), new IntPoint(9857, 12291), new IntPoint(9907, 12291), new IntPoint(9907, 11971), new
IntPoint(9883, 11971), new IntPoint(9883, 11935), new IntPoint(9887, 11935), new IntPoint(9887, 11941), new IntPoint(9957, 11941), new IntPoint(9957, 11821), new IntPoint(9933, 11821), new
IntPoint(9933, 11785), new IntPoint(9937, 11785), new IntPoint(9937, 11791), new IntPoint(10007, 11791), new IntPoint(10007, 11621), new IntPoint(9983, 11621), new IntPoint(9983, 11585), new
IntPoint(9987, 11585), new IntPoint(9987, 11591), new IntPoint(10057, 11591), new IntPoint(10057, 11521), new IntPoint(10033, 11521), new IntPoint(10033, 11485), new IntPoint(10037, 11485), new
IntPoint(10037, 11491), new IntPoint(10107, 11491), new IntPoint(10107, 11371), new IntPoint(10083, 11371), new IntPoint(10083, 11335), new IntPoint(10087, 11335), new IntPoint(10087, 11341), new
IntPoint(10157, 11341), new IntPoint(10157, 11271), new IntPoint(10133, 11271), new IntPoint(10133, 11235), new IntPoint(10137, 11235), new IntPoint(10137, 11241), new IntPoint(10207, 11241), new
IntPoint(10207, 11171), new IntPoint(10183, 11171), new IntPoint(10183, 11135), new IntPoint(10187, 11135), new IntPoint(10187, 11141), new IntPoint(10257, 11141), new IntPoint(10257, 11091), new
IntPoint(10357, 11091), new IntPoint(10357, 11085), new IntPoint(10387, 11085) }, new Polygon() { new IntPoint(12587, 12941), new IntPoint(12613, 12941), new IntPoint(12613, 12985), new
IntPoint(12637, 12985), new IntPoint(12637, 12991), new IntPoint(12713, 12991), new IntPoint(12713, 13165), new IntPoint(12663, 13165), new IntPoint(12663, 13215), new IntPoint(12557, 13215), new
IntPoint(12557, 13171), new IntPoint(12533, 13171), new IntPoint(12533, 13165), new IntPoint(12507, 13165), new IntPoint(12507, 13121), new IntPoint(12483, 13121), new IntPoint(12483, 13115), new
IntPoint(12457, 13115), new IntPoint(12457, 13041), new IntPoint(12507, 13041), new IntPoint(12507, 12991), new IntPoint(12557, 12991), new IntPoint(12557, 12935), new IntPoint(12587, 12935) }, new
Polygon() { new IntPoint(6139, 12741), new IntPoint(6165, 12741), new IntPoint(6165, 12785), new IntPoint(6189, 12785), new IntPoint(6189, 12791), new IntPoint(6309, 12791), new IntPoint(6309, 12785),
new IntPoint(6339, 12785), new IntPoint(6339, 12791), new IntPoint(6365, 12791), new IntPoint(6365, 12835), new IntPoint(6389, 12835), new IntPoint(6389, 12841), new IntPoint(6459, 12841), new
IntPoint(6459, 12835), new IntPoint(6489, 12835), new IntPoint(6489, 12841), new IntPoint(6515, 12841), new IntPoint(6515, 12885), new IntPoint(6539, 12885), new IntPoint(6539, 12891), new
IntPoint(6615, 12891), new IntPoint(6615, 13165), new IntPoint(5759, 13165), new IntPoint(5759, 13121), new IntPoint(5735, 13121), new IntPoint(5735, 13085), new IntPoint(5739, 13085), new
IntPoint(5739, 13091), new IntPoint(5809, 13091), new IntPoint(5809, 13021), new IntPoint(5785, 13021), new IntPoint(5785, 12985), new IntPoint(5789, 12985), new IntPoint(5789, 12991), new
IntPoint(5859, 12991), new IntPoint(5859, 12921), new IntPoint(5835, 12921), new IntPoint(5835, 12885), new IntPoint(5839, 12885), new IntPoint(5839, 12891), new IntPoint(5909, 12891), new
IntPoint(5909, 12841), new IntPoint(5959, 12841), new IntPoint(5959, 12791), new IntPoint(6009, 12791), new IntPoint(6009, 12741), new IntPoint(6109, 12741), new IntPoint(6109, 12735), new
IntPoint(6139, 12735) }, new Polygon() { new IntPoint(8087, 12391), new IntPoint(8113, 12391), new IntPoint(8113, 12435), new IntPoint(8137, 12435), new IntPoint(8137, 12441), new IntPoint(8207,
12441), new IntPoint(8207, 12435), new IntPoint(8237, 12435), new IntPoint(8237, 12441), new IntPoint(8263, 12441), new IntPoint(8263, 12485), new IntPoint(8287, 12485), new IntPoint(8287, 12491), new
IntPoint(8363, 12491), new IntPoint(8363, 12535), new IntPoint(8387, 12535), new IntPoint(8387, 12541), new IntPoint(8463, 12541), new IntPoint(8463, 12585), new IntPoint(8487, 12585), new
IntPoint(8487, 12591), new IntPoint(8513, 12591), new IntPoint(8513, 12865), new IntPoint(8463, 12865), new IntPoint(8463, 12965), new IntPoint(8413, 12965), new IntPoint(8413, 13015), new
IntPoint(8363, 13015), new IntPoint(8363, 13115), new IntPoint(8313, 13115), new IntPoint(8313, 13165), new IntPoint(6959, 13165), new IntPoint(6959, 12921), new IntPoint(6935, 12921), new
IntPoint(6935, 12885), new IntPoint(6939, 12885), new IntPoint(6939, 12891), new IntPoint(7009, 12891), new IntPoint(7009, 12841), new IntPoint(7159, 12841), new IntPoint(7159, 12791), new
IntPoint(7259, 12791), new IntPoint(7259, 12741), new IntPoint(7359, 12741), new IntPoint(7359, 12691), new IntPoint(7407, 12691), new IntPoint(7407, 12641), new IntPoint(7457, 12641), new
IntPoint(7457, 12591), new IntPoint(7507, 12591), new IntPoint(7507, 12541), new IntPoint(7557, 12541), new IntPoint(7557, 12491), new IntPoint(7607, 12491), new IntPoint(7607, 12441), new
IntPoint(7657, 12441), new IntPoint(7657, 12391), new IntPoint(8057, 12391), new IntPoint(8057, 12385), new IntPoint(8087, 12385) }, new Polygon() { new IntPoint(8937, 11441), new IntPoint(9207,
11441), new IntPoint(9207, 11435), new IntPoint(9237, 11435), new IntPoint(9237, 11441), new IntPoint(9263, 11441), new IntPoint(9263, 11635), new IntPoint(9287, 11635), new IntPoint(9287, 11641), new
IntPoint(9363, 11641), new IntPoint(9363, 12765), new IntPoint(9313, 12765), new IntPoint(9313, 13015), new IntPoint(9263, 13015), new IntPoint(9263, 13065), new IntPoint(9213, 13065), new
IntPoint(9213, 13115), new IntPoint(9057, 13115), new IntPoint(9057, 13071), new IntPoint(9033, 13071), new IntPoint(9033, 13065), new IntPoint(8957, 13065), new IntPoint(8957, 12821), new
IntPoint(8933, 12821), new IntPoint(8933, 12785), new IntPoint(8937, 12785), new IntPoint(8937, 12791), new IntPoint(9007, 12791), new IntPoint(9007, 12321), new IntPoint(8983, 12321), new
IntPoint(8983, 12315), new IntPoint(8907, 12315), new IntPoint(8907, 12271), new IntPoint(8883, 12271), new IntPoint(8883, 12265), new IntPoint(8857, 12265), new IntPoint(8857, 12221), new
IntPoint(8833, 12221), new IntPoint(8833, 12215), new IntPoint(8757, 12215), new IntPoint(8757, 12171), new IntPoint(8733, 12171), new IntPoint(8733, 12165), new IntPoint(8657, 12165), new
IntPoint(8657, 12121), new IntPoint(8633, 12121), new IntPoint(8633, 12115), new IntPoint(8607, 12115), new IntPoint(8607, 12071), new IntPoint(8583, 12071), new IntPoint(8583, 12035), new
IntPoint(8587, 12035), new IntPoint(8587, 12041), new IntPoint(8657, 12041), new IntPoint(8657, 11971), new IntPoint(8633, 11971), new IntPoint(8633, 11935), new IntPoint(8637, 11935), new
IntPoint(8637, 11941), new IntPoint(8707, 11941), new IntPoint(8707, 11871), new IntPoint(8683, 11871), new IntPoint(8683, 11835), new IntPoint(8687, 11835), new IntPoint(8687, 11841), new
IntPoint(8757, 11841), new IntPoint(8757, 11791), new IntPoint(8807, 11791), new IntPoint(8807, 11721), new IntPoint(8783, 11721), new IntPoint(8783, 11685), new IntPoint(8787, 11685), new
IntPoint(8787, 11691), new IntPoint(8857, 11691), new IntPoint(8857, 11621), new IntPoint(8833, 11621), new IntPoint(8833, 11585), new IntPoint(8837, 11585), new IntPoint(8837, 11591), new
IntPoint(8907, 11591), new IntPoint(8907, 11541), new IntPoint(8957, 11541), new IntPoint(8957, 11471), new IntPoint(8933, 11471), new IntPoint(8933, 11435), new IntPoint(8937, 11435) }, new Polygon()
{ new IntPoint(5189, 12491), new IntPoint(5215, 12491), new IntPoint(5215, 12535), new IntPoint(5239, 12535), new IntPoint(5239, 12541), new IntPoint(5309, 12541), new IntPoint(5309, 12535), new
IntPoint(5339, 12535), new IntPoint(5339, 12541), new IntPoint(5365, 12541), new IntPoint(5365, 12765), new IntPoint(5315, 12765), new IntPoint(5315, 12915), new IntPoint(5265, 12915), new
IntPoint(5265, 13065), new IntPoint(5215, 13065), new IntPoint(5215, 13115), new IntPoint(4309, 13115), new IntPoint(4309, 13071), new IntPoint(4285, 13071), new IntPoint(4285, 13065), new
IntPoint(4259, 13065), new IntPoint(4259, 13021), new IntPoint(4235, 13021), new IntPoint(4235, 13015), new IntPoint(4159, 13015), new IntPoint(4159, 12921), new IntPoint(4135, 12921), new
IntPoint(4135, 12885), new IntPoint(4139, 12885), new IntPoint(4139, 12891), new IntPoint(4209, 12891), new IntPoint(4209, 12821), new IntPoint(4185, 12821), new IntPoint(4185, 12785), new
IntPoint(4189, 12785), new IntPoint(4189, 12791), new IntPoint(4259, 12791), new IntPoint(4259, 12741), new IntPoint(4309, 12741), new IntPoint(4309, 12691), new IntPoint(4959, 12691), new
IntPoint(4959, 12621), new IntPoint(4935, 12621), new IntPoint(4935, 12585), new IntPoint(4939, 12585), new IntPoint(4939, 12591), new IntPoint(5009, 12591), new IntPoint(5009, 12541), new
IntPoint(5059, 12541), new IntPoint(5059, 12491), new IntPoint(5159, 12491), new IntPoint(5159, 12485), new IntPoint(5189, 12485) }, new Polygon() { new IntPoint(3889, 11591), new IntPoint(3915,
11591), new IntPoint(3915, 11635), new IntPoint(3939, 11635), new IntPoint(3939, 11641), new IntPoint(4015, 11641), new IntPoint(4015, 11685), new IntPoint(4039, 11685), new IntPoint(4039, 11691), new
IntPoint(4065, 11691), new IntPoint(4065, 11735), new IntPoint(4089, 11735), new IntPoint(4089, 11741), new IntPoint(4115, 11741), new IntPoint(4115, 12015), new IntPoint(4065, 12015), new
IntPoint(4065, 12065), new IntPoint(4015, 12065), new IntPoint(4015, 12165), new IntPoint(3965, 12165), new IntPoint(3965, 12215), new IntPoint(3915, 12215), new IntPoint(3915, 12265), new
IntPoint(3865, 12265), new IntPoint(3865, 12365), new IntPoint(3815, 12365), new IntPoint(3815, 12415), new IntPoint(3765, 12415), new IntPoint(3765, 12515), new IntPoint(3715, 12515), new
IntPoint(3715, 12665), new IntPoint(3665, 12665), new IntPoint(3665, 12765), new IntPoint(3615, 12765), new IntPoint(3615, 12865), new IntPoint(3459, 12865), new IntPoint(3459, 12821), new
IntPoint(3435, 12821), new IntPoint(3435, 12815), new IntPoint(3309, 12815), new IntPoint(3309, 12771), new IntPoint(3285, 12771), new IntPoint(3285, 12765), new IntPoint(3209, 12765), new
IntPoint(3209, 12721), new IntPoint(3185, 12721), new IntPoint(3185, 12715), new IntPoint(3159, 12715), new IntPoint(3159, 12671), new IntPoint(3135, 12671), new IntPoint(3135, 12665), new
IntPoint(3109, 12665), new IntPoint(3109, 12621), new IntPoint(3085, 12621), new IntPoint(3085, 12615), new IntPoint(3059, 12615), new IntPoint(3059, 12421), new IntPoint(3035, 12421), new
IntPoint(3035, 12415), new IntPoint(3009, 12415), new IntPoint(3009, 12221), new IntPoint(2985, 12221), new IntPoint(2985, 12185), new IntPoint(2989, 12185), new IntPoint(2989, 12191), new
IntPoint(3059, 12191), new IntPoint(3059, 12141), new IntPoint(3109, 12141), new IntPoint(3109, 12091), new IntPoint(3159, 12091), new IntPoint(3159, 12041), new IntPoint(3209, 12041), new
IntPoint(3209, 11971), new IntPoint(3185, 11971), new IntPoint(3185, 11935), new IntPoint(3189, 11935), new IntPoint(3189, 11941), new IntPoint(3359, 11941), new IntPoint(3359, 11891), new
IntPoint(3409, 11891), new IntPoint(3409, 11841), new IntPoint(3459, 11841), new IntPoint(3459, 11791), new IntPoint(3509, 11791), new IntPoint(3509, 11741), new IntPoint(3559, 11741), new
IntPoint(3559, 11691), new IntPoint(3609, 11691), new IntPoint(3609, 11641), new IntPoint(3809, 11641), new IntPoint(3809, 11591), new IntPoint(3859, 11591), new IntPoint(3859, 11585), new
IntPoint(3889, 11585) }, new Polygon() { new IntPoint(13087, 12491), new IntPoint(13113, 12491), new IntPoint(13113, 12535), new IntPoint(13137, 12535), new IntPoint(13137, 12541), new IntPoint(13163,
12541), new IntPoint(13163, 12665), new IntPoint(13113, 12665), new IntPoint(13113, 12715), new IntPoint(12957, 12715), new IntPoint(12957, 12671), new IntPoint(12933, 12671), new IntPoint(12933,
12665), new IntPoint(12907, 12665), new IntPoint(12907, 12591), new IntPoint(12957, 12591), new IntPoint(12957, 12491), new IntPoint(13057, 12491), new IntPoint(13057, 12485), new IntPoint(13087,
12485) }, new Polygon() { new IntPoint(10913, 12435), new IntPoint(10937, 12435), new IntPoint(10937, 12441), new IntPoint(10963, 12441), new IntPoint(10963, 12485), new IntPoint(10987, 12485), new
IntPoint(10987, 12491), new IntPoint(11013, 12491), new IntPoint(11013, 12565), new IntPoint(10963, 12565), new IntPoint(10963, 12615), new IntPoint(10913, 12615), new IntPoint(10913, 12665), new
IntPoint(10857, 12665), new IntPoint(10857, 12621), new IntPoint(10833, 12621), new IntPoint(10833, 12615), new IntPoint(10807, 12615), new IntPoint(10807, 12571), new IntPoint(10783, 12571), new
IntPoint(10783, 12565), new IntPoint(10757, 12565), new IntPoint(10757, 12521), new IntPoint(10733, 12521), new IntPoint(10733, 12485), new IntPoint(10737, 12485), new IntPoint(10737, 12491), new
IntPoint(10807, 12491), new IntPoint(10807, 12441), new IntPoint(10857, 12441), new IntPoint(10857, 12391), new IntPoint(10913, 12391) }, new Polygon() { new IntPoint(5865, 11485), new IntPoint(5889,
11485), new IntPoint(5889, 11491), new IntPoint(5965, 11491), new IntPoint(5965, 11535), new IntPoint(5989, 11535), new IntPoint(5989, 11541), new IntPoint(6065, 11541), new IntPoint(6065, 11585), new
IntPoint(6089, 11585), new IntPoint(6089, 11591), new IntPoint(6115, 11591), new IntPoint(6115, 11635), new IntPoint(6139, 11635), new IntPoint(6139, 11641), new IntPoint(6215, 11641), new
IntPoint(6215, 11685), new IntPoint(6239, 11685), new IntPoint(6239, 11691), new IntPoint(6459, 11691), new IntPoint(6459, 11685), new IntPoint(6489, 11685), new IntPoint(6489, 11691), new
IntPoint(6515, 11691), new IntPoint(6515, 11735), new IntPoint(6539, 11735), new IntPoint(6539, 11741), new IntPoint(6565, 11741), new IntPoint(6565, 11785), new IntPoint(6589, 11785), new
IntPoint(6589, 11791), new IntPoint(6909, 11791), new IntPoint(6909, 11741), new IntPoint(7009, 11741), new IntPoint(7009, 11691), new IntPoint(7109, 11691), new IntPoint(7109, 11685), new
IntPoint(7139, 11685), new IntPoint(7139, 11691), new IntPoint(7165, 11691), new IntPoint(7165, 12265), new IntPoint(7115, 12265), new IntPoint(7115, 12365), new IntPoint(7065, 12365), new
IntPoint(7065, 12415), new IntPoint(7015, 12415), new IntPoint(7015, 12465), new IntPoint(6759, 12465), new IntPoint(6759, 12421), new IntPoint(6735, 12421), new IntPoint(6735, 12415), new
IntPoint(6709, 12415), new IntPoint(6709, 12321), new IntPoint(6685, 12321), new IntPoint(6685, 12315), new IntPoint(6659, 12315), new IntPoint(6659, 12121), new IntPoint(6635, 12121), new
IntPoint(6635, 12115), new IntPoint(6609, 12115), new IntPoint(6609, 11971), new IntPoint(6585, 11971), new IntPoint(6585, 11965), new IntPoint(6215, 11965), new IntPoint(6215, 12015), new
IntPoint(6165, 12015), new IntPoint(6165, 12265), new IntPoint(6115, 12265), new IntPoint(6115, 12315), new IntPoint(6059, 12315), new IntPoint(6059, 12271), new IntPoint(6035, 12271), new
IntPoint(6035, 12265), new IntPoint(5909, 12265), new IntPoint(5909, 12221), new IntPoint(5885, 12221), new IntPoint(5885, 12215), new IntPoint(5809, 12215), new IntPoint(5809, 12171), new
IntPoint(5785, 12171), new IntPoint(5785, 12165), new IntPoint(5709, 12165), new IntPoint(5709, 12121), new IntPoint(5685, 12121), new IntPoint(5685, 12115), new IntPoint(5609, 12115), new
IntPoint(5609, 12071), new IntPoint(5585, 12071), new IntPoint(5585, 12065), new IntPoint(4915, 12065), new IntPoint(4915, 12115), new IntPoint(4815, 12115), new IntPoint(4815, 12165), new
IntPoint(4715, 12165), new IntPoint(4715, 12215), new IntPoint(4609, 12215), new IntPoint(4609, 12171), new IntPoint(4585, 12171), new IntPoint(4585, 12165), new IntPoint(4559, 12165), new
IntPoint(4559, 12121), new IntPoint(4535, 12121), new IntPoint(4535, 12085), new IntPoint(4539, 12085), new IntPoint(4539, 12091), new IntPoint(4609, 12091), new IntPoint(4609, 12041), new
IntPoint(4709, 12041), new IntPoint(4709, 11991), new IntPoint(4859, 11991), new IntPoint(4859, 11941), new IntPoint(4959, 11941), new IntPoint(4959, 11891), new IntPoint(5109, 11891), new
IntPoint(5109, 11841), new IntPoint(5309, 11841), new IntPoint(5309, 11791), new IntPoint(5509, 11791), new IntPoint(5509, 11741), new IntPoint(5559, 11741), new IntPoint(5559, 11691), new
IntPoint(5609, 11691), new IntPoint(5609, 11641), new IntPoint(5659, 11641), new IntPoint(5659, 11591), new IntPoint(5709, 11591), new IntPoint(5709, 11541), new IntPoint(5759, 11541), new
IntPoint(5759, 11491), new IntPoint(5809, 11491), new IntPoint(5809, 11441), new IntPoint(5865, 11441) }, new Polygon() { new IntPoint(11587, 11441), new IntPoint(11613, 11441), new IntPoint(11613,
11485), new IntPoint(11637, 11485), new IntPoint(11637, 11491), new IntPoint(11713, 11491), new IntPoint(11713, 11535), new IntPoint(11737, 11535), new IntPoint(11737, 11541), new IntPoint(11763,
11541), new IntPoint(11763, 11765), new IntPoint(11713, 11765), new IntPoint(11713, 11815), new IntPoint(11663, 11815), new IntPoint(11663, 11865), new IntPoint(11507, 11865), new IntPoint(11507,
11821), new IntPoint(11483, 11821), new IntPoint(11483, 11815), new IntPoint(11457, 11815), new IntPoint(11457, 11771), new IntPoint(11433, 11771), new IntPoint(11433, 11765), new IntPoint(11407,
11765), new IntPoint(11407, 11541), new IntPoint(11457, 11541), new IntPoint(11457, 11491), new IntPoint(11557, 11491), new IntPoint(11557, 11435), new IntPoint(11587, 11435) }, new Polygon() { new
IntPoint(8187, 10391), new IntPoint(8263, 10391), new IntPoint(8263, 10435), new IntPoint(8287, 10435), new IntPoint(8287, 10441), new IntPoint(8363, 10441), new IntPoint(8363, 10485), new
IntPoint(8387, 10485), new IntPoint(8387, 10491), new IntPoint(8413, 10491), new IntPoint(8413, 10535), new IntPoint(8437, 10535), new IntPoint(8437, 10541), new IntPoint(8463, 10541), new
IntPoint(8463, 10585), new IntPoint(8487, 10585), new IntPoint(8487, 10591), new IntPoint(8513, 10591), new IntPoint(8513, 10685), new IntPoint(8537, 10685), new IntPoint(8537, 10691), new
IntPoint(8563, 10691), new IntPoint(8563, 10785), new IntPoint(8587, 10785), new IntPoint(8587, 10791), new IntPoint(8613, 10791), new IntPoint(8613, 11115), new IntPoint(8563, 11115), new
IntPoint(8563, 11165), new IntPoint(8513, 11165), new IntPoint(8513, 11265), new IntPoint(8463, 11265), new IntPoint(8463, 11365), new IntPoint(8413, 11365), new IntPoint(8413, 11465), new
IntPoint(8363, 11465), new IntPoint(8363, 11565), new IntPoint(8313, 11565), new IntPoint(8313, 11615), new IntPoint(8263, 11615), new IntPoint(8263, 11665), new IntPoint(8113, 11665), new
IntPoint(8113, 11715), new IntPoint(7757, 11715), new IntPoint(7757, 11671), new IntPoint(7733, 11671), new IntPoint(7733, 11665), new IntPoint(7707, 11665), new IntPoint(7707, 11421), new
IntPoint(7683, 11421), new IntPoint(7683, 11385), new IntPoint(7687, 11385), new IntPoint(7687, 11391), new IntPoint(7757, 11391), new IntPoint(7757, 11341), new IntPoint(7807, 11341), new
IntPoint(7807, 11291), new IntPoint(7907, 11291), new IntPoint(7907, 11241), new IntPoint(8057, 11241), new IntPoint(8057, 11191), new IntPoint(8157, 11191), new IntPoint(8157, 11141), new
IntPoint(8207, 11141), new IntPoint(8207, 10421), new IntPoint(8183, 10421), new IntPoint(8183, 10385), new IntPoint(8187, 10385) }, new Polygon() { new IntPoint(3239, 9241), new IntPoint(3315, 9241),
new IntPoint(3315, 9335), new IntPoint(3339, 9335), new IntPoint(3339, 9341), new IntPoint(3365, 9341), new IntPoint(3365, 9385), new IntPoint(3389, 9385), new IntPoint(3389, 9391), new IntPoint(3415,
9391), new IntPoint(3415, 9585), new IntPoint(3439, 9585), new IntPoint(3439, 9591), new IntPoint(3465, 9591), new IntPoint(3465, 9765), new IntPoint(3415, 9765), new IntPoint(3415, 9915), new
IntPoint(3365, 9915), new IntPoint(3365, 10015), new IntPoint(3315, 10015), new IntPoint(3315, 10115), new IntPoint(3265, 10115), new IntPoint(3265, 10265), new IntPoint(3215, 10265), new
IntPoint(3215, 10365), new IntPoint(3165, 10365), new IntPoint(3165, 10465), new IntPoint(3115, 10465), new IntPoint(3115, 10565), new IntPoint(3065, 10565), new IntPoint(3065, 10665), new
IntPoint(3015, 10665), new IntPoint(3015, 10765), new IntPoint(2965, 10765), new IntPoint(2965, 10865), new IntPoint(2915, 10865), new IntPoint(2915, 10965), new IntPoint(2865, 10965), new
IntPoint(2865, 11065), new IntPoint(2815, 11065), new IntPoint(2815, 11165), new IntPoint(2765, 11165), new IntPoint(2765, 11265), new IntPoint(2715, 11265), new IntPoint(2715, 11315), new
IntPoint(2665, 11315), new IntPoint(2665, 11365), new IntPoint(2615, 11365), new IntPoint(2615, 11465), new IntPoint(2565, 11465), new IntPoint(2565, 11515), new IntPoint(2515, 11515), new
IntPoint(2515, 11565), new IntPoint(2465, 11565), new IntPoint(2465, 11615), new IntPoint(2365, 11615), new IntPoint(2365, 11665), new IntPoint(2159, 11665), new IntPoint(2159, 11621), new
IntPoint(2135, 11621), new IntPoint(2135, 11615), new IntPoint(2109, 11615), new IntPoint(2109, 11571), new IntPoint(2085, 11571), new IntPoint(2085, 11565), new IntPoint(2059, 11565), new
IntPoint(2059, 11521), new IntPoint(2035, 11521), new IntPoint(2035, 11515), new IntPoint(2009, 11515), new IntPoint(2009, 11421), new IntPoint(1985, 11421), new IntPoint(1985, 11415), new
IntPoint(1959, 11415), new IntPoint(1959, 11371), new IntPoint(1935, 11371), new IntPoint(1935, 11365), new IntPoint(1909, 11365), new IntPoint(1909, 11221), new IntPoint(1885, 11221), new
IntPoint(1885, 11215), new IntPoint(1859, 11215), new IntPoint(1859, 11071), new IntPoint(1835, 11071), new IntPoint(1835, 11065), new IntPoint(1809, 11065), new IntPoint(1809, 9871), new
IntPoint(1785, 9871), new IntPoint(1785, 9835), new IntPoint(1789, 9835), new IntPoint(1789, 9841), new IntPoint(1915, 9841), new IntPoint(1915, 9885), new IntPoint(1939, 9885), new IntPoint(1939,
9891), new IntPoint(2015, 9891), new IntPoint(2015, 9935), new IntPoint(2039, 9935), new IntPoint(2039, 9941), new IntPoint(2065, 9941), new IntPoint(2065, 9985), new IntPoint(2089, 9985), new
IntPoint(2089, 9991), new IntPoint(2115, 9991), new IntPoint(2115, 10085), new IntPoint(2139, 10085), new IntPoint(2139, 10091), new IntPoint(2165, 10091), new IntPoint(2165, 10135), new
IntPoint(2189, 10135), new IntPoint(2189, 10141), new IntPoint(2215, 10141), new IntPoint(2215, 10235), new IntPoint(2239, 10235), new IntPoint(2239, 10241), new IntPoint(2265, 10241), new
IntPoint(2265, 10335), new IntPoint(2289, 10335), new IntPoint(2289, 10341), new IntPoint(2315, 10341), new IntPoint(2315, 10385), new IntPoint(2339, 10385), new IntPoint(2339, 10391), new
IntPoint(2365, 10391), new IntPoint(2365, 10435), new IntPoint(2389, 10435), new IntPoint(2389, 10441), new IntPoint(2809, 10441), new IntPoint(2809, 10391), new IntPoint(2859, 10391), new
IntPoint(2859, 10341), new IntPoint(2909, 10341), new IntPoint(2909, 10291), new IntPoint(2959, 10291), new IntPoint(2959, 10221), new IntPoint(2935, 10221), new IntPoint(2935, 10185), new
IntPoint(2939, 10185), new IntPoint(2939, 10191), new IntPoint(3009, 10191), new IntPoint(3009, 10141), new IntPoint(3059, 10141), new IntPoint(3059, 10091), new IntPoint(3109, 10091), new
IntPoint(3109, 10021), new IntPoint(3085, 10021), new IntPoint(3085, 9985), new IntPoint(3089, 9985), new IntPoint(3089, 9991), new IntPoint(3159, 9991), new IntPoint(3159, 9921), new IntPoint(3135,
9921), new IntPoint(3135, 9885), new IntPoint(3139, 9885), new IntPoint(3139, 9891), new IntPoint(3209, 9891), new IntPoint(3209, 9821), new IntPoint(3185, 9821), new IntPoint(3185, 9785), new
IntPoint(3189, 9785), new IntPoint(3189, 9791), new IntPoint(3259, 9791), new IntPoint(3259, 9271), new IntPoint(3235, 9271), new IntPoint(3235, 9235), new IntPoint(3239, 9235) }, new Polygon() { new
IntPoint(5989, 9491), new IntPoint(6015, 9491), new IntPoint(6015, 9535), new IntPoint(6039, 9535), new IntPoint(6039, 9541), new IntPoint(6115, 9541), new IntPoint(6115, 9665), new IntPoint(6065,
9665), new IntPoint(6065, 9715), new IntPoint(6015, 9715), new IntPoint(6015, 9765), new IntPoint(5965, 9765), new IntPoint(5965, 9815), new IntPoint(5915, 9815), new IntPoint(5915, 9865), new
IntPoint(5865, 9865), new IntPoint(5865, 9915), new IntPoint(5815, 9915), new IntPoint(5815, 9965), new IntPoint(5765, 9965), new IntPoint(5765, 10615), new IntPoint(5715, 10615), new IntPoint(5715,
10765), new IntPoint(5665, 10765), new IntPoint(5665, 10915), new IntPoint(5615, 10915), new IntPoint(5615, 10965), new IntPoint(5565, 10965), new IntPoint(5565, 11015), new IntPoint(5515, 11015), new
IntPoint(5515, 11065), new IntPoint(5465, 11065), new IntPoint(5465, 11115), new IntPoint(5415, 11115), new IntPoint(5415, 11165), new IntPoint(5365, 11165), new IntPoint(5365, 11265), new
IntPoint(5265, 11265), new IntPoint(5265, 11315), new IntPoint(5165, 11315), new IntPoint(5165, 11365), new IntPoint(5015, 11365), new IntPoint(5015, 11415), new IntPoint(4915, 11415), new
IntPoint(4915, 11465), new IntPoint(4765, 11465), new IntPoint(4765, 11515), new IntPoint(4665, 11515), new IntPoint(4665, 11565), new IntPoint(4609, 11565), new IntPoint(4609, 11521), new
IntPoint(4585, 11521), new IntPoint(4585, 11515), new IntPoint(4559, 11515), new IntPoint(4559, 11471), new IntPoint(4535, 11471), new IntPoint(4535, 11465), new IntPoint(4509, 11465), new
IntPoint(4509, 11421), new IntPoint(4485, 11421), new IntPoint(4485, 11415), new IntPoint(4459, 11415), new IntPoint(4459, 11271), new IntPoint(4435, 11271), new IntPoint(4435, 11265), new
IntPoint(4409, 11265), new IntPoint(4409, 11221), new IntPoint(4385, 11221), new IntPoint(4385, 11215), new IntPoint(4009, 11215), new IntPoint(4009, 11171), new IntPoint(3985, 11171), new
IntPoint(3985, 11165), new IntPoint(3909, 11165), new IntPoint(3909, 11121), new IntPoint(3885, 11121), new IntPoint(3885, 11115), new IntPoint(3859, 11115), new IntPoint(3859, 11021), new
IntPoint(3835, 11021), new IntPoint(3835, 11015), new IntPoint(3809, 11015), new IntPoint(3809, 10921), new IntPoint(3785, 10921), new IntPoint(3785, 10885), new IntPoint(3789, 10885), new
IntPoint(3789, 10891), new IntPoint(3859, 10891), new IntPoint(3859, 10721), new IntPoint(3835, 10721), new IntPoint(3835, 10685), new IntPoint(3839, 10685), new IntPoint(3839, 10691), new
IntPoint(3909, 10691), new IntPoint(3909, 10621), new IntPoint(3885, 10621), new IntPoint(3885, 10585), new IntPoint(3889, 10585), new IntPoint(3889, 10591), new IntPoint(3959, 10591), new
IntPoint(3959, 10541), new IntPoint(4009, 10541), new IntPoint(4009, 10491), new IntPoint(4059, 10491), new IntPoint(4059, 10441), new IntPoint(4109, 10441), new IntPoint(4109, 10391), new
IntPoint(4159, 10391), new IntPoint(4159, 10341), new IntPoint(4259, 10341), new IntPoint(4259, 10291), new IntPoint(4309, 10291), new IntPoint(4309, 10241), new IntPoint(4359, 10241), new
IntPoint(4359, 10191), new IntPoint(4409, 10191), new IntPoint(4409, 10185), new IntPoint(4439, 10185), new IntPoint(4439, 10191), new IntPoint(4465, 10191), new IntPoint(4465, 10235), new
IntPoint(4489, 10235), new IntPoint(4489, 10241), new IntPoint(4515, 10241), new IntPoint(4515, 10315), new IntPoint(4465, 10315), new IntPoint(4465, 10365), new IntPoint(4415, 10365), new
IntPoint(4415, 10635), new IntPoint(4439, 10635), new IntPoint(4439, 10641), new IntPoint(4465, 10641), new IntPoint(4465, 10685), new IntPoint(4489, 10685), new IntPoint(4489, 10691), new
IntPoint(4515, 10691), new IntPoint(4515, 10735), new IntPoint(4539, 10735), new IntPoint(4539, 10741), new IntPoint(4565, 10741), new IntPoint(4565, 10785), new IntPoint(4589, 10785), new
IntPoint(4589, 10791), new IntPoint(4615, 10791), new IntPoint(4615, 10835), new IntPoint(4639, 10835), new IntPoint(4639, 10841), new IntPoint(4665, 10841), new IntPoint(4665, 10885), new
IntPoint(4689, 10885), new IntPoint(4689, 10891), new IntPoint(4765, 10891), new IntPoint(4765, 10935), new IntPoint(4789, 10935), new IntPoint(4789, 10941), new IntPoint(4909, 10941), new
IntPoint(4909, 10935), new IntPoint(4939, 10935), new IntPoint(4939, 10941), new IntPoint(4965, 10941), new IntPoint(4965, 10985), new IntPoint(4989, 10985), new IntPoint(4989, 10991), new
IntPoint(5159, 10991), new IntPoint(5159, 10941), new IntPoint(5259, 10941), new IntPoint(5259, 10891), new IntPoint(5309, 10891), new IntPoint(5309, 10841), new IntPoint(5359, 10841), new
IntPoint(5359, 10791), new IntPoint(5459, 10791), new IntPoint(5459, 10721), new IntPoint(5435, 10721), new IntPoint(5435, 10685), new IntPoint(5439, 10685), new IntPoint(5439, 10691), new
IntPoint(5509, 10691), new IntPoint(5509, 10321), new IntPoint(5485, 10321), new IntPoint(5485, 10315), new IntPoint(5459, 10315), new IntPoint(5459, 10271), new IntPoint(5435, 10271), new
IntPoint(5435, 10265), new IntPoint(5409, 10265), new IntPoint(5409, 10171), new IntPoint(5385, 10171), new IntPoint(5385, 10165), new IntPoint(5359, 10165), new IntPoint(5359, 10121), new
IntPoint(5335, 10121), new IntPoint(5335, 10115), new IntPoint(5309, 10115), new IntPoint(5309, 10071), new IntPoint(5285, 10071), new IntPoint(5285, 10065), new IntPoint(5259, 10065), new
IntPoint(5259, 9971), new IntPoint(5235, 9971), new IntPoint(5235, 9965), new IntPoint(4909, 9965), new IntPoint(4909, 9921), new IntPoint(4885, 9921), new IntPoint(4885, 9915), new IntPoint(4859,
9915), new IntPoint(4859, 9871), new IntPoint(4835, 9871), new IntPoint(4835, 9835), new IntPoint(4839, 9835), new IntPoint(4839, 9841), new IntPoint(4959, 9841), new IntPoint(4959, 9791), new
IntPoint(5059, 9791), new IntPoint(5059, 9741), new IntPoint(5159, 9741), new IntPoint(5159, 9691), new IntPoint(5259, 9691), new IntPoint(5259, 9641), new IntPoint(5359, 9641), new IntPoint(5359,
9591), new IntPoint(5509, 9591), new IntPoint(5509, 9541), new IntPoint(5759, 9541), new IntPoint(5759, 9491), new IntPoint(5959, 9491), new IntPoint(5959, 9485), new IntPoint(5989, 9485) }, new
Polygon() { new IntPoint(13587, 11091), new IntPoint(13613, 11091), new IntPoint(13613, 11135), new IntPoint(13637, 11135), new IntPoint(13637, 11141), new IntPoint(13713, 11141), new IntPoint(13713,
11185), new IntPoint(13737, 11185), new IntPoint(13737, 11191), new IntPoint(13763, 11191), new IntPoint(13763, 11415), new IntPoint(13713, 11415), new IntPoint(13713, 11465), new IntPoint(13663,
11465), new IntPoint(13663, 11515), new IntPoint(13507, 11515), new IntPoint(13507, 11471), new IntPoint(13483, 11471), new IntPoint(13483, 11465), new IntPoint(13457, 11465), new IntPoint(13457,
11421), new IntPoint(13433, 11421), new IntPoint(13433, 11415), new IntPoint(13407, 11415), new IntPoint(13407, 11191), new IntPoint(13457, 11191), new IntPoint(13457, 11141), new IntPoint(13557,
11141), new IntPoint(13557, 11085), new IntPoint(13587, 11085) }, new Polygon() { new IntPoint(6889, 10141), new IntPoint(6915, 10141), new IntPoint(6915, 10185), new IntPoint(6939, 10185), new
IntPoint(6939, 10191), new IntPoint(7109, 10191), new IntPoint(7109, 10185), new IntPoint(7139, 10185), new IntPoint(7139, 10191), new IntPoint(7165, 10191), new IntPoint(7165, 10235), new
IntPoint(7189, 10235), new IntPoint(7189, 10241), new IntPoint(7259, 10241), new IntPoint(7259, 10235), new IntPoint(7289, 10235), new IntPoint(7289, 10241), new IntPoint(7315, 10241), new
IntPoint(7315, 10285), new IntPoint(7337, 10285), new IntPoint(7337, 10291), new IntPoint(7407, 10291), new IntPoint(7407, 10285), new IntPoint(7437, 10285), new IntPoint(7437, 10291), new
IntPoint(7463, 10291), new IntPoint(7463, 10335), new IntPoint(7487, 10335), new IntPoint(7487, 10341), new IntPoint(7563, 10341), new IntPoint(7563, 10385), new IntPoint(7587, 10385), new
IntPoint(7587, 10391), new IntPoint(7657, 10391), new IntPoint(7657, 10385), new IntPoint(7687, 10385), new IntPoint(7687, 10391), new IntPoint(7713, 10391), new IntPoint(7713, 10865), new
IntPoint(7663, 10865), new IntPoint(7663, 10915), new IntPoint(7407, 10915), new IntPoint(7407, 10721), new IntPoint(7385, 10721), new IntPoint(7385, 10715), new IntPoint(7359, 10715), new
IntPoint(7359, 10671), new IntPoint(7335, 10671), new IntPoint(7335, 10665), new IntPoint(7259, 10665), new IntPoint(7259, 10621), new IntPoint(7235, 10621), new IntPoint(7235, 10615), new
IntPoint(7109, 10615), new IntPoint(7109, 10571), new IntPoint(7085, 10571), new IntPoint(7085, 10565), new IntPoint(6865, 10565), new IntPoint(6865, 10615), new IntPoint(6765, 10615), new
IntPoint(6765, 11035), new IntPoint(6789, 11035), new IntPoint(6789, 11041), new IntPoint(6815, 11041), new IntPoint(6815, 11085), new IntPoint(6839, 11085), new IntPoint(6839, 11091), new
IntPoint(6915, 11091), new IntPoint(6915, 11135), new IntPoint(6939, 11135), new IntPoint(6939, 11141), new IntPoint(6965, 11141), new IntPoint(6965, 11265), new IntPoint(6915, 11265), new
IntPoint(6915, 11315), new IntPoint(6865, 11315), new IntPoint(6865, 11365), new IntPoint(6709, 11365), new IntPoint(6709, 11321), new IntPoint(6685, 11321), new IntPoint(6685, 11315), new
IntPoint(6609, 11315), new IntPoint(6609, 11271), new IntPoint(6585, 11271), new IntPoint(6585, 11265), new IntPoint(6559, 11265), new IntPoint(6559, 11221), new IntPoint(6535, 11221), new
IntPoint(6535, 11215), new IntPoint(6509, 11215), new IntPoint(6509, 11171), new IntPoint(6485, 11171), new IntPoint(6485, 11165), new IntPoint(6459, 11165), new IntPoint(6459, 11121), new
IntPoint(6435, 11121), new IntPoint(6435, 11115), new IntPoint(6409, 11115), new IntPoint(6409, 11071), new IntPoint(6385, 11071), new IntPoint(6385, 11065), new IntPoint(6359, 11065), new
IntPoint(6359, 10971), new IntPoint(6335, 10971), new IntPoint(6335, 10965), new IntPoint(6309, 10965), new IntPoint(6309, 10921), new IntPoint(6285, 10921), new IntPoint(6285, 10915), new
IntPoint(6259, 10915), new IntPoint(6259, 10371), new IntPoint(6235, 10371), new IntPoint(6235, 10335), new IntPoint(6239, 10335), new IntPoint(6239, 10341), new IntPoint(6309, 10341), new
IntPoint(6309, 10221), new IntPoint(6285, 10221), new IntPoint(6285, 10185), new IntPoint(6289, 10185), new IntPoint(6289, 10191), new IntPoint(6359, 10191), new IntPoint(6359, 10141), new
IntPoint(6859, 10141), new IntPoint(6859, 10135), new IntPoint(6889, 10135) }, new Polygon() { new IntPoint(11187, 11091), new IntPoint(11213, 11091), new IntPoint(11213, 11185), new IntPoint(11237,
11185), new IntPoint(11237, 11191), new IntPoint(11263, 11191), new IntPoint(11263, 11215), new IntPoint(11213, 11215), new IntPoint(11213, 11315), new IntPoint(11057, 11315), new IntPoint(11057,
11271), new IntPoint(11033, 11271), new IntPoint(11033, 11265), new IntPoint(11007, 11265), new IntPoint(11007, 11141), new IntPoint(11057, 11141), new IntPoint(11057, 11091), new IntPoint(11157,
11091), new IntPoint(11157, 11085), new IntPoint(11187, 11085) }, new Polygon() { new IntPoint(8987, 9991), new IntPoint(9013, 9991), new IntPoint(9013, 10035), new IntPoint(9037, 10035), new
IntPoint(9037, 10041), new IntPoint(9107, 10041), new IntPoint(9107, 10035), new IntPoint(9137, 10035), new IntPoint(9137, 10041), new IntPoint(9163, 10041), new IntPoint(9163, 10085), new
IntPoint(9187, 10085), new IntPoint(9187, 10091), new IntPoint(9307, 10091), new IntPoint(9307, 10085), new IntPoint(9337, 10085), new IntPoint(9337, 10091), new IntPoint(9363, 10091), new
IntPoint(9363, 10135), new IntPoint(9387, 10135), new IntPoint(9387, 10141), new IntPoint(9463, 10141), new IntPoint(9463, 10185), new IntPoint(9487, 10185), new IntPoint(9487, 10191), new
IntPoint(9513, 10191), new IntPoint(9513, 10235), new IntPoint(9537, 10235), new IntPoint(9537, 10241), new IntPoint(9563, 10241), new IntPoint(9563, 10285), new IntPoint(9587, 10285), new
IntPoint(9587, 10291), new IntPoint(9613, 10291), new IntPoint(9613, 10335), new IntPoint(9637, 10335), new IntPoint(9637, 10341), new IntPoint(9663, 10341), new IntPoint(9663, 10385), new
IntPoint(9687, 10385), new IntPoint(9687, 10391), new IntPoint(9713, 10391), new IntPoint(9713, 10435), new IntPoint(9737, 10435), new IntPoint(9737, 10441), new IntPoint(9813, 10441), new
IntPoint(9813, 10485), new IntPoint(9837, 10485), new IntPoint(9837, 10491), new IntPoint(9863, 10491), new IntPoint(9863, 10535), new IntPoint(9887, 10535), new IntPoint(9887, 10541), new
IntPoint(9913, 10541), new IntPoint(9913, 10585), new IntPoint(9937, 10585), new IntPoint(9937, 10591), new IntPoint(9963, 10591), new IntPoint(9963, 10715), new IntPoint(9813, 10715), new
IntPoint(9813, 10765), new IntPoint(9763, 10765), new IntPoint(9763, 10865), new IntPoint(9713, 10865), new IntPoint(9713, 10915), new IntPoint(9663, 10915), new IntPoint(9663, 11015), new
IntPoint(9613, 11015), new IntPoint(9613, 11065), new IntPoint(9563, 11065), new IntPoint(9563, 11115), new IntPoint(9157, 11115), new IntPoint(9157, 11071), new IntPoint(9133, 11071), new
IntPoint(9133, 11065), new IntPoint(9107, 11065), new IntPoint(9107, 10771), new IntPoint(9083, 10771), new IntPoint(9083, 10765), new IntPoint(9057, 10765), new IntPoint(9057, 10671), new
IntPoint(9033, 10671), new IntPoint(9033, 10665), new IntPoint(9007, 10665), new IntPoint(9007, 10571), new IntPoint(8983, 10571), new IntPoint(8983, 10565), new IntPoint(8957, 10565), new
IntPoint(8957, 10521), new IntPoint(8933, 10521), new IntPoint(8933, 10515), new IntPoint(8907, 10515), new IntPoint(8907, 10421), new IntPoint(8883, 10421), new IntPoint(8883, 10415), new
IntPoint(8857, 10415), new IntPoint(8857, 10321), new IntPoint(8833, 10321), new IntPoint(8833, 10315), new IntPoint(8807, 10315), new IntPoint(8807, 10221), new IntPoint(8783, 10221), new
IntPoint(8783, 10215), new IntPoint(8757, 10215), new IntPoint(8757, 10071), new IntPoint(8733, 10071), new IntPoint(8733, 10035), new IntPoint(8737, 10035), new IntPoint(8737, 10041), new
IntPoint(8907, 10041), new IntPoint(8907, 9991), new IntPoint(8957, 9991), new IntPoint(8957, 9985), new IntPoint(8987, 9985) }, new Polygon() { new IntPoint(12387, 10791), new IntPoint(12413, 10791),
new IntPoint(12413, 10835), new IntPoint(12437, 10835), new IntPoint(12437, 10841), new IntPoint(12463, 10841), new IntPoint(12463, 10885), new IntPoint(12487, 10885), new IntPoint(12487, 10891), new
IntPoint(12513, 10891), new IntPoint(12513, 10965), new IntPoint(12463, 10965), new IntPoint(12463, 11015), new IntPoint(12413, 11015), new IntPoint(12413, 11065), new IntPoint(12357, 11065), new
IntPoint(12357, 11021), new IntPoint(12333, 11021), new IntPoint(12333, 11015), new IntPoint(12307, 11015), new IntPoint(12307, 10971), new IntPoint(12283, 10971), new IntPoint(12283, 10965), new
IntPoint(12257, 10965), new IntPoint(12257, 10891), new IntPoint(12307, 10891), new IntPoint(12307, 10841), new IntPoint(12357, 10841), new IntPoint(12357, 10785), new IntPoint(12387, 10785) }, new
Polygon() { new IntPoint(13637, 10441), new IntPoint(13663, 10441), new IntPoint(13663, 10485), new IntPoint(13687, 10485), new IntPoint(13687, 10491), new IntPoint(13713, 10491), new IntPoint(13713,
10665), new IntPoint(13613, 10665), new IntPoint(13613, 10715), new IntPoint(13607, 10715), new IntPoint(13607, 10671), new IntPoint(13583, 10671), new IntPoint(13583, 10665), new IntPoint(13507,
10665), new IntPoint(13507, 10491), new IntPoint(13557, 10491), new IntPoint(13557, 10441), new IntPoint(13607, 10441), new IntPoint(13607, 10435), new IntPoint(13637, 10435) }, new Polygon() { new
IntPoint(13087, 9891), new IntPoint(13113, 9891), new IntPoint(13113, 9935), new IntPoint(13137, 9935), new IntPoint(13137, 9941), new IntPoint(13163, 9941), new IntPoint(13163, 10115), new
IntPoint(13113, 10115), new IntPoint(13113, 10165), new IntPoint(12663, 10165), new IntPoint(12663, 10215), new IntPoint(11913, 10215), new IntPoint(11913, 10265), new IntPoint(11863, 10265), new
IntPoint(11863, 10315), new IntPoint(11763, 10315), new IntPoint(11763, 10365), new IntPoint(11613, 10365), new IntPoint(11613, 10415), new IntPoint(11513, 10415), new IntPoint(11513, 10465), new
IntPoint(11413, 10465), new IntPoint(11413, 10515), new IntPoint(11313, 10515), new IntPoint(11313, 10565), new IntPoint(11263, 10565), new IntPoint(11263, 10615), new IntPoint(11157, 10615), new
IntPoint(11157, 10571), new IntPoint(11133, 10571), new IntPoint(11133, 10565), new IntPoint(11107, 10565), new IntPoint(11107, 10521), new IntPoint(11083, 10521), new IntPoint(11083, 10515), new
IntPoint(11057, 10515), new IntPoint(11057, 10471), new IntPoint(11033, 10471), new IntPoint(11033, 10465), new IntPoint(11007, 10465), new IntPoint(11007, 10341), new IntPoint(11057, 10341), new
IntPoint(11057, 10291), new IntPoint(11107, 10291), new IntPoint(11107, 10241), new IntPoint(11207, 10241), new IntPoint(11207, 10191), new IntPoint(11507, 10191), new IntPoint(11507, 10141), new
IntPoint(11657, 10141), new IntPoint(11657, 10091), new IntPoint(11907, 10091), new IntPoint(11907, 10041), new IntPoint(11957, 10041), new IntPoint(11957, 9991), new IntPoint(12307, 9991), new
IntPoint(12307, 9941), new IntPoint(12707, 9941), new IntPoint(12707, 9891), new IntPoint(13057, 9891), new IntPoint(13057, 9885), new IntPoint(13087, 9885) }, new Polygon() { new IntPoint(965,
10335), new IntPoint(989, 10335), new IntPoint(989, 10341), new IntPoint(1065, 10341), new IntPoint(1065, 10515), new IntPoint(1015, 10515), new IntPoint(1015, 10565), new IntPoint(909, 10565), new
IntPoint(909, 10521), new IntPoint(885, 10521), new IntPoint(885, 10515), new IntPoint(859, 10515), new IntPoint(859, 10371), new IntPoint(835, 10371), new IntPoint(835, 10335), new IntPoint(839,
10335), new IntPoint(839, 10341), new IntPoint(959, 10341), new IntPoint(959, 10291), new IntPoint(965, 10291) }, new Polygon() { new IntPoint(9787, 9991), new IntPoint(9813, 9991), new IntPoint(9813,
10035), new IntPoint(9837, 10035), new IntPoint(9837, 10041), new IntPoint(9863, 10041), new IntPoint(9863, 10165), new IntPoint(9813, 10165), new IntPoint(9813, 10215), new IntPoint(9657, 10215), new
IntPoint(9657, 10041), new IntPoint(9707, 10041), new IntPoint(9707, 9991), new IntPoint(9757, 9991), new IntPoint(9757, 9985), new IntPoint(9787, 9985) }, new Polygon() { new IntPoint(7987, 8741),
new IntPoint(8013, 8741), new IntPoint(8013, 8785), new IntPoint(8037, 8785), new IntPoint(8037, 8791), new IntPoint(8113, 8791), new IntPoint(8113, 8835), new IntPoint(8137, 8835), new IntPoint(8137,
8841), new IntPoint(8163, 8841), new IntPoint(8163, 8885), new IntPoint(8187, 8885), new IntPoint(8187, 8891), new IntPoint(8213, 8891), new IntPoint(8213, 8935), new IntPoint(8237, 8935), new
IntPoint(8237, 8941), new IntPoint(8263, 8941), new IntPoint(8263, 8985), new IntPoint(8287, 8985), new IntPoint(8287, 8991), new IntPoint(8313, 8991), new IntPoint(8313, 9035), new IntPoint(8337,
9035), new IntPoint(8337, 9041), new IntPoint(8363, 9041), new IntPoint(8363, 9085), new IntPoint(8387, 9085), new IntPoint(8387, 9091), new IntPoint(8463, 9091), new IntPoint(8463, 9135), new
IntPoint(8487, 9135), new IntPoint(8487, 9141), new IntPoint(8513, 9141), new IntPoint(8513, 9185), new IntPoint(8537, 9185), new IntPoint(8537, 9191), new IntPoint(8563, 9191), new IntPoint(8563,
9235), new IntPoint(8587, 9235), new IntPoint(8587, 9241), new IntPoint(8613, 9241), new IntPoint(8613, 9285), new IntPoint(8637, 9285), new IntPoint(8637, 9291), new IntPoint(8663, 9291), new
IntPoint(8663, 9335), new IntPoint(8687, 9335), new IntPoint(8687, 9341), new IntPoint(8713, 9341), new IntPoint(8713, 9385), new IntPoint(8737, 9385), new IntPoint(8737, 9391), new IntPoint(8763,
9391), new IntPoint(8763, 9435), new IntPoint(8787, 9435), new IntPoint(8787, 9441), new IntPoint(8813, 9441), new IntPoint(8813, 9485), new IntPoint(8837, 9485), new IntPoint(8837, 9491), new
IntPoint(8863, 9491), new IntPoint(8863, 9535), new IntPoint(8887, 9535), new IntPoint(8887, 9541), new IntPoint(8913, 9541), new IntPoint(8913, 9615), new IntPoint(8757, 9615), new IntPoint(8757,
9571), new IntPoint(8733, 9571), new IntPoint(8733, 9565), new IntPoint(8313, 9565), new IntPoint(8313, 10065), new IntPoint(8157, 10065), new IntPoint(8157, 9921), new IntPoint(8133, 9921), new
IntPoint(8133, 9915), new IntPoint(8107, 9915), new IntPoint(8107, 9621), new IntPoint(8083, 9621), new IntPoint(8083, 9615), new IntPoint(8057, 9615), new IntPoint(8057, 9271), new IntPoint(8033,
9271), new IntPoint(8033, 9265), new IntPoint(7613, 9265), new IntPoint(7613, 9615), new IntPoint(7309, 9615), new IntPoint(7309, 9571), new IntPoint(7285, 9571), new IntPoint(7285, 9565), new
IntPoint(7159, 9565), new IntPoint(7159, 9321), new IntPoint(7135, 9321), new IntPoint(7135, 9285), new IntPoint(7139, 9285), new IntPoint(7139, 9291), new IntPoint(7209, 9291), new IntPoint(7209,
9241), new IntPoint(7309, 9241), new IntPoint(7309, 9191), new IntPoint(7359, 9191), new IntPoint(7359, 9141), new IntPoint(7407, 9141), new IntPoint(7407, 9091), new IntPoint(7457, 9091), new
IntPoint(7457, 9041), new IntPoint(7557, 9041), new IntPoint(7557, 8991), new IntPoint(7607, 8991), new IntPoint(7607, 8941), new IntPoint(7707, 8941), new IntPoint(7707, 8891), new IntPoint(7757,
8891), new IntPoint(7757, 8841), new IntPoint(7807, 8841), new IntPoint(7807, 8791), new IntPoint(7857, 8791), new IntPoint(7857, 8741), new IntPoint(7957, 8741), new IntPoint(7957, 8735), new
IntPoint(7987, 8735) }, new Polygon() { new IntPoint(3139, 8391), new IntPoint(3165, 8391), new IntPoint(3165, 8435), new IntPoint(3189, 8435), new IntPoint(3189, 8441), new IntPoint(3215, 8441), new
IntPoint(3215, 8485), new IntPoint(3239, 8485), new IntPoint(3239, 8491), new IntPoint(3315, 8491), new IntPoint(3315, 8565), new IntPoint(3265, 8565), new IntPoint(3265, 8615), new IntPoint(3215,
8615), new IntPoint(3215, 8665), new IntPoint(3165, 8665), new IntPoint(3165, 8715), new IntPoint(3115, 8715), new IntPoint(3115, 8765), new IntPoint(3065, 8765), new IntPoint(3065, 8815), new
IntPoint(3015, 8815), new IntPoint(3015, 8865), new IntPoint(2965, 8865), new IntPoint(2965, 8915), new IntPoint(2915, 8915), new IntPoint(2915, 8965), new IntPoint(2865, 8965), new IntPoint(2865,
9015), new IntPoint(2815, 9015), new IntPoint(2815, 9365), new IntPoint(2765, 9365), new IntPoint(2765, 9515), new IntPoint(2715, 9515), new IntPoint(2715, 9665), new IntPoint(2665, 9665), new
IntPoint(2665, 9865), new IntPoint(2609, 9865), new IntPoint(2609, 9171), new IntPoint(2585, 9171), new IntPoint(2585, 9165), new IntPoint(2559, 9165), new IntPoint(2559, 8971), new IntPoint(2535,
8971), new IntPoint(2535, 8965), new IntPoint(2509, 8965), new IntPoint(2509, 8721), new IntPoint(2485, 8721), new IntPoint(2485, 8685), new IntPoint(2489, 8685), new IntPoint(2489, 8691), new
IntPoint(2559, 8691), new IntPoint(2559, 8571), new IntPoint(2535, 8571), new IntPoint(2535, 8535), new IntPoint(2539, 8535), new IntPoint(2539, 8541), new IntPoint(2659, 8541), new IntPoint(2659,
8491), new IntPoint(2759, 8491), new IntPoint(2759, 8441), new IntPoint(2909, 8441), new IntPoint(2909, 8391), new IntPoint(3109, 8391), new IntPoint(3109, 8385), new IntPoint(3139, 8385) }, new
Polygon() { new IntPoint(11987, 7791), new IntPoint(12013, 7791), new IntPoint(12013, 8565), new IntPoint(11963, 8565), new IntPoint(11963, 8615), new IntPoint(11913, 8615), new IntPoint(11913, 8665),
new IntPoint(11863, 8665), new IntPoint(11863, 8715), new IntPoint(11813, 8715), new IntPoint(11813, 8765), new IntPoint(11763, 8765), new IntPoint(11763, 8815), new IntPoint(11713, 8815), new
IntPoint(11713, 8915), new IntPoint(11663, 8915), new IntPoint(11663, 9235), new IntPoint(11687, 9235), new IntPoint(11687, 9241), new IntPoint(11713, 9241), new IntPoint(11713, 9335), new
IntPoint(11737, 9335), new IntPoint(11737, 9341), new IntPoint(11763, 9341), new IntPoint(11763, 9415), new IntPoint(11713, 9415), new IntPoint(11713, 9465), new IntPoint(11663, 9465), new
IntPoint(11663, 9515), new IntPoint(11463, 9515), new IntPoint(11463, 9565), new IntPoint(11313, 9565), new IntPoint(11313, 9615), new IntPoint(11163, 9615), new IntPoint(11163, 9665), new
IntPoint(11013, 9665), new IntPoint(11013, 9715), new IntPoint(10913, 9715), new IntPoint(10913, 9765), new IntPoint(10763, 9765), new IntPoint(10763, 9815), new IntPoint(10657, 9815), new
IntPoint(10657, 9771), new IntPoint(10633, 9771), new IntPoint(10633, 9765), new IntPoint(10607, 9765), new IntPoint(10607, 9721), new IntPoint(10583, 9721), new IntPoint(10583, 9715), new
IntPoint(10507, 9715), new IntPoint(10507, 9671), new IntPoint(10483, 9671), new IntPoint(10483, 9665), new IntPoint(10457, 9665), new IntPoint(10457, 9621), new IntPoint(10433, 9621), new
IntPoint(10433, 9615), new IntPoint(10357, 9615), new IntPoint(10357, 9571), new IntPoint(10333, 9571), new IntPoint(10333, 9565), new IntPoint(10307, 9565), new IntPoint(10307, 9521), new
IntPoint(10283, 9521), new IntPoint(10283, 9515), new IntPoint(10257, 9515), new IntPoint(10257, 9471), new IntPoint(10233, 9471), new IntPoint(10233, 9465), new IntPoint(10207, 9465), new
IntPoint(10207, 9421), new IntPoint(10183, 9421), new IntPoint(10183, 9415), new IntPoint(10157, 9415), new IntPoint(10157, 9321), new IntPoint(10133, 9321), new IntPoint(10133, 9315), new
IntPoint(10107, 9315), new IntPoint(10107, 9271), new IntPoint(10083, 9271), new IntPoint(10083, 9265), new IntPoint(10057, 9265), new IntPoint(10057, 9221), new IntPoint(10033, 9221), new
IntPoint(10033, 9215), new IntPoint(10007, 9215), new IntPoint(10007, 9091), new IntPoint(10357, 9091), new IntPoint(10357, 9085), new IntPoint(10387, 9085), new IntPoint(10387, 9091), new
IntPoint(10413, 9091), new IntPoint(10413, 9135), new IntPoint(10437, 9135), new IntPoint(10437, 9141), new IntPoint(10463, 9141), new IntPoint(10463, 9185), new IntPoint(10487, 9185), new
IntPoint(10487, 9191), new IntPoint(10563, 9191), new IntPoint(10563, 9235), new IntPoint(10587, 9235), new IntPoint(10587, 9241), new IntPoint(10757, 9241), new IntPoint(10757, 9191), new
IntPoint(11007, 9191), new IntPoint(11007, 9141), new IntPoint(11107, 9141), new IntPoint(11107, 9091), new IntPoint(11207, 9091), new IntPoint(11207, 9041), new IntPoint(11307, 9041), new
IntPoint(11307, 8991), new IntPoint(11407, 8991), new IntPoint(11407, 8891), new IntPoint(11457, 8891), new IntPoint(11457, 8841), new IntPoint(11507, 8841), new IntPoint(11507, 8791), new
IntPoint(11557, 8791), new IntPoint(11557, 8741), new IntPoint(11607, 8741), new IntPoint(11607, 8691), new IntPoint(11657, 8691), new IntPoint(11657, 8591), new IntPoint(11707, 8591), new
IntPoint(11707, 8541), new IntPoint(11757, 8541), new IntPoint(11757, 8241), new IntPoint(11807, 8241), new IntPoint(11807, 7841), new IntPoint(11857, 7841), new IntPoint(11857, 7791), new
IntPoint(11957, 7791), new IntPoint(11957, 7785), new IntPoint(11987, 7785) }, new Polygon() { new IntPoint(2639, 7641), new IntPoint(2665, 7641), new IntPoint(2665, 7685), new IntPoint(2689, 7685),
new IntPoint(2689, 7691), new IntPoint(2715, 7691), new IntPoint(2715, 7965), new IntPoint(2665, 7965), new IntPoint(2665, 8015), new IntPoint(2565, 8015), new IntPoint(2565, 8065), new IntPoint(2465,
8065), new IntPoint(2465, 8115), new IntPoint(2365, 8115), new IntPoint(2365, 8165), new IntPoint(2215, 8165), new IntPoint(2215, 8215), new IntPoint(2115, 8215), new IntPoint(2115, 8265), new
IntPoint(2065, 8265), new IntPoint(2065, 8315), new IntPoint(2015, 8315), new IntPoint(2015, 8365), new IntPoint(1965, 8365), new IntPoint(1965, 8785), new IntPoint(1989, 8785), new IntPoint(1989,
8791), new IntPoint(2015, 8791), new IntPoint(2015, 8885), new IntPoint(2039, 8885), new IntPoint(2039, 8891), new IntPoint(2065, 8891), new IntPoint(2065, 8985), new IntPoint(2089, 8985), new
IntPoint(2089, 8991), new IntPoint(2115, 8991), new IntPoint(2115, 9135), new IntPoint(2139, 9135), new IntPoint(2139, 9141), new IntPoint(2165, 9141), new IntPoint(2165, 9335), new IntPoint(2189,
9335), new IntPoint(2189, 9341), new IntPoint(2215, 9341), new IntPoint(2215, 9415), new IntPoint(2165, 9415), new IntPoint(2165, 9465), new IntPoint(2109, 9465), new IntPoint(2109, 9421), new
IntPoint(2085, 9421), new IntPoint(2085, 9415), new IntPoint(2009, 9415), new IntPoint(2009, 9371), new IntPoint(1985, 9371), new IntPoint(1985, 9365), new IntPoint(1859, 9365), new IntPoint(1859,
9321), new IntPoint(1835, 9321), new IntPoint(1835, 9315), new IntPoint(1759, 9315), new IntPoint(1759, 9021), new IntPoint(1735, 9021), new IntPoint(1735, 9015), new IntPoint(1709, 9015), new
IntPoint(1709, 8221), new IntPoint(1685, 8221), new IntPoint(1685, 8185), new IntPoint(1689, 8185), new IntPoint(1689, 8191), new IntPoint(1759, 8191), new IntPoint(1759, 8071), new IntPoint(1735,
8071), new IntPoint(1735, 8035), new IntPoint(1739, 8035), new IntPoint(1739, 8041), new IntPoint(1859, 8041), new IntPoint(1859, 7991), new IntPoint(1959, 7991), new IntPoint(1959, 7941), new
IntPoint(2059, 7941), new IntPoint(2059, 7891), new IntPoint(2159, 7891), new IntPoint(2159, 7841), new IntPoint(2209, 7841), new IntPoint(2209, 7791), new IntPoint(2309, 7791), new IntPoint(2309,
7741), new IntPoint(2359, 7741), new IntPoint(2359, 7691), new IntPoint(2459, 7691), new IntPoint(2459, 7641), new IntPoint(2609, 7641), new IntPoint(2609, 7635), new IntPoint(2639, 7635) }, new
Polygon() { new IntPoint(4139, 7443), new IntPoint(4165, 7443), new IntPoint(4165, 7485), new IntPoint(4189, 7485), new IntPoint(4189, 7491), new IntPoint(4359, 7491), new IntPoint(4359, 7485), new
IntPoint(4389, 7485), new IntPoint(4389, 7491), new IntPoint(4415, 7491), new IntPoint(4415, 7535), new IntPoint(4439, 7535), new IntPoint(4439, 7541), new IntPoint(4465, 7541), new IntPoint(4465,
7585), new IntPoint(4489, 7585), new IntPoint(4489, 7591), new IntPoint(4515, 7591), new IntPoint(4515, 7635), new IntPoint(4539, 7635), new IntPoint(4539, 7641), new IntPoint(4565, 7641), new
IntPoint(4565, 7715), new IntPoint(4515, 7715), new IntPoint(4515, 7865), new IntPoint(4465, 7865), new IntPoint(4465, 7965), new IntPoint(4415, 7965), new IntPoint(4415, 8015), new IntPoint(4365,
8015), new IntPoint(4365, 8115), new IntPoint(4315, 8115), new IntPoint(4315, 8215), new IntPoint(4265, 8215), new IntPoint(4265, 8335), new IntPoint(4289, 8335), new IntPoint(4289, 8341), new
IntPoint(4315, 8341), new IntPoint(4315, 8435), new IntPoint(4339, 8435), new IntPoint(4339, 8441), new IntPoint(4365, 8441), new IntPoint(4365, 8485), new IntPoint(4389, 8485), new IntPoint(4389,
8491), new IntPoint(4415, 8491), new IntPoint(4415, 8535), new IntPoint(4439, 8535), new IntPoint(4439, 8541), new IntPoint(4465, 8541), new IntPoint(4465, 8585), new IntPoint(4489, 8585), new
IntPoint(4489, 8591), new IntPoint(4515, 8591), new IntPoint(4515, 8635), new IntPoint(4539, 8635), new IntPoint(4539, 8641), new IntPoint(4615, 8641), new IntPoint(4615, 8685), new IntPoint(4639,
8685), new IntPoint(4639, 8691), new IntPoint(4665, 8691), new IntPoint(4665, 8735), new IntPoint(4689, 8735), new IntPoint(4689, 8741), new IntPoint(4765, 8741), new IntPoint(4765, 8815), new
IntPoint(4715, 8815), new IntPoint(4715, 8865), new IntPoint(4615, 8865), new IntPoint(4615, 8915), new IntPoint(4515, 8915), new IntPoint(4515, 8965), new IntPoint(4365, 8965), new IntPoint(4365,
9015), new IntPoint(4315, 9015), new IntPoint(4315, 9065), new IntPoint(4215, 9065), new IntPoint(4215, 9115), new IntPoint(4165, 9115), new IntPoint(4165, 9165), new IntPoint(4065, 9165), new
IntPoint(4065, 9215), new IntPoint(4015, 9215), new IntPoint(4015, 9265), new IntPoint(3965, 9265), new IntPoint(3965, 9315), new IntPoint(3915, 9315), new IntPoint(3915, 9365), new IntPoint(3859,
9365), new IntPoint(3859, 9221), new IntPoint(3835, 9221), new IntPoint(3835, 9215), new IntPoint(3809, 9215), new IntPoint(3809, 9071), new IntPoint(3785, 9071), new IntPoint(3785, 9065), new
IntPoint(3759, 9065), new IntPoint(3759, 9021), new IntPoint(3735, 9021), new IntPoint(3735, 9015), new IntPoint(3709, 9015), new IntPoint(3709, 8921), new IntPoint(3685, 8921), new IntPoint(3685,
8915), new IntPoint(3659, 8915), new IntPoint(3659, 8871), new IntPoint(3635, 8871), new IntPoint(3635, 8835), new IntPoint(3639, 8835), new IntPoint(3639, 8841), new IntPoint(3759, 8841), new
IntPoint(3759, 8791), new IntPoint(3809, 8791), new IntPoint(3809, 8171), new IntPoint(3785, 8171), new IntPoint(3785, 8135), new IntPoint(3789, 8135), new IntPoint(3789, 8141), new IntPoint(3909,
8141), new IntPoint(3909, 8091), new IntPoint(4059, 8091), new IntPoint(4059, 8041), new IntPoint(4159, 8041), new IntPoint(4159, 7721), new IntPoint(4135, 7721), new IntPoint(4135, 7715), new
IntPoint(4109, 7715), new IntPoint(4109, 7671), new IntPoint(4085, 7671), new IntPoint(4085, 7665), new IntPoint(3209, 7665), new IntPoint(3209, 7621), new IntPoint(3185, 7621), new IntPoint(3185,
7615), new IntPoint(3159, 7615), new IntPoint(3159, 7521), new IntPoint(3135, 7521), new IntPoint(3135, 7485), new IntPoint(3139, 7485), new IntPoint(3139, 7491), new IntPoint(3209, 7491), new
IntPoint(3209, 7443), new IntPoint(4109, 7443), new IntPoint(4109, 7435), new IntPoint(4139, 7435) }, new Polygon() { new IntPoint(12987, 7393), new IntPoint(13013, 7393), new IntPoint(13013, 7985),
new IntPoint(13037, 7985), new IntPoint(13037, 7991), new IntPoint(13063, 7991), new IntPoint(13063, 9115), new IntPoint(13013, 9115), new IntPoint(13013, 9265), new IntPoint(12963, 9265), new
IntPoint(12963, 9315), new IntPoint(12613, 9315), new IntPoint(12613, 9365), new IntPoint(12457, 9365), new IntPoint(12457, 9321), new IntPoint(12433, 9321), new IntPoint(12433, 9315), new
IntPoint(12407, 9315), new IntPoint(12407, 9271), new IntPoint(12383, 9271), new IntPoint(12383, 9265), new IntPoint(12357, 9265), new IntPoint(12357, 9221), new IntPoint(12333, 9221), new
IntPoint(12333, 9215), new IntPoint(12257, 9215), new IntPoint(12257, 8991), new IntPoint(12307, 8991), new IntPoint(12307, 8941), new IntPoint(12407, 8941), new IntPoint(12407, 8791), new
IntPoint(12457, 8791), new IntPoint(12457, 8421), new IntPoint(12433, 8421), new IntPoint(12433, 8415), new IntPoint(12407, 8415), new IntPoint(12407, 7741), new IntPoint(12457, 7741), new
IntPoint(12457, 7691), new IntPoint(12557, 7691), new IntPoint(12557, 7641), new IntPoint(12607, 7641), new IntPoint(12607, 7591), new IntPoint(12657, 7591), new IntPoint(12657, 7541), new
IntPoint(12757, 7541), new IntPoint(12757, 7491), new IntPoint(12807, 7491), new IntPoint(12807, 7443), new IntPoint(12857, 7443), new IntPoint(12857, 7393), new IntPoint(12957, 7393), new
IntPoint(12957, 7385), new IntPoint(12987, 7385) }, new Polygon() { new IntPoint(7437, 8041), new IntPoint(7463, 8041), new IntPoint(7463, 8085), new IntPoint(7487, 8085), new IntPoint(7487, 8091),
new IntPoint(7513, 8091), new IntPoint(7513, 8265), new IntPoint(7463, 8265), new IntPoint(7463, 8315), new IntPoint(7413, 8315), new IntPoint(7413, 8365), new IntPoint(7363, 8365), new IntPoint(7363,
8415), new IntPoint(7265, 8415), new IntPoint(7265, 8465), new IntPoint(7215, 8465), new IntPoint(7215, 8515), new IntPoint(7165, 8515), new IntPoint(7165, 8565), new IntPoint(7115, 8565), new
IntPoint(7115, 8615), new IntPoint(7065, 8615), new IntPoint(7065, 8665), new IntPoint(7015, 8665), new IntPoint(7015, 8715), new IntPoint(6965, 8715), new IntPoint(6965, 8765), new IntPoint(6915,
8765), new IntPoint(6915, 8815), new IntPoint(6815, 8815), new IntPoint(6815, 8865), new IntPoint(6765, 8865), new IntPoint(6765, 8915), new IntPoint(6715, 8915), new IntPoint(6715, 8965), new
IntPoint(6615, 8965), new IntPoint(6615, 9015), new IntPoint(6465, 9015), new IntPoint(6465, 9065), new IntPoint(6309, 9065), new IntPoint(6309, 9021), new IntPoint(6285, 9021), new IntPoint(6285,
8985), new IntPoint(6289, 8985), new IntPoint(6289, 8991), new IntPoint(6409, 8991), new IntPoint(6409, 8941), new IntPoint(6459, 8941), new IntPoint(6459, 8891), new IntPoint(6559, 8891), new
IntPoint(6559, 8841), new IntPoint(6609, 8841), new IntPoint(6609, 8791), new IntPoint(6709, 8791), new IntPoint(6709, 8741), new IntPoint(6759, 8741), new IntPoint(6759, 8691), new IntPoint(6809,
8691), new IntPoint(6809, 8641), new IntPoint(6909, 8641), new IntPoint(6909, 8591), new IntPoint(6959, 8591), new IntPoint(6959, 8521), new IntPoint(6935, 8521), new IntPoint(6935, 8485), new
IntPoint(6939, 8485), new IntPoint(6939, 8491), new IntPoint(7009, 8491), new IntPoint(7009, 8441), new IntPoint(7059, 8441), new IntPoint(7059, 8391), new IntPoint(7109, 8391), new IntPoint(7109,
8341), new IntPoint(7159, 8341), new IntPoint(7159, 8291), new IntPoint(7209, 8291), new IntPoint(7209, 8221), new IntPoint(7185, 8221), new IntPoint(7185, 8185), new IntPoint(7189, 8185), new
IntPoint(7189, 8191), new IntPoint(7259, 8191), new IntPoint(7259, 8141), new IntPoint(7309, 8141), new IntPoint(7309, 8091), new IntPoint(7359, 8091), new IntPoint(7359, 8041), new IntPoint(7407,
8041), new IntPoint(7407, 8035), new IntPoint(7437, 8035) }, new Polygon() { new IntPoint(9837, 7393), new IntPoint(9863, 7393), new IntPoint(9863, 7485), new IntPoint(9887, 7485), new IntPoint(9887,
7491), new IntPoint(9913, 7491), new IntPoint(9913, 7765), new IntPoint(9863, 7765), new IntPoint(9863, 7915), new IntPoint(9813, 7915), new IntPoint(9813, 8285), new IntPoint(9837, 8285), new
IntPoint(9837, 8291), new IntPoint(9863, 8291), new IntPoint(9863, 8435), new IntPoint(9887, 8435), new IntPoint(9887, 8441), new IntPoint(9913, 8441), new IntPoint(9913, 8535), new IntPoint(9937,
8535), new IntPoint(9937, 8541), new IntPoint(9963, 8541), new IntPoint(9963, 8585), new IntPoint(9987, 8585), new IntPoint(9987, 8591), new IntPoint(10013, 8591), new IntPoint(10013, 8665), new
IntPoint(9963, 8665), new IntPoint(9963, 8715), new IntPoint(9613, 8715), new IntPoint(9613, 8765), new IntPoint(9557, 8765), new IntPoint(9557, 8721), new IntPoint(9533, 8721), new IntPoint(9533,
8715), new IntPoint(9507, 8715), new IntPoint(9507, 8671), new IntPoint(9483, 8671), new IntPoint(9483, 8665), new IntPoint(9457, 8665), new IntPoint(9457, 8621), new IntPoint(9433, 8621), new
IntPoint(9433, 8615), new IntPoint(9407, 8615), new IntPoint(9407, 8571), new IntPoint(9383, 8571), new IntPoint(9383, 8565), new IntPoint(9357, 8565), new IntPoint(9357, 8521), new IntPoint(9333,
8521), new IntPoint(9333, 8515), new IntPoint(9307, 8515), new IntPoint(9307, 8471), new IntPoint(9283, 8471), new IntPoint(9283, 8465), new IntPoint(9257, 8465), new IntPoint(9257, 8421), new
IntPoint(9233, 8421), new IntPoint(9233, 8415), new IntPoint(9207, 8415), new IntPoint(9207, 8371), new IntPoint(9183, 8371), new IntPoint(9183, 8365), new IntPoint(9157, 8365), new IntPoint(9157,
8321), new IntPoint(9133, 8321), new IntPoint(9133, 8315), new IntPoint(9107, 8315), new IntPoint(9107, 8271), new IntPoint(9083, 8271), new IntPoint(9083, 8265), new IntPoint(9057, 8265), new
IntPoint(9057, 8221), new IntPoint(9033, 8221), new IntPoint(9033, 8215), new IntPoint(9007, 8215), new IntPoint(9007, 8171), new IntPoint(8983, 8171), new IntPoint(8983, 8165), new IntPoint(8957,
8165), new IntPoint(8957, 7841), new IntPoint(9007, 7841), new IntPoint(9007, 7741), new IntPoint(9057, 7741), new IntPoint(9057, 7691), new IntPoint(9107, 7691), new IntPoint(9107, 7641), new
IntPoint(9157, 7641), new IntPoint(9157, 7591), new IntPoint(9207, 7591), new IntPoint(9207, 7541), new IntPoint(9257, 7541), new IntPoint(9257, 7491), new IntPoint(9357, 7491), new IntPoint(9357,
7443), new IntPoint(9457, 7443), new IntPoint(9457, 7393), new IntPoint(9807, 7393), new IntPoint(9807, 7385), new IntPoint(9837, 7385) }, new Polygon() { new IntPoint(11037, 7791), new
IntPoint(11063, 7791), new IntPoint(11063, 7835), new IntPoint(11087, 7835), new IntPoint(11087, 7841), new IntPoint(11163, 7841), new IntPoint(11163, 7885), new IntPoint(11187, 7885), new
IntPoint(11187, 7891), new IntPoint(11213, 7891), new IntPoint(11213, 7935), new IntPoint(11237, 7935), new IntPoint(11237, 7941), new IntPoint(11263, 7941), new IntPoint(11263, 7985), new
IntPoint(11287, 7985), new IntPoint(11287, 7991), new IntPoint(11363, 7991), new IntPoint(11363, 8165), new IntPoint(11313, 8165), new IntPoint(11313, 8265), new IntPoint(11257, 8265), new
IntPoint(11257, 8221), new IntPoint(11233, 8221), new IntPoint(11233, 8215), new IntPoint(11207, 8215), new IntPoint(11207, 8171), new IntPoint(11183, 8171), new IntPoint(11183, 8165), new
IntPoint(11157, 8165), new IntPoint(11157, 8121), new IntPoint(11133, 8121), new IntPoint(11133, 8115), new IntPoint(10863, 8115), new IntPoint(10863, 8165), new IntPoint(10813, 8165), new
IntPoint(10813, 8215), new IntPoint(10763, 8215), new IntPoint(10763, 8265), new IntPoint(10713, 8265), new IntPoint(10713, 8535), new IntPoint(10737, 8535), new IntPoint(10737, 8541), new
IntPoint(10763, 8541), new IntPoint(10763, 8665), new IntPoint(10713, 8665), new IntPoint(10713, 8715), new IntPoint(10657, 8715), new IntPoint(10657, 8671), new IntPoint(10633, 8671), new
IntPoint(10633, 8665), new IntPoint(10557, 8665), new IntPoint(10557, 8621), new IntPoint(10533, 8621), new IntPoint(10533, 8615), new IntPoint(10507, 8615), new IntPoint(10507, 8571), new
IntPoint(10483, 8571), new IntPoint(10483, 8565), new IntPoint(10457, 8565), new IntPoint(10457, 8521), new IntPoint(10433, 8521), new IntPoint(10433, 8515), new IntPoint(10407, 8515), new
IntPoint(10407, 8421), new IntPoint(10383, 8421), new IntPoint(10383, 8415), new IntPoint(10357, 8415), new IntPoint(10357, 8271), new IntPoint(10333, 8271), new IntPoint(10333, 8265), new
IntPoint(10307, 8265), new IntPoint(10307, 8041), new IntPoint(10357, 8041), new IntPoint(10357, 7941), new IntPoint(10407, 7941), new IntPoint(10407, 7891), new IntPoint(10457, 7891), new
IntPoint(10457, 7841), new IntPoint(10557, 7841), new IntPoint(10557, 7791), new IntPoint(11007, 7791), new IntPoint(11007, 7785), new IntPoint(11037, 7785) }, new Polygon() { new IntPoint(8987,
8391), new IntPoint(9013, 8391), new IntPoint(9013, 8485), new IntPoint(9037, 8485), new IntPoint(9037, 8491), new IntPoint(9063, 8491), new IntPoint(9063, 8515), new IntPoint(9013, 8515), new
IntPoint(9013, 8615), new IntPoint(8907, 8615), new IntPoint(8907, 8571), new IntPoint(8883, 8571), new IntPoint(8883, 8565), new IntPoint(8857, 8565), new IntPoint(8857, 8441), new IntPoint(8907,
8441), new IntPoint(8907, 8391), new IntPoint(8957, 8391), new IntPoint(8957, 8385), new IntPoint(8987, 8385) }, new Polygon() { new IntPoint(6439, 7243), new IntPoint(6465, 7243), new IntPoint(6465,
7285), new IntPoint(6489, 7285), new IntPoint(6489, 7293), new IntPoint(6565, 7293), new IntPoint(6565, 7565), new IntPoint(6515, 7565), new IntPoint(6515, 7615), new IntPoint(6465, 7615), new
IntPoint(6465, 7715), new IntPoint(6415, 7715), new IntPoint(6415, 7815), new IntPoint(6365, 7815), new IntPoint(6365, 7915), new IntPoint(6315, 7915), new IntPoint(6315, 8015), new IntPoint(6215,
8015), new IntPoint(6215, 8065), new IntPoint(6115, 8065), new IntPoint(6115, 8115), new IntPoint(6065, 8115), new IntPoint(6065, 8165), new IntPoint(5965, 8165), new IntPoint(5965, 8215), new
IntPoint(5915, 8215), new IntPoint(5915, 8265), new IntPoint(5815, 8265), new IntPoint(5815, 8315), new IntPoint(5765, 8315), new IntPoint(5765, 8365), new IntPoint(5665, 8365), new IntPoint(5665,
8415), new IntPoint(5565, 8415), new IntPoint(5565, 8465), new IntPoint(5465, 8465), new IntPoint(5465, 8515), new IntPoint(5309, 8515), new IntPoint(5309, 8471), new IntPoint(5285, 8471), new
IntPoint(5285, 8465), new IntPoint(5159, 8465), new IntPoint(5159, 8421), new IntPoint(5135, 8421), new IntPoint(5135, 8415), new IntPoint(5059, 8415), new IntPoint(5059, 8371), new IntPoint(5035,
8371), new IntPoint(5035, 8365), new IntPoint(5009, 8365), new IntPoint(5009, 8321), new IntPoint(4985, 8321), new IntPoint(4985, 8315), new IntPoint(4959, 8315), new IntPoint(4959, 8271), new
IntPoint(4935, 8271), new IntPoint(4935, 8265), new IntPoint(4909, 8265), new IntPoint(4909, 8221), new IntPoint(4885, 8221), new IntPoint(4885, 8215), new IntPoint(4859, 8215), new IntPoint(4859,
8071), new IntPoint(4835, 8071), new IntPoint(4835, 8035), new IntPoint(4839, 8035), new IntPoint(4839, 8041), new IntPoint(4909, 8041), new IntPoint(4909, 7991), new IntPoint(5309, 7991), new
IntPoint(5309, 7941), new IntPoint(5509, 7941), new IntPoint(5509, 7891), new IntPoint(5659, 7891), new IntPoint(5659, 7841), new IntPoint(5759, 7841), new IntPoint(5759, 7791), new IntPoint(5809,
7791), new IntPoint(5809, 7741), new IntPoint(5859, 7741), new IntPoint(5859, 7691), new IntPoint(5959, 7691), new IntPoint(5959, 7641), new IntPoint(6009, 7641), new IntPoint(6009, 7571), new
IntPoint(5985, 7571), new IntPoint(5985, 7535), new IntPoint(5989, 7535), new IntPoint(5989, 7541), new IntPoint(6059, 7541), new IntPoint(6059, 7491), new IntPoint(6109, 7491), new IntPoint(6109,
7443), new IntPoint(6159, 7443), new IntPoint(6159, 7373), new IntPoint(6135, 7373), new IntPoint(6135, 7335), new IntPoint(6139, 7335), new IntPoint(6139, 7343), new IntPoint(6209, 7343), new
IntPoint(6209, 7293), new IntPoint(6259, 7293), new IntPoint(6259, 7243), new IntPoint(6409, 7243), new IntPoint(6409, 7235), new IntPoint(6439, 7235) }, new Polygon() { new IntPoint(13337, 8091), new
IntPoint(13363, 8091), new IntPoint(13363, 8135), new IntPoint(13387, 8135), new IntPoint(13387, 8141), new IntPoint(13413, 8141), new IntPoint(13413, 8315), new IntPoint(13363, 8315), new
IntPoint(13363, 8365), new IntPoint(13307, 8365), new IntPoint(13307, 8321), new IntPoint(13283, 8321), new IntPoint(13283, 8315), new IntPoint(13207, 8315), new IntPoint(13207, 8141), new
IntPoint(13257, 8141), new IntPoint(13257, 8091), new IntPoint(13307, 8091), new IntPoint(13307, 8085), new IntPoint(13337, 8085) }, new Polygon() { new IntPoint(2339, 5543), new IntPoint(2365, 5543),
new IntPoint(2365, 5585), new IntPoint(2389, 5585), new IntPoint(2389, 5593), new IntPoint(2415, 5593), new IntPoint(2415, 5635), new IntPoint(2439, 5635), new IntPoint(2439, 5643), new IntPoint(2515,
5643), new IntPoint(2515, 5685), new IntPoint(2539, 5685), new IntPoint(2539, 5693), new IntPoint(2565, 5693), new IntPoint(2565, 5915), new IntPoint(2465, 5915), new IntPoint(2465, 5965), new
IntPoint(2415, 5965), new IntPoint(2415, 6015), new IntPoint(2365, 6015), new IntPoint(2365, 6535), new IntPoint(2389, 6535), new IntPoint(2389, 6543), new IntPoint(2415, 6543), new IntPoint(2415,
7165), new IntPoint(2315, 7165), new IntPoint(2315, 7215), new IntPoint(2265, 7215), new IntPoint(2265, 7265), new IntPoint(2215, 7265), new IntPoint(2215, 7315), new IntPoint(2115, 7315), new
IntPoint(2115, 7365), new IntPoint(2065, 7365), new IntPoint(2065, 7415), new IntPoint(1965, 7415), new IntPoint(1965, 7465), new IntPoint(1915, 7465), new IntPoint(1915, 7515), new IntPoint(1809,
7515), new IntPoint(1809, 6773), new IntPoint(1785, 6773), new IntPoint(1785, 6765), new IntPoint(1759, 6765), new IntPoint(1759, 5623), new IntPoint(1735, 5623), new IntPoint(1735, 5585), new
IntPoint(1739, 5585), new IntPoint(1739, 5593), new IntPoint(2109, 5593), new IntPoint(2109, 5543), new IntPoint(2309, 5543), new IntPoint(2309, 5535), new IntPoint(2339, 5535) }, new Polygon() { new
IntPoint(5139, 6143), new IntPoint(5165, 6143), new IntPoint(5165, 6185), new IntPoint(5189, 6185), new IntPoint(5189, 6193), new IntPoint(5265, 6193), new IntPoint(5265, 6235), new IntPoint(5289,
6235), new IntPoint(5289, 6243), new IntPoint(5315, 6243), new IntPoint(5315, 6285), new IntPoint(5339, 6285), new IntPoint(5339, 6293), new IntPoint(5365, 6293), new IntPoint(5365, 6335), new
IntPoint(5389, 6335), new IntPoint(5389, 6343), new IntPoint(5415, 6343), new IntPoint(5415, 6385), new IntPoint(5439, 6385), new IntPoint(5439, 6393), new IntPoint(5465, 6393), new IntPoint(5465,
6435), new IntPoint(5489, 6435), new IntPoint(5489, 6443), new IntPoint(5515, 6443), new IntPoint(5515, 6485), new IntPoint(5539, 6485), new IntPoint(5539, 6493), new IntPoint(5615, 6493), new
IntPoint(5615, 6535), new IntPoint(5639, 6535), new IntPoint(5639, 6543), new IntPoint(5665, 6543), new IntPoint(5665, 6585), new IntPoint(5689, 6585), new IntPoint(5689, 6593), new IntPoint(5715,
6593), new IntPoint(5715, 6635), new IntPoint(5739, 6635), new IntPoint(5739, 6643), new IntPoint(5765, 6643), new IntPoint(5765, 6685), new IntPoint(5789, 6685), new IntPoint(5789, 6693), new
IntPoint(5815, 6693), new IntPoint(5815, 6835), new IntPoint(5839, 6835), new IntPoint(5839, 6843), new IntPoint(5865, 6843), new IntPoint(5865, 6915), new IntPoint(5815, 6915), new IntPoint(5815,
7115), new IntPoint(5765, 7115), new IntPoint(5765, 7165), new IntPoint(5715, 7165), new IntPoint(5715, 7265), new IntPoint(5665, 7265), new IntPoint(5665, 7315), new IntPoint(5615, 7315), new
IntPoint(5615, 7365), new IntPoint(5515, 7365), new IntPoint(5515, 7415), new IntPoint(5465, 7415), new IntPoint(5465, 7465), new IntPoint(5265, 7465), new IntPoint(5265, 7515), new IntPoint(5009,
7515), new IntPoint(5009, 7471), new IntPoint(4985, 7471), new IntPoint(4985, 7465), new IntPoint(4959, 7465), new IntPoint(4959, 7421), new IntPoint(4935, 7421), new IntPoint(4935, 7415), new
IntPoint(4909, 7415), new IntPoint(4909, 7373), new IntPoint(4885, 7373), new IntPoint(4885, 7365), new IntPoint(4859, 7365), new IntPoint(4859, 7323), new IntPoint(4835, 7323), new IntPoint(4835,
7315), new IntPoint(4809, 7315), new IntPoint(4809, 7273), new IntPoint(4785, 7273), new IntPoint(4785, 7235), new IntPoint(4789, 7235), new IntPoint(4789, 7243), new IntPoint(4859, 7243), new
IntPoint(4859, 7193), new IntPoint(4909, 7193), new IntPoint(4909, 7143), new IntPoint(4959, 7143), new IntPoint(4959, 6623), new IntPoint(4935, 6623), new IntPoint(4935, 6615), new IntPoint(4909,
6615), new IntPoint(4909, 6373), new IntPoint(4885, 6373), new IntPoint(4885, 6365), new IntPoint(4859, 6365), new IntPoint(4859, 6273), new IntPoint(4835, 6273), new IntPoint(4835, 6265), new
IntPoint(4809, 6265), new IntPoint(4809, 6223), new IntPoint(4785, 6223), new IntPoint(4785, 6185), new IntPoint(4789, 6185), new IntPoint(4789, 6193), new IntPoint(4959, 6193), new IntPoint(4959,
6143), new IntPoint(5109, 6143), new IntPoint(5109, 6135), new IntPoint(5139, 6135) }, new Polygon() { new IntPoint(9587, 6393), new IntPoint(9613, 6393), new IntPoint(9613, 6435), new IntPoint(9637,
6435), new IntPoint(9637, 6443), new IntPoint(9713, 6443), new IntPoint(9713, 6485), new IntPoint(9737, 6485), new IntPoint(9737, 6493), new IntPoint(9763, 6493), new IntPoint(9763, 6535), new
IntPoint(9787, 6535), new IntPoint(9787, 6543), new IntPoint(9813, 6543), new IntPoint(9813, 6585), new IntPoint(9837, 6585), new IntPoint(9837, 6593), new IntPoint(9863, 6593), new IntPoint(9863,
6635), new IntPoint(9887, 6635), new IntPoint(9887, 6643), new IntPoint(9913, 6643), new IntPoint(9913, 6815), new IntPoint(9863, 6815), new IntPoint(9863, 6865), new IntPoint(9613, 6865), new
IntPoint(9613, 6915), new IntPoint(9463, 6915), new IntPoint(9463, 6965), new IntPoint(9263, 6965), new IntPoint(9263, 7015), new IntPoint(9113, 7015), new IntPoint(9113, 7065), new IntPoint(9063,
7065), new IntPoint(9063, 7115), new IntPoint(9013, 7115), new IntPoint(9013, 7165), new IntPoint(8913, 7165), new IntPoint(8913, 7215), new IntPoint(8863, 7215), new IntPoint(8863, 7265), new
IntPoint(8813, 7265), new IntPoint(8813, 7315), new IntPoint(8763, 7315), new IntPoint(8763, 7365), new IntPoint(8713, 7365), new IntPoint(8713, 7415), new IntPoint(8663, 7415), new IntPoint(8663,
7465), new IntPoint(8457, 7465), new IntPoint(8457, 7421), new IntPoint(8433, 7421), new IntPoint(8433, 7415), new IntPoint(8407, 7415), new IntPoint(8407, 7373), new IntPoint(8383, 7373), new
IntPoint(8383, 7365), new IntPoint(8357, 7365), new IntPoint(8357, 7273), new IntPoint(8333, 7273), new IntPoint(8333, 7265), new IntPoint(8307, 7265), new IntPoint(8307, 7093), new IntPoint(8357,
7093), new IntPoint(8357, 7043), new IntPoint(8407, 7043), new IntPoint(8407, 6943), new IntPoint(8507, 6943), new IntPoint(8507, 6893), new IntPoint(8557, 6893), new IntPoint(8557, 6843), new
IntPoint(8607, 6843), new IntPoint(8607, 6793), new IntPoint(8707, 6793), new IntPoint(8707, 6743), new IntPoint(8807, 6743), new IntPoint(8807, 6693), new IntPoint(8857, 6693), new IntPoint(8857,
6643), new IntPoint(8957, 6643), new IntPoint(8957, 6593), new IntPoint(9057, 6593), new IntPoint(9057, 6543), new IntPoint(9157, 6543), new IntPoint(9157, 6493), new IntPoint(9207, 6493), new
IntPoint(9207, 6443), new IntPoint(9307, 6443), new IntPoint(9307, 6393), new IntPoint(9557, 6393), new IntPoint(9557, 6385), new IntPoint(9587, 6385) }, new Polygon() { new IntPoint(10937, 5543), new
IntPoint(10963, 5543), new IntPoint(10963, 5685), new IntPoint(10987, 5685), new IntPoint(10987, 5693), new IntPoint(11013, 5693), new IntPoint(11013, 5785), new IntPoint(11037, 5785), new
IntPoint(11037, 5793), new IntPoint(11063, 5793), new IntPoint(11063, 5835), new IntPoint(11087, 5835), new IntPoint(11087, 5843), new IntPoint(11113, 5843), new IntPoint(11113, 5935), new
IntPoint(11137, 5935), new IntPoint(11137, 5943), new IntPoint(11163, 5943), new IntPoint(11163, 6015), new IntPoint(11113, 6015), new IntPoint(11113, 6065), new IntPoint(11063, 6065), new
IntPoint(11063, 6115), new IntPoint(11013, 6115), new IntPoint(11013, 6315), new IntPoint(10963, 6315), new IntPoint(10963, 6585), new IntPoint(10987, 6585), new IntPoint(10987, 6593), new
IntPoint(11013, 6593), new IntPoint(11013, 6715), new IntPoint(10963, 6715), new IntPoint(10963, 6765), new IntPoint(10913, 6765), new IntPoint(10913, 6815), new IntPoint(10813, 6815), new
IntPoint(10813, 6865), new IntPoint(10663, 6865), new IntPoint(10663, 7185), new IntPoint(10687, 7185), new IntPoint(10687, 7193), new IntPoint(10713, 7193), new IntPoint(10713, 7235), new
IntPoint(10737, 7235), new IntPoint(10737, 7243), new IntPoint(11557, 7243), new IntPoint(11557, 7235), new IntPoint(11587, 7235), new IntPoint(11587, 7243), new IntPoint(11613, 7243), new
IntPoint(11613, 7285), new IntPoint(11637, 7285), new IntPoint(11637, 7293), new IntPoint(11663, 7293), new IntPoint(11663, 7365), new IntPoint(11613, 7365), new IntPoint(11613, 7465), new
IntPoint(10857, 7465), new IntPoint(10857, 7421), new IntPoint(10833, 7421), new IntPoint(10833, 7415), new IntPoint(10457, 7415), new IntPoint(10457, 7373), new IntPoint(10433, 7373), new
IntPoint(10433, 7365), new IntPoint(10407, 7365), new IntPoint(10407, 7323), new IntPoint(10383, 7323), new IntPoint(10383, 7315), new IntPoint(10307, 7315), new IntPoint(10307, 7273), new
IntPoint(10283, 7273), new IntPoint(10283, 7265), new IntPoint(10257, 7265), new IntPoint(10257, 7093), new IntPoint(10307, 7093), new IntPoint(10307, 6993), new IntPoint(10357, 6993), new
IntPoint(10357, 6893), new IntPoint(10407, 6893), new IntPoint(10407, 6793), new IntPoint(10457, 6793), new IntPoint(10457, 6423), new IntPoint(10433, 6423), new IntPoint(10433, 6415), new
IntPoint(10407, 6415), new IntPoint(10407, 6373), new IntPoint(10383, 6373), new IntPoint(10383, 6365), new IntPoint(10357, 6365), new IntPoint(10357, 6323), new IntPoint(10333, 6323), new
IntPoint(10333, 6315), new IntPoint(10307, 6315), new IntPoint(10307, 6273), new IntPoint(10283, 6273), new IntPoint(10283, 6265), new IntPoint(10257, 6265), new IntPoint(10257, 6223), new
IntPoint(10233, 6223), new IntPoint(10233, 6215), new IntPoint(10207, 6215), new IntPoint(10207, 6173), new IntPoint(10183, 6173), new IntPoint(10183, 6165), new IntPoint(10107, 6165), new
IntPoint(10107, 6123), new IntPoint(10083, 6123), new IntPoint(10083, 6115), new IntPoint(10057, 6115), new IntPoint(10057, 6043), new IntPoint(10107, 6043), new IntPoint(10107, 5993), new
IntPoint(10257, 5993), new IntPoint(10257, 5943), new IntPoint(10407, 5943), new IntPoint(10407, 5893), new IntPoint(10507, 5893), new IntPoint(10507, 5843), new IntPoint(10607, 5843), new
IntPoint(10607, 5793), new IntPoint(10657, 5793), new IntPoint(10657, 5743), new IntPoint(10707, 5743), new IntPoint(10707, 5693), new IntPoint(10757, 5693), new IntPoint(10757, 5643), new
IntPoint(10807, 5643), new IntPoint(10807, 5593), new IntPoint(10907, 5593), new IntPoint(10907, 5535), new IntPoint(10937, 5535) }, new Polygon() { new IntPoint(12737, 5443), new IntPoint(12763,
5443), new IntPoint(12763, 5485), new IntPoint(12787, 5485), new IntPoint(12787, 5493), new IntPoint(12863, 5493), new IntPoint(12863, 5535), new IntPoint(12887, 5535), new IntPoint(12887, 5543), new
IntPoint(12957, 5543), new IntPoint(12957, 5535), new IntPoint(12987, 5535), new IntPoint(12987, 5543), new IntPoint(13013, 5543), new IntPoint(13013, 5585), new IntPoint(13037, 5585), new
IntPoint(13037, 5593), new IntPoint(13063, 5593), new IntPoint(13063, 5735), new IntPoint(13087, 5735), new IntPoint(13087, 5743), new IntPoint(13113, 5743), new IntPoint(13113, 6615), new
IntPoint(13063, 6615), new IntPoint(13063, 6815), new IntPoint(13013, 6815), new IntPoint(13013, 6865), new IntPoint(12863, 6865), new IntPoint(12863, 6915), new IntPoint(12763, 6915), new
IntPoint(12763, 6965), new IntPoint(12713, 6965), new IntPoint(12713, 7015), new IntPoint(12613, 7015), new IntPoint(12613, 7065), new IntPoint(12513, 7065), new IntPoint(12513, 7115), new
IntPoint(12463, 7115), new IntPoint(12463, 7165), new IntPoint(12413, 7165), new IntPoint(12413, 7215), new IntPoint(12157, 7215), new IntPoint(12157, 7173), new IntPoint(12133, 7173), new
IntPoint(12133, 7165), new IntPoint(12107, 7165), new IntPoint(12107, 6893), new IntPoint(12207, 6893), new IntPoint(12207, 6843), new IntPoint(12307, 6843), new IntPoint(12307, 6793), new
IntPoint(12357, 6793), new IntPoint(12357, 6743), new IntPoint(12507, 6743), new IntPoint(12507, 6693), new IntPoint(12657, 6693), new IntPoint(12657, 6643), new IntPoint(12707, 6643), new
IntPoint(12707, 6593), new IntPoint(12757, 6593), new IntPoint(12757, 6543), new IntPoint(12807, 6543), new IntPoint(12807, 6073), new IntPoint(12783, 6073), new IntPoint(12783, 6065), new
IntPoint(12757, 6065), new IntPoint(12757, 5873), new IntPoint(12733, 5873), new IntPoint(12733, 5865), new IntPoint(12707, 5865), new IntPoint(12707, 5623), new IntPoint(12683, 5623), new
IntPoint(12683, 5615), new IntPoint(12657, 5615), new IntPoint(12657, 5493), new IntPoint(12707, 5493), new IntPoint(12707, 5435), new IntPoint(12737, 5435) }, new Polygon() { new IntPoint(4139,
6143), new IntPoint(4165, 6143), new IntPoint(4165, 6185), new IntPoint(4189, 6185), new IntPoint(4189, 6193), new IntPoint(4215, 6193), new IntPoint(4215, 6235), new IntPoint(4239, 6235), new
IntPoint(4239, 6243), new IntPoint(4265, 6243), new IntPoint(4265, 6285), new IntPoint(4289, 6285), new IntPoint(4289, 6293), new IntPoint(4365, 6293), new IntPoint(4365, 6335), new IntPoint(4389,
6335), new IntPoint(4389, 6343), new IntPoint(4415, 6343), new IntPoint(4415, 6485), new IntPoint(4439, 6485), new IntPoint(4439, 6493), new IntPoint(4465, 6493), new IntPoint(4465, 6635), new
IntPoint(4489, 6635), new IntPoint(4489, 6643), new IntPoint(4515, 6643), new IntPoint(4515, 6865), new IntPoint(4465, 6865), new IntPoint(4465, 6965), new IntPoint(4365, 6965), new IntPoint(4365,
7015), new IntPoint(4265, 7015), new IntPoint(4265, 7065), new IntPoint(4015, 7065), new IntPoint(4015, 7115), new IntPoint(3859, 7115), new IntPoint(3859, 7073), new IntPoint(3835, 7073), new
IntPoint(3835, 7065), new IntPoint(3709, 7065), new IntPoint(3709, 7023), new IntPoint(3685, 7023), new IntPoint(3685, 7015), new IntPoint(3609, 7015), new IntPoint(3609, 6973), new IntPoint(3585,
6973), new IntPoint(3585, 6965), new IntPoint(3559, 6965), new IntPoint(3559, 6923), new IntPoint(3535, 6923), new IntPoint(3535, 6915), new IntPoint(3509, 6915), new IntPoint(3509, 6873), new
IntPoint(3485, 6873), new IntPoint(3485, 6865), new IntPoint(3459, 6865), new IntPoint(3459, 6823), new IntPoint(3435, 6823), new IntPoint(3435, 6785), new IntPoint(3439, 6785), new IntPoint(3439,
6793), new IntPoint(3509, 6793), new IntPoint(3509, 6743), new IntPoint(3909, 6743), new IntPoint(3909, 6693), new IntPoint(3959, 6693), new IntPoint(3959, 6643), new IntPoint(4009, 6643), new
IntPoint(4009, 6593), new IntPoint(4059, 6593), new IntPoint(4059, 6543), new IntPoint(4109, 6543), new IntPoint(4109, 6423), new IntPoint(4085, 6423), new IntPoint(4085, 6415), new IntPoint(4059,
6415), new IntPoint(4059, 6323), new IntPoint(4035, 6323), new IntPoint(4035, 6315), new IntPoint(4009, 6315), new IntPoint(4009, 6273), new IntPoint(3985, 6273), new IntPoint(3985, 6265), new
IntPoint(3959, 6265), new IntPoint(3959, 6223), new IntPoint(3935, 6223), new IntPoint(3935, 6185), new IntPoint(3939, 6185), new IntPoint(3939, 6193), new IntPoint(4009, 6193), new IntPoint(4009,
6143), new IntPoint(4109, 6143), new IntPoint(4109, 6135), new IntPoint(4139, 6135) }, new Polygon() { new IntPoint(4139, 5093), new IntPoint(4165, 5093), new IntPoint(4165, 5135), new IntPoint(4189,
5135), new IntPoint(4189, 5143), new IntPoint(4215, 5143), new IntPoint(4215, 5185), new IntPoint(4239, 5185), new IntPoint(4239, 5193), new IntPoint(4265, 5193), new IntPoint(4265, 5235), new
IntPoint(4289, 5235), new IntPoint(4289, 5243), new IntPoint(4315, 5243), new IntPoint(4315, 5285), new IntPoint(4339, 5285), new IntPoint(4339, 5293), new IntPoint(4365, 5293), new IntPoint(4365,
5335), new IntPoint(4389, 5335), new IntPoint(4389, 5343), new IntPoint(4415, 5343), new IntPoint(4415, 5385), new IntPoint(4439, 5385), new IntPoint(4439, 5393), new IntPoint(4465, 5393), new
IntPoint(4465, 5435), new IntPoint(4489, 5435), new IntPoint(4489, 5443), new IntPoint(4515, 5443), new IntPoint(4515, 5485), new IntPoint(4539, 5485), new IntPoint(4539, 5493), new IntPoint(4565,
5493), new IntPoint(4565, 5535), new IntPoint(4589, 5535), new IntPoint(4589, 5543), new IntPoint(4615, 5543), new IntPoint(4615, 5585), new IntPoint(4639, 5585), new IntPoint(4639, 5593), new
IntPoint(4665, 5593), new IntPoint(4665, 5635), new IntPoint(4689, 5635), new IntPoint(4689, 5643), new IntPoint(4715, 5643), new IntPoint(4715, 5685), new IntPoint(4739, 5685), new IntPoint(4739,
5693), new IntPoint(4765, 5693), new IntPoint(4765, 5735), new IntPoint(4789, 5735), new IntPoint(4789, 5743), new IntPoint(4815, 5743), new IntPoint(4815, 5815), new IntPoint(4515, 5815), new
IntPoint(4515, 5865), new IntPoint(4465, 5865), new IntPoint(4465, 5915), new IntPoint(4409, 5915), new IntPoint(4409, 5873), new IntPoint(4385, 5873), new IntPoint(4385, 5865), new IntPoint(4359,
5865), new IntPoint(4359, 5823), new IntPoint(4335, 5823), new IntPoint(4335, 5815), new IntPoint(4259, 5815), new IntPoint(4259, 5773), new IntPoint(4235, 5773), new IntPoint(4235, 5765), new
IntPoint(3765, 5765), new IntPoint(3765, 5815), new IntPoint(3615, 5815), new IntPoint(3615, 5865), new IntPoint(3515, 5865), new IntPoint(3515, 5915), new IntPoint(3415, 5915), new IntPoint(3415,
5965), new IntPoint(3365, 5965), new IntPoint(3365, 6065), new IntPoint(3315, 6065), new IntPoint(3315, 6115), new IntPoint(3265, 6115), new IntPoint(3265, 6165), new IntPoint(3215, 6165), new
IntPoint(3215, 6215), new IntPoint(3165, 6215), new IntPoint(3165, 6315), new IntPoint(3115, 6315), new IntPoint(3115, 6365), new IntPoint(3065, 6365), new IntPoint(3065, 6465), new IntPoint(3015,
6465), new IntPoint(3015, 7015), new IntPoint(2965, 7015), new IntPoint(2965, 7065), new IntPoint(2909, 7065), new IntPoint(2909, 7023), new IntPoint(2885, 7023), new IntPoint(2885, 7015), new
IntPoint(2859, 7015), new IntPoint(2859, 6673), new IntPoint(2835, 6673), new IntPoint(2835, 6665), new IntPoint(2809, 6665), new IntPoint(2809, 6373), new IntPoint(2785, 6373), new IntPoint(2785,
6335), new IntPoint(2789, 6335), new IntPoint(2789, 6343), new IntPoint(2859, 6343), new IntPoint(2859, 6293), new IntPoint(2909, 6293), new IntPoint(2909, 6243), new IntPoint(2959, 6243), new
IntPoint(2959, 6193), new IntPoint(3009, 6193), new IntPoint(3009, 6143), new IntPoint(3059, 6143), new IntPoint(3059, 6073), new IntPoint(3035, 6073), new IntPoint(3035, 6035), new IntPoint(3039,
6035), new IntPoint(3039, 6043), new IntPoint(3109, 6043), new IntPoint(3109, 5993), new IntPoint(3159, 5993), new IntPoint(3159, 5673), new IntPoint(3135, 5673), new IntPoint(3135, 5665), new
IntPoint(3109, 5665), new IntPoint(3109, 5573), new IntPoint(3085, 5573), new IntPoint(3085, 5565), new IntPoint(3059, 5565), new IntPoint(3059, 5523), new IntPoint(3035, 5523), new IntPoint(3035,
5515), new IntPoint(3009, 5515), new IntPoint(3009, 5473), new IntPoint(2985, 5473), new IntPoint(2985, 5435), new IntPoint(2989, 5435), new IntPoint(2989, 5443), new IntPoint(3059, 5443), new
IntPoint(3059, 5393), new IntPoint(3309, 5393), new IntPoint(3309, 5343), new IntPoint(3459, 5343), new IntPoint(3459, 5293), new IntPoint(3609, 5293), new IntPoint(3609, 5243), new IntPoint(3759,
5243), new IntPoint(3759, 5193), new IntPoint(3909, 5193), new IntPoint(3909, 5143), new IntPoint(4009, 5143), new IntPoint(4009, 5093), new IntPoint(4109, 5093), new IntPoint(4109, 5085), new
IntPoint(4139, 5085) }, new Polygon() { new IntPoint(1389, 6593), new IntPoint(1509, 6593), new IntPoint(1509, 6585), new IntPoint(1539, 6585), new IntPoint(1539, 6593), new IntPoint(1565, 6593), new
IntPoint(1565, 6635), new IntPoint(1589, 6635), new IntPoint(1589, 6643), new IntPoint(1615, 6643), new IntPoint(1615, 6765), new IntPoint(1565, 6765), new IntPoint(1565, 6815), new IntPoint(1459,
6815), new IntPoint(1459, 6773), new IntPoint(1435, 6773), new IntPoint(1435, 6765), new IntPoint(1409, 6765), new IntPoint(1409, 6723), new IntPoint(1385, 6723), new IntPoint(1385, 6715), new
IntPoint(1335, 6715), new IntPoint(1335, 6685), new IntPoint(1339, 6685), new IntPoint(1339, 6693), new IntPoint(1409, 6693), new IntPoint(1409, 6623), new IntPoint(1385, 6623), new IntPoint(1385,
6585), new IntPoint(1389, 6585) }, new Polygon() { new IntPoint(8437, 5793), new IntPoint(8463, 5793), new IntPoint(8463, 5865), new IntPoint(8413, 5865), new IntPoint(8413, 5915), new IntPoint(8313,
5915), new IntPoint(8313, 5965), new IntPoint(8213, 5965), new IntPoint(8213, 6015), new IntPoint(8163, 6015), new IntPoint(8163, 6065), new IntPoint(8063, 6065), new IntPoint(8063, 6115), new
IntPoint(7963, 6115), new IntPoint(7963, 6165), new IntPoint(7913, 6165), new IntPoint(7913, 6215), new IntPoint(7863, 6215), new IntPoint(7863, 6265), new IntPoint(7763, 6265), new IntPoint(7763,
6315), new IntPoint(7713, 6315), new IntPoint(7713, 6365), new IntPoint(7663, 6365), new IntPoint(7663, 6415), new IntPoint(7613, 6415), new IntPoint(7613, 6515), new IntPoint(7563, 6515), new
IntPoint(7563, 6565), new IntPoint(7513, 6565), new IntPoint(7513, 6615), new IntPoint(7463, 6615), new IntPoint(7463, 6665), new IntPoint(7359, 6665), new IntPoint(7359, 6623), new IntPoint(7335,
6623), new IntPoint(7335, 6615), new IntPoint(7309, 6615), new IntPoint(7309, 6443), new IntPoint(7359, 6443), new IntPoint(7359, 6393), new IntPoint(7407, 6393), new IntPoint(7407, 6343), new
IntPoint(7457, 6343), new IntPoint(7457, 6293), new IntPoint(7507, 6293), new IntPoint(7507, 6243), new IntPoint(7557, 6243), new IntPoint(7557, 6193), new IntPoint(7657, 6193), new IntPoint(7657,
6143), new IntPoint(7707, 6143), new IntPoint(7707, 6093), new IntPoint(7807, 6093), new IntPoint(7807, 6043), new IntPoint(7907, 6043), new IntPoint(7907, 5993), new IntPoint(7957, 5993), new
IntPoint(7957, 5943), new IntPoint(8057, 5943), new IntPoint(8057, 5893), new IntPoint(8207, 5893), new IntPoint(8207, 5843), new IntPoint(8357, 5843), new IntPoint(8357, 5793), new IntPoint(8407,
5793), new IntPoint(8407, 5785), new IntPoint(8437, 5785) }, new Polygon() { new IntPoint(5889, 6293), new IntPoint(5915, 6293), new IntPoint(5915, 6335), new IntPoint(5939, 6335), new IntPoint(5939,
6343), new IntPoint(5965, 6343), new IntPoint(5965, 6415), new IntPoint(5915, 6415), new IntPoint(5915, 6515), new IntPoint(5759, 6515), new IntPoint(5759, 6473), new IntPoint(5735, 6473), new
IntPoint(5735, 6465), new IntPoint(5709, 6465), new IntPoint(5709, 6373), new IntPoint(5685, 6373), new IntPoint(5685, 6335), new IntPoint(5689, 6335), new IntPoint(5689, 6343), new IntPoint(5759,
6343), new IntPoint(5759, 6293), new IntPoint(5859, 6293), new IntPoint(5859, 6285), new IntPoint(5889, 6285) }, new Polygon() { new IntPoint(12187, 5043), new IntPoint(12213, 5043), new
IntPoint(12213, 5585), new IntPoint(12237, 5585), new IntPoint(12237, 5593), new IntPoint(12263, 5593), new IntPoint(12263, 5935), new IntPoint(12287, 5935), new IntPoint(12287, 5943), new
IntPoint(12313, 5943), new IntPoint(12313, 6165), new IntPoint(12263, 6165), new IntPoint(12263, 6315), new IntPoint(12213, 6315), new IntPoint(12213, 6365), new IntPoint(12113, 6365), new
IntPoint(12113, 6415), new IntPoint(11963, 6415), new IntPoint(11963, 6465), new IntPoint(11863, 6465), new IntPoint(11863, 6515), new IntPoint(11707, 6515), new IntPoint(11707, 6473), new
IntPoint(11683, 6473), new IntPoint(11683, 6465), new IntPoint(11607, 6465), new IntPoint(11607, 6423), new IntPoint(11583, 6423), new IntPoint(11583, 6415), new IntPoint(11507, 6415), new
IntPoint(11507, 6343), new IntPoint(11557, 6343), new IntPoint(11557, 6293), new IntPoint(11607, 6293), new IntPoint(11607, 6243), new IntPoint(11657, 6243), new IntPoint(11657, 6193), new
IntPoint(11707, 6193), new IntPoint(11707, 6143), new IntPoint(11757, 6143), new IntPoint(11757, 6093), new IntPoint(11807, 6093), new IntPoint(11807, 6043), new IntPoint(11857, 6043), new
IntPoint(11857, 5993), new IntPoint(11907, 5993), new IntPoint(11907, 5943), new IntPoint(11957, 5943), new IntPoint(11957, 5893), new IntPoint(12007, 5893), new IntPoint(12007, 5493), new
IntPoint(12057, 5493), new IntPoint(12057, 5343), new IntPoint(12107, 5343), new IntPoint(12107, 5243), new IntPoint(12157, 5243), new IntPoint(12157, 5035), new IntPoint(12187, 5035) }, new Polygon()
{ new IntPoint(6639, 4843), new IntPoint(6665, 4843), new IntPoint(6665, 4935), new IntPoint(6689, 4935), new IntPoint(6689, 4943), new IntPoint(6715, 4943), new IntPoint(6715, 5235), new
IntPoint(6739, 5235), new IntPoint(6739, 5243), new IntPoint(6765, 5243), new IntPoint(6765, 5635), new IntPoint(6789, 5635), new IntPoint(6789, 5643), new IntPoint(7209, 5643), new IntPoint(7209,
5243), new IntPoint(7607, 5243), new IntPoint(7607, 5235), new IntPoint(7637, 5235), new IntPoint(7637, 5243), new IntPoint(7663, 5243), new IntPoint(7663, 5565), new IntPoint(7613, 5565), new
IntPoint(7613, 5615), new IntPoint(7563, 5615), new IntPoint(7563, 5665), new IntPoint(7513, 5665), new IntPoint(7513, 5715), new IntPoint(7413, 5715), new IntPoint(7413, 5765), new IntPoint(7363,
5765), new IntPoint(7363, 5815), new IntPoint(7315, 5815), new IntPoint(7315, 5865), new IntPoint(7215, 5865), new IntPoint(7215, 5915), new IntPoint(7165, 5915), new IntPoint(7165, 5965), new
IntPoint(7115, 5965), new IntPoint(7115, 6015), new IntPoint(7065, 6015), new IntPoint(7065, 6065), new IntPoint(6965, 6065), new IntPoint(6965, 6115), new IntPoint(6915, 6115), new IntPoint(6915,
6165), new IntPoint(6659, 6165), new IntPoint(6659, 6123), new IntPoint(6635, 6123), new IntPoint(6635, 6115), new IntPoint(6609, 6115), new IntPoint(6609, 6073), new IntPoint(6585, 6073), new
IntPoint(6585, 6065), new IntPoint(6559, 6065), new IntPoint(6559, 5973), new IntPoint(6535, 5973), new IntPoint(6535, 5965), new IntPoint(6509, 5965), new IntPoint(6509, 5923), new IntPoint(6485,
5923), new IntPoint(6485, 5915), new IntPoint(6459, 5915), new IntPoint(6459, 5873), new IntPoint(6435, 5873), new IntPoint(6435, 5865), new IntPoint(6409, 5865), new IntPoint(6409, 5823), new
IntPoint(6385, 5823), new IntPoint(6385, 5815), new IntPoint(6359, 5815), new IntPoint(6359, 5773), new IntPoint(6335, 5773), new IntPoint(6335, 5765), new IntPoint(6309, 5765), new IntPoint(6309,
5723), new IntPoint(6285, 5723), new IntPoint(6285, 5715), new IntPoint(6259, 5715), new IntPoint(6259, 5673), new IntPoint(6235, 5673), new IntPoint(6235, 5665), new IntPoint(6209, 5665), new
IntPoint(6209, 5623), new IntPoint(6185, 5623), new IntPoint(6185, 5615), new IntPoint(6159, 5615), new IntPoint(6159, 5573), new IntPoint(6135, 5573), new IntPoint(6135, 5565), new IntPoint(6109,
5565), new IntPoint(6109, 5523), new IntPoint(6085, 5523), new IntPoint(6085, 5515), new IntPoint(6059, 5515), new IntPoint(6059, 5473), new IntPoint(6035, 5473), new IntPoint(6035, 5465), new
IntPoint(6009, 5465), new IntPoint(6009, 5423), new IntPoint(5985, 5423), new IntPoint(5985, 5415), new IntPoint(5959, 5415), new IntPoint(5959, 5373), new IntPoint(5935, 5373), new IntPoint(5935,
5365), new IntPoint(5909, 5365), new IntPoint(5909, 5243), new IntPoint(6009, 5243), new IntPoint(6009, 5235), new IntPoint(6039, 5235), new IntPoint(6039, 5243), new IntPoint(6065, 5243), new
IntPoint(6065, 5335), new IntPoint(6089, 5335), new IntPoint(6089, 5343), new IntPoint(6459, 5343), new IntPoint(6459, 4893), new IntPoint(6559, 4893), new IntPoint(6559, 4843), new IntPoint(6609,
4843), new IntPoint(6609, 4835), new IntPoint(6639, 4835) }, new Polygon() { new IntPoint(12637, 3243), new IntPoint(12663, 3243), new IntPoint(12663, 3285), new IntPoint(12687, 3285), new
IntPoint(12687, 3293), new IntPoint(12713, 3293), new IntPoint(12713, 3335), new IntPoint(12737, 3335), new IntPoint(12737, 3343), new IntPoint(12763, 3343), new IntPoint(12763, 3385), new
IntPoint(12787, 3385), new IntPoint(12787, 3393), new IntPoint(12813, 3393), new IntPoint(12813, 3435), new IntPoint(12837, 3435), new IntPoint(12837, 3443), new IntPoint(12863, 3443), new
IntPoint(12863, 3535), new IntPoint(12887, 3535), new IntPoint(12887, 3543), new IntPoint(12913, 3543), new IntPoint(12913, 3685), new IntPoint(12937, 3685), new IntPoint(12937, 3693), new
IntPoint(12963, 3693), new IntPoint(12963, 3835), new IntPoint(12987, 3835), new IntPoint(12987, 3843), new IntPoint(13013, 3843), new IntPoint(13013, 5065), new IntPoint(12957, 5065), new
IntPoint(12957, 5023), new IntPoint(12933, 5023), new IntPoint(12933, 5015), new IntPoint(12857, 5015), new IntPoint(12857, 4973), new IntPoint(12833, 4973), new IntPoint(12833, 4965), new
IntPoint(12807, 4965), new IntPoint(12807, 4923), new IntPoint(12783, 4923), new IntPoint(12783, 4915), new IntPoint(12707, 4915), new IntPoint(12707, 4873), new IntPoint(12683, 4873), new
IntPoint(12683, 4865), new IntPoint(12657, 4865), new IntPoint(12657, 4823), new IntPoint(12633, 4823), new IntPoint(12633, 4815), new IntPoint(12607, 4815), new IntPoint(12607, 4623), new
IntPoint(12583, 4623), new IntPoint(12583, 4615), new IntPoint(12557, 4615), new IntPoint(12557, 4573), new IntPoint(12533, 4573), new IntPoint(12533, 4565), new IntPoint(12507, 4565), new
IntPoint(12507, 4473), new IntPoint(12483, 4473), new IntPoint(12483, 4465), new IntPoint(12313, 4465), new IntPoint(12313, 4515), new IntPoint(12013, 4515), new IntPoint(12013, 4615), new
IntPoint(11963, 4615), new IntPoint(11963, 4665), new IntPoint(11913, 4665), new IntPoint(11913, 4715), new IntPoint(11863, 4715), new IntPoint(11863, 4765), new IntPoint(11813, 4765), new
IntPoint(11813, 4865), new IntPoint(11763, 4865), new IntPoint(11763, 4915), new IntPoint(11713, 4915), new IntPoint(11713, 4965), new IntPoint(11663, 4965), new IntPoint(11663, 5065), new
IntPoint(11613, 5065), new IntPoint(11613, 5115), new IntPoint(11563, 5115), new IntPoint(11563, 5165), new IntPoint(11513, 5165), new IntPoint(11513, 5385), new IntPoint(11537, 5385), new
IntPoint(11537, 5393), new IntPoint(11563, 5393), new IntPoint(11563, 5615), new IntPoint(11507, 5615), new IntPoint(11507, 5573), new IntPoint(11483, 5573), new IntPoint(11483, 5565), new
IntPoint(11457, 5565), new IntPoint(11457, 5473), new IntPoint(11433, 5473), new IntPoint(11433, 5465), new IntPoint(11407, 5465), new IntPoint(11407, 5323), new IntPoint(11383, 5323), new
IntPoint(11383, 5315), new IntPoint(11357, 5315), new IntPoint(11357, 5143), new IntPoint(11407, 5143), new IntPoint(11407, 5093), new IntPoint(11457, 5093), new IntPoint(11457, 5043), new
IntPoint(11507, 5043), new IntPoint(11507, 4943), new IntPoint(11557, 4943), new IntPoint(11557, 4893), new IntPoint(11607, 4893), new IntPoint(11607, 4843), new IntPoint(11657, 4843), new
IntPoint(11657, 4743), new IntPoint(11707, 4743), new IntPoint(11707, 4693), new IntPoint(11757, 4693), new IntPoint(11757, 4643), new IntPoint(11807, 4643), new IntPoint(11807, 4543), new
IntPoint(11857, 4543), new IntPoint(11857, 4393), new IntPoint(11907, 4393), new IntPoint(11907, 4193), new IntPoint(11957, 4193), new IntPoint(11957, 3943), new IntPoint(12007, 3943), new
IntPoint(12007, 3793), new IntPoint(12057, 3793), new IntPoint(12057, 3643), new IntPoint(12107, 3643), new IntPoint(12107, 3543), new IntPoint(12157, 3543), new IntPoint(12157, 3493), new
IntPoint(12207, 3493), new IntPoint(12207, 3443), new IntPoint(12257, 3443), new IntPoint(12257, 3393), new IntPoint(12307, 3393), new IntPoint(12307, 3343), new IntPoint(12357, 3343), new
IntPoint(12357, 3293), new IntPoint(12507, 3293), new IntPoint(12507, 3243), new IntPoint(12607, 3243), new IntPoint(12607, 3235), new IntPoint(12637, 3235) }, new Polygon() { new IntPoint(10337,
3293), new IntPoint(10363, 3293), new IntPoint(10363, 3535), new IntPoint(10387, 3535), new IntPoint(10387, 3543), new IntPoint(10413, 3543), new IntPoint(10413, 3635), new IntPoint(10437, 3635), new
IntPoint(10437, 3643), new IntPoint(10463, 3643), new IntPoint(10463, 3685), new IntPoint(10487, 3685), new IntPoint(10487, 3693), new IntPoint(10707, 3693), new IntPoint(10707, 3635), new
IntPoint(10737, 3635), new IntPoint(10737, 3643), new IntPoint(10763, 3643), new IntPoint(10763, 3685), new IntPoint(10787, 3685), new IntPoint(10787, 3693), new IntPoint(10863, 3693), new
IntPoint(10863, 3735), new IntPoint(10887, 3735), new IntPoint(10887, 3743), new IntPoint(10913, 3743), new IntPoint(10913, 3785), new IntPoint(10937, 3785), new IntPoint(10937, 3793), new
IntPoint(10963, 3793), new IntPoint(10963, 4015), new IntPoint(10913, 4015), new IntPoint(10913, 4165), new IntPoint(10863, 4165), new IntPoint(10863, 4315), new IntPoint(10813, 4315), new
IntPoint(10813, 4365), new IntPoint(10763, 4365), new IntPoint(10763, 4415), new IntPoint(10663, 4415), new IntPoint(10663, 4465), new IntPoint(10613, 4465), new IntPoint(10613, 4515), new
IntPoint(10563, 4515), new IntPoint(10563, 4565), new IntPoint(10513, 4565), new IntPoint(10513, 4615), new IntPoint(10463, 4615), new IntPoint(10463, 4665), new IntPoint(10413, 4665), new
IntPoint(10413, 4715), new IntPoint(10357, 4715), new IntPoint(10357, 4673), new IntPoint(10333, 4673), new IntPoint(10333, 4665), new IntPoint(10307, 4665), new IntPoint(10307, 4593), new
IntPoint(10357, 4593), new IntPoint(10357, 4543), new IntPoint(10407, 4543), new IntPoint(10407, 4493), new IntPoint(10457, 4493), new IntPoint(10457, 4443), new IntPoint(10507, 4443), new
IntPoint(10507, 4273), new IntPoint(10483, 4273), new IntPoint(10483, 4265), new IntPoint(10457, 4265), new IntPoint(10457, 4223), new IntPoint(10433, 4223), new IntPoint(10433, 4215), new
IntPoint(10407, 4215), new IntPoint(10407, 4173), new IntPoint(10383, 4173), new IntPoint(10383, 4165), new IntPoint(10357, 4165), new IntPoint(10357, 4123), new IntPoint(10333, 4123), new
IntPoint(10333, 4115), new IntPoint(10307, 4115), new IntPoint(10307, 4073), new IntPoint(10283, 4073), new IntPoint(10283, 4065), new IntPoint(10257, 4065), new IntPoint(10257, 4023), new
IntPoint(10233, 4023), new IntPoint(10233, 4015), new IntPoint(10207, 4015), new IntPoint(10207, 3973), new IntPoint(10183, 3973), new IntPoint(10183, 3965), new IntPoint(10157, 3965), new
IntPoint(10157, 3923), new IntPoint(10133, 3923), new IntPoint(10133, 3915), new IntPoint(10107, 3915), new IntPoint(10107, 3873), new IntPoint(10083, 3873), new IntPoint(10083, 3865), new
IntPoint(9957, 3865), new IntPoint(9957, 3823), new IntPoint(9933, 3823), new IntPoint(9933, 3815), new IntPoint(9713, 3815), new IntPoint(9713, 3865), new IntPoint(9663, 3865), new IntPoint(9663,
3915), new IntPoint(9613, 3915), new IntPoint(9613, 3965), new IntPoint(9563, 3965), new IntPoint(9563, 4015), new IntPoint(9513, 4015), new IntPoint(9513, 4065), new IntPoint(9463, 4065), new
IntPoint(9463, 4115), new IntPoint(9363, 4115), new IntPoint(9363, 4165), new IntPoint(9313, 4165), new IntPoint(9313, 4265), new IntPoint(9263, 4265), new IntPoint(9263, 4535), new IntPoint(9287,
4535), new IntPoint(9287, 4543), new IntPoint(9313, 4543), new IntPoint(9313, 4685), new IntPoint(9337, 4685), new IntPoint(9337, 4693), new IntPoint(9363, 4693), new IntPoint(9363, 4785), new
IntPoint(9387, 4785), new IntPoint(9387, 4793), new IntPoint(9413, 4793), new IntPoint(9413, 4835), new IntPoint(9437, 4835), new IntPoint(9437, 4843), new IntPoint(9463, 4843), new IntPoint(9463,
4885), new IntPoint(9487, 4885), new IntPoint(9487, 4893), new IntPoint(9513, 4893), new IntPoint(9513, 4935), new IntPoint(9537, 4935), new IntPoint(9537, 4943), new IntPoint(9963, 4943), new
IntPoint(9963, 5065), new IntPoint(9863, 5065), new IntPoint(9863, 5115), new IntPoint(9763, 5115), new IntPoint(9763, 5165), new IntPoint(9663, 5165), new IntPoint(9663, 5215), new IntPoint(9563,
5215), new IntPoint(9563, 5265), new IntPoint(9413, 5265), new IntPoint(9413, 5315), new IntPoint(9213, 5315), new IntPoint(9213, 5365), new IntPoint(9013, 5365), new IntPoint(9013, 5415), new
IntPoint(8757, 5415), new IntPoint(8757, 5373), new IntPoint(8733, 5373), new IntPoint(8733, 5365), new IntPoint(8707, 5365), new IntPoint(8707, 5143), new IntPoint(8757, 5143), new IntPoint(8757,
5093), new IntPoint(8857, 5093), new IntPoint(8857, 5043), new IntPoint(8907, 5043), new IntPoint(8907, 4993), new IntPoint(8957, 4993), new IntPoint(8957, 4943), new IntPoint(9007, 4943), new
IntPoint(9007, 4893), new IntPoint(9057, 4893), new IntPoint(9057, 4793), new IntPoint(9107, 4793), new IntPoint(9107, 4523), new IntPoint(9083, 4523), new IntPoint(9083, 4515), new IntPoint(9057,
4515), new IntPoint(9057, 4293), new IntPoint(9107, 4293), new IntPoint(9107, 4093), new IntPoint(9157, 4093), new IntPoint(9157, 3943), new IntPoint(9207, 3943), new IntPoint(9207, 3893), new
IntPoint(9257, 3893), new IntPoint(9257, 3843), new IntPoint(9307, 3843), new IntPoint(9307, 3793), new IntPoint(9357, 3793), new IntPoint(9357, 3743), new IntPoint(9407, 3743), new IntPoint(9407,
3693), new IntPoint(9457, 3693), new IntPoint(9457, 3643), new IntPoint(9507, 3643), new IntPoint(9507, 3593), new IntPoint(9607, 3593), new IntPoint(9607, 3543), new IntPoint(9707, 3543), new
IntPoint(9707, 3493), new IntPoint(9807, 3493), new IntPoint(9807, 3443), new IntPoint(9907, 3443), new IntPoint(9907, 3393), new IntPoint(10007, 3393), new IntPoint(10007, 3343), new IntPoint(10107,
3343), new IntPoint(10107, 3293), new IntPoint(10307, 3293), new IntPoint(10307, 3285), new IntPoint(10337, 3285) }, new Polygon() { new IntPoint(2439, 4743), new IntPoint(2465, 4743), new
IntPoint(2465, 4785), new IntPoint(2489, 4785), new IntPoint(2489, 4793), new IntPoint(2515, 4793), new IntPoint(2515, 4965), new IntPoint(2415, 4965), new IntPoint(2415, 5015), new IntPoint(1709,
5015), new IntPoint(1709, 4923), new IntPoint(1685, 4923), new IntPoint(1685, 4915), new IntPoint(1659, 4915), new IntPoint(1659, 4823), new IntPoint(1635, 4823), new IntPoint(1635, 4785), new
IntPoint(1639, 4785), new IntPoint(1639, 4793), new IntPoint(1709, 4793), new IntPoint(1709, 4743), new IntPoint(2409, 4743), new IntPoint(2409, 4735), new IntPoint(2439, 4735) }, new Polygon() { new
IntPoint(5089, 4693), new IntPoint(5115, 4693), new IntPoint(5115, 4735), new IntPoint(5139, 4735), new IntPoint(5139, 4743), new IntPoint(5165, 4743), new IntPoint(5165, 4865), new IntPoint(5115,
4865), new IntPoint(5115, 4915), new IntPoint(4959, 4915), new IntPoint(4959, 4873), new IntPoint(4935, 4873), new IntPoint(4935, 4865), new IntPoint(4909, 4865), new IntPoint(4909, 4743), new
IntPoint(4959, 4743), new IntPoint(4959, 4693), new IntPoint(5059, 4693), new IntPoint(5059, 4685), new IntPoint(5089, 4685) }, new Polygon() { new IntPoint(3639, 4343), new IntPoint(3665, 4343), new
IntPoint(3665, 4385), new IntPoint(3689, 4385), new IntPoint(3689, 4393), new IntPoint(3715, 4393), new IntPoint(3715, 4565), new IntPoint(3665, 4565), new IntPoint(3665, 4615), new IntPoint(3565,
4615), new IntPoint(3565, 4665), new IntPoint(3465, 4665), new IntPoint(3465, 4715), new IntPoint(3365, 4715), new IntPoint(3365, 4765), new IntPoint(3265, 4765), new IntPoint(3265, 4815), new
IntPoint(3115, 4815), new IntPoint(3115, 4865), new IntPoint(3065, 4865), new IntPoint(3065, 4915), new IntPoint(2909, 4915), new IntPoint(2909, 4873), new IntPoint(2885, 4873), new IntPoint(2885,
4865), new IntPoint(2859, 4865), new IntPoint(2859, 4723), new IntPoint(2835, 4723), new IntPoint(2835, 4685), new IntPoint(2839, 4685), new IntPoint(2839, 4693), new IntPoint(2909, 4693), new
IntPoint(2909, 4643), new IntPoint(2959, 4643), new IntPoint(2959, 4593), new IntPoint(3109, 4593), new IntPoint(3109, 4543), new IntPoint(3259, 4543), new IntPoint(3259, 4493), new IntPoint(3359,
4493), new IntPoint(3359, 4443), new IntPoint(3409, 4443), new IntPoint(3409, 4393), new IntPoint(3509, 4393), new IntPoint(3509, 4343), new IntPoint(3609, 4343), new IntPoint(3609, 4335), new
IntPoint(3639, 4335) }, new Polygon() { new IntPoint(5589, 3793), new IntPoint(5615, 3793), new IntPoint(5615, 3935), new IntPoint(5639, 3935), new IntPoint(5639, 3943), new IntPoint(5665, 3943), new
IntPoint(5665, 4035), new IntPoint(5689, 4035), new IntPoint(5689, 4043), new IntPoint(5715, 4043), new IntPoint(5715, 4185), new IntPoint(5739, 4185), new IntPoint(5739, 4193), new IntPoint(5765,
4193), new IntPoint(5765, 4285), new IntPoint(5789, 4285), new IntPoint(5789, 4293), new IntPoint(5815, 4293), new IntPoint(5815, 4385), new IntPoint(5839, 4385), new IntPoint(5839, 4393), new
IntPoint(5865, 4393), new IntPoint(5865, 4485), new IntPoint(5889, 4485), new IntPoint(5889, 4493), new IntPoint(5915, 4493), new IntPoint(5915, 4585), new IntPoint(5939, 4585), new IntPoint(5939,
4593), new IntPoint(5965, 4593), new IntPoint(5965, 4685), new IntPoint(5989, 4685), new IntPoint(5989, 4693), new IntPoint(6015, 4693), new IntPoint(6015, 4735), new IntPoint(6039, 4735), new
IntPoint(6039, 4743), new IntPoint(6065, 4743), new IntPoint(6065, 4865), new IntPoint(5865, 4865), new IntPoint(5865, 4915), new IntPoint(5559, 4915), new IntPoint(5559, 4873), new IntPoint(5535,
4873), new IntPoint(5535, 4865), new IntPoint(5459, 4865), new IntPoint(5459, 4823), new IntPoint(5435, 4823), new IntPoint(5435, 4815), new IntPoint(5359, 4815), new IntPoint(5359, 4773), new
IntPoint(5335, 4773), new IntPoint(5335, 4765), new IntPoint(5309, 4765), new IntPoint(5309, 4723), new IntPoint(5285, 4723), new IntPoint(5285, 4715), new IntPoint(5259, 4715), new IntPoint(5259,
4673), new IntPoint(5235, 4673), new IntPoint(5235, 4665), new IntPoint(5209, 4665), new IntPoint(5209, 4623), new IntPoint(5185, 4623), new IntPoint(5185, 4615), new IntPoint(5159, 4615), new
IntPoint(5159, 4573), new IntPoint(5135, 4573), new IntPoint(5135, 4565), new IntPoint(5109, 4565), new IntPoint(5109, 4523), new IntPoint(5085, 4523), new IntPoint(5085, 4515), new IntPoint(5059,
4515), new IntPoint(5059, 4473), new IntPoint(5035, 4473), new IntPoint(5035, 4465), new IntPoint(5009, 4465), new IntPoint(5009, 4423), new IntPoint(4985, 4423), new IntPoint(4985, 4415), new
IntPoint(4959, 4415), new IntPoint(4959, 4373), new IntPoint(4935, 4373), new IntPoint(4935, 4365), new IntPoint(4909, 4365), new IntPoint(4909, 4273), new IntPoint(4885, 4273), new IntPoint(4885,
4265), new IntPoint(4859, 4265), new IntPoint(4859, 4193), new IntPoint(4909, 4193), new IntPoint(4909, 4143), new IntPoint(5059, 4143), new IntPoint(5059, 4043), new IntPoint(5109, 4043), new
IntPoint(5109, 3943), new IntPoint(5159, 3943), new IntPoint(5159, 3893), new IntPoint(5209, 3893), new IntPoint(5209, 3793), new IntPoint(5559, 3793), new IntPoint(5559, 3785), new IntPoint(5589,
3785) }, new Polygon() { new IntPoint(8137, 3543), new IntPoint(8163, 3543), new IntPoint(8163, 3585), new IntPoint(8187, 3585), new IntPoint(8187, 3593), new IntPoint(8213, 3593), new IntPoint(8213,
3635), new IntPoint(8237, 3635), new IntPoint(8237, 3643), new IntPoint(8313, 3643), new IntPoint(8313, 3685), new IntPoint(8337, 3685), new IntPoint(8337, 3693), new IntPoint(8363, 3693), new
IntPoint(8363, 3785), new IntPoint(8387, 3785), new IntPoint(8387, 3793), new IntPoint(8413, 3793), new IntPoint(8413, 3835), new IntPoint(8437, 3835), new IntPoint(8437, 3843), new IntPoint(8463,
3843), new IntPoint(8463, 3885), new IntPoint(8487, 3885), new IntPoint(8487, 3893), new IntPoint(8513, 3893), new IntPoint(8513, 3935), new IntPoint(8537, 3935), new IntPoint(8537, 3943), new
IntPoint(8563, 3943), new IntPoint(8563, 4515), new IntPoint(8513, 4515), new IntPoint(8513, 4665), new IntPoint(8463, 4665), new IntPoint(8463, 4715), new IntPoint(7707, 4715), new IntPoint(7707,
4673), new IntPoint(7683, 4673), new IntPoint(7683, 4665), new IntPoint(7507, 4665), new IntPoint(7507, 4623), new IntPoint(7483, 4623), new IntPoint(7483, 4615), new IntPoint(7359, 4615), new
IntPoint(7359, 4573), new IntPoint(7335, 4573), new IntPoint(7335, 4565), new IntPoint(7259, 4565), new IntPoint(7259, 4523), new IntPoint(7235, 4523), new IntPoint(7235, 4515), new IntPoint(7109,
4515), new IntPoint(7109, 4093), new IntPoint(7159, 4093), new IntPoint(7159, 3993), new IntPoint(7359, 3993), new IntPoint(7359, 3985), new IntPoint(7387, 3985), new IntPoint(7387, 3993), new
IntPoint(7413, 3993), new IntPoint(7413, 4185), new IntPoint(7437, 4185), new IntPoint(7437, 4193), new IntPoint(7513, 4193), new IntPoint(7513, 4235), new IntPoint(7537, 4235), new IntPoint(7537,
4243), new IntPoint(7563, 4243), new IntPoint(7563, 4285), new IntPoint(7587, 4285), new IntPoint(7587, 4293), new IntPoint(7657, 4293), new IntPoint(7657, 4285), new IntPoint(7687, 4285), new
IntPoint(7687, 4293), new IntPoint(7713, 4293), new IntPoint(7713, 4335), new IntPoint(7737, 4335), new IntPoint(7737, 4343), new IntPoint(7907, 4343), new IntPoint(7907, 4293), new IntPoint(8057,
4293), new IntPoint(8057, 3873), new IntPoint(8033, 3873), new IntPoint(8033, 3865), new IntPoint(8007, 3865), new IntPoint(8007, 3823), new IntPoint(7983, 3823), new IntPoint(7983, 3815), new
IntPoint(7907, 3815), new IntPoint(7907, 3773), new IntPoint(7883, 3773), new IntPoint(7883, 3765), new IntPoint(7857, 3765), new IntPoint(7857, 3643), new IntPoint(7907, 3643), new IntPoint(7907,
3593), new IntPoint(7957, 3593), new IntPoint(7957, 3543), new IntPoint(8107, 3543), new IntPoint(8107, 3535), new IntPoint(8137, 3535) }, new Polygon() { new IntPoint(13887, 4393), new
IntPoint(13913, 4393), new IntPoint(13913, 4435), new IntPoint(13937, 4435), new IntPoint(13937, 4443), new IntPoint(13963, 4443), new IntPoint(13963, 4565), new IntPoint(13913, 4565), new
IntPoint(13913, 4615), new IntPoint(13807, 4615), new IntPoint(13807, 4573), new IntPoint(13783, 4573), new IntPoint(13783, 4565), new IntPoint(13757, 4565), new IntPoint(13757, 4443), new
IntPoint(13807, 4443), new IntPoint(13807, 4393), new IntPoint(13857, 4393), new IntPoint(13857, 4385), new IntPoint(13887, 4385) }, new Polygon() { new IntPoint(6989, 3143), new IntPoint(7015, 3143),
new IntPoint(7015, 3185), new IntPoint(7039, 3185), new IntPoint(7039, 3193), new IntPoint(7115, 3193), new IntPoint(7115, 3515), new IntPoint(7065, 3515), new IntPoint(7065, 3565), new IntPoint(7015,
3565), new IntPoint(7015, 3615), new IntPoint(6915, 3615), new IntPoint(6915, 3665), new IntPoint(6815, 3665), new IntPoint(6815, 3715), new IntPoint(6715, 3715), new IntPoint(6715, 3765), new
IntPoint(6615, 3765), new IntPoint(6615, 4465), new IntPoint(6459, 4465), new IntPoint(6459, 4423), new IntPoint(6435, 4423), new IntPoint(6435, 4415), new IntPoint(6359, 4415), new IntPoint(6359,
4373), new IntPoint(6335, 4373), new IntPoint(6335, 4365), new IntPoint(6309, 4365), new IntPoint(6309, 4273), new IntPoint(6285, 4273), new IntPoint(6285, 4265), new IntPoint(6259, 4265), new
IntPoint(6259, 4173), new IntPoint(6235, 4173), new IntPoint(6235, 4165), new IntPoint(6209, 4165), new IntPoint(6209, 4073), new IntPoint(6185, 4073), new IntPoint(6185, 4065), new IntPoint(6159,
4065), new IntPoint(6159, 3793), new IntPoint(6209, 3793), new IntPoint(6209, 3743), new IntPoint(6259, 3743), new IntPoint(6259, 3643), new IntPoint(6309, 3643), new IntPoint(6309, 3593), new
IntPoint(6359, 3593), new IntPoint(6359, 3493), new IntPoint(6409, 3493), new IntPoint(6409, 3393), new IntPoint(6459, 3393), new IntPoint(6459, 3343), new IntPoint(6509, 3343), new IntPoint(6509,
3243), new IntPoint(6559, 3243), new IntPoint(6559, 3193), new IntPoint(6909, 3193), new IntPoint(6909, 3143), new IntPoint(6959, 3143), new IntPoint(6959, 3135), new IntPoint(6989, 3135) }, new
Polygon() { new IntPoint(1165, 4185), new IntPoint(1189, 4185), new IntPoint(1189, 4193), new IntPoint(1265, 4193), new IntPoint(1265, 4365), new IntPoint(1215, 4365), new IntPoint(1215, 4415), new
IntPoint(1109, 4415), new IntPoint(1109, 4373), new IntPoint(1085, 4373), new IntPoint(1085, 4365), new IntPoint(1059, 4365), new IntPoint(1059, 4223), new IntPoint(1035, 4223), new IntPoint(1035,
4185), new IntPoint(1039, 4185), new IntPoint(1039, 4193), new IntPoint(1109, 4193), new IntPoint(1109, 4143), new IntPoint(1165, 4143) }, new Polygon() { new IntPoint(2465, 3935), new IntPoint(2489,
3935), new IntPoint(2489, 3943), new IntPoint(2515, 3943), new IntPoint(2515, 3985), new IntPoint(2539, 3985), new IntPoint(2539, 3993), new IntPoint(2565, 3993), new IntPoint(2565, 4065), new
IntPoint(2515, 4065), new IntPoint(2515, 4115), new IntPoint(2465, 4115), new IntPoint(2465, 4165), new IntPoint(2409, 4165), new IntPoint(2409, 4123), new IntPoint(2385, 4123), new IntPoint(2385,
4115), new IntPoint(2359, 4115), new IntPoint(2359, 4073), new IntPoint(2335, 4073), new IntPoint(2335, 4065), new IntPoint(2309, 4065), new IntPoint(2309, 4023), new IntPoint(2285, 4023), new
IntPoint(2285, 3985), new IntPoint(2289, 3985), new IntPoint(2289, 3993), new IntPoint(2359, 3993), new IntPoint(2359, 3943), new IntPoint(2409, 3943), new IntPoint(2409, 3893), new IntPoint(2465,
3893) }, new Polygon() { new IntPoint(4789, 2993), new IntPoint(4815, 2993), new IntPoint(4815, 3035), new IntPoint(4839, 3035), new IntPoint(4839, 3043), new IntPoint(4865, 3043), new IntPoint(4865,
3215), new IntPoint(4815, 3215), new IntPoint(4815, 3265), new IntPoint(4765, 3265), new IntPoint(4765, 3365), new IntPoint(4715, 3365), new IntPoint(4715, 3465), new IntPoint(4665, 3465), new
IntPoint(4665, 3565), new IntPoint(4615, 3565), new IntPoint(4615, 3665), new IntPoint(4565, 3665), new IntPoint(4565, 3765), new IntPoint(4515, 3765), new IntPoint(4515, 3815), new IntPoint(4465,
3815), new IntPoint(4465, 3865), new IntPoint(4409, 3865), new IntPoint(4409, 3823), new IntPoint(4385, 3823), new IntPoint(4385, 3815), new IntPoint(4359, 3815), new IntPoint(4359, 3773), new
IntPoint(4335, 3773), new IntPoint(4335, 3765), new IntPoint(4309, 3765), new IntPoint(4309, 3723), new IntPoint(4285, 3723), new IntPoint(4285, 3715), new IntPoint(4259, 3715), new IntPoint(4259,
3643), new IntPoint(4309, 3643), new IntPoint(4309, 3543), new IntPoint(4359, 3543), new IntPoint(4359, 3443), new IntPoint(4409, 3443), new IntPoint(4409, 3393), new IntPoint(4459, 3393), new
IntPoint(4459, 3343), new IntPoint(4509, 3343), new IntPoint(4509, 3293), new IntPoint(4559, 3293), new IntPoint(4559, 3193), new IntPoint(4609, 3193), new IntPoint(4609, 3043), new IntPoint(4659,
3043), new IntPoint(4659, 2993), new IntPoint(4759, 2993), new IntPoint(4759, 2985), new IntPoint(4789, 2985) }, new Polygon() { new IntPoint(3689, 3593), new IntPoint(3715, 3593), new IntPoint(3715,
3635), new IntPoint(3739, 3635), new IntPoint(3739, 3643), new IntPoint(3765, 3643), new IntPoint(3765, 3765), new IntPoint(3715, 3765), new IntPoint(3715, 3815), new IntPoint(3559, 3815), new
IntPoint(3559, 3723), new IntPoint(3535, 3723), new IntPoint(3535, 3715), new IntPoint(3509, 3715), new IntPoint(3509, 3673), new IntPoint(3485, 3673), new IntPoint(3485, 3635), new IntPoint(3489,
3635), new IntPoint(3489, 3643), new IntPoint(3559, 3643), new IntPoint(3559, 3593), new IntPoint(3659, 3593), new IntPoint(3659, 3585), new IntPoint(3689, 3585) }, new Polygon() { new IntPoint(1189,
3393), new IntPoint(1215, 3393), new IntPoint(1215, 3435), new IntPoint(1239, 3435), new IntPoint(1239, 3443), new IntPoint(1265, 3443), new IntPoint(1265, 3485), new IntPoint(1289, 3485), new
IntPoint(1289, 3493), new IntPoint(1315, 3493), new IntPoint(1315, 3665), new IntPoint(1265, 3665), new IntPoint(1265, 3715), new IntPoint(1165, 3715), new IntPoint(1165, 3765), new IntPoint(1159,
3765), new IntPoint(1159, 3723), new IntPoint(1135, 3723), new IntPoint(1135, 3715), new IntPoint(1059, 3715), new IntPoint(1059, 3673), new IntPoint(1035, 3673), new IntPoint(1035, 3665), new
IntPoint(1009, 3665), new IntPoint(1009, 3473), new IntPoint(985, 3473), new IntPoint(985, 3435), new IntPoint(989, 3435), new IntPoint(989, 3443), new IntPoint(1109, 3443), new IntPoint(1109, 3393),
new IntPoint(1159, 3393), new IntPoint(1159, 3385), new IntPoint(1189, 3385) }, new Polygon() { new IntPoint(5889, 1793), new IntPoint(5915, 1793), new IntPoint(5915, 1865), new IntPoint(5865, 1865),
new IntPoint(5865, 1965), new IntPoint(5815, 1965), new IntPoint(5815, 2535), new IntPoint(5839, 2535), new IntPoint(5839, 2543), new IntPoint(5865, 2543), new IntPoint(5865, 2585), new IntPoint(5889,
2585), new IntPoint(5889, 2593), new IntPoint(5915, 2593), new IntPoint(5915, 2635), new IntPoint(5939, 2635), new IntPoint(5939, 2643), new IntPoint(6015, 2643), new IntPoint(6015, 2685), new
IntPoint(6039, 2685), new IntPoint(6039, 2693), new IntPoint(6115, 2693), new IntPoint(6115, 2735), new IntPoint(6139, 2735), new IntPoint(6139, 2743), new IntPoint(6215, 2743), new IntPoint(6215,
2865), new IntPoint(6165, 2865), new IntPoint(6165, 2965), new IntPoint(6115, 2965), new IntPoint(6115, 3015), new IntPoint(6065, 3015), new IntPoint(6065, 3115), new IntPoint(6015, 3115), new
IntPoint(6015, 3215), new IntPoint(5965, 3215), new IntPoint(5965, 3265), new IntPoint(5915, 3265), new IntPoint(5915, 3365), new IntPoint(5865, 3365), new IntPoint(5865, 3465), new IntPoint(5559,
3465), new IntPoint(5559, 3223), new IntPoint(5535, 3223), new IntPoint(5535, 3215), new IntPoint(5459, 3215), new IntPoint(5459, 1793), new IntPoint(5859, 1793), new IntPoint(5859, 1785), new
IntPoint(5889, 1785) }, new Polygon() { new IntPoint(7987, 2393), new IntPoint(8013, 2393), new IntPoint(8013, 2435), new IntPoint(8037, 2435), new IntPoint(8037, 2443), new IntPoint(8063, 2443), new
IntPoint(8063, 2485), new IntPoint(8087, 2485), new IntPoint(8087, 2493), new IntPoint(8113, 2493), new IntPoint(8113, 2585), new IntPoint(8137, 2585), new IntPoint(8137, 2593), new IntPoint(8163,
2593), new IntPoint(8163, 2785), new IntPoint(8187, 2785), new IntPoint(8187, 2793), new IntPoint(8213, 2793), new IntPoint(8213, 2935), new IntPoint(8237, 2935), new IntPoint(8237, 2943), new
IntPoint(8607, 2943), new IntPoint(8607, 2793), new IntPoint(8657, 2793), new IntPoint(8657, 2593), new IntPoint(8757, 2593), new IntPoint(8757, 2585), new IntPoint(8787, 2585), new IntPoint(8787,
2593), new IntPoint(8813, 2593), new IntPoint(8813, 2635), new IntPoint(8837, 2635), new IntPoint(8837, 2643), new IntPoint(8913, 2643), new IntPoint(8913, 2685), new IntPoint(8937, 2685), new
IntPoint(8937, 2693), new IntPoint(9007, 2693), new IntPoint(9007, 2685), new IntPoint(9037, 2685), new IntPoint(9037, 2693), new IntPoint(9063, 2693), new IntPoint(9063, 2735), new IntPoint(9087,
2735), new IntPoint(9087, 2743), new IntPoint(9163, 2743), new IntPoint(9163, 2785), new IntPoint(9187, 2785), new IntPoint(9187, 2793), new IntPoint(9263, 2793), new IntPoint(9263, 2835), new
IntPoint(9287, 2835), new IntPoint(9287, 2843), new IntPoint(9757, 2843), new IntPoint(9757, 2793), new IntPoint(9857, 2793), new IntPoint(9857, 2743), new IntPoint(9957, 2743), new IntPoint(9957,
2693), new IntPoint(10057, 2693), new IntPoint(10057, 2643), new IntPoint(10157, 2643), new IntPoint(10157, 2635), new IntPoint(10187, 2635), new IntPoint(10187, 2643), new IntPoint(10213, 2643), new
IntPoint(10213, 2735), new IntPoint(10237, 2735), new IntPoint(10237, 2743), new IntPoint(10263, 2743), new IntPoint(10263, 2815), new IntPoint(10163, 2815), new IntPoint(10163, 2865), new
IntPoint(10113, 2865), new IntPoint(10113, 2915), new IntPoint(9913, 2915), new IntPoint(9913, 2965), new IntPoint(9813, 2965), new IntPoint(9813, 3015), new IntPoint(9613, 3015), new IntPoint(9613,
3065), new IntPoint(9463, 3065), new IntPoint(9463, 3115), new IntPoint(9263, 3115), new IntPoint(9263, 3165), new IntPoint(9213, 3165), new IntPoint(9213, 3215), new IntPoint(9163, 3215), new
IntPoint(9163, 3265), new IntPoint(9113, 3265), new IntPoint(9113, 3315), new IntPoint(9063, 3315), new IntPoint(9063, 3365), new IntPoint(9013, 3365), new IntPoint(9013, 3415), new IntPoint(8907,
3415), new IntPoint(8907, 3373), new IntPoint(8883, 3373), new IntPoint(8883, 3365), new IntPoint(8807, 3365), new IntPoint(8807, 3323), new IntPoint(8783, 3323), new IntPoint(8783, 3315), new
IntPoint(8757, 3315), new IntPoint(8757, 3273), new IntPoint(8733, 3273), new IntPoint(8733, 3265), new IntPoint(8657, 3265), new IntPoint(8657, 3223), new IntPoint(8633, 3223), new IntPoint(8633,
3215), new IntPoint(8307, 3215), new IntPoint(8307, 3173), new IntPoint(8283, 3173), new IntPoint(8283, 3165), new IntPoint(8257, 3165), new IntPoint(8257, 3123), new IntPoint(8233, 3123), new
IntPoint(8233, 3115), new IntPoint(7863, 3115), new IntPoint(7863, 3165), new IntPoint(7763, 3165), new IntPoint(7763, 3215), new IntPoint(7657, 3215), new IntPoint(7657, 2593), new IntPoint(7707,
2593), new IntPoint(7707, 2543), new IntPoint(7757, 2543), new IntPoint(7757, 2493), new IntPoint(7807, 2493), new IntPoint(7807, 2443), new IntPoint(7857, 2443), new IntPoint(7857, 2393), new
IntPoint(7957, 2393), new IntPoint(7957, 2385), new IntPoint(7987, 2385) }, new Polygon() { new IntPoint(3239, 3043), new IntPoint(3265, 3043), new IntPoint(3265, 3085), new IntPoint(3289, 3085), new
IntPoint(3289, 3093), new IntPoint(3315, 3093), new IntPoint(3315, 3135), new IntPoint(3339, 3135), new IntPoint(3339, 3143), new IntPoint(3365, 3143), new IntPoint(3365, 3265), new IntPoint(3315,
3265), new IntPoint(3315, 3315), new IntPoint(3265, 3315), new IntPoint(3265, 3365), new IntPoint(3109, 3365), new IntPoint(3109, 3323), new IntPoint(3085, 3323), new IntPoint(3085, 3315), new
IntPoint(3059, 3315), new IntPoint(3059, 3273), new IntPoint(3035, 3273), new IntPoint(3035, 3265), new IntPoint(3009, 3265), new IntPoint(3009, 3173), new IntPoint(2985, 3173), new IntPoint(2985,
3135), new IntPoint(2989, 3135), new IntPoint(2989, 3143), new IntPoint(3059, 3143), new IntPoint(3059, 3093), new IntPoint(3109, 3093), new IntPoint(3109, 3043), new IntPoint(3209, 3043), new
IntPoint(3209, 3035), new IntPoint(3239, 3035) }, new Polygon() { new IntPoint(11337, 1943), new IntPoint(11363, 1943), new IntPoint(11363, 1985), new IntPoint(11387, 1985), new IntPoint(11387, 1993),
new IntPoint(11463, 1993), new IntPoint(11463, 2035), new IntPoint(11487, 2035), new IntPoint(11487, 2043), new IntPoint(11513, 2043), new IntPoint(11513, 2135), new IntPoint(11537, 2135), new
IntPoint(11537, 2143), new IntPoint(11563, 2143), new IntPoint(11563, 2235), new IntPoint(11587, 2235), new IntPoint(11587, 2243), new IntPoint(11613, 2243), new IntPoint(11613, 2385), new
IntPoint(11637, 2385), new IntPoint(11637, 2393), new IntPoint(11663, 2393), new IntPoint(11663, 2485), new IntPoint(11687, 2485), new IntPoint(11687, 2493), new IntPoint(11713, 2493), new
IntPoint(11713, 2765), new IntPoint(11663, 2765), new IntPoint(11663, 2815), new IntPoint(11613, 2815), new IntPoint(11613, 2865), new IntPoint(11563, 2865), new IntPoint(11563, 2915), new
IntPoint(11513, 2915), new IntPoint(11513, 2965), new IntPoint(11463, 2965), new IntPoint(11463, 3015), new IntPoint(11363, 3015), new IntPoint(11363, 3065), new IntPoint(11313, 3065), new
IntPoint(11313, 3115), new IntPoint(11263, 3115), new IntPoint(11263, 3165), new IntPoint(11163, 3165), new IntPoint(11163, 3215), new IntPoint(11113, 3215), new IntPoint(11113, 3265), new
IntPoint(10857, 3265), new IntPoint(10857, 3223), new IntPoint(10833, 3223), new IntPoint(10833, 3215), new IntPoint(10757, 3215), new IntPoint(10757, 3173), new IntPoint(10733, 3173), new
IntPoint(10733, 3165), new IntPoint(10707, 3165), new IntPoint(10707, 3123), new IntPoint(10683, 3123), new IntPoint(10683, 3115), new IntPoint(10657, 3115), new IntPoint(10657, 2943), new
IntPoint(10707, 2943), new IntPoint(10707, 2893), new IntPoint(10757, 2893), new IntPoint(10757, 2793), new IntPoint(10807, 2793), new IntPoint(10807, 2743), new IntPoint(10857, 2743), new
IntPoint(10857, 2693), new IntPoint(10907, 2693), new IntPoint(10907, 2593), new IntPoint(10957, 2593), new IntPoint(10957, 2543), new IntPoint(11007, 2543), new IntPoint(11007, 2443), new
IntPoint(11057, 2443), new IntPoint(11057, 2193), new IntPoint(11107, 2193), new IntPoint(11107, 2093), new IntPoint(11157, 2093), new IntPoint(11157, 1993), new IntPoint(11207, 1993), new
IntPoint(11207, 1943), new IntPoint(11307, 1943), new IntPoint(11307, 1935), new IntPoint(11337, 1935) }, new Polygon() { new IntPoint(4939, 1643), new IntPoint(4965, 1643), new IntPoint(4965, 1685),
new IntPoint(4989, 1685), new IntPoint(4989, 1693), new IntPoint(5015, 1693), new IntPoint(5015, 2115), new IntPoint(4965, 2115), new IntPoint(4965, 2615), new IntPoint(4915, 2615), new IntPoint(4915,
2665), new IntPoint(4759, 2665), new IntPoint(4759, 2623), new IntPoint(4735, 2623), new IntPoint(4735, 2615), new IntPoint(4709, 2615), new IntPoint(4709, 2093), new IntPoint(4759, 2093), new
IntPoint(4759, 1693), new IntPoint(4809, 1693), new IntPoint(4809, 1643), new IntPoint(4909, 1643), new IntPoint(4909, 1635), new IntPoint(4939, 1635) }, new Polygon() { new IntPoint(3989, 2243), new
IntPoint(4015, 2243), new IntPoint(4015, 2285), new IntPoint(4039, 2285), new IntPoint(4039, 2293), new IntPoint(4065, 2293), new IntPoint(4065, 2335), new IntPoint(4089, 2335), new IntPoint(4089,
2343), new IntPoint(4115, 2343), new IntPoint(4115, 2415), new IntPoint(4065, 2415), new IntPoint(4065, 2465), new IntPoint(4015, 2465), new IntPoint(4015, 2515), new IntPoint(3959, 2515), new
IntPoint(3959, 2473), new IntPoint(3935, 2473), new IntPoint(3935, 2465), new IntPoint(3909, 2465), new IntPoint(3909, 2423), new IntPoint(3885, 2423), new IntPoint(3885, 2415), new IntPoint(3859,
2415), new IntPoint(3859, 2343), new IntPoint(3909, 2343), new IntPoint(3909, 2293), new IntPoint(3959, 2293), new IntPoint(3959, 2235), new IntPoint(3989, 2235) }, new Polygon() { new IntPoint(7837,
1743), new IntPoint(7863, 1743), new IntPoint(7863, 2015), new IntPoint(7663, 2015), new IntPoint(7663, 2065), new IntPoint(7563, 2065), new IntPoint(7563, 2115), new IntPoint(7513, 2115), new
IntPoint(7513, 2165), new IntPoint(7463, 2165), new IntPoint(7463, 2215), new IntPoint(7413, 2215), new IntPoint(7413, 2265), new IntPoint(7363, 2265), new IntPoint(7363, 2315), new IntPoint(7315,
2315), new IntPoint(7315, 2365), new IntPoint(7265, 2365), new IntPoint(7265, 2415), new IntPoint(7215, 2415), new IntPoint(7215, 2465), new IntPoint(7165, 2465), new IntPoint(7165, 2515), new
IntPoint(6759, 2515), new IntPoint(6759, 2473), new IntPoint(6735, 2473), new IntPoint(6735, 2465), new IntPoint(6609, 2465), new IntPoint(6609, 2423), new IntPoint(6585, 2423), new IntPoint(6585,
2415), new IntPoint(6509, 2415), new IntPoint(6509, 2373), new IntPoint(6485, 2373), new IntPoint(6485, 2365), new IntPoint(6409, 2365), new IntPoint(6409, 2323), new IntPoint(6385, 2323), new
IntPoint(6385, 2315), new IntPoint(6309, 2315), new IntPoint(6309, 1993), new IntPoint(6359, 1993), new IntPoint(6359, 1943), new IntPoint(6409, 1943), new IntPoint(6409, 1843), new IntPoint(6459,
1843), new IntPoint(6459, 1743), new IntPoint(7807, 1743), new IntPoint(7807, 1735), new IntPoint(7837, 1735) }, new Polygon() { new IntPoint(1789, 2143), new IntPoint(1815, 2143), new IntPoint(1815,
2235), new IntPoint(1839, 2235), new IntPoint(1839, 2243), new IntPoint(1865, 2243), new IntPoint(1865, 2315), new IntPoint(1815, 2315), new IntPoint(1815, 2365), new IntPoint(1765, 2365), new
IntPoint(1765, 2415), new IntPoint(1709, 2415), new IntPoint(1709, 2373), new IntPoint(1685, 2373), new IntPoint(1685, 2365), new IntPoint(1659, 2365), new IntPoint(1659, 2323), new IntPoint(1635,
2323), new IntPoint(1635, 2315), new IntPoint(1609, 2315), new IntPoint(1609, 2223), new IntPoint(1585, 2223), new IntPoint(1585, 2185), new IntPoint(1589, 2185), new IntPoint(1589, 2193), new
IntPoint(1659, 2193), new IntPoint(1659, 2143), new IntPoint(1759, 2143), new IntPoint(1759, 2135), new IntPoint(1789, 2135) }, new Polygon() { new IntPoint(10487, 1793), new IntPoint(10513, 1793),
new IntPoint(10513, 1835), new IntPoint(10537, 1835), new IntPoint(10537, 1843), new IntPoint(10613, 1843), new IntPoint(10613, 1885), new IntPoint(10637, 1885), new IntPoint(10637, 1893), new
IntPoint(10663, 1893), new IntPoint(10663, 2065), new IntPoint(10613, 2065), new IntPoint(10613, 2115), new IntPoint(10563, 2115), new IntPoint(10563, 2165), new IntPoint(10163, 2165), new
IntPoint(10163, 2215), new IntPoint(10063, 2215), new IntPoint(10063, 2265), new IntPoint(9963, 2265), new IntPoint(9963, 2315), new IntPoint(9863, 2315), new IntPoint(9863, 2365), new IntPoint(9407,
2365), new IntPoint(9407, 2293), new IntPoint(9457, 2293), new IntPoint(9457, 2193), new IntPoint(9507, 2193), new IntPoint(9507, 1993), new IntPoint(9557, 1993), new IntPoint(9557, 1843), new
IntPoint(9607, 1843), new IntPoint(9607, 1793), new IntPoint(10457, 1793), new IntPoint(10457, 1785), new IntPoint(10487, 1785) }, new Polygon() { new IntPoint(9087, 1743), new IntPoint(9113, 1743),
new IntPoint(9113, 1815), new IntPoint(9063, 1815), new IntPoint(9063, 1915), new IntPoint(9013, 1915), new IntPoint(9013, 1965), new IntPoint(8963, 1965), new IntPoint(8963, 2065), new IntPoint(8913,
2065), new IntPoint(8913, 2165), new IntPoint(8807, 2165), new IntPoint(8807, 2123), new IntPoint(8783, 2123), new IntPoint(8783, 2115), new IntPoint(8607, 2115), new IntPoint(8607, 2073), new
IntPoint(8583, 2073), new IntPoint(8583, 2065), new IntPoint(8407, 2065), new IntPoint(8407, 2023), new IntPoint(8383, 2023), new IntPoint(8383, 2015), new IntPoint(8207, 2015), new IntPoint(8207,
1743), new IntPoint(9057, 1743), new IntPoint(9057, 1735), new IntPoint(9087, 1735) }, new Polygon() { new IntPoint(1565, 1335), new IntPoint(1589, 1335), new IntPoint(1589, 1343), new IntPoint(1659,
1343), new IntPoint(1659, 1335), new IntPoint(1689, 1335), new IntPoint(1689, 1343), new IntPoint(1715, 1343), new IntPoint(1715, 1385), new IntPoint(1739, 1385), new IntPoint(1739, 1393), new
IntPoint(1765, 1393), new IntPoint(1765, 1435), new IntPoint(1789, 1435), new IntPoint(1789, 1443), new IntPoint(1815, 1443), new IntPoint(1815, 1535), new IntPoint(1839, 1535), new IntPoint(1839,
1543), new IntPoint(1865, 1543), new IntPoint(1865, 1765), new IntPoint(1815, 1765), new IntPoint(1815, 1865), new IntPoint(1765, 1865), new IntPoint(1765, 1915), new IntPoint(1715, 1915), new
IntPoint(1715, 1965), new IntPoint(1565, 1965), new IntPoint(1565, 2015), new IntPoint(1509, 2015), new IntPoint(1509, 1973), new IntPoint(1485, 1973), new IntPoint(1485, 1965), new IntPoint(1359,
1965), new IntPoint(1359, 1923), new IntPoint(1335, 1923), new IntPoint(1335, 1915), new IntPoint(1309, 1915), new IntPoint(1309, 1873), new IntPoint(1285, 1873), new IntPoint(1285, 1865), new
IntPoint(1259, 1865), new IntPoint(1259, 1773), new IntPoint(1235, 1773), new IntPoint(1235, 1765), new IntPoint(1209, 1765), new IntPoint(1209, 1573), new IntPoint(1185, 1573), new IntPoint(1185,
1535), new IntPoint(1189, 1535), new IntPoint(1189, 1543), new IntPoint(1259, 1543), new IntPoint(1259, 1473), new IntPoint(1235, 1473), new IntPoint(1235, 1435), new IntPoint(1239, 1435), new
IntPoint(1239, 1443), new IntPoint(1309, 1443), new IntPoint(1309, 1393), new IntPoint(1359, 1393), new IntPoint(1359, 1343), new IntPoint(1559, 1343), new IntPoint(1559, 1285), new IntPoint(1565,
1285) }, new Polygon() { new IntPoint(2239, 1693), new IntPoint(2265, 1693), new IntPoint(2265, 1915), new IntPoint(2109, 1915), new IntPoint(2109, 1873), new IntPoint(2085, 1873), new IntPoint(2085,
1865), new IntPoint(2059, 1865), new IntPoint(2059, 1743), new IntPoint(2109, 1743), new IntPoint(2109, 1693), new IntPoint(2209, 1693), new IntPoint(2209, 1685), new IntPoint(2239, 1685) }, new
Polygon() { new IntPoint(6939, 1343), new IntPoint(6965, 1343), new IntPoint(6965, 1385), new IntPoint(6989, 1385), new IntPoint(6989, 1393), new IntPoint(7015, 1393), new IntPoint(7015, 1565), new
IntPoint(6965, 1565), new IntPoint(6965, 1615), new IntPoint(6859, 1615), new IntPoint(6859, 1573), new IntPoint(6835, 1573), new IntPoint(6835, 1565), new IntPoint(6809, 1565), new IntPoint(6809,
1393), new IntPoint(6859, 1393), new IntPoint(6859, 1343), new IntPoint(6909, 1343), new IntPoint(6909, 1335), new IntPoint(6939, 1335) }, new Polygon() { new IntPoint(3439, 1043), new IntPoint(3465,
1043), new IntPoint(3465, 1085), new IntPoint(3489, 1085), new IntPoint(3489, 1093), new IntPoint(3565, 1093), new IntPoint(3565, 1185), new IntPoint(3589, 1185), new IntPoint(3589, 1193), new
IntPoint(3615, 1193), new IntPoint(3615, 1315), new IntPoint(3565, 1315), new IntPoint(3565, 1365), new IntPoint(3515, 1365), new IntPoint(3515, 1415), new IntPoint(3409, 1415), new IntPoint(3409,
1373), new IntPoint(3385, 1373), new IntPoint(3385, 1365), new IntPoint(3309, 1365), new IntPoint(3309, 1273), new IntPoint(3285, 1273), new IntPoint(3285, 1265), new IntPoint(3259, 1265), new
IntPoint(3259, 1193), new IntPoint(3309, 1193), new IntPoint(3309, 1093), new IntPoint(3409, 1093), new IntPoint(3409, 1035), new IntPoint(3439, 1035) }, new Polygon() { new IntPoint(4339, 1143), new
IntPoint(4365, 1143), new IntPoint(4365, 1365), new IntPoint(4209, 1365), new IntPoint(4209, 1323), new IntPoint(4185, 1323), new IntPoint(4185, 1315), new IntPoint(4159, 1315), new IntPoint(4159,
1193), new IntPoint(4209, 1193), new IntPoint(4209, 1143), new IntPoint(4309, 1143), new IntPoint(4309, 1135), new IntPoint(4339, 1135) }, new Polygon() { new IntPoint(10487, 893), new IntPoint(10513,
893), new IntPoint(10513, 935), new IntPoint(10537, 935), new IntPoint(10537, 943), new IntPoint(10613, 943), new IntPoint(10613, 1065), new IntPoint(10563, 1065), new IntPoint(10563, 1115), new
IntPoint(10513, 1115), new IntPoint(10513, 1165), new IntPoint(10457, 1165), new IntPoint(10457, 1123), new IntPoint(10433, 1123), new IntPoint(10433, 1115), new IntPoint(10407, 1115), new
IntPoint(10407, 1073), new IntPoint(10383, 1073), new IntPoint(10383, 1065), new IntPoint(10357, 1065), new IntPoint(10357, 993), new IntPoint(10407, 993), new IntPoint(10407, 943), new
IntPoint(10457, 943), new IntPoint(10457, 885), new IntPoint(10487, 885) } };
        public static PolygonSet bushCollisionPolygonSet = new PolygonSet{new Polygon(){new IntPoint(5508,3238),new IntPoint(5533,3285),new IntPoint(5547,3336),new IntPoint(5544,3388),new IntPoint(5546,3449),new
IntPoint(5586,3482),new IntPoint(5656,3486),new IntPoint(5718,3483),new IntPoint(5780,3485),new IntPoint(5841,3482),new IntPoint(5846,3520),new IntPoint(5831,3562),new IntPoint(5779,3574),new
IntPoint(5711,3579),new IntPoint(5628,3581),new IntPoint(5532,3580),new IntPoint(5470,3578),new IntPoint(5420,3562),new IntPoint(5404,3469),new IntPoint(5400,3377),new IntPoint(5405,3294),new
IntPoint(5432,3237)},new Polygon(){new IntPoint(6562,3036),new IntPoint(6608,3033),new IntPoint(6633,3040),new IntPoint(6675,3036),new IntPoint(6721,3034),new IntPoint(6777,3034),new
IntPoint(6800,3007),new IntPoint(6818,2984),new IntPoint(6854,2987),new IntPoint(6919,2984),new IntPoint(6962,2985),new IntPoint(7025,2985),new IntPoint(7087,3000),new IntPoint(7123,3033),new
IntPoint(7146,3074),new IntPoint(7140,3126),new IntPoint(7144,3177),new IntPoint(7121,3176),new IntPoint(7050,3163),new IntPoint(6992,3126),new IntPoint(6937,3128),new IntPoint(6896,3144),new
IntPoint(6882,3180),new IntPoint(6822,3176),new IntPoint(6752,3173),new IntPoint(6701,3175),new IntPoint(6637,3179),new IntPoint(6565,3163),new IntPoint(6553,3074)},new Polygon(){new
IntPoint(9498,2102),new IntPoint(9492,2173),new IntPoint(9445,2253),new IntPoint(9414,2275),new IntPoint(9397,2331),new IntPoint(9358,2331),new IntPoint(9302,2317),new IntPoint(9253,2278),new
IntPoint(9194,2272),new IntPoint(9153,2249),new IntPoint(9109,2231),new IntPoint(9022,2226),new IntPoint(8950,2214),new IntPoint(8951,2161),new IntPoint(8954,2113),new IntPoint(8974,2082),new
IntPoint(9000,2052),new IntPoint(9002,2003),new IntPoint(9059,1985),new IntPoint(9104,1984),new IntPoint(9151,1986),new IntPoint(9199,2031),new IntPoint(9274,2034),new IntPoint(9344,2080),new
IntPoint(9461,2086)},new Polygon(){new IntPoint(6506,4880),new IntPoint(6451,4875),new IntPoint(6451,4839),new IntPoint(6448,4803),new IntPoint(6432,4781),new IntPoint(6401,4702),new
IntPoint(6402,4642),new IntPoint(6402,4593),new IntPoint(6404,4547),new IntPoint(6402,4490),new IntPoint(6429,4484),new IntPoint(6457,4488),new IntPoint(6510,4482),new IntPoint(6554,4487),new
IntPoint(6602,4487),new IntPoint(6617,4522),new IntPoint(6638,4577),new IntPoint(6643,4610),new IntPoint(6656,4635),new IntPoint(6683,4632),new IntPoint(6690,4699),new IntPoint(6694,4768),new
IntPoint(6689,4825)},new Polygon(){new IntPoint(7885,3630),new IntPoint(7831,3628),new IntPoint(7800,3578),new IntPoint(7802,3516),new IntPoint(7826,3439),new IntPoint(7892,3435),new
IntPoint(7918,3388),new IntPoint(7966,3385),new IntPoint(8012,3385),new IntPoint(8069,3383),new IntPoint(8128,3388),new IntPoint(8199,3399),new IntPoint(8260,3435),new IntPoint(8305,3488),new
IntPoint(8348,3519),new IntPoint(8349,3575),new IntPoint(8340,3629),new IntPoint(8280,3624),new IntPoint(8237,3575),new IntPoint(8202,3547),new IntPoint(8151,3531),new IntPoint(8094,3526),new
IntPoint(8024,3526),new IntPoint(7959,3531),new IntPoint(7932,3581)},new Polygon(){new IntPoint(8695,4510),new IntPoint(8698,4631),new IntPoint(8694,4726),new IntPoint(8649,4778),new
IntPoint(8639,4855),new IntPoint(8598,4917),new IntPoint(8541,4927),new IntPoint(8480,4931),new IntPoint(8452,4894),new IntPoint(8452,4826),new IntPoint(8458,4753),new IntPoint(8506,4721),new
IntPoint(8553,4673),new IntPoint(8561,4624),new IntPoint(8561,4550),new IntPoint(8603,4520),new IntPoint(8612,4483),new IntPoint(8661,4484),new IntPoint(8687,4484)},new Polygon(){new
IntPoint(7985,732),new IntPoint(7999,785),new IntPoint(7993,853),new IntPoint(7939,876),new IntPoint(7877,879),new IntPoint(7807,877),new IntPoint(7741,879),new IntPoint(7673,880),new
IntPoint(7654,845),new IntPoint(7615,828),new IntPoint(7607,782),new IntPoint(7614,736)},new Polygon(){new IntPoint(10300,2835),new IntPoint(10361,2889),new IntPoint(10403,2932),new
IntPoint(10445,2935),new IntPoint(10503,2937),new IntPoint(10575,2935),new IntPoint(10647,2941),new IntPoint(10644,2984),new IntPoint(10649,3030),new IntPoint(10644,3075),new IntPoint(10621,3119),new
IntPoint(10554,3117),new IntPoint(10508,3125),new IntPoint(10458,3128),new IntPoint(10444,3191),new IntPoint(10411,3224),new IntPoint(10399,3278),new IntPoint(10364,3279),new IntPoint(10317,3279),new
IntPoint(10278,3280),new IntPoint(10250,3255),new IntPoint(10250,3189),new IntPoint(10252,3113),new IntPoint(10223,3076),new IntPoint(10185,3059),new IntPoint(10159,3036),new IntPoint(10152,2991),new
IntPoint(10154,2930),new IntPoint(10181,2884),new IntPoint(10208,2854),new IntPoint(10243,2836),new IntPoint(10271,2832)},new Polygon(){new IntPoint(8155,6084),new IntPoint(8249,6174),new
IntPoint(8297,6254),new IntPoint(8348,6314),new IntPoint(8422,6334),new IntPoint(8500,6385),new IntPoint(8599,6445),new IntPoint(8698,6533),new IntPoint(8773,6633),new IntPoint(8799,6698),new
IntPoint(8764,6726),new IntPoint(8699,6760),new IntPoint(8651,6780),new IntPoint(8613,6776),new IntPoint(8580,6728),new IntPoint(8550,6698),new IntPoint(8501,6662),new IntPoint(8450,6625),new
IntPoint(8401,6581),new IntPoint(8401,6562),new IntPoint(8356,6530),new IntPoint(8317,6528),new IntPoint(8303,6485),new IntPoint(8290,6469),new IntPoint(8255,6469),new IntPoint(8256,6431),new
IntPoint(8225,6426),new IntPoint(8193,6419),new IntPoint(8165,6414),new IntPoint(8148,6378),new IntPoint(8109,6378),new IntPoint(8102,6337),new IntPoint(8072,6327),new IntPoint(8053,6293),new
IntPoint(8024,6277),new IntPoint(8001,6252),new IntPoint(7985,6226),new IntPoint(7960,6195),new IntPoint(8015,6153)},new Polygon(){new IntPoint(9351,5556),new IntPoint(9395,5534),new
IntPoint(9428,5488),new IntPoint(9487,5488),new IntPoint(9548,5528),new IntPoint(9592,5603),new IntPoint(9545,5667),new IntPoint(9547,5713),new IntPoint(9515,5729),new IntPoint(9495,5773),new
IntPoint(9448,5777),new IntPoint(9401,5777),new IntPoint(9358,5746),new IntPoint(9314,5715),new IntPoint(9306,5664),new IntPoint(9318,5607)},new Polygon(){new IntPoint(9952,7686),new
IntPoint(10036,7688),new IntPoint(10124,7699),new IntPoint(10140,7739),new IntPoint(10122,7783),new IntPoint(10092,7832),new IntPoint(10097,7885),new IntPoint(10074,7923),new IntPoint(10048,7963),new
IntPoint(10049,8010),new IntPoint(10045,8072),new IntPoint(9999,8081),new IntPoint(9953,8081),new IntPoint(9915,8080),new IntPoint(9893,8032),new IntPoint(9856,8007),new IntPoint(9851,7941),new
IntPoint(9879,7935),new IntPoint(9900,7902),new IntPoint(9907,7848),new IntPoint(9904,7815),new IntPoint(9923,7784),new IntPoint(9950,7747),new IntPoint(9951,7721)},new Polygon(){new
IntPoint(11301,7231),new IntPoint(11304,7169),new IntPoint(11321,7132),new IntPoint(11352,7097),new IntPoint(11359,7053),new IntPoint(11397,7033),new IntPoint(11454,7037),new IntPoint(11517,7035),new
IntPoint(11596,7037),new IntPoint(11649,7043),new IntPoint(11648,7101),new IntPoint(11648,7167),new IntPoint(11643,7228),new IntPoint(11606,7223),new IntPoint(11562,7230),new IntPoint(11504,7226),new
IntPoint(11460,7230)},new Polygon(){new IntPoint(14135,6733),new IntPoint(14143,6768),new IntPoint(14148,6820),new IntPoint(14146,6882),new IntPoint(14147,6978),new IntPoint(14149,7052),new
IntPoint(14147,7130),new IntPoint(14146,7202),new IntPoint(14138,7227),new IntPoint(14102,7216),new IntPoint(14091,7179),new IntPoint(14052,7165),new IntPoint(14034,7126),new IntPoint(14002,7120),new
IntPoint(14000,7044),new IntPoint(14004,6977),new IntPoint(14001,6910),new IntPoint(14001,6827),new IntPoint(14039,6784),new IntPoint(14077,6782),new IntPoint(14107,6745)},new Polygon(){new
IntPoint(12047,3731),new IntPoint(12041,3764),new IntPoint(12004,3771),new IntPoint(11993,3817),new IntPoint(11996,3885),new IntPoint(11966,3925),new IntPoint(11948,3987),new IntPoint(11946,4105),new
IntPoint(11937,4180),new IntPoint(11902,4174),new IntPoint(11860,4125),new IntPoint(11803,4129),new IntPoint(11750,4101),new IntPoint(11701,4056),new IntPoint(11701,3998),new IntPoint(11704,3927),new
IntPoint(11740,3882),new IntPoint(11751,3811),new IntPoint(11756,3758),new IntPoint(11760,3718),new IntPoint(11803,3656),new IntPoint(11835,3583),new IntPoint(11907,3584),new IntPoint(11968,3595),new
IntPoint(12023,3637),new IntPoint(12045,3704)},new Polygon(){new IntPoint(12720,5428),new IntPoint(12699,5432),new IntPoint(12678,5476),new IntPoint(12647,5500),new IntPoint(12622,5528),new
IntPoint(12571,5523),new IntPoint(12557,5461),new IntPoint(12552,5415),new IntPoint(12564,5397),new IntPoint(12532,5368),new IntPoint(12511,5318),new IntPoint(12456,5281),new IntPoint(12392,5277),new
IntPoint(12311,5273),new IntPoint(12262,5265),new IntPoint(12255,5201),new IntPoint(12251,5133),new IntPoint(12257,5083),new IntPoint(12271,5058),new IntPoint(12293,5051),new IntPoint(12324,5044),new
IntPoint(12362,5053),new IntPoint(12396,5048),new IntPoint(12436,5048),new IntPoint(12476,5036),new IntPoint(12500,4992),new IntPoint(12504,4944),new IntPoint(12536,4888),new IntPoint(12556,4840),new
IntPoint(12601,4837),new IntPoint(12632,4841),new IntPoint(12647,4886),new IntPoint(12690,4908),new IntPoint(12698,4963),new IntPoint(12692,5035),new IntPoint(12693,5117),new IntPoint(12698,5190),new
IntPoint(12691,5244),new IntPoint(12693,5302),new IntPoint(12728,5366),new IntPoint(12747,5430)},new Polygon(){new IntPoint(12168,1237),new IntPoint(12201,1212),new IntPoint(12225,1186),new
IntPoint(12254,1171),new IntPoint(12265,1134),new IntPoint(12297,1157),new IntPoint(12348,1190),new IntPoint(12395,1234),new IntPoint(12442,1267),new IntPoint(12496,1296),new IntPoint(12524,1338),new
IntPoint(12597,1376),new IntPoint(12673,1432),new IntPoint(12731,1495),new IntPoint(12792,1546),new IntPoint(12848,1612),new IntPoint(12897,1666),new IntPoint(12948,1712),new IntPoint(12922,1731),new
IntPoint(12896,1743),new IntPoint(12876,1772),new IntPoint(12849,1793),new IntPoint(12821,1826),new IntPoint(12793,1840),new IntPoint(12769,1874),new IntPoint(12739,1878),new IntPoint(12703,1840),new
IntPoint(12651,1830),new IntPoint(12640,1779),new IntPoint(12602,1748),new IntPoint(12565,1719),new IntPoint(12543,1679),new IntPoint(12502,1654),new IntPoint(12483,1625),new IntPoint(12451,1623),new
IntPoint(12440,1577),new IntPoint(12400,1551),new IntPoint(12361,1528),new IntPoint(12324,1526),new IntPoint(12300,1501),new IntPoint(12280,1479),new IntPoint(12250,1466),new IntPoint(12238,1429),new
IntPoint(12204,1426),new IntPoint(12185,1381),new IntPoint(12155,1354),new IntPoint(12129,1326),new IntPoint(12105,1328),new IntPoint(12107,1292),new IntPoint(12152,1240)},new Polygon(){new
IntPoint(13246,2052),new IntPoint(13249,2075),new IntPoint(13276,2087),new IntPoint(13298,2099),new IntPoint(13320,2134),new IntPoint(13340,2143),new IntPoint(13373,2184),new IntPoint(13398,2228),new
IntPoint(13425,2282),new IntPoint(13448,2312),new IntPoint(13472,2335),new IntPoint(13499,2357),new IntPoint(13498,2397),new IntPoint(13516,2438),new IntPoint(13545,2449),new IntPoint(13555,2485),new
IntPoint(13587,2485),new IntPoint(13595,2556),new IntPoint(13596,2579),new IntPoint(13644,2675),new IntPoint(13648,2744),new IntPoint(13644,2776),new IntPoint(13599,2793),new IntPoint(13561,2827),new
IntPoint(13500,2827),new IntPoint(13450,2816),new IntPoint(13431,2780),new IntPoint(13404,2734),new IntPoint(13373,2679),new IntPoint(13351,2623),new IntPoint(13335,2579),new IntPoint(13295,2531),new
IntPoint(13260,2485),new IntPoint(13249,2427),new IntPoint(13200,2399),new IntPoint(13150,2354),new IntPoint(13105,2323),new IntPoint(13093,2277),new IntPoint(13051,2239),new IntPoint(13057,2175),new
IntPoint(13051,2142),new IntPoint(13083,2134),new IntPoint(13104,2124),new IntPoint(13102,2092),new IntPoint(13128,2090),new IntPoint(13151,2080),new IntPoint(13155,2037),new IntPoint(13220,2039)},new
Polygon(){new IntPoint(704,7855),new IntPoint(766,7846),new IntPoint(790,7884),new IntPoint(826,7885),new IntPoint(878,7885),new IntPoint(897,7916),new IntPoint(908,7979),new IntPoint(894,8034),new
IntPoint(896,8097),new IntPoint(896,8150),new IntPoint(894,8199),new IntPoint(895,8257),new IntPoint(889,8307),new IntPoint(895,8335),new IntPoint(874,8381),new IntPoint(839,8408),new
IntPoint(799,8432),new IntPoint(762,8426),new IntPoint(746,8470),new IntPoint(713,8480),new IntPoint(699,8452),new IntPoint(699,8384),new IntPoint(698,8322),new IntPoint(699,8194),new
IntPoint(703,8023)},new Polygon(){new IntPoint(7399,14124),new IntPoint(7382,14131),new IntPoint(7336,14131),new IntPoint(7255,14131),new IntPoint(7179,14129),new IntPoint(7054,14131),new
IntPoint(6967,14133),new IntPoint(6950,14122),new IntPoint(6950,14075),new IntPoint(6981,14037),new IntPoint(7018,14039),new IntPoint(7062,14039),new IntPoint(7100,14037),new IntPoint(7113,13995),new
IntPoint(7164,14011),new IntPoint(7213,13992),new IntPoint(7257,14034),new IntPoint(7298,14035),new IntPoint(7342,14046),new IntPoint(7359,14085),new IntPoint(7398,14104)},new Polygon(){new
IntPoint(1205,12038),new IntPoint(1243,12088),new IntPoint(1285,12147),new IntPoint(1294,12177),new IntPoint(1296,12220),new IntPoint(1315,12237),new IntPoint(1342,12271),new IntPoint(1342,12323),new
IntPoint(1344,12385),new IntPoint(1393,12387),new IntPoint(1397,12415),new IntPoint(1392,12470),new IntPoint(1346,12486),new IntPoint(1305,12524),new IntPoint(1273,12576),new IntPoint(1230,12583),new
IntPoint(1178,12581),new IntPoint(1150,12554),new IntPoint(1102,12516),new IntPoint(1101,12442),new IntPoint(1050,12413),new IntPoint(1050,12327),new IntPoint(1016,12282),new IntPoint(1000,12215),new
IntPoint(1000,12163),new IntPoint(998,12118),new IntPoint(1010,12084),new IntPoint(1049,12049),new IntPoint(1114,12034)},new Polygon(){new IntPoint(1615,12740),new IntPoint(1643,12746),new
IntPoint(1645,12784),new IntPoint(1685,12786),new IntPoint(1691,12835),new IntPoint(1726,12837),new IntPoint(1742,12873),new IntPoint(1766,12885),new IntPoint(1793,12914),new IntPoint(1827,12941),new
IntPoint(1847,12972),new IntPoint(1878,12990),new IntPoint(1894,13024),new IntPoint(1926,13041),new IntPoint(1905,13081),new IntPoint(1875,13130),new IntPoint(1838,13181),new IntPoint(1797,13187),new
IntPoint(1788,13231),new IntPoint(1747,13242),new IntPoint(1733,13280),new IntPoint(1702,13273),new IntPoint(1671,13232),new IntPoint(1645,13181),new IntPoint(1608,13178),new IntPoint(1598,13136),new
IntPoint(1568,13130),new IntPoint(1548,13104),new IntPoint(1529,13080),new IntPoint(1504,13045),new IntPoint(1453,13025),new IntPoint(1446,12983),new IntPoint(1409,12974),new IntPoint(1400,12935),new
IntPoint(1436,12934),new IntPoint(1449,12887),new IntPoint(1495,12889),new IntPoint(1514,12858),new IntPoint(1551,12832),new IntPoint(1568,12791),new IntPoint(1598,12778)},new Polygon(){new
IntPoint(2232,13286),new IntPoint(2249,13245),new IntPoint(2280,13240),new IntPoint(2289,13269),new IntPoint(2319,13284),new IntPoint(2338,13311),new IntPoint(2365,13344),new IntPoint(2397,13375),new
IntPoint(2446,13388),new IntPoint(2496,13384),new IntPoint(2522,13436),new IntPoint(2567,13439),new IntPoint(2594,13472),new IntPoint(2633,13485),new IntPoint(2646,13522),new IntPoint(2682,13536),new
IntPoint(2689,13592),new IntPoint(2655,13633),new IntPoint(2643,13681),new IntPoint(2638,13729),new IntPoint(2597,13762),new IntPoint(2557,13777),new IntPoint(2499,13777),new IntPoint(2445,13731),new
IntPoint(2397,13683),new IntPoint(2351,13678),new IntPoint(2298,13670),new IntPoint(2247,13633),new IntPoint(2200,13593),new IntPoint(2149,13560),new IntPoint(2103,13532),new IntPoint(2059,13516),new
IntPoint(2086,13490),new IntPoint(2109,13451),new IntPoint(2114,13406),new IntPoint(2143,13389),new IntPoint(2156,13349),new IntPoint(2179,13337),new IntPoint(2199,13316),new IntPoint(2204,13293)},new
Polygon(){new IntPoint(4945,7023),new IntPoint(4946,7062),new IntPoint(4942,7105),new IntPoint(4919,7129),new IntPoint(4895,7158),new IntPoint(4870,7179),new IntPoint(4846,7185),new
IntPoint(4830,7226),new IntPoint(4794,7252),new IntPoint(4776,7278),new IntPoint(4744,7274),new IntPoint(4701,7276),new IntPoint(4660,7280),new IntPoint(4650,7226),new IntPoint(4657,7173),new
IntPoint(4653,7137),new IntPoint(4673,7090),new IntPoint(4698,7066),new IntPoint(4709,7039),new IntPoint(4733,7035),new IntPoint(4748,7008),new IntPoint(4767,6984),new IntPoint(4798,6980),new
IntPoint(4798,6951),new IntPoint(4840,6942),new IntPoint(4891,6939),new IntPoint(4944,6945)},new Polygon(){new IntPoint(2247,9435),new IntPoint(2270,9435),new IntPoint(2296,9456),new
IntPoint(2296,9478),new IntPoint(2316,9484),new IntPoint(2345,9505),new IntPoint(2345,9544),new IntPoint(2347,9561),new IntPoint(2355,9586),new IntPoint(2371,9588),new IntPoint(2405,9586),new
IntPoint(2433,9588),new IntPoint(2445,9609),new IntPoint(2460,9635),new IntPoint(2488,9637),new IntPoint(2521,9634),new IntPoint(2547,9639),new IntPoint(2574,9644),new IntPoint(2595,9670),new
IntPoint(2594,9716),new IntPoint(2593,9754),new IntPoint(2588,9790),new IntPoint(2578,9824),new IntPoint(2540,9822),new IntPoint(2502,9831),new IntPoint(2465,9829),new IntPoint(2423,9831),new
IntPoint(2388,9848),new IntPoint(2354,9879),new IntPoint(2342,9934),new IntPoint(2338,9986),new IntPoint(2337,10048),new IntPoint(2345,10108),new IntPoint(2311,10125),new IntPoint(2275,10127),new
IntPoint(2235,10123),new IntPoint(2198,10096),new IntPoint(2173,10075),new IntPoint(2148,10069),new IntPoint(2148,10039),new IntPoint(2153,9995),new IntPoint(2150,9958),new IntPoint(2148,9924),new
IntPoint(2155,9879),new IntPoint(2150,9847),new IntPoint(2154,9789),new IntPoint(2156,9721),new IntPoint(2148,9675),new IntPoint(2151,9643),new IntPoint(2154,9604),new IntPoint(2152,9575),new
IntPoint(2152,9546),new IntPoint(2151,9504),new IntPoint(2178,9494),new IntPoint(2199,9476),new IntPoint(2201,9452),new IntPoint(2210,9438)},new Polygon(){new IntPoint(3256,7690),new
IntPoint(3310,7695),new IntPoint(3352,7689),new IntPoint(3399,7688),new IntPoint(3448,7690),new IntPoint(3510,7689),new IntPoint(3549,7690),new IntPoint(3584,7690),new IntPoint(3595,7714),new
IntPoint(3573,7728),new IntPoint(3546,7743),new IntPoint(3547,7773),new IntPoint(3545,7811),new IntPoint(3544,7849),new IntPoint(3509,7876),new IntPoint(3464,7883),new IntPoint(3417,7878),new
IntPoint(3373,7877),new IntPoint(3332,7882),new IntPoint(3281,7883),new IntPoint(3251,7879),new IntPoint(3210,7866),new IntPoint(3198,7828),new IntPoint(3217,7784),new IntPoint(3251,7756)},new
Polygon(){new IntPoint(6335,8036),new IntPoint(6395,8071),new IntPoint(6444,8125),new IntPoint(6493,8156),new IntPoint(6567,8190),new IntPoint(6627,8240),new IntPoint(6661,8287),new
IntPoint(6733,8342),new IntPoint(6783,8399),new IntPoint(6834,8455),new IntPoint(6885,8500),new IntPoint(6913,8537),new IntPoint(6890,8585),new IntPoint(6857,8625),new IntPoint(6801,8629),new
IntPoint(6795,8669),new IntPoint(6748,8680),new IntPoint(6732,8630),new IntPoint(6695,8579),new IntPoint(6653,8576),new IntPoint(6651,8544),new IntPoint(6618,8532),new IntPoint(6569,8524),new
IntPoint(6555,8490),new IntPoint(6515,8475),new IntPoint(6501,8446),new IntPoint(6465,8423),new IntPoint(6429,8383),new IntPoint(6398,8356),new IntPoint(6367,8330),new IntPoint(6349,8296),new
IntPoint(6312,8281),new IntPoint(6256,8279),new IntPoint(6253,8257),new IntPoint(6226,8233),new IntPoint(6200,8213),new IntPoint(6186,8181),new IntPoint(6152,8173),new IntPoint(6118,8148),new
IntPoint(6149,8116),new IntPoint(6201,8085),new IntPoint(6250,8047),new IntPoint(6281,8038)},new Polygon(){new IntPoint(5150,9002),new IntPoint(5176,8995),new IntPoint(5223,8987),new
IntPoint(5264,8987),new IntPoint(5295,9002),new IntPoint(5294,9036),new IntPoint(5337,9054),new IntPoint(5366,9096),new IntPoint(5380,9128),new IntPoint(5391,9181),new IntPoint(5380,9222),new
IntPoint(5346,9253),new IntPoint(5294,9261),new IntPoint(5260,9270),new IntPoint(5221,9268),new IntPoint(5175,9276),new IntPoint(5129,9272),new IntPoint(5104,9239),new IntPoint(5104,9204),new
IntPoint(5100,9145),new IntPoint(5098,9105),new IntPoint(5099,9070),new IntPoint(5113,9045),new IntPoint(5156,9016)},new Polygon(){new IntPoint(4927,8285),new IntPoint(4942,8302),new
IntPoint(4939,8337),new IntPoint(4980,8370),new IntPoint(5023,8398),new IntPoint(5064,8440),new IntPoint(5112,8449),new IntPoint(5162,8490),new IntPoint(5201,8498),new IntPoint(5256,8490),new
IntPoint(5286,8534),new IntPoint(5264,8561),new IntPoint(5211,8573),new IntPoint(5162,8581),new IntPoint(5122,8578),new IntPoint(5077,8583),new IntPoint(5033,8580),new IntPoint(5001,8563),new
IntPoint(4975,8525),new IntPoint(4944,8533),new IntPoint(4906,8515),new IntPoint(4872,8476),new IntPoint(4849,8428),new IntPoint(4810,8396),new IntPoint(4800,8334),new IntPoint(4820,8300),new
IntPoint(4860,8287),new IntPoint(4912,8285)},new Polygon(){new IntPoint(3074,10687),new IntPoint(3094,10738),new IntPoint(3127,10743),new IntPoint(3171,10743),new IntPoint(3193,10772),new
IntPoint(3175,10826),new IntPoint(3141,10877),new IntPoint(3137,10933),new IntPoint(3140,10980),new IntPoint(3119,10982),new IntPoint(3095,11016),new IntPoint(3084,11078),new IntPoint(3047,11091),new
IntPoint(3042,11144),new IntPoint(3041,11195),new IntPoint(3046,11252),new IntPoint(3014,11279),new IntPoint(2994,11327),new IntPoint(2991,11381),new IntPoint(2955,11429),new IntPoint(2947,11472),new
IntPoint(2918,11479),new IntPoint(2901,11447),new IntPoint(2858,11428),new IntPoint(2850,11390),new IntPoint(2822,11380),new IntPoint(2800,11358),new IntPoint(2767,11329),new IntPoint(2750,11301),new
IntPoint(2778,11286),new IntPoint(2799,11236),new IntPoint(2837,11187),new IntPoint(2848,11128),new IntPoint(2880,11085),new IntPoint(2905,11027),new IntPoint(2930,10984),new IntPoint(2949,10932),new
IntPoint(2964,10887),new IntPoint(2976,10884),new IntPoint(2999,10863),new IntPoint(3000,10824),new IntPoint(3015,10786),new IntPoint(3033,10785),new IntPoint(3050,10756),new IntPoint(3051,10729),new
IntPoint(3051,10704)},new Polygon(){new IntPoint(4484,11436),new IntPoint(4494,11465),new IntPoint(4514,11485),new IntPoint(4547,11514),new IntPoint(4578,11539),new IntPoint(4595,11573),new
IntPoint(4597,11607),new IntPoint(4584,11620),new IntPoint(4590,11669),new IntPoint(4587,11705),new IntPoint(4595,11754),new IntPoint(4594,11800),new IntPoint(4596,11833),new IntPoint(4644,11848),new
IntPoint(4653,11889),new IntPoint(4690,11893),new IntPoint(4691,11959),new IntPoint(4694,12000),new IntPoint(4680,12026),new IntPoint(4648,12022),new IntPoint(4621,12026),new IntPoint(4594,12055),new
IntPoint(4565,12080),new IntPoint(4534,12080),new IntPoint(4509,12061),new IntPoint(4489,12028),new IntPoint(4448,12010),new IntPoint(4421,11981),new IntPoint(4374,11979),new IntPoint(4339,11971),new
IntPoint(4293,11971),new IntPoint(4238,11975),new IntPoint(4183,11979),new IntPoint(4152,11969),new IntPoint(4150,11921),new IntPoint(4157,11876),new IntPoint(4155,11839),new IntPoint(4152,11778),new
IntPoint(4156,11749),new IntPoint(4188,11741),new IntPoint(4213,11742),new IntPoint(4252,11742),new IntPoint(4276,11737),new IntPoint(4308,11738),new IntPoint(4343,11734),new IntPoint(4375,11707),new
IntPoint(4402,11678),new IntPoint(4402,11630),new IntPoint(4415,11589),new IntPoint(4409,11543),new IntPoint(4409,11523),new IntPoint(4444,11497),new IntPoint(4453,11438)},new Polygon(){new
IntPoint(5428,12585),new IntPoint(5467,12585),new IntPoint(5502,12587),new IntPoint(5551,12589),new IntPoint(5597,12602),new IntPoint(5596,12628),new IntPoint(5625,12634),new IntPoint(5653,12635),new
IntPoint(5691,12639),new IntPoint(5725,12639),new IntPoint(5774,12641),new IntPoint(5813,12641),new IntPoint(5847,12674),new IntPoint(5882,12685),new IntPoint(5921,12685),new IntPoint(5958,12689),new
IntPoint(5992,12707),new IntPoint(5989,12760),new IntPoint(5959,12780),new IntPoint(5944,12819),new IntPoint(5917,12829),new IntPoint(5894,12860),new IntPoint(5873,12882),new IntPoint(5845,12903),new
IntPoint(5824,12928),new IntPoint(5785,12928),new IntPoint(5750,12925),new IntPoint(5748,12892),new IntPoint(5713,12882),new IntPoint(5698,12845),new IntPoint(5665,12829),new IntPoint(5637,12831),new
IntPoint(5602,12831),new IntPoint(5599,12805),new IntPoint(5567,12780),new IntPoint(5529,12783),new IntPoint(5492,12780),new IntPoint(5445,12770),new IntPoint(5409,12778),new IntPoint(5399,12753),new
IntPoint(5399,12706),new IntPoint(5403,12663),new IntPoint(5401,12620),new IntPoint(5400,12588)},new Polygon(){new IntPoint(6530,11234),new IntPoint(6546,11261),new IntPoint(6572,11284),new
IntPoint(6593,11307),new IntPoint(6604,11336),new IntPoint(6640,11335),new IntPoint(6667,11338),new IntPoint(6693,11356),new IntPoint(6693,11386),new IntPoint(6737,11389),new IntPoint(6778,11391),new
IntPoint(6813,11394),new IntPoint(6859,11389),new IntPoint(6898,11381),new IntPoint(6900,11335),new IntPoint(6935,11336),new IntPoint(6960,11293),new IntPoint(6987,11291),new IntPoint(7008,11290),new
IntPoint(7030,11285),new IntPoint(7044,11309),new IntPoint(7041,11326),new IntPoint(7068,11344),new IntPoint(7085,11366),new IntPoint(7090,11399),new IntPoint(7097,11421),new IntPoint(7072,11433),new
IntPoint(7066,11431),new IntPoint(7043,11465),new IntPoint(7016,11474),new IntPoint(6992,11490),new IntPoint(6967,11525),new IntPoint(6910,11527),new IntPoint(6871,11529),new IntPoint(6847,11526),new
IntPoint(6797,11528),new IntPoint(6748,11528),new IntPoint(6706,11529),new IntPoint(6661,11533),new IntPoint(6625,11529),new IntPoint(6595,11529),new IntPoint(6570,11527),new IntPoint(6558,11504),new
IntPoint(6550,11478),new IntPoint(6526,11481),new IntPoint(6504,11460),new IntPoint(6488,11429),new IntPoint(6452,11415),new IntPoint(6428,11381),new IntPoint(6400,11363),new IntPoint(6432,11335),new
IntPoint(6449,11306),new IntPoint(6475,11284),new IntPoint(6503,11279),new IntPoint(6505,11236)},new Polygon(){new IntPoint(8330,10084),new IntPoint(8359,10087),new IntPoint(8391,10101),new
IntPoint(8399,10144),new IntPoint(8394,10184),new IntPoint(8398,10212),new IntPoint(8392,10244),new IntPoint(8396,10279),new IntPoint(8396,10314),new IntPoint(8395,10347),new IntPoint(8397,10374),new
IntPoint(8397,10403),new IntPoint(8392,10427),new IntPoint(8365,10428),new IntPoint(8328,10430),new IntPoint(8300,10421),new IntPoint(8293,10382),new IntPoint(8272,10383),new IntPoint(8252,10380),new
IntPoint(8231,10380),new IntPoint(8209,10378),new IntPoint(8202,10358),new IntPoint(8202,10313),new IntPoint(8187,10281),new IntPoint(8158,10274),new IntPoint(8154,10251),new IntPoint(8152,10204),new
IntPoint(8160,10170),new IntPoint(8159,10136),new IntPoint(8160,10104),new IntPoint(8178,10088),new IntPoint(8230,10086),new IntPoint(8274,10088)},new Polygon(){new IntPoint(9018,11335),new
IntPoint(9073,11335),new IntPoint(9143,11337),new IntPoint(9212,11336),new IntPoint(9264,11336),new IntPoint(9289,11338),new IntPoint(9323,11337),new IntPoint(9360,11336),new IntPoint(9397,11337),new
IntPoint(9428,11344),new IntPoint(9444,11368),new IntPoint(9449,11387),new IntPoint(9444,11409),new IntPoint(9444,11428),new IntPoint(9445,11462),new IntPoint(9447,11492),new IntPoint(9447,11524),new
IntPoint(9447,11555),new IntPoint(9447,11583),new IntPoint(9446,11611),new IntPoint(9447,11632),new IntPoint(9424,11631),new IntPoint(9398,11629),new IntPoint(9373,11631),new IntPoint(9341,11632),new
IntPoint(9312,11631),new IntPoint(9300,11600),new IntPoint(9300,11560),new IntPoint(9300,11534),new IntPoint(9302,11518),new IntPoint(9302,11471),new IntPoint(9286,11433),new IntPoint(9237,11433),new
IntPoint(9192,11432),new IntPoint(9146,11430),new IntPoint(9094,11433),new IntPoint(9042,11432),new IntPoint(9005,11432),new IntPoint(8969,11433),new IntPoint(8952,11433),new IntPoint(8957,11377),new
IntPoint(8978,11339)},new Polygon(){new IntPoint(8286,11690),new IntPoint(8294,11758),new IntPoint(8299,11808),new IntPoint(8295,11859),new IntPoint(8267,11879),new IntPoint(8234,11879),new
IntPoint(8203,11880),new IntPoint(8167,11882),new IntPoint(8148,11913),new IntPoint(8111,11931),new IntPoint(8075,11931),new IntPoint(8032,11933),new IntPoint(8003,11930),new IntPoint(7972,11930),new
IntPoint(7936,11933),new IntPoint(7905,11931),new IntPoint(7874,11933),new IntPoint(7851,11920),new IntPoint(7851,11897),new IntPoint(7834,11882),new IntPoint(7811,11880),new IntPoint(7787,11882),new
IntPoint(7758,11879),new IntPoint(7750,11864),new IntPoint(7750,11843),new IntPoint(7732,11831),new IntPoint(7707,11831),new IntPoint(7703,11811),new IntPoint(7700,11783),new IntPoint(7700,11760),new
IntPoint(7700,11735),new IntPoint(7704,11710),new IntPoint(7716,11687),new IntPoint(7729,11688),new IntPoint(7746,11688),new IntPoint(7746,11717),new IntPoint(7756,11735),new IntPoint(7771,11741),new
IntPoint(7798,11749),new IntPoint(7815,11741),new IntPoint(7846,11734),new IntPoint(7870,11740),new IntPoint(7901,11740),new IntPoint(7941,11741),new IntPoint(7979,11738),new IntPoint(8015,11738),new
IntPoint(8051,11735),new IntPoint(8096,11735),new IntPoint(8157,11718),new IntPoint(8179,11690),new IntPoint(8198,11684),new IntPoint(8269,11684)},}; public static PolygonSet visionCollisionPolygonSet = new
PolygonSet() { new Polygon() { new IntPoint(16000, 16000), new IntPoint(0, 16000), new IntPoint(0, 0), new IntPoint(16000, 0) }, new Polygon() { new IntPoint(215, 115), new IntPoint(215, 215), new
IntPoint(115, 215), new IntPoint(115, 265), new IntPoint(15, 265), new IntPoint(15, 685), new IntPoint(65, 685), new IntPoint(65, 735), new IntPoint(89, 735), new IntPoint(89, 743), new IntPoint(115,
743), new IntPoint(115, 785), new IntPoint(139, 785), new IntPoint(139, 793), new IntPoint(209, 793), new IntPoint(209, 785), new IntPoint(215, 785), new IntPoint(215, 835), new IntPoint(239, 835),
new IntPoint(239, 843), new IntPoint(309, 843), new IntPoint(309, 835), new IntPoint(315, 835), new IntPoint(315, 885), new IntPoint(339, 885), new IntPoint(339, 893), new IntPoint(365, 893), new
IntPoint(365, 935), new IntPoint(389, 935), new IntPoint(389, 943), new IntPoint(415, 943), new IntPoint(415, 1085), new IntPoint(439, 1085), new IntPoint(439, 1093), new IntPoint(465, 1093), new
IntPoint(465, 4185), new IntPoint(489, 4185), new IntPoint(489, 4193), new IntPoint(515, 4193), new IntPoint(515, 4385), new IntPoint(539, 4385), new IntPoint(539, 4393), new IntPoint(565, 4393), new
IntPoint(565, 4535), new IntPoint(589, 4535), new IntPoint(589, 4543), new IntPoint(615, 4543), new IntPoint(615, 4735), new IntPoint(639, 4735), new IntPoint(639, 4743), new IntPoint(665, 4743), new
IntPoint(665, 5135), new IntPoint(689, 5135), new IntPoint(689, 5143), new IntPoint(715, 5143), new IntPoint(715, 5815), new IntPoint(665, 5815), new IntPoint(665, 9385), new IntPoint(689, 9385), new
IntPoint(689, 9391), new IntPoint(715, 9391), new IntPoint(715, 10835), new IntPoint(739, 10835), new IntPoint(739, 10841), new IntPoint(765, 10841), new IntPoint(765, 11135), new IntPoint(789,
11135), new IntPoint(789, 11141), new IntPoint(815, 11141), new IntPoint(815, 11485), new IntPoint(839, 11485), new IntPoint(839, 11491), new IntPoint(865, 11491), new IntPoint(865, 11835), new
IntPoint(889, 11835), new IntPoint(889, 11841), new IntPoint(915, 11841), new IntPoint(915, 12035), new IntPoint(939, 12035), new IntPoint(939, 12041), new IntPoint(965, 12041), new IntPoint(965,
12285), new IntPoint(989, 12285), new IntPoint(989, 12291), new IntPoint(1015, 12291), new IntPoint(1015, 12435), new IntPoint(1039, 12435), new IntPoint(1039, 12441), new IntPoint(1065, 12441), new
IntPoint(1065, 12535), new IntPoint(1089, 12535), new IntPoint(1089, 12541), new IntPoint(1115, 12541), new IntPoint(1115, 12635), new IntPoint(1139, 12635), new IntPoint(1139, 12641), new
IntPoint(1165, 12641), new IntPoint(1165, 12735), new IntPoint(1189, 12735), new IntPoint(1189, 12741), new IntPoint(1215, 12741), new IntPoint(1215, 12835), new IntPoint(1239, 12835), new
IntPoint(1239, 12841), new IntPoint(1265, 12841), new IntPoint(1265, 12885), new IntPoint(1289, 12885), new IntPoint(1289, 12891), new IntPoint(1315, 12891), new IntPoint(1315, 12935), new
IntPoint(1339, 12935), new IntPoint(1339, 12941), new IntPoint(1365, 12941), new IntPoint(1365, 12985), new IntPoint(1389, 12985), new IntPoint(1389, 12991), new IntPoint(1415, 12991), new
IntPoint(1415, 13035), new IntPoint(1439, 13035), new IntPoint(1439, 13041), new IntPoint(1465, 13041), new IntPoint(1465, 13085), new IntPoint(1489, 13085), new IntPoint(1489, 13091), new
IntPoint(1515, 13091), new IntPoint(1515, 13135), new IntPoint(1539, 13135), new IntPoint(1539, 13141), new IntPoint(1565, 13141), new IntPoint(1565, 13185), new IntPoint(1589, 13185), new
IntPoint(1589, 13191), new IntPoint(1615, 13191), new IntPoint(1615, 13235), new IntPoint(1639, 13235), new IntPoint(1639, 13241), new IntPoint(1665, 13241), new IntPoint(1665, 13285), new
IntPoint(1689, 13285), new IntPoint(1689, 13291), new IntPoint(1715, 13291), new IntPoint(1715, 13335), new IntPoint(1739, 13335), new IntPoint(1739, 13341), new IntPoint(1815, 13341), new
IntPoint(1815, 13385), new IntPoint(1839, 13385), new IntPoint(1839, 13391), new IntPoint(1865, 13391), new IntPoint(1865, 13435), new IntPoint(1889, 13435), new IntPoint(1889, 13441), new
IntPoint(1965, 13441), new IntPoint(1965, 13485), new IntPoint(1989, 13485), new IntPoint(1989, 13491), new IntPoint(2015, 13491), new IntPoint(2015, 13535), new IntPoint(2039, 13535), new
IntPoint(2039, 13541), new IntPoint(2115, 13541), new IntPoint(2115, 13585), new IntPoint(2139, 13585), new IntPoint(2139, 13591), new IntPoint(2165, 13591), new IntPoint(2165, 13635), new
IntPoint(2189, 13635), new IntPoint(2189, 13641), new IntPoint(2265, 13641), new IntPoint(2265, 13685), new IntPoint(2289, 13685), new IntPoint(2289, 13691), new IntPoint(2365, 13691), new
IntPoint(2365, 13735), new IntPoint(2389, 13735), new IntPoint(2389, 13741), new IntPoint(2465, 13741), new IntPoint(2465, 13785), new IntPoint(2489, 13785), new IntPoint(2489, 13791), new
IntPoint(2609, 13791), new IntPoint(2609, 13785), new IntPoint(2639, 13785), new IntPoint(2639, 13791), new IntPoint(2665, 13791), new IntPoint(2665, 13835), new IntPoint(2689, 13835), new
IntPoint(2689, 13841), new IntPoint(2759, 13841), new IntPoint(2759, 13835), new IntPoint(2789, 13835), new IntPoint(2789, 13841), new IntPoint(2815, 13841), new IntPoint(2815, 13885), new
IntPoint(2839, 13885), new IntPoint(2839, 13891), new IntPoint(2909, 13891), new IntPoint(2909, 13885), new IntPoint(2939, 13885), new IntPoint(2939, 13891), new IntPoint(2965, 13891), new
IntPoint(2965, 13935), new IntPoint(2989, 13935), new IntPoint(2989, 13941), new IntPoint(3109, 13941), new IntPoint(3109, 13935), new IntPoint(3139, 13935), new IntPoint(3139, 13941), new
IntPoint(3165, 13941), new IntPoint(3165, 13985), new IntPoint(3189, 13985), new IntPoint(3189, 13991), new IntPoint(3309, 13991), new IntPoint(3309, 13985), new IntPoint(3339, 13985), new
IntPoint(3339, 13991), new IntPoint(3365, 13991), new IntPoint(3365, 14035), new IntPoint(3389, 14035), new IntPoint(3389, 14041), new IntPoint(3809, 14041), new IntPoint(3809, 14035), new
IntPoint(3839, 14035), new IntPoint(3839, 14041), new IntPoint(3865, 14041), new IntPoint(3865, 14085), new IntPoint(3889, 14085), new IntPoint(3889, 14091), new IntPoint(4759, 14091), new
IntPoint(4759, 14085), new IntPoint(4789, 14085), new IntPoint(4789, 14091), new IntPoint(4815, 14091), new IntPoint(4815, 14135), new IntPoint(4839, 14135), new IntPoint(4839, 14141), new
IntPoint(7907, 14141), new IntPoint(7907, 14135), new IntPoint(7937, 14135), new IntPoint(7937, 14141), new IntPoint(7963, 14141), new IntPoint(7963, 14185), new IntPoint(7987, 14185), new
IntPoint(7987, 14191), new IntPoint(9457, 14191), new IntPoint(9457, 14141), new IntPoint(9857, 14141), new IntPoint(9857, 14135), new IntPoint(9887, 14135), new IntPoint(9887, 14141), new
IntPoint(9913, 14141), new IntPoint(9913, 14185), new IntPoint(9937, 14185), new IntPoint(9937, 14191), new IntPoint(10257, 14191), new IntPoint(10257, 14185), new IntPoint(10287, 14185), new
IntPoint(10287, 14191), new IntPoint(10313, 14191), new IntPoint(10313, 14235), new IntPoint(10337, 14235), new IntPoint(10337, 14241), new IntPoint(10363, 14241), new IntPoint(10363, 14285), new
IntPoint(10387, 14285), new IntPoint(10387, 14291), new IntPoint(10413, 14291), new IntPoint(10413, 14335), new IntPoint(10437, 14335), new IntPoint(10437, 14341), new IntPoint(10513, 14341), new
IntPoint(10513, 14385), new IntPoint(10537, 14385), new IntPoint(10537, 14391), new IntPoint(13357, 14391), new IntPoint(13357, 14341), new IntPoint(13757, 14341), new IntPoint(13757, 14335), new
IntPoint(13787, 14335), new IntPoint(13787, 14341), new IntPoint(13813, 14341), new IntPoint(13813, 14385), new IntPoint(13837, 14385), new IntPoint(13837, 14391), new IntPoint(13863, 14391), new
IntPoint(13863, 14435), new IntPoint(13887, 14435), new IntPoint(13887, 14441), new IntPoint(13913, 14441), new IntPoint(13913, 14485), new IntPoint(13937, 14485), new IntPoint(13937, 14491), new
IntPoint(13963, 14491), new IntPoint(13963, 14535), new IntPoint(13987, 14535), new IntPoint(13987, 14541), new IntPoint(14013, 14541), new IntPoint(14013, 14735), new IntPoint(14037, 14735), new
IntPoint(14037, 14741), new IntPoint(14063, 14741), new IntPoint(14063, 14775), new IntPoint(14383, 14775), new IntPoint(14383, 14741), new IntPoint(14457, 14741), new IntPoint(14457, 14691), new
IntPoint(14507, 14691), new IntPoint(14507, 14591), new IntPoint(14607, 14591), new IntPoint(14607, 14541), new IntPoint(14657, 14541), new IntPoint(14657, 14535), new IntPoint(14701, 14535), new
IntPoint(14701, 14415), new IntPoint(14657, 14415), new IntPoint(14657, 14371), new IntPoint(14633, 14371), new IntPoint(14633, 14365), new IntPoint(14607, 14365), new IntPoint(14607, 14341), new
IntPoint(14657, 14341), new IntPoint(14657, 14335), new IntPoint(14701, 14335), new IntPoint(14701, 14165), new IntPoint(14657, 14165), new IntPoint(14657, 14121), new IntPoint(14633, 14121), new
IntPoint(14633, 14115), new IntPoint(14607, 14115), new IntPoint(14607, 14071), new IntPoint(14583, 14071), new IntPoint(14583, 14065), new IntPoint(14557, 14065), new IntPoint(14557, 14021), new
IntPoint(14533, 14021), new IntPoint(14533, 14015), new IntPoint(14507, 14015), new IntPoint(14507, 13921), new IntPoint(14483, 13921), new IntPoint(14483, 13915), new IntPoint(14457, 13915), new
IntPoint(14457, 13821), new IntPoint(14433, 13821), new IntPoint(14433, 13815), new IntPoint(14407, 13815), new IntPoint(14407, 13671), new IntPoint(14383, 13671), new IntPoint(14383, 13665), new
IntPoint(14357, 13665), new IntPoint(14357, 12271), new IntPoint(14333, 12271), new IntPoint(14333, 12265), new IntPoint(14307, 12265), new IntPoint(14307, 10671), new IntPoint(14283, 10671), new
IntPoint(14283, 10665), new IntPoint(14257, 10665), new IntPoint(14257, 10371), new IntPoint(14233, 10371), new IntPoint(14233, 10365), new IntPoint(14207, 10365), new IntPoint(14207, 10221), new
IntPoint(14183, 10221), new IntPoint(14183, 10215), new IntPoint(14157, 10215), new IntPoint(14157, 9471), new IntPoint(14133, 9471), new IntPoint(14133, 9465), new IntPoint(14107, 9465), new
IntPoint(14107, 8991), new IntPoint(14157, 8991), new IntPoint(14157, 4373), new IntPoint(14133, 4373), new IntPoint(14133, 4365), new IntPoint(14107, 4365), new IntPoint(14107, 3973), new
IntPoint(14083, 3973), new IntPoint(14083, 3965), new IntPoint(14057, 3965), new IntPoint(14057, 3773), new IntPoint(14033, 3773), new IntPoint(14033, 3765), new IntPoint(14007, 3765), new
IntPoint(14007, 3623), new IntPoint(13983, 3623), new IntPoint(13983, 3615), new IntPoint(13957, 3615), new IntPoint(13957, 3323), new IntPoint(13933, 3323), new IntPoint(13933, 3315), new
IntPoint(13907, 3315), new IntPoint(13907, 3223), new IntPoint(13883, 3223), new IntPoint(13883, 3215), new IntPoint(13857, 3215), new IntPoint(13857, 3073), new IntPoint(13833, 3073), new
IntPoint(13833, 3065), new IntPoint(13807, 3065), new IntPoint(13807, 2923), new IntPoint(13783, 2923), new IntPoint(13783, 2915), new IntPoint(13757, 2915), new IntPoint(13757, 2773), new
IntPoint(13733, 2773), new IntPoint(13733, 2765), new IntPoint(13707, 2765), new IntPoint(13707, 2673), new IntPoint(13683, 2673), new IntPoint(13683, 2665), new IntPoint(13657, 2665), new
IntPoint(13657, 2573), new IntPoint(13633, 2573), new IntPoint(13633, 2565), new IntPoint(13607, 2565), new IntPoint(13607, 2473), new IntPoint(13583, 2473), new IntPoint(13583, 2465), new
IntPoint(13557, 2465), new IntPoint(13557, 2423), new IntPoint(13533, 2423), new IntPoint(13533, 2415), new IntPoint(13507, 2415), new IntPoint(13507, 2323), new IntPoint(13483, 2323), new
IntPoint(13483, 2315), new IntPoint(13457, 2315), new IntPoint(13457, 2273), new IntPoint(13433, 2273), new IntPoint(13433, 2265), new IntPoint(13407, 2265), new IntPoint(13407, 2173), new
IntPoint(13383, 2173), new IntPoint(13383, 2165), new IntPoint(13357, 2165), new IntPoint(13357, 2123), new IntPoint(13333, 2123), new IntPoint(13333, 2115), new IntPoint(13307, 2115), new
IntPoint(13307, 2073), new IntPoint(13283, 2073), new IntPoint(13283, 2065), new IntPoint(13257, 2065), new IntPoint(13257, 1973), new IntPoint(13233, 1973), new IntPoint(13233, 1965), new
IntPoint(13207, 1965), new IntPoint(13207, 1923), new IntPoint(13183, 1923), new IntPoint(13183, 1915), new IntPoint(13157, 1915), new IntPoint(13157, 1873), new IntPoint(13133, 1873), new
IntPoint(13133, 1865), new IntPoint(13107, 1865), new IntPoint(13107, 1823), new IntPoint(13083, 1823), new IntPoint(13083, 1815), new IntPoint(13057, 1815), new IntPoint(13057, 1773), new
IntPoint(13033, 1773), new IntPoint(13033, 1765), new IntPoint(13007, 1765), new IntPoint(13007, 1723), new IntPoint(12983, 1723), new IntPoint(12983, 1715), new IntPoint(12957, 1715), new
IntPoint(12957, 1673), new IntPoint(12933, 1673), new IntPoint(12933, 1665), new IntPoint(12907, 1665), new IntPoint(12907, 1623), new IntPoint(12883, 1623), new IntPoint(12883, 1615), new
IntPoint(12857, 1615), new IntPoint(12857, 1573), new IntPoint(12833, 1573), new IntPoint(12833, 1565), new IntPoint(12807, 1565), new IntPoint(12807, 1523), new IntPoint(12783, 1523), new
IntPoint(12783, 1515), new IntPoint(12757, 1515), new IntPoint(12757, 1473), new IntPoint(12733, 1473), new IntPoint(12733, 1465), new IntPoint(12707, 1465), new IntPoint(12707, 1423), new
IntPoint(12683, 1423), new IntPoint(12683, 1415), new IntPoint(12657, 1415), new IntPoint(12657, 1373), new IntPoint(12633, 1373), new IntPoint(12633, 1365), new IntPoint(12607, 1365), new
IntPoint(12607, 1323), new IntPoint(12583, 1323), new IntPoint(12583, 1315), new IntPoint(12507, 1315), new IntPoint(12507, 1273), new IntPoint(12483, 1273), new IntPoint(12483, 1265), new
IntPoint(12457, 1265), new IntPoint(12457, 1223), new IntPoint(12433, 1223), new IntPoint(12433, 1215), new IntPoint(12357, 1215), new IntPoint(12357, 1173), new IntPoint(12333, 1173), new
IntPoint(12333, 1165), new IntPoint(12307, 1165), new IntPoint(12307, 1123), new IntPoint(12283, 1123), new IntPoint(12283, 1115), new IntPoint(12107, 1115), new IntPoint(12107, 1073), new
IntPoint(12083, 1073), new IntPoint(12083, 1065), new IntPoint(11907, 1065), new IntPoint(11907, 1023), new IntPoint(11883, 1023), new IntPoint(11883, 1015), new IntPoint(11757, 1015), new
IntPoint(11757, 973), new IntPoint(11733, 973), new IntPoint(11733, 965), new IntPoint(11607, 965), new IntPoint(11607, 923), new IntPoint(11583, 923), new IntPoint(11583, 915), new IntPoint(11407,
915), new IntPoint(11407, 873), new IntPoint(11383, 873), new IntPoint(11383, 865), new IntPoint(10857, 865), new IntPoint(10857, 823), new IntPoint(10833, 823), new IntPoint(10833, 815), new
IntPoint(10457, 815), new IntPoint(10457, 773), new IntPoint(10433, 773), new IntPoint(10433, 765), new IntPoint(8707, 765), new IntPoint(8707, 723), new IntPoint(8683, 723), new IntPoint(8683, 715),
new IntPoint(4909, 715), new IntPoint(4909, 673), new IntPoint(4885, 673), new IntPoint(4885, 665), new IntPoint(4809, 665), new IntPoint(4809, 623), new IntPoint(4785, 623), new IntPoint(4785, 615),
new IntPoint(4759, 615), new IntPoint(4759, 573), new IntPoint(4735, 573), new IntPoint(4735, 565), new IntPoint(4659, 565), new IntPoint(4659, 523), new IntPoint(4635, 523), new IntPoint(4635, 515),
new IntPoint(1309, 515), new IntPoint(1309, 473), new IntPoint(1285, 473), new IntPoint(1285, 465), new IntPoint(1209, 465), new IntPoint(1209, 423), new IntPoint(1185, 423), new IntPoint(1185, 415),
new IntPoint(1109, 415), new IntPoint(1109, 373), new IntPoint(1085, 373), new IntPoint(1085, 365), new IntPoint(1009, 365), new IntPoint(1009, 323), new IntPoint(985, 323), new IntPoint(985, 315),
new IntPoint(909, 315), new IntPoint(909, 273), new IntPoint(885, 273), new IntPoint(885, 265), new IntPoint(859, 265), new IntPoint(859, 223), new IntPoint(835, 223), new IntPoint(835, 215), new
IntPoint(759, 215), new IntPoint(759, 173), new IntPoint(735, 173), new IntPoint(735, 165), new IntPoint(709, 165), new IntPoint(709, 123), new IntPoint(685, 123), new IntPoint(685, 115) }, new
Polygon() { new IntPoint(10387, 11091), new IntPoint(10413, 11091), new IntPoint(10413, 11135), new IntPoint(10437, 11135), new IntPoint(10437, 11141), new IntPoint(10463, 11141), new IntPoint(10463,
11315), new IntPoint(10413, 11315), new IntPoint(10413, 11415), new IntPoint(10363, 11415), new IntPoint(10363, 11465), new IntPoint(10313, 11465), new IntPoint(10313, 11565), new IntPoint(10263,
11565), new IntPoint(10263, 11765), new IntPoint(10213, 11765), new IntPoint(10213, 11915), new IntPoint(10163, 11915), new IntPoint(10163, 11965), new IntPoint(10113, 11965), new IntPoint(10113,
12315), new IntPoint(10063, 12315), new IntPoint(10063, 13165), new IntPoint(10013, 13165), new IntPoint(10013, 13215), new IntPoint(9857, 13215), new IntPoint(9857, 13171), new IntPoint(9833, 13171),
new IntPoint(9833, 13165), new IntPoint(9807, 13165), new IntPoint(9807, 12371), new IntPoint(9783, 12371), new IntPoint(9783, 12335), new IntPoint(9787, 12335), new IntPoint(9787, 12341), new
IntPoint(9857, 12341), new IntPoint(9857, 12291), new IntPoint(9907, 12291), new IntPoint(9907, 11971), new IntPoint(9883, 11971), new IntPoint(9883, 11935), new IntPoint(9887, 11935), new
IntPoint(9887, 11941), new IntPoint(9957, 11941), new IntPoint(9957, 11821), new IntPoint(9933, 11821), new IntPoint(9933, 11785), new IntPoint(9937, 11785), new IntPoint(9937, 11791), new
IntPoint(10007, 11791), new IntPoint(10007, 11621), new IntPoint(9983, 11621), new IntPoint(9983, 11585), new IntPoint(9987, 11585), new IntPoint(9987, 11591), new IntPoint(10057, 11591), new
IntPoint(10057, 11521), new IntPoint(10033, 11521), new IntPoint(10033, 11485), new IntPoint(10037, 11485), new IntPoint(10037, 11491), new IntPoint(10107, 11491), new IntPoint(10107, 11371), new
IntPoint(10083, 11371), new IntPoint(10083, 11335), new IntPoint(10087, 11335), new IntPoint(10087, 11341), new IntPoint(10157, 11341), new IntPoint(10157, 11271), new IntPoint(10133, 11271), new
IntPoint(10133, 11235), new IntPoint(10137, 11235), new IntPoint(10137, 11241), new IntPoint(10207, 11241), new IntPoint(10207, 11171), new IntPoint(10183, 11171), new IntPoint(10183, 11135), new
IntPoint(10187, 11135), new IntPoint(10187, 11141), new IntPoint(10257, 11141), new IntPoint(10257, 11091), new IntPoint(10357, 11091), new IntPoint(10357, 11085), new IntPoint(10387, 11085) }, new
Polygon() { new IntPoint(6139, 12741), new IntPoint(6165, 12741), new IntPoint(6165, 12785), new IntPoint(6189, 12785), new IntPoint(6189, 12791), new IntPoint(6309, 12791), new IntPoint(6309, 12785),
new IntPoint(6339, 12785), new IntPoint(6339, 12791), new IntPoint(6365, 12791), new IntPoint(6365, 12835), new IntPoint(6389, 12835), new IntPoint(6389, 12841), new IntPoint(6459, 12841), new
IntPoint(6459, 12835), new IntPoint(6489, 12835), new IntPoint(6489, 12841), new IntPoint(6515, 12841), new IntPoint(6515, 12885), new IntPoint(6539, 12885), new IntPoint(6539, 12891), new
IntPoint(6615, 12891), new IntPoint(6615, 13165), new IntPoint(5759, 13165), new IntPoint(5759, 13121), new IntPoint(5735, 13121), new IntPoint(5735, 13085), new IntPoint(5739, 13085), new
IntPoint(5739, 13091), new IntPoint(5809, 13091), new IntPoint(5809, 13021), new IntPoint(5785, 13021), new IntPoint(5785, 12985), new IntPoint(5789, 12985), new IntPoint(5789, 12991), new
IntPoint(5859, 12991), new IntPoint(5859, 12921), new IntPoint(5835, 12921), new IntPoint(5835, 12885), new IntPoint(5839, 12885), new IntPoint(5839, 12891), new IntPoint(5909, 12891), new
IntPoint(5909, 12841), new IntPoint(5959, 12841), new IntPoint(5959, 12791), new IntPoint(6009, 12791), new IntPoint(6009, 12741), new IntPoint(6109, 12741), new IntPoint(6109, 12735), new
IntPoint(6139, 12735) }, new Polygon() { new IntPoint(8087, 12391), new IntPoint(8113, 12391), new IntPoint(8113, 12435), new IntPoint(8137, 12435), new IntPoint(8137, 12441), new IntPoint(8207,
12441), new IntPoint(8207, 12435), new IntPoint(8237, 12435), new IntPoint(8237, 12441), new IntPoint(8263, 12441), new IntPoint(8263, 12485), new IntPoint(8287, 12485), new IntPoint(8287, 12491), new
IntPoint(8363, 12491), new IntPoint(8363, 12535), new IntPoint(8387, 12535), new IntPoint(8387, 12541), new IntPoint(8463, 12541), new IntPoint(8463, 12585), new IntPoint(8487, 12585), new
IntPoint(8487, 12591), new IntPoint(8513, 12591), new IntPoint(8513, 12865), new IntPoint(8463, 12865), new IntPoint(8463, 12965), new IntPoint(8413, 12965), new IntPoint(8413, 13015), new
IntPoint(8363, 13015), new IntPoint(8363, 13115), new IntPoint(8313, 13115), new IntPoint(8313, 13165), new IntPoint(6959, 13165), new IntPoint(6959, 12921), new IntPoint(6935, 12921), new
IntPoint(6935, 12885), new IntPoint(6939, 12885), new IntPoint(6939, 12891), new IntPoint(7009, 12891), new IntPoint(7009, 12841), new IntPoint(7159, 12841), new IntPoint(7159, 12791), new
IntPoint(7259, 12791), new IntPoint(7259, 12741), new IntPoint(7359, 12741), new IntPoint(7359, 12691), new IntPoint(7407, 12691), new IntPoint(7407, 12641), new IntPoint(7457, 12641), new
IntPoint(7457, 12591), new IntPoint(7507, 12591), new IntPoint(7507, 12541), new IntPoint(7557, 12541), new IntPoint(7557, 12491), new IntPoint(7607, 12491), new IntPoint(7607, 12441), new
IntPoint(7657, 12441), new IntPoint(7657, 12391), new IntPoint(8057, 12391), new IntPoint(8057, 12385), new IntPoint(8087, 12385) }, new Polygon() { new IntPoint(8937, 11441), new IntPoint(9207,
11441), new IntPoint(9207, 11435), new IntPoint(9237, 11435), new IntPoint(9237, 11441), new IntPoint(9263, 11441), new IntPoint(9263, 11635), new IntPoint(9287, 11635), new IntPoint(9287, 11641), new
IntPoint(9363, 11641), new IntPoint(9363, 12765), new IntPoint(9313, 12765), new IntPoint(9313, 13015), new IntPoint(9263, 13015), new IntPoint(9263, 13065), new IntPoint(9213, 13065), new
IntPoint(9213, 13115), new IntPoint(9057, 13115), new IntPoint(9057, 13071), new IntPoint(9033, 13071), new IntPoint(9033, 13065), new IntPoint(8957, 13065), new IntPoint(8957, 12821), new
IntPoint(8933, 12821), new IntPoint(8933, 12785), new IntPoint(8937, 12785), new IntPoint(8937, 12791), new IntPoint(9007, 12791), new IntPoint(9007, 12321), new IntPoint(8983, 12321), new
IntPoint(8983, 12315), new IntPoint(8907, 12315), new IntPoint(8907, 12271), new IntPoint(8883, 12271), new IntPoint(8883, 12265), new IntPoint(8857, 12265), new IntPoint(8857, 12221), new
IntPoint(8833, 12221), new IntPoint(8833, 12215), new IntPoint(8757, 12215), new IntPoint(8757, 12171), new IntPoint(8733, 12171), new IntPoint(8733, 12165), new IntPoint(8657, 12165), new
IntPoint(8657, 12121), new IntPoint(8633, 12121), new IntPoint(8633, 12115), new IntPoint(8607, 12115), new IntPoint(8607, 12071), new IntPoint(8583, 12071), new IntPoint(8583, 12035), new
IntPoint(8587, 12035), new IntPoint(8587, 12041), new IntPoint(8657, 12041), new IntPoint(8657, 11971), new IntPoint(8633, 11971), new IntPoint(8633, 11935), new IntPoint(8637, 11935), new
IntPoint(8637, 11941), new IntPoint(8707, 11941), new IntPoint(8707, 11871), new IntPoint(8683, 11871), new IntPoint(8683, 11835), new IntPoint(8687, 11835), new IntPoint(8687, 11841), new
IntPoint(8757, 11841), new IntPoint(8757, 11791), new IntPoint(8807, 11791), new IntPoint(8807, 11721), new IntPoint(8783, 11721), new IntPoint(8783, 11685), new IntPoint(8787, 11685), new
IntPoint(8787, 11691), new IntPoint(8857, 11691), new IntPoint(8857, 11621), new IntPoint(8833, 11621), new IntPoint(8833, 11585), new IntPoint(8837, 11585), new IntPoint(8837, 11591), new
IntPoint(8907, 11591), new IntPoint(8907, 11541), new IntPoint(8957, 11541), new IntPoint(8957, 11471), new IntPoint(8933, 11471), new IntPoint(8933, 11435), new IntPoint(8937, 11435) }, new Polygon()
{ new IntPoint(5189, 12491), new IntPoint(5215, 12491), new IntPoint(5215, 12535), new IntPoint(5239, 12535), new IntPoint(5239, 12541), new IntPoint(5309, 12541), new IntPoint(5309, 12535), new
IntPoint(5339, 12535), new IntPoint(5339, 12541), new IntPoint(5365, 12541), new IntPoint(5365, 12765), new IntPoint(5315, 12765), new IntPoint(5315, 12915), new IntPoint(5265, 12915), new
IntPoint(5265, 13065), new IntPoint(5215, 13065), new IntPoint(5215, 13115), new IntPoint(4309, 13115), new IntPoint(4309, 13071), new IntPoint(4285, 13071), new IntPoint(4285, 13065), new
IntPoint(4259, 13065), new IntPoint(4259, 13021), new IntPoint(4235, 13021), new IntPoint(4235, 13015), new IntPoint(4159, 13015), new IntPoint(4159, 12921), new IntPoint(4135, 12921), new
IntPoint(4135, 12885), new IntPoint(4139, 12885), new IntPoint(4139, 12891), new IntPoint(4209, 12891), new IntPoint(4209, 12821), new IntPoint(4185, 12821), new IntPoint(4185, 12785), new
IntPoint(4189, 12785), new IntPoint(4189, 12791), new IntPoint(4259, 12791), new IntPoint(4259, 12741), new IntPoint(4309, 12741), new IntPoint(4309, 12691), new IntPoint(4959, 12691), new
IntPoint(4959, 12621), new IntPoint(4935, 12621), new IntPoint(4935, 12585), new IntPoint(4939, 12585), new IntPoint(4939, 12591), new IntPoint(5009, 12591), new IntPoint(5009, 12541), new
IntPoint(5059, 12541), new IntPoint(5059, 12491), new IntPoint(5159, 12491), new IntPoint(5159, 12485), new IntPoint(5189, 12485) }, new Polygon() { new IntPoint(3889, 11591), new IntPoint(3915,
11591), new IntPoint(3915, 11635), new IntPoint(3939, 11635), new IntPoint(3939, 11641), new IntPoint(4015, 11641), new IntPoint(4015, 11685), new IntPoint(4039, 11685), new IntPoint(4039, 11691), new
IntPoint(4065, 11691), new IntPoint(4065, 11735), new IntPoint(4089, 11735), new IntPoint(4089, 11741), new IntPoint(4115, 11741), new IntPoint(4115, 12015), new IntPoint(4065, 12015), new
IntPoint(4065, 12065), new IntPoint(4015, 12065), new IntPoint(4015, 12165), new IntPoint(3965, 12165), new IntPoint(3965, 12215), new IntPoint(3915, 12215), new IntPoint(3915, 12265), new
IntPoint(3865, 12265), new IntPoint(3865, 12365), new IntPoint(3815, 12365), new IntPoint(3815, 12415), new IntPoint(3765, 12415), new IntPoint(3765, 12515), new IntPoint(3715, 12515), new
IntPoint(3715, 12665), new IntPoint(3665, 12665), new IntPoint(3665, 12765), new IntPoint(3615, 12765), new IntPoint(3615, 12865), new IntPoint(3459, 12865), new IntPoint(3459, 12821), new
IntPoint(3435, 12821), new IntPoint(3435, 12815), new IntPoint(3309, 12815), new IntPoint(3309, 12771), new IntPoint(3285, 12771), new IntPoint(3285, 12765), new IntPoint(3209, 12765), new
IntPoint(3209, 12721), new IntPoint(3185, 12721), new IntPoint(3185, 12715), new IntPoint(3159, 12715), new IntPoint(3159, 12671), new IntPoint(3135, 12671), new IntPoint(3135, 12665), new
IntPoint(3109, 12665), new IntPoint(3109, 12621), new IntPoint(3085, 12621), new IntPoint(3085, 12615), new IntPoint(3059, 12615), new IntPoint(3059, 12421), new IntPoint(3035, 12421), new
IntPoint(3035, 12415), new IntPoint(3009, 12415), new IntPoint(3009, 12221), new IntPoint(2985, 12221), new IntPoint(2985, 12185), new IntPoint(2989, 12185), new IntPoint(2989, 12191), new
IntPoint(3059, 12191), new IntPoint(3059, 12141), new IntPoint(3109, 12141), new IntPoint(3109, 12091), new IntPoint(3159, 12091), new IntPoint(3159, 12041), new IntPoint(3209, 12041), new
IntPoint(3209, 11971), new IntPoint(3185, 11971), new IntPoint(3185, 11935), new IntPoint(3189, 11935), new IntPoint(3189, 11941), new IntPoint(3359, 11941), new IntPoint(3359, 11891), new
IntPoint(3409, 11891), new IntPoint(3409, 11841), new IntPoint(3459, 11841), new IntPoint(3459, 11791), new IntPoint(3509, 11791), new IntPoint(3509, 11741), new IntPoint(3559, 11741), new
IntPoint(3559, 11691), new IntPoint(3609, 11691), new IntPoint(3609, 11641), new IntPoint(3809, 11641), new IntPoint(3809, 11591), new IntPoint(3859, 11591), new IntPoint(3859, 11585), new
IntPoint(3889, 11585) }, new Polygon() { new IntPoint(10913, 12435), new IntPoint(10937, 12435), new IntPoint(10937, 12441), new IntPoint(10963, 12441), new IntPoint(10963, 12485), new IntPoint(10987,
12485), new IntPoint(10987, 12491), new IntPoint(11013, 12491), new IntPoint(11013, 12565), new IntPoint(10963, 12565), new IntPoint(10963, 12615), new IntPoint(10913, 12615), new IntPoint(10913,
12665), new IntPoint(10857, 12665), new IntPoint(10857, 12621), new IntPoint(10833, 12621), new IntPoint(10833, 12615), new IntPoint(10807, 12615), new IntPoint(10807, 12571), new IntPoint(10783,
12571), new IntPoint(10783, 12565), new IntPoint(10757, 12565), new IntPoint(10757, 12521), new IntPoint(10733, 12521), new IntPoint(10733, 12485), new IntPoint(10737, 12485), new IntPoint(10737,
12491), new IntPoint(10807, 12491), new IntPoint(10807, 12441), new IntPoint(10857, 12441), new IntPoint(10857, 12391), new IntPoint(10913, 12391) }, new Polygon() { new IntPoint(5865, 11485), new
IntPoint(5889, 11485), new IntPoint(5889, 11491), new IntPoint(5965, 11491), new IntPoint(5965, 11535), new IntPoint(5989, 11535), new IntPoint(5989, 11541), new IntPoint(6065, 11541), new
IntPoint(6065, 11585), new IntPoint(6089, 11585), new IntPoint(6089, 11591), new IntPoint(6115, 11591), new IntPoint(6115, 11635), new IntPoint(6139, 11635), new IntPoint(6139, 11641), new
IntPoint(6215, 11641), new IntPoint(6215, 11685), new IntPoint(6239, 11685), new IntPoint(6239, 11691), new IntPoint(6459, 11691), new IntPoint(6459, 11685), new IntPoint(6489, 11685), new
IntPoint(6489, 11691), new IntPoint(6515, 11691), new IntPoint(6515, 11735), new IntPoint(6539, 11735), new IntPoint(6539, 11741), new IntPoint(6565, 11741), new IntPoint(6565, 11785), new
IntPoint(6589, 11785), new IntPoint(6589, 11791), new IntPoint(6909, 11791), new IntPoint(6909, 11741), new IntPoint(7009, 11741), new IntPoint(7009, 11691), new IntPoint(7109, 11691), new
IntPoint(7109, 11685), new IntPoint(7139, 11685), new IntPoint(7139, 11691), new IntPoint(7165, 11691), new IntPoint(7165, 12265), new IntPoint(7115, 12265), new IntPoint(7115, 12365), new
IntPoint(7065, 12365), new IntPoint(7065, 12415), new IntPoint(7015, 12415), new IntPoint(7015, 12465), new IntPoint(6759, 12465), new IntPoint(6759, 12421), new IntPoint(6735, 12421), new
IntPoint(6735, 12415), new IntPoint(6709, 12415), new IntPoint(6709, 12321), new IntPoint(6685, 12321), new IntPoint(6685, 12315), new IntPoint(6659, 12315), new IntPoint(6659, 12121), new
IntPoint(6635, 12121), new IntPoint(6635, 12115), new IntPoint(6609, 12115), new IntPoint(6609, 11971), new IntPoint(6585, 11971), new IntPoint(6585, 11965), new IntPoint(6215, 11965), new
IntPoint(6215, 12015), new IntPoint(6165, 12015), new IntPoint(6165, 12265), new IntPoint(6115, 12265), new IntPoint(6115, 12315), new IntPoint(6059, 12315), new IntPoint(6059, 12271), new
IntPoint(6035, 12271), new IntPoint(6035, 12265), new IntPoint(5909, 12265), new IntPoint(5909, 12221), new IntPoint(5885, 12221), new IntPoint(5885, 12215), new IntPoint(5809, 12215), new
IntPoint(5809, 12171), new IntPoint(5785, 12171), new IntPoint(5785, 12165), new IntPoint(5709, 12165), new IntPoint(5709, 12121), new IntPoint(5685, 12121), new IntPoint(5685, 12115), new
IntPoint(5609, 12115), new IntPoint(5609, 12071), new IntPoint(5585, 12071), new IntPoint(5585, 12065), new IntPoint(4915, 12065), new IntPoint(4915, 12115), new IntPoint(4815, 12115), new
IntPoint(4815, 12165), new IntPoint(4715, 12165), new IntPoint(4715, 12215), new IntPoint(4609, 12215), new IntPoint(4609, 12171), new IntPoint(4585, 12171), new IntPoint(4585, 12165), new
IntPoint(4559, 12165), new IntPoint(4559, 12121), new IntPoint(4535, 12121), new IntPoint(4535, 12085), new IntPoint(4539, 12085), new IntPoint(4539, 12091), new IntPoint(4609, 12091), new
IntPoint(4609, 12041), new IntPoint(4709, 12041), new IntPoint(4709, 11991), new IntPoint(4859, 11991), new IntPoint(4859, 11941), new IntPoint(4959, 11941), new IntPoint(4959, 11891), new
IntPoint(5109, 11891), new IntPoint(5109, 11841), new IntPoint(5309, 11841), new IntPoint(5309, 11791), new IntPoint(5509, 11791), new IntPoint(5509, 11741), new IntPoint(5559, 11741), new
IntPoint(5559, 11691), new IntPoint(5609, 11691), new IntPoint(5609, 11641), new IntPoint(5659, 11641), new IntPoint(5659, 11591), new IntPoint(5709, 11591), new IntPoint(5709, 11541), new
IntPoint(5759, 11541), new IntPoint(5759, 11491), new IntPoint(5809, 11491), new IntPoint(5809, 11441), new IntPoint(5865, 11441) }, new Polygon() { new IntPoint(8187, 10391), new IntPoint(8263,
10391), new IntPoint(8263, 10435), new IntPoint(8287, 10435), new IntPoint(8287, 10441), new IntPoint(8363, 10441), new IntPoint(8363, 10485), new IntPoint(8387, 10485), new IntPoint(8387, 10491), new
IntPoint(8413, 10491), new IntPoint(8413, 10535), new IntPoint(8437, 10535), new IntPoint(8437, 10541), new IntPoint(8463, 10541), new IntPoint(8463, 10585), new IntPoint(8487, 10585), new
IntPoint(8487, 10591), new IntPoint(8513, 10591), new IntPoint(8513, 10685), new IntPoint(8537, 10685), new IntPoint(8537, 10691), new IntPoint(8563, 10691), new IntPoint(8563, 10785), new
IntPoint(8587, 10785), new IntPoint(8587, 10791), new IntPoint(8613, 10791), new IntPoint(8613, 11115), new IntPoint(8563, 11115), new IntPoint(8563, 11165), new IntPoint(8513, 11165), new
IntPoint(8513, 11265), new IntPoint(8463, 11265), new IntPoint(8463, 11365), new IntPoint(8413, 11365), new IntPoint(8413, 11465), new IntPoint(8363, 11465), new IntPoint(8363, 11565), new
IntPoint(8313, 11565), new IntPoint(8313, 11615), new IntPoint(8263, 11615), new IntPoint(8263, 11665), new IntPoint(8113, 11665), new IntPoint(8113, 11715), new IntPoint(7757, 11715), new
IntPoint(7757, 11671), new IntPoint(7733, 11671), new IntPoint(7733, 11665), new IntPoint(7707, 11665), new IntPoint(7707, 11421), new IntPoint(7683, 11421), new IntPoint(7683, 11385), new
IntPoint(7687, 11385), new IntPoint(7687, 11391), new IntPoint(7757, 11391), new IntPoint(7757, 11341), new IntPoint(7807, 11341), new IntPoint(7807, 11291), new IntPoint(7907, 11291), new
IntPoint(7907, 11241), new IntPoint(8057, 11241), new IntPoint(8057, 11191), new IntPoint(8157, 11191), new IntPoint(8157, 11141), new IntPoint(8207, 11141), new IntPoint(8207, 10421), new
IntPoint(8183, 10421), new IntPoint(8183, 10385), new IntPoint(8187, 10385) }, new Polygon() { new IntPoint(3239, 9241), new IntPoint(3315, 9241), new IntPoint(3315, 9335), new IntPoint(3339, 9335),
new IntPoint(3339, 9341), new IntPoint(3365, 9341), new IntPoint(3365, 9385), new IntPoint(3389, 9385), new IntPoint(3389, 9391), new IntPoint(3415, 9391), new IntPoint(3415, 9585), new IntPoint(3439,
9585), new IntPoint(3439, 9591), new IntPoint(3465, 9591), new IntPoint(3465, 9765), new IntPoint(3415, 9765), new IntPoint(3415, 9915), new IntPoint(3365, 9915), new IntPoint(3365, 10015), new
IntPoint(3315, 10015), new IntPoint(3315, 10115), new IntPoint(3265, 10115), new IntPoint(3265, 10265), new IntPoint(3215, 10265), new IntPoint(3215, 10365), new IntPoint(3165, 10365), new
IntPoint(3165, 10465), new IntPoint(3115, 10465), new IntPoint(3115, 10565), new IntPoint(3065, 10565), new IntPoint(3065, 10665), new IntPoint(3015, 10665), new IntPoint(3015, 10765), new
IntPoint(2965, 10765), new IntPoint(2965, 10865), new IntPoint(2915, 10865), new IntPoint(2915, 10965), new IntPoint(2865, 10965), new IntPoint(2865, 11065), new IntPoint(2815, 11065), new
IntPoint(2815, 11165), new IntPoint(2765, 11165), new IntPoint(2765, 11265), new IntPoint(2715, 11265), new IntPoint(2715, 11315), new IntPoint(2665, 11315), new IntPoint(2665, 11365), new
IntPoint(2615, 11365), new IntPoint(2615, 11465), new IntPoint(2565, 11465), new IntPoint(2565, 11515), new IntPoint(2515, 11515), new IntPoint(2515, 11565), new IntPoint(2465, 11565), new
IntPoint(2465, 11615), new IntPoint(2365, 11615), new IntPoint(2365, 11665), new IntPoint(2159, 11665), new IntPoint(2159, 11621), new IntPoint(2135, 11621), new IntPoint(2135, 11615), new
IntPoint(2109, 11615), new IntPoint(2109, 11571), new IntPoint(2085, 11571), new IntPoint(2085, 11565), new IntPoint(2059, 11565), new IntPoint(2059, 11521), new IntPoint(2035, 11521), new
IntPoint(2035, 11515), new IntPoint(2009, 11515), new IntPoint(2009, 11421), new IntPoint(1985, 11421), new IntPoint(1985, 11415), new IntPoint(1959, 11415), new IntPoint(1959, 11371), new
IntPoint(1935, 11371), new IntPoint(1935, 11365), new IntPoint(1909, 11365), new IntPoint(1909, 11221), new IntPoint(1885, 11221), new IntPoint(1885, 11215), new IntPoint(1859, 11215), new
IntPoint(1859, 11071), new IntPoint(1835, 11071), new IntPoint(1835, 11065), new IntPoint(1809, 11065), new IntPoint(1809, 9871), new IntPoint(1785, 9871), new IntPoint(1785, 9835), new IntPoint(1789,
9835), new IntPoint(1789, 9841), new IntPoint(1915, 9841), new IntPoint(1915, 9885), new IntPoint(1939, 9885), new IntPoint(1939, 9891), new IntPoint(2015, 9891), new IntPoint(2015, 9935), new
IntPoint(2039, 9935), new IntPoint(2039, 9941), new IntPoint(2065, 9941), new IntPoint(2065, 9985), new IntPoint(2089, 9985), new IntPoint(2089, 9991), new IntPoint(2115, 9991), new IntPoint(2115,
10085), new IntPoint(2139, 10085), new IntPoint(2139, 10091), new IntPoint(2165, 10091), new IntPoint(2165, 10135), new IntPoint(2189, 10135), new IntPoint(2189, 10141), new IntPoint(2215, 10141), new
IntPoint(2215, 10235), new IntPoint(2239, 10235), new IntPoint(2239, 10241), new IntPoint(2265, 10241), new IntPoint(2265, 10335), new IntPoint(2289, 10335), new IntPoint(2289, 10341), new
IntPoint(2315, 10341), new IntPoint(2315, 10385), new IntPoint(2339, 10385), new IntPoint(2339, 10391), new IntPoint(2365, 10391), new IntPoint(2365, 10435), new IntPoint(2389, 10435), new
IntPoint(2389, 10441), new IntPoint(2809, 10441), new IntPoint(2809, 10391), new IntPoint(2859, 10391), new IntPoint(2859, 10341), new IntPoint(2909, 10341), new IntPoint(2909, 10291), new
IntPoint(2959, 10291), new IntPoint(2959, 10221), new IntPoint(2935, 10221), new IntPoint(2935, 10185), new IntPoint(2939, 10185), new IntPoint(2939, 10191), new IntPoint(3009, 10191), new
IntPoint(3009, 10141), new IntPoint(3059, 10141), new IntPoint(3059, 10091), new IntPoint(3109, 10091), new IntPoint(3109, 10021), new IntPoint(3085, 10021), new IntPoint(3085, 9985), new
IntPoint(3089, 9985), new IntPoint(3089, 9991), new IntPoint(3159, 9991), new IntPoint(3159, 9921), new IntPoint(3135, 9921), new IntPoint(3135, 9885), new IntPoint(3139, 9885), new IntPoint(3139,
9891), new IntPoint(3209, 9891), new IntPoint(3209, 9821), new IntPoint(3185, 9821), new IntPoint(3185, 9785), new IntPoint(3189, 9785), new IntPoint(3189, 9791), new IntPoint(3259, 9791), new
IntPoint(3259, 9271), new IntPoint(3235, 9271), new IntPoint(3235, 9235), new IntPoint(3239, 9235) }, new Polygon() { new IntPoint(5989, 9491), new IntPoint(6015, 9491), new IntPoint(6015, 9535), new
IntPoint(6039, 9535), new IntPoint(6039, 9541), new IntPoint(6115, 9541), new IntPoint(6115, 9665), new IntPoint(6065, 9665), new IntPoint(6065, 9715), new IntPoint(6015, 9715), new IntPoint(6015,
9765), new IntPoint(5965, 9765), new IntPoint(5965, 9815), new IntPoint(5915, 9815), new IntPoint(5915, 9865), new IntPoint(5865, 9865), new IntPoint(5865, 9915), new IntPoint(5815, 9915), new
IntPoint(5815, 9965), new IntPoint(5765, 9965), new IntPoint(5765, 10615), new IntPoint(5715, 10615), new IntPoint(5715, 10765), new IntPoint(5665, 10765), new IntPoint(5665, 10915), new
IntPoint(5615, 10915), new IntPoint(5615, 10965), new IntPoint(5565, 10965), new IntPoint(5565, 11015), new IntPoint(5515, 11015), new IntPoint(5515, 11065), new IntPoint(5465, 11065), new
IntPoint(5465, 11115), new IntPoint(5415, 11115), new IntPoint(5415, 11165), new IntPoint(5365, 11165), new IntPoint(5365, 11265), new IntPoint(5265, 11265), new IntPoint(5265, 11315), new
IntPoint(5165, 11315), new IntPoint(5165, 11365), new IntPoint(5015, 11365), new IntPoint(5015, 11415), new IntPoint(4915, 11415), new IntPoint(4915, 11465), new IntPoint(4765, 11465), new
IntPoint(4765, 11515), new IntPoint(4665, 11515), new IntPoint(4665, 11565), new IntPoint(4609, 11565), new IntPoint(4609, 11521), new IntPoint(4585, 11521), new IntPoint(4585, 11515), new
IntPoint(4559, 11515), new IntPoint(4559, 11471), new IntPoint(4535, 11471), new IntPoint(4535, 11465), new IntPoint(4509, 11465), new IntPoint(4509, 11421), new IntPoint(4485, 11421), new
IntPoint(4485, 11415), new IntPoint(4459, 11415), new IntPoint(4459, 11271), new IntPoint(4435, 11271), new IntPoint(4435, 11265), new IntPoint(4409, 11265), new IntPoint(4409, 11221), new
IntPoint(4385, 11221), new IntPoint(4385, 11215), new IntPoint(4009, 11215), new IntPoint(4009, 11171), new IntPoint(3985, 11171), new IntPoint(3985, 11165), new IntPoint(3909, 11165), new
IntPoint(3909, 11121), new IntPoint(3885, 11121), new IntPoint(3885, 11115), new IntPoint(3859, 11115), new IntPoint(3859, 11021), new IntPoint(3835, 11021), new IntPoint(3835, 11015), new
IntPoint(3809, 11015), new IntPoint(3809, 10921), new IntPoint(3785, 10921), new IntPoint(3785, 10885), new IntPoint(3789, 10885), new IntPoint(3789, 10891), new IntPoint(3859, 10891), new
IntPoint(3859, 10721), new IntPoint(3835, 10721), new IntPoint(3835, 10685), new IntPoint(3839, 10685), new IntPoint(3839, 10691), new IntPoint(3909, 10691), new IntPoint(3909, 10621), new
IntPoint(3885, 10621), new IntPoint(3885, 10585), new IntPoint(3889, 10585), new IntPoint(3889, 10591), new IntPoint(3959, 10591), new IntPoint(3959, 10541), new IntPoint(4009, 10541), new
IntPoint(4009, 10491), new IntPoint(4059, 10491), new IntPoint(4059, 10441), new IntPoint(4109, 10441), new IntPoint(4109, 10391), new IntPoint(4159, 10391), new IntPoint(4159, 10341), new
IntPoint(4259, 10341), new IntPoint(4259, 10291), new IntPoint(4309, 10291), new IntPoint(4309, 10241), new IntPoint(4359, 10241), new IntPoint(4359, 10191), new IntPoint(4409, 10191), new
IntPoint(4409, 10185), new IntPoint(4439, 10185), new IntPoint(4439, 10191), new IntPoint(4465, 10191), new IntPoint(4465, 10235), new IntPoint(4489, 10235), new IntPoint(4489, 10241), new
IntPoint(4515, 10241), new IntPoint(4515, 10315), new IntPoint(4465, 10315), new IntPoint(4465, 10365), new IntPoint(4415, 10365), new IntPoint(4415, 10635), new IntPoint(4439, 10635), new
IntPoint(4439, 10641), new IntPoint(4465, 10641), new IntPoint(4465, 10685), new IntPoint(4489, 10685), new IntPoint(4489, 10691), new IntPoint(4515, 10691), new IntPoint(4515, 10735), new
IntPoint(4539, 10735), new IntPoint(4539, 10741), new IntPoint(4565, 10741), new IntPoint(4565, 10785), new IntPoint(4589, 10785), new IntPoint(4589, 10791), new IntPoint(4615, 10791), new
IntPoint(4615, 10835), new IntPoint(4639, 10835), new IntPoint(4639, 10841), new IntPoint(4665, 10841), new IntPoint(4665, 10885), new IntPoint(4689, 10885), new IntPoint(4689, 10891), new
IntPoint(4765, 10891), new IntPoint(4765, 10935), new IntPoint(4789, 10935), new IntPoint(4789, 10941), new IntPoint(4909, 10941), new IntPoint(4909, 10935), new IntPoint(4939, 10935), new
IntPoint(4939, 10941), new IntPoint(4965, 10941), new IntPoint(4965, 10985), new IntPoint(4989, 10985), new IntPoint(4989, 10991), new IntPoint(5159, 10991), new IntPoint(5159, 10941), new
IntPoint(5259, 10941), new IntPoint(5259, 10891), new IntPoint(5309, 10891), new IntPoint(5309, 10841), new IntPoint(5359, 10841), new IntPoint(5359, 10791), new IntPoint(5459, 10791), new
IntPoint(5459, 10721), new IntPoint(5435, 10721), new IntPoint(5435, 10685), new IntPoint(5439, 10685), new IntPoint(5439, 10691), new IntPoint(5509, 10691), new IntPoint(5509, 10321), new
IntPoint(5485, 10321), new IntPoint(5485, 10315), new IntPoint(5459, 10315), new IntPoint(5459, 10271), new IntPoint(5435, 10271), new IntPoint(5435, 10265), new IntPoint(5409, 10265), new
IntPoint(5409, 10171), new IntPoint(5385, 10171), new IntPoint(5385, 10165), new IntPoint(5359, 10165), new IntPoint(5359, 10121), new IntPoint(5335, 10121), new IntPoint(5335, 10115), new
IntPoint(5309, 10115), new IntPoint(5309, 10071), new IntPoint(5285, 10071), new IntPoint(5285, 10065), new IntPoint(5259, 10065), new IntPoint(5259, 9971), new IntPoint(5235, 9971), new
IntPoint(5235, 9965), new IntPoint(4909, 9965), new IntPoint(4909, 9921), new IntPoint(4885, 9921), new IntPoint(4885, 9915), new IntPoint(4859, 9915), new IntPoint(4859, 9871), new IntPoint(4835,
9871), new IntPoint(4835, 9835), new IntPoint(4839, 9835), new IntPoint(4839, 9841), new IntPoint(4959, 9841), new IntPoint(4959, 9791), new IntPoint(5059, 9791), new IntPoint(5059, 9741), new
IntPoint(5159, 9741), new IntPoint(5159, 9691), new IntPoint(5259, 9691), new IntPoint(5259, 9641), new IntPoint(5359, 9641), new IntPoint(5359, 9591), new IntPoint(5509, 9591), new IntPoint(5509,
9541), new IntPoint(5759, 9541), new IntPoint(5759, 9491), new IntPoint(5959, 9491), new IntPoint(5959, 9485), new IntPoint(5989, 9485) }, new Polygon() { new IntPoint(6889, 10141), new IntPoint(6915,
10141), new IntPoint(6915, 10185), new IntPoint(6939, 10185), new IntPoint(6939, 10191), new IntPoint(7109, 10191), new IntPoint(7109, 10185), new IntPoint(7139, 10185), new IntPoint(7139, 10191), new
IntPoint(7165, 10191), new IntPoint(7165, 10235), new IntPoint(7189, 10235), new IntPoint(7189, 10241), new IntPoint(7259, 10241), new IntPoint(7259, 10235), new IntPoint(7289, 10235), new
IntPoint(7289, 10241), new IntPoint(7315, 10241), new IntPoint(7315, 10285), new IntPoint(7337, 10285), new IntPoint(7337, 10291), new IntPoint(7407, 10291), new IntPoint(7407, 10285), new
IntPoint(7437, 10285), new IntPoint(7437, 10291), new IntPoint(7463, 10291), new IntPoint(7463, 10335), new IntPoint(7487, 10335), new IntPoint(7487, 10341), new IntPoint(7563, 10341), new
IntPoint(7563, 10385), new IntPoint(7587, 10385), new IntPoint(7587, 10391), new IntPoint(7657, 10391), new IntPoint(7657, 10385), new IntPoint(7687, 10385), new IntPoint(7687, 10391), new
IntPoint(7713, 10391), new IntPoint(7713, 10865), new IntPoint(7663, 10865), new IntPoint(7663, 10915), new IntPoint(7407, 10915), new IntPoint(7407, 10721), new IntPoint(7385, 10721), new
IntPoint(7385, 10715), new IntPoint(7359, 10715), new IntPoint(7359, 10671), new IntPoint(7335, 10671), new IntPoint(7335, 10665), new IntPoint(7259, 10665), new IntPoint(7259, 10621), new
IntPoint(7235, 10621), new IntPoint(7235, 10615), new IntPoint(7109, 10615), new IntPoint(7109, 10571), new IntPoint(7085, 10571), new IntPoint(7085, 10565), new IntPoint(6865, 10565), new
IntPoint(6865, 10615), new IntPoint(6765, 10615), new IntPoint(6765, 11035), new IntPoint(6789, 11035), new IntPoint(6789, 11041), new IntPoint(6815, 11041), new IntPoint(6815, 11085), new
IntPoint(6839, 11085), new IntPoint(6839, 11091), new IntPoint(6915, 11091), new IntPoint(6915, 11135), new IntPoint(6939, 11135), new IntPoint(6939, 11141), new IntPoint(6965, 11141), new
IntPoint(6965, 11265), new IntPoint(6915, 11265), new IntPoint(6915, 11315), new IntPoint(6865, 11315), new IntPoint(6865, 11365), new IntPoint(6709, 11365), new IntPoint(6709, 11321), new
IntPoint(6685, 11321), new IntPoint(6685, 11315), new IntPoint(6609, 11315), new IntPoint(6609, 11271), new IntPoint(6585, 11271), new IntPoint(6585, 11265), new IntPoint(6559, 11265), new
IntPoint(6559, 11221), new IntPoint(6535, 11221), new IntPoint(6535, 11215), new IntPoint(6509, 11215), new IntPoint(6509, 11171), new IntPoint(6485, 11171), new IntPoint(6485, 11165), new
IntPoint(6459, 11165), new IntPoint(6459, 11121), new IntPoint(6435, 11121), new IntPoint(6435, 11115), new IntPoint(6409, 11115), new IntPoint(6409, 11071), new IntPoint(6385, 11071), new
IntPoint(6385, 11065), new IntPoint(6359, 11065), new IntPoint(6359, 10971), new IntPoint(6335, 10971), new IntPoint(6335, 10965), new IntPoint(6309, 10965), new IntPoint(6309, 10921), new
IntPoint(6285, 10921), new IntPoint(6285, 10915), new IntPoint(6259, 10915), new IntPoint(6259, 10371), new IntPoint(6235, 10371), new IntPoint(6235, 10335), new IntPoint(6239, 10335), new
IntPoint(6239, 10341), new IntPoint(6309, 10341), new IntPoint(6309, 10221), new IntPoint(6285, 10221), new IntPoint(6285, 10185), new IntPoint(6289, 10185), new IntPoint(6289, 10191), new
IntPoint(6359, 10191), new IntPoint(6359, 10141), new IntPoint(6859, 10141), new IntPoint(6859, 10135), new IntPoint(6889, 10135) }, new Polygon() { new IntPoint(8987, 9991), new IntPoint(9013, 9991),
new IntPoint(9013, 10035), new IntPoint(9037, 10035), new IntPoint(9037, 10041), new IntPoint(9107, 10041), new IntPoint(9107, 10035), new IntPoint(9137, 10035), new IntPoint(9137, 10041), new
IntPoint(9163, 10041), new IntPoint(9163, 10085), new IntPoint(9187, 10085), new IntPoint(9187, 10091), new IntPoint(9307, 10091), new IntPoint(9307, 10085), new IntPoint(9337, 10085), new
IntPoint(9337, 10091), new IntPoint(9363, 10091), new IntPoint(9363, 10135), new IntPoint(9387, 10135), new IntPoint(9387, 10141), new IntPoint(9463, 10141), new IntPoint(9463, 10185), new
IntPoint(9487, 10185), new IntPoint(9487, 10191), new IntPoint(9513, 10191), new IntPoint(9513, 10235), new IntPoint(9537, 10235), new IntPoint(9537, 10241), new IntPoint(9563, 10241), new
IntPoint(9563, 10285), new IntPoint(9587, 10285), new IntPoint(9587, 10291), new IntPoint(9613, 10291), new IntPoint(9613, 10335), new IntPoint(9637, 10335), new IntPoint(9637, 10341), new
IntPoint(9663, 10341), new IntPoint(9663, 10385), new IntPoint(9687, 10385), new IntPoint(9687, 10391), new IntPoint(9713, 10391), new IntPoint(9713, 10435), new IntPoint(9737, 10435), new
IntPoint(9737, 10441), new IntPoint(9813, 10441), new IntPoint(9813, 10485), new IntPoint(9837, 10485), new IntPoint(9837, 10491), new IntPoint(9863, 10491), new IntPoint(9863, 10535), new
IntPoint(9887, 10535), new IntPoint(9887, 10541), new IntPoint(9913, 10541), new IntPoint(9913, 10585), new IntPoint(9937, 10585), new IntPoint(9937, 10591), new IntPoint(9963, 10591), new
IntPoint(9963, 10715), new IntPoint(9813, 10715), new IntPoint(9813, 10765), new IntPoint(9763, 10765), new IntPoint(9763, 10865), new IntPoint(9713, 10865), new IntPoint(9713, 10915), new
IntPoint(9663, 10915), new IntPoint(9663, 11015), new IntPoint(9613, 11015), new IntPoint(9613, 11065), new IntPoint(9563, 11065), new IntPoint(9563, 11115), new IntPoint(9157, 11115), new
IntPoint(9157, 11071), new IntPoint(9133, 11071), new IntPoint(9133, 11065), new IntPoint(9107, 11065), new IntPoint(9107, 10771), new IntPoint(9083, 10771), new IntPoint(9083, 10765), new
IntPoint(9057, 10765), new IntPoint(9057, 10671), new IntPoint(9033, 10671), new IntPoint(9033, 10665), new IntPoint(9007, 10665), new IntPoint(9007, 10571), new IntPoint(8983, 10571), new
IntPoint(8983, 10565), new IntPoint(8957, 10565), new IntPoint(8957, 10521), new IntPoint(8933, 10521), new IntPoint(8933, 10515), new IntPoint(8907, 10515), new IntPoint(8907, 10421), new
IntPoint(8883, 10421), new IntPoint(8883, 10415), new IntPoint(8857, 10415), new IntPoint(8857, 10321), new IntPoint(8833, 10321), new IntPoint(8833, 10315), new IntPoint(8807, 10315), new
IntPoint(8807, 10221), new IntPoint(8783, 10221), new IntPoint(8783, 10215), new IntPoint(8757, 10215), new IntPoint(8757, 10071), new IntPoint(8733, 10071), new IntPoint(8733, 10035), new
IntPoint(8737, 10035), new IntPoint(8737, 10041), new IntPoint(8907, 10041), new IntPoint(8907, 9991), new IntPoint(8957, 9991), new IntPoint(8957, 9985), new IntPoint(8987, 9985) }, new Polygon() {
new IntPoint(12387, 10791), new IntPoint(12413, 10791), new IntPoint(12413, 10835), new IntPoint(12437, 10835), new IntPoint(12437, 10841), new IntPoint(12463, 10841), new IntPoint(12463, 10885), new
IntPoint(12487, 10885), new IntPoint(12487, 10891), new IntPoint(12513, 10891), new IntPoint(12513, 10965), new IntPoint(12463, 10965), new IntPoint(12463, 11015), new IntPoint(12413, 11015), new
IntPoint(12413, 11065), new IntPoint(12357, 11065), new IntPoint(12357, 11021), new IntPoint(12333, 11021), new IntPoint(12333, 11015), new IntPoint(12307, 11015), new IntPoint(12307, 10971), new
IntPoint(12283, 10971), new IntPoint(12283, 10965), new IntPoint(12257, 10965), new IntPoint(12257, 10891), new IntPoint(12307, 10891), new IntPoint(12307, 10841), new IntPoint(12357, 10841), new
IntPoint(12357, 10785), new IntPoint(12387, 10785) }, new Polygon() { new IntPoint(13087, 9891), new IntPoint(13113, 9891), new IntPoint(13113, 9935), new IntPoint(13137, 9935), new IntPoint(13137,
9941), new IntPoint(13163, 9941), new IntPoint(13163, 10115), new IntPoint(13113, 10115), new IntPoint(13113, 10165), new IntPoint(12663, 10165), new IntPoint(12663, 10215), new IntPoint(11913,
10215), new IntPoint(11913, 10265), new IntPoint(11863, 10265), new IntPoint(11863, 10315), new IntPoint(11763, 10315), new IntPoint(11763, 10365), new IntPoint(11613, 10365), new IntPoint(11613,
10415), new IntPoint(11513, 10415), new IntPoint(11513, 10465), new IntPoint(11413, 10465), new IntPoint(11413, 10515), new IntPoint(11313, 10515), new IntPoint(11313, 10565), new IntPoint(11263,
10565), new IntPoint(11263, 10615), new IntPoint(11157, 10615), new IntPoint(11157, 10571), new IntPoint(11133, 10571), new IntPoint(11133, 10565), new IntPoint(11107, 10565), new IntPoint(11107,
10521), new IntPoint(11083, 10521), new IntPoint(11083, 10515), new IntPoint(11057, 10515), new IntPoint(11057, 10471), new IntPoint(11033, 10471), new IntPoint(11033, 10465), new IntPoint(11007,
10465), new IntPoint(11007, 10341), new IntPoint(11057, 10341), new IntPoint(11057, 10291), new IntPoint(11107, 10291), new IntPoint(11107, 10241), new IntPoint(11207, 10241), new IntPoint(11207,
10191), new IntPoint(11507, 10191), new IntPoint(11507, 10141), new IntPoint(11657, 10141), new IntPoint(11657, 10091), new IntPoint(11907, 10091), new IntPoint(11907, 10041), new IntPoint(11957,
10041), new IntPoint(11957, 9991), new IntPoint(12307, 9991), new IntPoint(12307, 9941), new IntPoint(12707, 9941), new IntPoint(12707, 9891), new IntPoint(13057, 9891), new IntPoint(13057, 9885), new
IntPoint(13087, 9885) }, new Polygon() { new IntPoint(7987, 8741), new IntPoint(8013, 8741), new IntPoint(8013, 8785), new IntPoint(8037, 8785), new IntPoint(8037, 8791), new IntPoint(8113, 8791), new
IntPoint(8113, 8835), new IntPoint(8137, 8835), new IntPoint(8137, 8841), new IntPoint(8163, 8841), new IntPoint(8163, 8885), new IntPoint(8187, 8885), new IntPoint(8187, 8891), new IntPoint(8213,
8891), new IntPoint(8213, 8935), new IntPoint(8237, 8935), new IntPoint(8237, 8941), new IntPoint(8263, 8941), new IntPoint(8263, 8985), new IntPoint(8287, 8985), new IntPoint(8287, 8991), new
IntPoint(8313, 8991), new IntPoint(8313, 9035), new IntPoint(8337, 9035), new IntPoint(8337, 9041), new IntPoint(8363, 9041), new IntPoint(8363, 9085), new IntPoint(8387, 9085), new IntPoint(8387,
9091), new IntPoint(8463, 9091), new IntPoint(8463, 9135), new IntPoint(8487, 9135), new IntPoint(8487, 9141), new IntPoint(8513, 9141), new IntPoint(8513, 9185), new IntPoint(8537, 9185), new
IntPoint(8537, 9191), new IntPoint(8563, 9191), new IntPoint(8563, 9235), new IntPoint(8587, 9235), new IntPoint(8587, 9241), new IntPoint(8613, 9241), new IntPoint(8613, 9285), new IntPoint(8637,
9285), new IntPoint(8637, 9291), new IntPoint(8663, 9291), new IntPoint(8663, 9335), new IntPoint(8687, 9335), new IntPoint(8687, 9341), new IntPoint(8713, 9341), new IntPoint(8713, 9385), new
IntPoint(8737, 9385), new IntPoint(8737, 9391), new IntPoint(8763, 9391), new IntPoint(8763, 9435), new IntPoint(8787, 9435), new IntPoint(8787, 9441), new IntPoint(8813, 9441), new IntPoint(8813,
9485), new IntPoint(8837, 9485), new IntPoint(8837, 9491), new IntPoint(8863, 9491), new IntPoint(8863, 9535), new IntPoint(8887, 9535), new IntPoint(8887, 9541), new IntPoint(8913, 9541), new
IntPoint(8913, 9615), new IntPoint(8757, 9615), new IntPoint(8757, 9571), new IntPoint(8733, 9571), new IntPoint(8733, 9565), new IntPoint(8313, 9565), new IntPoint(8313, 10065), new IntPoint(8157,
10065), new IntPoint(8157, 9921), new IntPoint(8133, 9921), new IntPoint(8133, 9915), new IntPoint(8107, 9915), new IntPoint(8107, 9621), new IntPoint(8083, 9621), new IntPoint(8083, 9615), new
IntPoint(8057, 9615), new IntPoint(8057, 9271), new IntPoint(8033, 9271), new IntPoint(8033, 9265), new IntPoint(7613, 9265), new IntPoint(7613, 9615), new IntPoint(7309, 9615), new IntPoint(7309,
9571), new IntPoint(7285, 9571), new IntPoint(7285, 9565), new IntPoint(7159, 9565), new IntPoint(7159, 9321), new IntPoint(7135, 9321), new IntPoint(7135, 9285), new IntPoint(7139, 9285), new
IntPoint(7139, 9291), new IntPoint(7209, 9291), new IntPoint(7209, 9241), new IntPoint(7309, 9241), new IntPoint(7309, 9191), new IntPoint(7359, 9191), new IntPoint(7359, 9141), new IntPoint(7407,
9141), new IntPoint(7407, 9091), new IntPoint(7457, 9091), new IntPoint(7457, 9041), new IntPoint(7557, 9041), new IntPoint(7557, 8991), new IntPoint(7607, 8991), new IntPoint(7607, 8941), new
IntPoint(7707, 8941), new IntPoint(7707, 8891), new IntPoint(7757, 8891), new IntPoint(7757, 8841), new IntPoint(7807, 8841), new IntPoint(7807, 8791), new IntPoint(7857, 8791), new IntPoint(7857,
8741), new IntPoint(7957, 8741), new IntPoint(7957, 8735), new IntPoint(7987, 8735) }, new Polygon() { new IntPoint(3139, 8391), new IntPoint(3165, 8391), new IntPoint(3165, 8435), new IntPoint(3189,
8435), new IntPoint(3189, 8441), new IntPoint(3215, 8441), new IntPoint(3215, 8485), new IntPoint(3239, 8485), new IntPoint(3239, 8491), new IntPoint(3315, 8491), new IntPoint(3315, 8565), new
IntPoint(3265, 8565), new IntPoint(3265, 8615), new IntPoint(3215, 8615), new IntPoint(3215, 8665), new IntPoint(3165, 8665), new IntPoint(3165, 8715), new IntPoint(3115, 8715), new IntPoint(3115,
8765), new IntPoint(3065, 8765), new IntPoint(3065, 8815), new IntPoint(3015, 8815), new IntPoint(3015, 8865), new IntPoint(2965, 8865), new IntPoint(2965, 8915), new IntPoint(2915, 8915), new
IntPoint(2915, 8965), new IntPoint(2865, 8965), new IntPoint(2865, 9015), new IntPoint(2815, 9015), new IntPoint(2815, 9365), new IntPoint(2765, 9365), new IntPoint(2765, 9515), new IntPoint(2715,
9515), new IntPoint(2715, 9665), new IntPoint(2665, 9665), new IntPoint(2665, 9865), new IntPoint(2609, 9865), new IntPoint(2609, 9171), new IntPoint(2585, 9171), new IntPoint(2585, 9165), new
IntPoint(2559, 9165), new IntPoint(2559, 8971), new IntPoint(2535, 8971), new IntPoint(2535, 8965), new IntPoint(2509, 8965), new IntPoint(2509, 8721), new IntPoint(2485, 8721), new IntPoint(2485,
8685), new IntPoint(2489, 8685), new IntPoint(2489, 8691), new IntPoint(2559, 8691), new IntPoint(2559, 8571), new IntPoint(2535, 8571), new IntPoint(2535, 8535), new IntPoint(2539, 8535), new
IntPoint(2539, 8541), new IntPoint(2659, 8541), new IntPoint(2659, 8491), new IntPoint(2759, 8491), new IntPoint(2759, 8441), new IntPoint(2909, 8441), new IntPoint(2909, 8391), new IntPoint(3109,
8391), new IntPoint(3109, 8385), new IntPoint(3139, 8385) }, new Polygon() { new IntPoint(11987, 7791), new IntPoint(12013, 7791), new IntPoint(12013, 8565), new IntPoint(11963, 8565), new
IntPoint(11963, 8615), new IntPoint(11913, 8615), new IntPoint(11913, 8665), new IntPoint(11863, 8665), new IntPoint(11863, 8715), new IntPoint(11813, 8715), new IntPoint(11813, 8765), new
IntPoint(11763, 8765), new IntPoint(11763, 8815), new IntPoint(11713, 8815), new IntPoint(11713, 8915), new IntPoint(11663, 8915), new IntPoint(11663, 9235), new IntPoint(11687, 9235), new
IntPoint(11687, 9241), new IntPoint(11713, 9241), new IntPoint(11713, 9335), new IntPoint(11737, 9335), new IntPoint(11737, 9341), new IntPoint(11763, 9341), new IntPoint(11763, 9415), new
IntPoint(11713, 9415), new IntPoint(11713, 9465), new IntPoint(11663, 9465), new IntPoint(11663, 9515), new IntPoint(11463, 9515), new IntPoint(11463, 9565), new IntPoint(11313, 9565), new
IntPoint(11313, 9615), new IntPoint(11163, 9615), new IntPoint(11163, 9665), new IntPoint(11013, 9665), new IntPoint(11013, 9715), new IntPoint(10913, 9715), new IntPoint(10913, 9765), new
IntPoint(10763, 9765), new IntPoint(10763, 9815), new IntPoint(10657, 9815), new IntPoint(10657, 9771), new IntPoint(10633, 9771), new IntPoint(10633, 9765), new IntPoint(10607, 9765), new
IntPoint(10607, 9721), new IntPoint(10583, 9721), new IntPoint(10583, 9715), new IntPoint(10507, 9715), new IntPoint(10507, 9671), new IntPoint(10483, 9671), new IntPoint(10483, 9665), new
IntPoint(10457, 9665), new IntPoint(10457, 9621), new IntPoint(10433, 9621), new IntPoint(10433, 9615), new IntPoint(10357, 9615), new IntPoint(10357, 9571), new IntPoint(10333, 9571), new
IntPoint(10333, 9565), new IntPoint(10307, 9565), new IntPoint(10307, 9521), new IntPoint(10283, 9521), new IntPoint(10283, 9515), new IntPoint(10257, 9515), new IntPoint(10257, 9471), new
IntPoint(10233, 9471), new IntPoint(10233, 9465), new IntPoint(10207, 9465), new IntPoint(10207, 9421), new IntPoint(10183, 9421), new IntPoint(10183, 9415), new IntPoint(10157, 9415), new
IntPoint(10157, 9321), new IntPoint(10133, 9321), new IntPoint(10133, 9315), new IntPoint(10107, 9315), new IntPoint(10107, 9271), new IntPoint(10083, 9271), new IntPoint(10083, 9265), new
IntPoint(10057, 9265), new IntPoint(10057, 9221), new IntPoint(10033, 9221), new IntPoint(10033, 9215), new IntPoint(10007, 9215), new IntPoint(10007, 9091), new IntPoint(10357, 9091), new
IntPoint(10357, 9085), new IntPoint(10387, 9085), new IntPoint(10387, 9091), new IntPoint(10413, 9091), new IntPoint(10413, 9135), new IntPoint(10437, 9135), new IntPoint(10437, 9141), new
IntPoint(10463, 9141), new IntPoint(10463, 9185), new IntPoint(10487, 9185), new IntPoint(10487, 9191), new IntPoint(10563, 9191), new IntPoint(10563, 9235), new IntPoint(10587, 9235), new
IntPoint(10587, 9241), new IntPoint(10757, 9241), new IntPoint(10757, 9191), new IntPoint(11007, 9191), new IntPoint(11007, 9141), new IntPoint(11107, 9141), new IntPoint(11107, 9091), new
IntPoint(11207, 9091), new IntPoint(11207, 9041), new IntPoint(11307, 9041), new IntPoint(11307, 8991), new IntPoint(11407, 8991), new IntPoint(11407, 8891), new IntPoint(11457, 8891), new
IntPoint(11457, 8841), new IntPoint(11507, 8841), new IntPoint(11507, 8791), new IntPoint(11557, 8791), new IntPoint(11557, 8741), new IntPoint(11607, 8741), new IntPoint(11607, 8691), new
IntPoint(11657, 8691), new IntPoint(11657, 8591), new IntPoint(11707, 8591), new IntPoint(11707, 8541), new IntPoint(11757, 8541), new IntPoint(11757, 8241), new IntPoint(11807, 8241), new
IntPoint(11807, 7841), new IntPoint(11857, 7841), new IntPoint(11857, 7791), new IntPoint(11957, 7791), new IntPoint(11957, 7785), new IntPoint(11987, 7785) }, new Polygon() { new IntPoint(2639,
7641), new IntPoint(2665, 7641), new IntPoint(2665, 7685), new IntPoint(2689, 7685), new IntPoint(2689, 7691), new IntPoint(2715, 7691), new IntPoint(2715, 7965), new IntPoint(2665, 7965), new
IntPoint(2665, 8015), new IntPoint(2565, 8015), new IntPoint(2565, 8065), new IntPoint(2465, 8065), new IntPoint(2465, 8115), new IntPoint(2365, 8115), new IntPoint(2365, 8165), new IntPoint(2215,
8165), new IntPoint(2215, 8215), new IntPoint(2115, 8215), new IntPoint(2115, 8265), new IntPoint(2065, 8265), new IntPoint(2065, 8315), new IntPoint(2015, 8315), new IntPoint(2015, 8365), new
IntPoint(1965, 8365), new IntPoint(1965, 8785), new IntPoint(1989, 8785), new IntPoint(1989, 8791), new IntPoint(2015, 8791), new IntPoint(2015, 8885), new IntPoint(2039, 8885), new IntPoint(2039,
8891), new IntPoint(2065, 8891), new IntPoint(2065, 8985), new IntPoint(2089, 8985), new IntPoint(2089, 8991), new IntPoint(2115, 8991), new IntPoint(2115, 9135), new IntPoint(2139, 9135), new
IntPoint(2139, 9141), new IntPoint(2165, 9141), new IntPoint(2165, 9335), new IntPoint(2189, 9335), new IntPoint(2189, 9341), new IntPoint(2215, 9341), new IntPoint(2215, 9415), new IntPoint(2165,
9415), new IntPoint(2165, 9465), new IntPoint(2109, 9465), new IntPoint(2109, 9421), new IntPoint(2085, 9421), new IntPoint(2085, 9415), new IntPoint(2009, 9415), new IntPoint(2009, 9371), new
IntPoint(1985, 9371), new IntPoint(1985, 9365), new IntPoint(1859, 9365), new IntPoint(1859, 9321), new IntPoint(1835, 9321), new IntPoint(1835, 9315), new IntPoint(1759, 9315), new IntPoint(1759,
9021), new IntPoint(1735, 9021), new IntPoint(1735, 9015), new IntPoint(1709, 9015), new IntPoint(1709, 8221), new IntPoint(1685, 8221), new IntPoint(1685, 8185), new IntPoint(1689, 8185), new
IntPoint(1689, 8191), new IntPoint(1759, 8191), new IntPoint(1759, 8071), new IntPoint(1735, 8071), new IntPoint(1735, 8035), new IntPoint(1739, 8035), new IntPoint(1739, 8041), new IntPoint(1859,
8041), new IntPoint(1859, 7991), new IntPoint(1959, 7991), new IntPoint(1959, 7941), new IntPoint(2059, 7941), new IntPoint(2059, 7891), new IntPoint(2159, 7891), new IntPoint(2159, 7841), new
IntPoint(2209, 7841), new IntPoint(2209, 7791), new IntPoint(2309, 7791), new IntPoint(2309, 7741), new IntPoint(2359, 7741), new IntPoint(2359, 7691), new IntPoint(2459, 7691), new IntPoint(2459,
7641), new IntPoint(2609, 7641), new IntPoint(2609, 7635), new IntPoint(2639, 7635) }, new Polygon() { new IntPoint(4139, 7443), new IntPoint(4165, 7443), new IntPoint(4165, 7485), new IntPoint(4189,
7485), new IntPoint(4189, 7491), new IntPoint(4359, 7491), new IntPoint(4359, 7485), new IntPoint(4389, 7485), new IntPoint(4389, 7491), new IntPoint(4415, 7491), new IntPoint(4415, 7535), new
IntPoint(4439, 7535), new IntPoint(4439, 7541), new IntPoint(4465, 7541), new IntPoint(4465, 7585), new IntPoint(4489, 7585), new IntPoint(4489, 7591), new IntPoint(4515, 7591), new IntPoint(4515,
7635), new IntPoint(4539, 7635), new IntPoint(4539, 7641), new IntPoint(4565, 7641), new IntPoint(4565, 7715), new IntPoint(4515, 7715), new IntPoint(4515, 7865), new IntPoint(4465, 7865), new
IntPoint(4465, 7965), new IntPoint(4415, 7965), new IntPoint(4415, 8015), new IntPoint(4365, 8015), new IntPoint(4365, 8115), new IntPoint(4315, 8115), new IntPoint(4315, 8215), new IntPoint(4265,
8215), new IntPoint(4265, 8335), new IntPoint(4289, 8335), new IntPoint(4289, 8341), new IntPoint(4315, 8341), new IntPoint(4315, 8435), new IntPoint(4339, 8435), new IntPoint(4339, 8441), new
IntPoint(4365, 8441), new IntPoint(4365, 8485), new IntPoint(4389, 8485), new IntPoint(4389, 8491), new IntPoint(4415, 8491), new IntPoint(4415, 8535), new IntPoint(4439, 8535), new IntPoint(4439,
8541), new IntPoint(4465, 8541), new IntPoint(4465, 8585), new IntPoint(4489, 8585), new IntPoint(4489, 8591), new IntPoint(4515, 8591), new IntPoint(4515, 8635), new IntPoint(4539, 8635), new
IntPoint(4539, 8641), new IntPoint(4615, 8641), new IntPoint(4615, 8685), new IntPoint(4639, 8685), new IntPoint(4639, 8691), new IntPoint(4665, 8691), new IntPoint(4665, 8735), new IntPoint(4689,
8735), new IntPoint(4689, 8741), new IntPoint(4765, 8741), new IntPoint(4765, 8815), new IntPoint(4715, 8815), new IntPoint(4715, 8865), new IntPoint(4615, 8865), new IntPoint(4615, 8915), new
IntPoint(4515, 8915), new IntPoint(4515, 8965), new IntPoint(4365, 8965), new IntPoint(4365, 9015), new IntPoint(4315, 9015), new IntPoint(4315, 9065), new IntPoint(4215, 9065), new IntPoint(4215,
9115), new IntPoint(4165, 9115), new IntPoint(4165, 9165), new IntPoint(4065, 9165), new IntPoint(4065, 9215), new IntPoint(4015, 9215), new IntPoint(4015, 9265), new IntPoint(3965, 9265), new
IntPoint(3965, 9315), new IntPoint(3915, 9315), new IntPoint(3915, 9365), new IntPoint(3859, 9365), new IntPoint(3859, 9221), new IntPoint(3835, 9221), new IntPoint(3835, 9215), new IntPoint(3809,
9215), new IntPoint(3809, 9071), new IntPoint(3785, 9071), new IntPoint(3785, 9065), new IntPoint(3759, 9065), new IntPoint(3759, 9021), new IntPoint(3735, 9021), new IntPoint(3735, 9015), new
IntPoint(3709, 9015), new IntPoint(3709, 8921), new IntPoint(3685, 8921), new IntPoint(3685, 8915), new IntPoint(3659, 8915), new IntPoint(3659, 8871), new IntPoint(3635, 8871), new IntPoint(3635,
8835), new IntPoint(3639, 8835), new IntPoint(3639, 8841), new IntPoint(3759, 8841), new IntPoint(3759, 8791), new IntPoint(3809, 8791), new IntPoint(3809, 8171), new IntPoint(3785, 8171), new
IntPoint(3785, 8135), new IntPoint(3789, 8135), new IntPoint(3789, 8141), new IntPoint(3909, 8141), new IntPoint(3909, 8091), new IntPoint(4059, 8091), new IntPoint(4059, 8041), new IntPoint(4159,
8041), new IntPoint(4159, 7721), new IntPoint(4135, 7721), new IntPoint(4135, 7715), new IntPoint(4109, 7715), new IntPoint(4109, 7671), new IntPoint(4085, 7671), new IntPoint(4085, 7665), new
IntPoint(3209, 7665), new IntPoint(3209, 7621), new IntPoint(3185, 7621), new IntPoint(3185, 7615), new IntPoint(3159, 7615), new IntPoint(3159, 7521), new IntPoint(3135, 7521), new IntPoint(3135,
7485), new IntPoint(3139, 7485), new IntPoint(3139, 7491), new IntPoint(3209, 7491), new IntPoint(3209, 7443), new IntPoint(4109, 7443), new IntPoint(4109, 7435), new IntPoint(4139, 7435) }, new
Polygon() { new IntPoint(12987, 7393), new IntPoint(13013, 7393), new IntPoint(13013, 7985), new IntPoint(13037, 7985), new IntPoint(13037, 7991), new IntPoint(13063, 7991), new IntPoint(13063, 9115),
new IntPoint(13013, 9115), new IntPoint(13013, 9265), new IntPoint(12963, 9265), new IntPoint(12963, 9315), new IntPoint(12613, 9315), new IntPoint(12613, 9365), new IntPoint(12457, 9365), new
IntPoint(12457, 9321), new IntPoint(12433, 9321), new IntPoint(12433, 9315), new IntPoint(12407, 9315), new IntPoint(12407, 9271), new IntPoint(12383, 9271), new IntPoint(12383, 9265), new
IntPoint(12357, 9265), new IntPoint(12357, 9221), new IntPoint(12333, 9221), new IntPoint(12333, 9215), new IntPoint(12257, 9215), new IntPoint(12257, 8991), new IntPoint(12307, 8991), new
IntPoint(12307, 8941), new IntPoint(12407, 8941), new IntPoint(12407, 8791), new IntPoint(12457, 8791), new IntPoint(12457, 8421), new IntPoint(12433, 8421), new IntPoint(12433, 8415), new
IntPoint(12407, 8415), new IntPoint(12407, 7741), new IntPoint(12457, 7741), new IntPoint(12457, 7691), new IntPoint(12557, 7691), new IntPoint(12557, 7641), new IntPoint(12607, 7641), new
IntPoint(12607, 7591), new IntPoint(12657, 7591), new IntPoint(12657, 7541), new IntPoint(12757, 7541), new IntPoint(12757, 7491), new IntPoint(12807, 7491), new IntPoint(12807, 7443), new
IntPoint(12857, 7443), new IntPoint(12857, 7393), new IntPoint(12957, 7393), new IntPoint(12957, 7385), new IntPoint(12987, 7385) }, new Polygon() { new IntPoint(7437, 8041), new IntPoint(7463, 8041),
new IntPoint(7463, 8085), new IntPoint(7487, 8085), new IntPoint(7487, 8091), new IntPoint(7513, 8091), new IntPoint(7513, 8265), new IntPoint(7463, 8265), new IntPoint(7463, 8315), new IntPoint(7413,
8315), new IntPoint(7413, 8365), new IntPoint(7363, 8365), new IntPoint(7363, 8415), new IntPoint(7265, 8415), new IntPoint(7265, 8465), new IntPoint(7215, 8465), new IntPoint(7215, 8515), new
IntPoint(7165, 8515), new IntPoint(7165, 8565), new IntPoint(7115, 8565), new IntPoint(7115, 8615), new IntPoint(7065, 8615), new IntPoint(7065, 8665), new IntPoint(7015, 8665), new IntPoint(7015,
8715), new IntPoint(6965, 8715), new IntPoint(6965, 8765), new IntPoint(6915, 8765), new IntPoint(6915, 8815), new IntPoint(6815, 8815), new IntPoint(6815, 8865), new IntPoint(6765, 8865), new
IntPoint(6765, 8915), new IntPoint(6715, 8915), new IntPoint(6715, 8965), new IntPoint(6615, 8965), new IntPoint(6615, 9015), new IntPoint(6465, 9015), new IntPoint(6465, 9065), new IntPoint(6309,
9065), new IntPoint(6309, 9021), new IntPoint(6285, 9021), new IntPoint(6285, 8985), new IntPoint(6289, 8985), new IntPoint(6289, 8991), new IntPoint(6409, 8991), new IntPoint(6409, 8941), new
IntPoint(6459, 8941), new IntPoint(6459, 8891), new IntPoint(6559, 8891), new IntPoint(6559, 8841), new IntPoint(6609, 8841), new IntPoint(6609, 8791), new IntPoint(6709, 8791), new IntPoint(6709,
8741), new IntPoint(6759, 8741), new IntPoint(6759, 8691), new IntPoint(6809, 8691), new IntPoint(6809, 8641), new IntPoint(6909, 8641), new IntPoint(6909, 8591), new IntPoint(6959, 8591), new
IntPoint(6959, 8521), new IntPoint(6935, 8521), new IntPoint(6935, 8485), new IntPoint(6939, 8485), new IntPoint(6939, 8491), new IntPoint(7009, 8491), new IntPoint(7009, 8441), new IntPoint(7059,
8441), new IntPoint(7059, 8391), new IntPoint(7109, 8391), new IntPoint(7109, 8341), new IntPoint(7159, 8341), new IntPoint(7159, 8291), new IntPoint(7209, 8291), new IntPoint(7209, 8221), new
IntPoint(7185, 8221), new IntPoint(7185, 8185), new IntPoint(7189, 8185), new IntPoint(7189, 8191), new IntPoint(7259, 8191), new IntPoint(7259, 8141), new IntPoint(7309, 8141), new IntPoint(7309,
8091), new IntPoint(7359, 8091), new IntPoint(7359, 8041), new IntPoint(7407, 8041), new IntPoint(7407, 8035), new IntPoint(7437, 8035) }, new Polygon() { new IntPoint(9837, 7393), new IntPoint(9863,
7393), new IntPoint(9863, 7485), new IntPoint(9887, 7485), new IntPoint(9887, 7491), new IntPoint(9913, 7491), new IntPoint(9913, 7765), new IntPoint(9863, 7765), new IntPoint(9863, 7915), new
IntPoint(9813, 7915), new IntPoint(9813, 8285), new IntPoint(9837, 8285), new IntPoint(9837, 8291), new IntPoint(9863, 8291), new IntPoint(9863, 8435), new IntPoint(9887, 8435), new IntPoint(9887,
8441), new IntPoint(9913, 8441), new IntPoint(9913, 8535), new IntPoint(9937, 8535), new IntPoint(9937, 8541), new IntPoint(9963, 8541), new IntPoint(9963, 8585), new IntPoint(9987, 8585), new
IntPoint(9987, 8591), new IntPoint(10013, 8591), new IntPoint(10013, 8665), new IntPoint(9963, 8665), new IntPoint(9963, 8715), new IntPoint(9613, 8715), new IntPoint(9613, 8765), new IntPoint(9557,
8765), new IntPoint(9557, 8721), new IntPoint(9533, 8721), new IntPoint(9533, 8715), new IntPoint(9507, 8715), new IntPoint(9507, 8671), new IntPoint(9483, 8671), new IntPoint(9483, 8665), new
IntPoint(9457, 8665), new IntPoint(9457, 8621), new IntPoint(9433, 8621), new IntPoint(9433, 8615), new IntPoint(9407, 8615), new IntPoint(9407, 8571), new IntPoint(9383, 8571), new IntPoint(9383,
8565), new IntPoint(9357, 8565), new IntPoint(9357, 8521), new IntPoint(9333, 8521), new IntPoint(9333, 8515), new IntPoint(9307, 8515), new IntPoint(9307, 8471), new IntPoint(9283, 8471), new
IntPoint(9283, 8465), new IntPoint(9257, 8465), new IntPoint(9257, 8421), new IntPoint(9233, 8421), new IntPoint(9233, 8415), new IntPoint(9207, 8415), new IntPoint(9207, 8371), new IntPoint(9183,
8371), new IntPoint(9183, 8365), new IntPoint(9157, 8365), new IntPoint(9157, 8321), new IntPoint(9133, 8321), new IntPoint(9133, 8315), new IntPoint(9107, 8315), new IntPoint(9107, 8271), new
IntPoint(9083, 8271), new IntPoint(9083, 8265), new IntPoint(9057, 8265), new IntPoint(9057, 8221), new IntPoint(9033, 8221), new IntPoint(9033, 8215), new IntPoint(9007, 8215), new IntPoint(9007,
8171), new IntPoint(8983, 8171), new IntPoint(8983, 8165), new IntPoint(8957, 8165), new IntPoint(8957, 7841), new IntPoint(9007, 7841), new IntPoint(9007, 7741), new IntPoint(9057, 7741), new
IntPoint(9057, 7691), new IntPoint(9107, 7691), new IntPoint(9107, 7641), new IntPoint(9157, 7641), new IntPoint(9157, 7591), new IntPoint(9207, 7591), new IntPoint(9207, 7541), new IntPoint(9257,
7541), new IntPoint(9257, 7491), new IntPoint(9357, 7491), new IntPoint(9357, 7443), new IntPoint(9457, 7443), new IntPoint(9457, 7393), new IntPoint(9807, 7393), new IntPoint(9807, 7385), new
IntPoint(9837, 7385) }, new Polygon() { new IntPoint(11037, 7791), new IntPoint(11063, 7791), new IntPoint(11063, 7835), new IntPoint(11087, 7835), new IntPoint(11087, 7841), new IntPoint(11163,
7841), new IntPoint(11163, 7885), new IntPoint(11187, 7885), new IntPoint(11187, 7891), new IntPoint(11213, 7891), new IntPoint(11213, 7935), new IntPoint(11237, 7935), new IntPoint(11237, 7941), new
IntPoint(11263, 7941), new IntPoint(11263, 7985), new IntPoint(11287, 7985), new IntPoint(11287, 7991), new IntPoint(11363, 7991), new IntPoint(11363, 8165), new IntPoint(11313, 8165), new
IntPoint(11313, 8265), new IntPoint(11257, 8265), new IntPoint(11257, 8221), new IntPoint(11233, 8221), new IntPoint(11233, 8215), new IntPoint(11207, 8215), new IntPoint(11207, 8171), new
IntPoint(11183, 8171), new IntPoint(11183, 8165), new IntPoint(11157, 8165), new IntPoint(11157, 8121), new IntPoint(11133, 8121), new IntPoint(11133, 8115), new IntPoint(10863, 8115), new
IntPoint(10863, 8165), new IntPoint(10813, 8165), new IntPoint(10813, 8215), new IntPoint(10763, 8215), new IntPoint(10763, 8265), new IntPoint(10713, 8265), new IntPoint(10713, 8535), new
IntPoint(10737, 8535), new IntPoint(10737, 8541), new IntPoint(10763, 8541), new IntPoint(10763, 8665), new IntPoint(10713, 8665), new IntPoint(10713, 8715), new IntPoint(10657, 8715), new
IntPoint(10657, 8671), new IntPoint(10633, 8671), new IntPoint(10633, 8665), new IntPoint(10557, 8665), new IntPoint(10557, 8621), new IntPoint(10533, 8621), new IntPoint(10533, 8615), new
IntPoint(10507, 8615), new IntPoint(10507, 8571), new IntPoint(10483, 8571), new IntPoint(10483, 8565), new IntPoint(10457, 8565), new IntPoint(10457, 8521), new IntPoint(10433, 8521), new
IntPoint(10433, 8515), new IntPoint(10407, 8515), new IntPoint(10407, 8421), new IntPoint(10383, 8421), new IntPoint(10383, 8415), new IntPoint(10357, 8415), new IntPoint(10357, 8271), new
IntPoint(10333, 8271), new IntPoint(10333, 8265), new IntPoint(10307, 8265), new IntPoint(10307, 8041), new IntPoint(10357, 8041), new IntPoint(10357, 7941), new IntPoint(10407, 7941), new
IntPoint(10407, 7891), new IntPoint(10457, 7891), new IntPoint(10457, 7841), new IntPoint(10557, 7841), new IntPoint(10557, 7791), new IntPoint(11007, 7791), new IntPoint(11007, 7785), new
IntPoint(11037, 7785) }, new Polygon() { new IntPoint(6439, 7243), new IntPoint(6465, 7243), new IntPoint(6465, 7285), new IntPoint(6489, 7285), new IntPoint(6489, 7293), new IntPoint(6565, 7293), new
IntPoint(6565, 7565), new IntPoint(6515, 7565), new IntPoint(6515, 7615), new IntPoint(6465, 7615), new IntPoint(6465, 7715), new IntPoint(6415, 7715), new IntPoint(6415, 7815), new IntPoint(6365,
7815), new IntPoint(6365, 7915), new IntPoint(6315, 7915), new IntPoint(6315, 8015), new IntPoint(6215, 8015), new IntPoint(6215, 8065), new IntPoint(6115, 8065), new IntPoint(6115, 8115), new
IntPoint(6065, 8115), new IntPoint(6065, 8165), new IntPoint(5965, 8165), new IntPoint(5965, 8215), new IntPoint(5915, 8215), new IntPoint(5915, 8265), new IntPoint(5815, 8265), new IntPoint(5815,
8315), new IntPoint(5765, 8315), new IntPoint(5765, 8365), new IntPoint(5665, 8365), new IntPoint(5665, 8415), new IntPoint(5565, 8415), new IntPoint(5565, 8465), new IntPoint(5465, 8465), new
IntPoint(5465, 8515), new IntPoint(5309, 8515), new IntPoint(5309, 8471), new IntPoint(5285, 8471), new IntPoint(5285, 8465), new IntPoint(5159, 8465), new IntPoint(5159, 8421), new IntPoint(5135,
8421), new IntPoint(5135, 8415), new IntPoint(5059, 8415), new IntPoint(5059, 8371), new IntPoint(5035, 8371), new IntPoint(5035, 8365), new IntPoint(5009, 8365), new IntPoint(5009, 8321), new
IntPoint(4985, 8321), new IntPoint(4985, 8315), new IntPoint(4959, 8315), new IntPoint(4959, 8271), new IntPoint(4935, 8271), new IntPoint(4935, 8265), new IntPoint(4909, 8265), new IntPoint(4909,
8221), new IntPoint(4885, 8221), new IntPoint(4885, 8215), new IntPoint(4859, 8215), new IntPoint(4859, 8071), new IntPoint(4835, 8071), new IntPoint(4835, 8035), new IntPoint(4839, 8035), new
IntPoint(4839, 8041), new IntPoint(4909, 8041), new IntPoint(4909, 7991), new IntPoint(5309, 7991), new IntPoint(5309, 7941), new IntPoint(5509, 7941), new IntPoint(5509, 7891), new IntPoint(5659,
7891), new IntPoint(5659, 7841), new IntPoint(5759, 7841), new IntPoint(5759, 7791), new IntPoint(5809, 7791), new IntPoint(5809, 7741), new IntPoint(5859, 7741), new IntPoint(5859, 7691), new
IntPoint(5959, 7691), new IntPoint(5959, 7641), new IntPoint(6009, 7641), new IntPoint(6009, 7571), new IntPoint(5985, 7571), new IntPoint(5985, 7535), new IntPoint(5989, 7535), new IntPoint(5989,
7541), new IntPoint(6059, 7541), new IntPoint(6059, 7491), new IntPoint(6109, 7491), new IntPoint(6109, 7443), new IntPoint(6159, 7443), new IntPoint(6159, 7373), new IntPoint(6135, 7373), new
IntPoint(6135, 7335), new IntPoint(6139, 7335), new IntPoint(6139, 7343), new IntPoint(6209, 7343), new IntPoint(6209, 7293), new IntPoint(6259, 7293), new IntPoint(6259, 7243), new IntPoint(6409,
7243), new IntPoint(6409, 7235), new IntPoint(6439, 7235) }, new Polygon() { new IntPoint(2339, 5543), new IntPoint(2365, 5543), new IntPoint(2365, 5585), new IntPoint(2389, 5585), new IntPoint(2389,
5593), new IntPoint(2415, 5593), new IntPoint(2415, 5635), new IntPoint(2439, 5635), new IntPoint(2439, 5643), new IntPoint(2515, 5643), new IntPoint(2515, 5685), new IntPoint(2539, 5685), new
IntPoint(2539, 5693), new IntPoint(2565, 5693), new IntPoint(2565, 5915), new IntPoint(2465, 5915), new IntPoint(2465, 5965), new IntPoint(2415, 5965), new IntPoint(2415, 6015), new IntPoint(2365,
6015), new IntPoint(2365, 6535), new IntPoint(2389, 6535), new IntPoint(2389, 6543), new IntPoint(2415, 6543), new IntPoint(2415, 7165), new IntPoint(2315, 7165), new IntPoint(2315, 7215), new
IntPoint(2265, 7215), new IntPoint(2265, 7265), new IntPoint(2215, 7265), new IntPoint(2215, 7315), new IntPoint(2115, 7315), new IntPoint(2115, 7365), new IntPoint(2065, 7365), new IntPoint(2065,
7415), new IntPoint(1965, 7415), new IntPoint(1965, 7465), new IntPoint(1915, 7465), new IntPoint(1915, 7515), new IntPoint(1809, 7515), new IntPoint(1809, 6773), new IntPoint(1785, 6773), new
IntPoint(1785, 6765), new IntPoint(1759, 6765), new IntPoint(1759, 5623), new IntPoint(1735, 5623), new IntPoint(1735, 5585), new IntPoint(1739, 5585), new IntPoint(1739, 5593), new IntPoint(2109,
5593), new IntPoint(2109, 5543), new IntPoint(2309, 5543), new IntPoint(2309, 5535), new IntPoint(2339, 5535) }, new Polygon() { new IntPoint(5139, 6143), new IntPoint(5165, 6143), new IntPoint(5165,
6185), new IntPoint(5189, 6185), new IntPoint(5189, 6193), new IntPoint(5265, 6193), new IntPoint(5265, 6235), new IntPoint(5289, 6235), new IntPoint(5289, 6243), new IntPoint(5315, 6243), new
IntPoint(5315, 6285), new IntPoint(5339, 6285), new IntPoint(5339, 6293), new IntPoint(5365, 6293), new IntPoint(5365, 6335), new IntPoint(5389, 6335), new IntPoint(5389, 6343), new IntPoint(5415,
6343), new IntPoint(5415, 6385), new IntPoint(5439, 6385), new IntPoint(5439, 6393), new IntPoint(5465, 6393), new IntPoint(5465, 6435), new IntPoint(5489, 6435), new IntPoint(5489, 6443), new
IntPoint(5515, 6443), new IntPoint(5515, 6485), new IntPoint(5539, 6485), new IntPoint(5539, 6493), new IntPoint(5615, 6493), new IntPoint(5615, 6535), new IntPoint(5639, 6535), new IntPoint(5639,
6543), new IntPoint(5665, 6543), new IntPoint(5665, 6585), new IntPoint(5689, 6585), new IntPoint(5689, 6593), new IntPoint(5715, 6593), new IntPoint(5715, 6635), new IntPoint(5739, 6635), new
IntPoint(5739, 6643), new IntPoint(5765, 6643), new IntPoint(5765, 6685), new IntPoint(5789, 6685), new IntPoint(5789, 6693), new IntPoint(5815, 6693), new IntPoint(5815, 6835), new IntPoint(5839,
6835), new IntPoint(5839, 6843), new IntPoint(5865, 6843), new IntPoint(5865, 6915), new IntPoint(5815, 6915), new IntPoint(5815, 7115), new IntPoint(5765, 7115), new IntPoint(5765, 7165), new
IntPoint(5715, 7165), new IntPoint(5715, 7265), new IntPoint(5665, 7265), new IntPoint(5665, 7315), new IntPoint(5615, 7315), new IntPoint(5615, 7365), new IntPoint(5515, 7365), new IntPoint(5515,
7415), new IntPoint(5465, 7415), new IntPoint(5465, 7465), new IntPoint(5265, 7465), new IntPoint(5265, 7515), new IntPoint(5009, 7515), new IntPoint(5009, 7471), new IntPoint(4985, 7471), new
IntPoint(4985, 7465), new IntPoint(4959, 7465), new IntPoint(4959, 7421), new IntPoint(4935, 7421), new IntPoint(4935, 7415), new IntPoint(4909, 7415), new IntPoint(4909, 7373), new IntPoint(4885,
7373), new IntPoint(4885, 7365), new IntPoint(4859, 7365), new IntPoint(4859, 7323), new IntPoint(4835, 7323), new IntPoint(4835, 7315), new IntPoint(4809, 7315), new IntPoint(4809, 7273), new
IntPoint(4785, 7273), new IntPoint(4785, 7235), new IntPoint(4789, 7235), new IntPoint(4789, 7243), new IntPoint(4859, 7243), new IntPoint(4859, 7193), new IntPoint(4909, 7193), new IntPoint(4909,
7143), new IntPoint(4959, 7143), new IntPoint(4959, 6623), new IntPoint(4935, 6623), new IntPoint(4935, 6615), new IntPoint(4909, 6615), new IntPoint(4909, 6373), new IntPoint(4885, 6373), new
IntPoint(4885, 6365), new IntPoint(4859, 6365), new IntPoint(4859, 6273), new IntPoint(4835, 6273), new IntPoint(4835, 6265), new IntPoint(4809, 6265), new IntPoint(4809, 6223), new IntPoint(4785,
6223), new IntPoint(4785, 6185), new IntPoint(4789, 6185), new IntPoint(4789, 6193), new IntPoint(4959, 6193), new IntPoint(4959, 6143), new IntPoint(5109, 6143), new IntPoint(5109, 6135), new
IntPoint(5139, 6135) }, new Polygon() { new IntPoint(9587, 6393), new IntPoint(9613, 6393), new IntPoint(9613, 6435), new IntPoint(9637, 6435), new IntPoint(9637, 6443), new IntPoint(9713, 6443), new
IntPoint(9713, 6485), new IntPoint(9737, 6485), new IntPoint(9737, 6493), new IntPoint(9763, 6493), new IntPoint(9763, 6535), new IntPoint(9787, 6535), new IntPoint(9787, 6543), new IntPoint(9813,
6543), new IntPoint(9813, 6585), new IntPoint(9837, 6585), new IntPoint(9837, 6593), new IntPoint(9863, 6593), new IntPoint(9863, 6635), new IntPoint(9887, 6635), new IntPoint(9887, 6643), new
IntPoint(9913, 6643), new IntPoint(9913, 6815), new IntPoint(9863, 6815), new IntPoint(9863, 6865), new IntPoint(9613, 6865), new IntPoint(9613, 6915), new IntPoint(9463, 6915), new IntPoint(9463,
6965), new IntPoint(9263, 6965), new IntPoint(9263, 7015), new IntPoint(9113, 7015), new IntPoint(9113, 7065), new IntPoint(9063, 7065), new IntPoint(9063, 7115), new IntPoint(9013, 7115), new
IntPoint(9013, 7165), new IntPoint(8913, 7165), new IntPoint(8913, 7215), new IntPoint(8863, 7215), new IntPoint(8863, 7265), new IntPoint(8813, 7265), new IntPoint(8813, 7315), new IntPoint(8763,
7315), new IntPoint(8763, 7365), new IntPoint(8713, 7365), new IntPoint(8713, 7415), new IntPoint(8663, 7415), new IntPoint(8663, 7465), new IntPoint(8457, 7465), new IntPoint(8457, 7421), new
IntPoint(8433, 7421), new IntPoint(8433, 7415), new IntPoint(8407, 7415), new IntPoint(8407, 7373), new IntPoint(8383, 7373), new IntPoint(8383, 7365), new IntPoint(8357, 7365), new IntPoint(8357,
7273), new IntPoint(8333, 7273), new IntPoint(8333, 7265), new IntPoint(8307, 7265), new IntPoint(8307, 7093), new IntPoint(8357, 7093), new IntPoint(8357, 7043), new IntPoint(8407, 7043), new
IntPoint(8407, 6943), new IntPoint(8507, 6943), new IntPoint(8507, 6893), new IntPoint(8557, 6893), new IntPoint(8557, 6843), new IntPoint(8607, 6843), new IntPoint(8607, 6793), new IntPoint(8707,
6793), new IntPoint(8707, 6743), new IntPoint(8807, 6743), new IntPoint(8807, 6693), new IntPoint(8857, 6693), new IntPoint(8857, 6643), new IntPoint(8957, 6643), new IntPoint(8957, 6593), new
IntPoint(9057, 6593), new IntPoint(9057, 6543), new IntPoint(9157, 6543), new IntPoint(9157, 6493), new IntPoint(9207, 6493), new IntPoint(9207, 6443), new IntPoint(9307, 6443), new IntPoint(9307,
6393), new IntPoint(9557, 6393), new IntPoint(9557, 6385), new IntPoint(9587, 6385) }, new Polygon() { new IntPoint(10937, 5543), new IntPoint(10963, 5543), new IntPoint(10963, 5685), new
IntPoint(10987, 5685), new IntPoint(10987, 5693), new IntPoint(11013, 5693), new IntPoint(11013, 5785), new IntPoint(11037, 5785), new IntPoint(11037, 5793), new IntPoint(11063, 5793), new
IntPoint(11063, 5835), new IntPoint(11087, 5835), new IntPoint(11087, 5843), new IntPoint(11113, 5843), new IntPoint(11113, 5935), new IntPoint(11137, 5935), new IntPoint(11137, 5943), new
IntPoint(11163, 5943), new IntPoint(11163, 6015), new IntPoint(11113, 6015), new IntPoint(11113, 6065), new IntPoint(11063, 6065), new IntPoint(11063, 6115), new IntPoint(11013, 6115), new
IntPoint(11013, 6315), new IntPoint(10963, 6315), new IntPoint(10963, 6585), new IntPoint(10987, 6585), new IntPoint(10987, 6593), new IntPoint(11013, 6593), new IntPoint(11013, 6715), new
IntPoint(10963, 6715), new IntPoint(10963, 6765), new IntPoint(10913, 6765), new IntPoint(10913, 6815), new IntPoint(10813, 6815), new IntPoint(10813, 6865), new IntPoint(10663, 6865), new
IntPoint(10663, 7185), new IntPoint(10687, 7185), new IntPoint(10687, 7193), new IntPoint(10713, 7193), new IntPoint(10713, 7235), new IntPoint(10737, 7235), new IntPoint(10737, 7243), new
IntPoint(11557, 7243), new IntPoint(11557, 7235), new IntPoint(11587, 7235), new IntPoint(11587, 7243), new IntPoint(11613, 7243), new IntPoint(11613, 7285), new IntPoint(11637, 7285), new
IntPoint(11637, 7293), new IntPoint(11663, 7293), new IntPoint(11663, 7365), new IntPoint(11613, 7365), new IntPoint(11613, 7465), new IntPoint(10857, 7465), new IntPoint(10857, 7421), new
IntPoint(10833, 7421), new IntPoint(10833, 7415), new IntPoint(10457, 7415), new IntPoint(10457, 7373), new IntPoint(10433, 7373), new IntPoint(10433, 7365), new IntPoint(10407, 7365), new
IntPoint(10407, 7323), new IntPoint(10383, 7323), new IntPoint(10383, 7315), new IntPoint(10307, 7315), new IntPoint(10307, 7273), new IntPoint(10283, 7273), new IntPoint(10283, 7265), new
IntPoint(10257, 7265), new IntPoint(10257, 7093), new IntPoint(10307, 7093), new IntPoint(10307, 6993), new IntPoint(10357, 6993), new IntPoint(10357, 6893), new IntPoint(10407, 6893), new
IntPoint(10407, 6793), new IntPoint(10457, 6793), new IntPoint(10457, 6423), new IntPoint(10433, 6423), new IntPoint(10433, 6415), new IntPoint(10407, 6415), new IntPoint(10407, 6373), new
IntPoint(10383, 6373), new IntPoint(10383, 6365), new IntPoint(10357, 6365), new IntPoint(10357, 6323), new IntPoint(10333, 6323), new IntPoint(10333, 6315), new IntPoint(10307, 6315), new
IntPoint(10307, 6273), new IntPoint(10283, 6273), new IntPoint(10283, 6265), new IntPoint(10257, 6265), new IntPoint(10257, 6223), new IntPoint(10233, 6223), new IntPoint(10233, 6215), new
IntPoint(10207, 6215), new IntPoint(10207, 6173), new IntPoint(10183, 6173), new IntPoint(10183, 6165), new IntPoint(10107, 6165), new IntPoint(10107, 6123), new IntPoint(10083, 6123), new
IntPoint(10083, 6115), new IntPoint(10057, 6115), new IntPoint(10057, 6043), new IntPoint(10107, 6043), new IntPoint(10107, 5993), new IntPoint(10257, 5993), new IntPoint(10257, 5943), new
IntPoint(10407, 5943), new IntPoint(10407, 5893), new IntPoint(10507, 5893), new IntPoint(10507, 5843), new IntPoint(10607, 5843), new IntPoint(10607, 5793), new IntPoint(10657, 5793), new
IntPoint(10657, 5743), new IntPoint(10707, 5743), new IntPoint(10707, 5693), new IntPoint(10757, 5693), new IntPoint(10757, 5643), new IntPoint(10807, 5643), new IntPoint(10807, 5593), new
IntPoint(10907, 5593), new IntPoint(10907, 5535), new IntPoint(10937, 5535) }, new Polygon() { new IntPoint(12737, 5443), new IntPoint(12763, 5443), new IntPoint(12763, 5485), new IntPoint(12787,
5485), new IntPoint(12787, 5493), new IntPoint(12863, 5493), new IntPoint(12863, 5535), new IntPoint(12887, 5535), new IntPoint(12887, 5543), new IntPoint(12957, 5543), new IntPoint(12957, 5535), new
IntPoint(12987, 5535), new IntPoint(12987, 5543), new IntPoint(13013, 5543), new IntPoint(13013, 5585), new IntPoint(13037, 5585), new IntPoint(13037, 5593), new IntPoint(13063, 5593), new
IntPoint(13063, 5735), new IntPoint(13087, 5735), new IntPoint(13087, 5743), new IntPoint(13113, 5743), new IntPoint(13113, 6615), new IntPoint(13063, 6615), new IntPoint(13063, 6815), new
IntPoint(13013, 6815), new IntPoint(13013, 6865), new IntPoint(12863, 6865), new IntPoint(12863, 6915), new IntPoint(12763, 6915), new IntPoint(12763, 6965), new IntPoint(12713, 6965), new
IntPoint(12713, 7015), new IntPoint(12613, 7015), new IntPoint(12613, 7065), new IntPoint(12513, 7065), new IntPoint(12513, 7115), new IntPoint(12463, 7115), new IntPoint(12463, 7165), new
IntPoint(12413, 7165), new IntPoint(12413, 7215), new IntPoint(12157, 7215), new IntPoint(12157, 7173), new IntPoint(12133, 7173), new IntPoint(12133, 7165), new IntPoint(12107, 7165), new
IntPoint(12107, 6893), new IntPoint(12207, 6893), new IntPoint(12207, 6843), new IntPoint(12307, 6843), new IntPoint(12307, 6793), new IntPoint(12357, 6793), new IntPoint(12357, 6743), new
IntPoint(12507, 6743), new IntPoint(12507, 6693), new IntPoint(12657, 6693), new IntPoint(12657, 6643), new IntPoint(12707, 6643), new IntPoint(12707, 6593), new IntPoint(12757, 6593), new
IntPoint(12757, 6543), new IntPoint(12807, 6543), new IntPoint(12807, 6073), new IntPoint(12783, 6073), new IntPoint(12783, 6065), new IntPoint(12757, 6065), new IntPoint(12757, 5873), new
IntPoint(12733, 5873), new IntPoint(12733, 5865), new IntPoint(12707, 5865), new IntPoint(12707, 5623), new IntPoint(12683, 5623), new IntPoint(12683, 5615), new IntPoint(12657, 5615), new
IntPoint(12657, 5493), new IntPoint(12707, 5493), new IntPoint(12707, 5435), new IntPoint(12737, 5435) }, new Polygon() { new IntPoint(4139, 6143), new IntPoint(4165, 6143), new IntPoint(4165, 6185),
new IntPoint(4189, 6185), new IntPoint(4189, 6193), new IntPoint(4215, 6193), new IntPoint(4215, 6235), new IntPoint(4239, 6235), new IntPoint(4239, 6243), new IntPoint(4265, 6243), new IntPoint(4265,
6285), new IntPoint(4289, 6285), new IntPoint(4289, 6293), new IntPoint(4365, 6293), new IntPoint(4365, 6335), new IntPoint(4389, 6335), new IntPoint(4389, 6343), new IntPoint(4415, 6343), new
IntPoint(4415, 6485), new IntPoint(4439, 6485), new IntPoint(4439, 6493), new IntPoint(4465, 6493), new IntPoint(4465, 6635), new IntPoint(4489, 6635), new IntPoint(4489, 6643), new IntPoint(4515,
6643), new IntPoint(4515, 6865), new IntPoint(4465, 6865), new IntPoint(4465, 6965), new IntPoint(4365, 6965), new IntPoint(4365, 7015), new IntPoint(4265, 7015), new IntPoint(4265, 7065), new
IntPoint(4015, 7065), new IntPoint(4015, 7115), new IntPoint(3859, 7115), new IntPoint(3859, 7073), new IntPoint(3835, 7073), new IntPoint(3835, 7065), new IntPoint(3709, 7065), new IntPoint(3709,
7023), new IntPoint(3685, 7023), new IntPoint(3685, 7015), new IntPoint(3609, 7015), new IntPoint(3609, 6973), new IntPoint(3585, 6973), new IntPoint(3585, 6965), new IntPoint(3559, 6965), new
IntPoint(3559, 6923), new IntPoint(3535, 6923), new IntPoint(3535, 6915), new IntPoint(3509, 6915), new IntPoint(3509, 6873), new IntPoint(3485, 6873), new IntPoint(3485, 6865), new IntPoint(3459,
6865), new IntPoint(3459, 6823), new IntPoint(3435, 6823), new IntPoint(3435, 6785), new IntPoint(3439, 6785), new IntPoint(3439, 6793), new IntPoint(3509, 6793), new IntPoint(3509, 6743), new
IntPoint(3909, 6743), new IntPoint(3909, 6693), new IntPoint(3959, 6693), new IntPoint(3959, 6643), new IntPoint(4009, 6643), new IntPoint(4009, 6593), new IntPoint(4059, 6593), new IntPoint(4059,
6543), new IntPoint(4109, 6543), new IntPoint(4109, 6423), new IntPoint(4085, 6423), new IntPoint(4085, 6415), new IntPoint(4059, 6415), new IntPoint(4059, 6323), new IntPoint(4035, 6323), new
IntPoint(4035, 6315), new IntPoint(4009, 6315), new IntPoint(4009, 6273), new IntPoint(3985, 6273), new IntPoint(3985, 6265), new IntPoint(3959, 6265), new IntPoint(3959, 6223), new IntPoint(3935,
6223), new IntPoint(3935, 6185), new IntPoint(3939, 6185), new IntPoint(3939, 6193), new IntPoint(4009, 6193), new IntPoint(4009, 6143), new IntPoint(4109, 6143), new IntPoint(4109, 6135), new
IntPoint(4139, 6135) }, new Polygon() { new IntPoint(4139, 5093), new IntPoint(4165, 5093), new IntPoint(4165, 5135), new IntPoint(4189, 5135), new IntPoint(4189, 5143), new IntPoint(4215, 5143), new
IntPoint(4215, 5185), new IntPoint(4239, 5185), new IntPoint(4239, 5193), new IntPoint(4265, 5193), new IntPoint(4265, 5235), new IntPoint(4289, 5235), new IntPoint(4289, 5243), new IntPoint(4315,
5243), new IntPoint(4315, 5285), new IntPoint(4339, 5285), new IntPoint(4339, 5293), new IntPoint(4365, 5293), new IntPoint(4365, 5335), new IntPoint(4389, 5335), new IntPoint(4389, 5343), new
IntPoint(4415, 5343), new IntPoint(4415, 5385), new IntPoint(4439, 5385), new IntPoint(4439, 5393), new IntPoint(4465, 5393), new IntPoint(4465, 5435), new IntPoint(4489, 5435), new IntPoint(4489,
5443), new IntPoint(4515, 5443), new IntPoint(4515, 5485), new IntPoint(4539, 5485), new IntPoint(4539, 5493), new IntPoint(4565, 5493), new IntPoint(4565, 5535), new IntPoint(4589, 5535), new
IntPoint(4589, 5543), new IntPoint(4615, 5543), new IntPoint(4615, 5585), new IntPoint(4639, 5585), new IntPoint(4639, 5593), new IntPoint(4665, 5593), new IntPoint(4665, 5635), new IntPoint(4689,
5635), new IntPoint(4689, 5643), new IntPoint(4715, 5643), new IntPoint(4715, 5685), new IntPoint(4739, 5685), new IntPoint(4739, 5693), new IntPoint(4765, 5693), new IntPoint(4765, 5735), new
IntPoint(4789, 5735), new IntPoint(4789, 5743), new IntPoint(4815, 5743), new IntPoint(4815, 5815), new IntPoint(4515, 5815), new IntPoint(4515, 5865), new IntPoint(4465, 5865), new IntPoint(4465,
5915), new IntPoint(4409, 5915), new IntPoint(4409, 5873), new IntPoint(4385, 5873), new IntPoint(4385, 5865), new IntPoint(4359, 5865), new IntPoint(4359, 5823), new IntPoint(4335, 5823), new
IntPoint(4335, 5815), new IntPoint(4259, 5815), new IntPoint(4259, 5773), new IntPoint(4235, 5773), new IntPoint(4235, 5765), new IntPoint(3765, 5765), new IntPoint(3765, 5815), new IntPoint(3615,
5815), new IntPoint(3615, 5865), new IntPoint(3515, 5865), new IntPoint(3515, 5915), new IntPoint(3415, 5915), new IntPoint(3415, 5965), new IntPoint(3365, 5965), new IntPoint(3365, 6065), new
IntPoint(3315, 6065), new IntPoint(3315, 6115), new IntPoint(3265, 6115), new IntPoint(3265, 6165), new IntPoint(3215, 6165), new IntPoint(3215, 6215), new IntPoint(3165, 6215), new IntPoint(3165,
6315), new IntPoint(3115, 6315), new IntPoint(3115, 6365), new IntPoint(3065, 6365), new IntPoint(3065, 6465), new IntPoint(3015, 6465), new IntPoint(3015, 7015), new IntPoint(2965, 7015), new
IntPoint(2965, 7065), new IntPoint(2909, 7065), new IntPoint(2909, 7023), new IntPoint(2885, 7023), new IntPoint(2885, 7015), new IntPoint(2859, 7015), new IntPoint(2859, 6673), new IntPoint(2835,
6673), new IntPoint(2835, 6665), new IntPoint(2809, 6665), new IntPoint(2809, 6373), new IntPoint(2785, 6373), new IntPoint(2785, 6335), new IntPoint(2789, 6335), new IntPoint(2789, 6343), new
IntPoint(2859, 6343), new IntPoint(2859, 6293), new IntPoint(2909, 6293), new IntPoint(2909, 6243), new IntPoint(2959, 6243), new IntPoint(2959, 6193), new IntPoint(3009, 6193), new IntPoint(3009,
6143), new IntPoint(3059, 6143), new IntPoint(3059, 6073), new IntPoint(3035, 6073), new IntPoint(3035, 6035), new IntPoint(3039, 6035), new IntPoint(3039, 6043), new IntPoint(3109, 6043), new
IntPoint(3109, 5993), new IntPoint(3159, 5993), new IntPoint(3159, 5673), new IntPoint(3135, 5673), new IntPoint(3135, 5665), new IntPoint(3109, 5665), new IntPoint(3109, 5573), new IntPoint(3085,
5573), new IntPoint(3085, 5565), new IntPoint(3059, 5565), new IntPoint(3059, 5523), new IntPoint(3035, 5523), new IntPoint(3035, 5515), new IntPoint(3009, 5515), new IntPoint(3009, 5473), new
IntPoint(2985, 5473), new IntPoint(2985, 5435), new IntPoint(2989, 5435), new IntPoint(2989, 5443), new IntPoint(3059, 5443), new IntPoint(3059, 5393), new IntPoint(3309, 5393), new IntPoint(3309,
5343), new IntPoint(3459, 5343), new IntPoint(3459, 5293), new IntPoint(3609, 5293), new IntPoint(3609, 5243), new IntPoint(3759, 5243), new IntPoint(3759, 5193), new IntPoint(3909, 5193), new
IntPoint(3909, 5143), new IntPoint(4009, 5143), new IntPoint(4009, 5093), new IntPoint(4109, 5093), new IntPoint(4109, 5085), new IntPoint(4139, 5085) }, new Polygon() { new IntPoint(8437, 5793), new
IntPoint(8463, 5793), new IntPoint(8463, 5865), new IntPoint(8413, 5865), new IntPoint(8413, 5915), new IntPoint(8313, 5915), new IntPoint(8313, 5965), new IntPoint(8213, 5965), new IntPoint(8213,
6015), new IntPoint(8163, 6015), new IntPoint(8163, 6065), new IntPoint(8063, 6065), new IntPoint(8063, 6115), new IntPoint(7963, 6115), new IntPoint(7963, 6165), new IntPoint(7913, 6165), new
IntPoint(7913, 6215), new IntPoint(7863, 6215), new IntPoint(7863, 6265), new IntPoint(7763, 6265), new IntPoint(7763, 6315), new IntPoint(7713, 6315), new IntPoint(7713, 6365), new IntPoint(7663,
6365), new IntPoint(7663, 6415), new IntPoint(7613, 6415), new IntPoint(7613, 6515), new IntPoint(7563, 6515), new IntPoint(7563, 6565), new IntPoint(7513, 6565), new IntPoint(7513, 6615), new
IntPoint(7463, 6615), new IntPoint(7463, 6665), new IntPoint(7359, 6665), new IntPoint(7359, 6623), new IntPoint(7335, 6623), new IntPoint(7335, 6615), new IntPoint(7309, 6615), new IntPoint(7309,
6443), new IntPoint(7359, 6443), new IntPoint(7359, 6393), new IntPoint(7407, 6393), new IntPoint(7407, 6343), new IntPoint(7457, 6343), new IntPoint(7457, 6293), new IntPoint(7507, 6293), new
IntPoint(7507, 6243), new IntPoint(7557, 6243), new IntPoint(7557, 6193), new IntPoint(7657, 6193), new IntPoint(7657, 6143), new IntPoint(7707, 6143), new IntPoint(7707, 6093), new IntPoint(7807,
6093), new IntPoint(7807, 6043), new IntPoint(7907, 6043), new IntPoint(7907, 5993), new IntPoint(7957, 5993), new IntPoint(7957, 5943), new IntPoint(8057, 5943), new IntPoint(8057, 5893), new
IntPoint(8207, 5893), new IntPoint(8207, 5843), new IntPoint(8357, 5843), new IntPoint(8357, 5793), new IntPoint(8407, 5793), new IntPoint(8407, 5785), new IntPoint(8437, 5785) }, new Polygon() { new
IntPoint(12187, 5043), new IntPoint(12213, 5043), new IntPoint(12213, 5585), new IntPoint(12237, 5585), new IntPoint(12237, 5593), new IntPoint(12263, 5593), new IntPoint(12263, 5935), new
IntPoint(12287, 5935), new IntPoint(12287, 5943), new IntPoint(12313, 5943), new IntPoint(12313, 6165), new IntPoint(12263, 6165), new IntPoint(12263, 6315), new IntPoint(12213, 6315), new
IntPoint(12213, 6365), new IntPoint(12113, 6365), new IntPoint(12113, 6415), new IntPoint(11963, 6415), new IntPoint(11963, 6465), new IntPoint(11863, 6465), new IntPoint(11863, 6515), new
IntPoint(11707, 6515), new IntPoint(11707, 6473), new IntPoint(11683, 6473), new IntPoint(11683, 6465), new IntPoint(11607, 6465), new IntPoint(11607, 6423), new IntPoint(11583, 6423), new
IntPoint(11583, 6415), new IntPoint(11507, 6415), new IntPoint(11507, 6343), new IntPoint(11557, 6343), new IntPoint(11557, 6293), new IntPoint(11607, 6293), new IntPoint(11607, 6243), new
IntPoint(11657, 6243), new IntPoint(11657, 6193), new IntPoint(11707, 6193), new IntPoint(11707, 6143), new IntPoint(11757, 6143), new IntPoint(11757, 6093), new IntPoint(11807, 6093), new
IntPoint(11807, 6043), new IntPoint(11857, 6043), new IntPoint(11857, 5993), new IntPoint(11907, 5993), new IntPoint(11907, 5943), new IntPoint(11957, 5943), new IntPoint(11957, 5893), new
IntPoint(12007, 5893), new IntPoint(12007, 5493), new IntPoint(12057, 5493), new IntPoint(12057, 5343), new IntPoint(12107, 5343), new IntPoint(12107, 5243), new IntPoint(12157, 5243), new
IntPoint(12157, 5035), new IntPoint(12187, 5035) }, new Polygon() { new IntPoint(6639, 4843), new IntPoint(6665, 4843), new IntPoint(6665, 4935), new IntPoint(6689, 4935), new IntPoint(6689, 4943),
new IntPoint(6715, 4943), new IntPoint(6715, 5235), new IntPoint(6739, 5235), new IntPoint(6739, 5243), new IntPoint(6765, 5243), new IntPoint(6765, 5635), new IntPoint(6789, 5635), new IntPoint(6789,
5643), new IntPoint(7209, 5643), new IntPoint(7209, 5243), new IntPoint(7607, 5243), new IntPoint(7607, 5235), new IntPoint(7637, 5235), new IntPoint(7637, 5243), new IntPoint(7663, 5243), new
IntPoint(7663, 5565), new IntPoint(7613, 5565), new IntPoint(7613, 5615), new IntPoint(7563, 5615), new IntPoint(7563, 5665), new IntPoint(7513, 5665), new IntPoint(7513, 5715), new IntPoint(7413,
5715), new IntPoint(7413, 5765), new IntPoint(7363, 5765), new IntPoint(7363, 5815), new IntPoint(7315, 5815), new IntPoint(7315, 5865), new IntPoint(7215, 5865), new IntPoint(7215, 5915), new
IntPoint(7165, 5915), new IntPoint(7165, 5965), new IntPoint(7115, 5965), new IntPoint(7115, 6015), new IntPoint(7065, 6015), new IntPoint(7065, 6065), new IntPoint(6965, 6065), new IntPoint(6965,
6115), new IntPoint(6915, 6115), new IntPoint(6915, 6165), new IntPoint(6659, 6165), new IntPoint(6659, 6123), new IntPoint(6635, 6123), new IntPoint(6635, 6115), new IntPoint(6609, 6115), new
IntPoint(6609, 6073), new IntPoint(6585, 6073), new IntPoint(6585, 6065), new IntPoint(6559, 6065), new IntPoint(6559, 5973), new IntPoint(6535, 5973), new IntPoint(6535, 5965), new IntPoint(6509,
5965), new IntPoint(6509, 5923), new IntPoint(6485, 5923), new IntPoint(6485, 5915), new IntPoint(6459, 5915), new IntPoint(6459, 5873), new IntPoint(6435, 5873), new IntPoint(6435, 5865), new
IntPoint(6409, 5865), new IntPoint(6409, 5823), new IntPoint(6385, 5823), new IntPoint(6385, 5815), new IntPoint(6359, 5815), new IntPoint(6359, 5773), new IntPoint(6335, 5773), new IntPoint(6335,
5765), new IntPoint(6309, 5765), new IntPoint(6309, 5723), new IntPoint(6285, 5723), new IntPoint(6285, 5715), new IntPoint(6259, 5715), new IntPoint(6259, 5673), new IntPoint(6235, 5673), new
IntPoint(6235, 5665), new IntPoint(6209, 5665), new IntPoint(6209, 5623), new IntPoint(6185, 5623), new IntPoint(6185, 5615), new IntPoint(6159, 5615), new IntPoint(6159, 5573), new IntPoint(6135,
5573), new IntPoint(6135, 5565), new IntPoint(6109, 5565), new IntPoint(6109, 5523), new IntPoint(6085, 5523), new IntPoint(6085, 5515), new IntPoint(6059, 5515), new IntPoint(6059, 5473), new
IntPoint(6035, 5473), new IntPoint(6035, 5465), new IntPoint(6009, 5465), new IntPoint(6009, 5423), new IntPoint(5985, 5423), new IntPoint(5985, 5415), new IntPoint(5959, 5415), new IntPoint(5959,
5373), new IntPoint(5935, 5373), new IntPoint(5935, 5365), new IntPoint(5909, 5365), new IntPoint(5909, 5243), new IntPoint(6009, 5243), new IntPoint(6009, 5235), new IntPoint(6039, 5235), new
IntPoint(6039, 5243), new IntPoint(6065, 5243), new IntPoint(6065, 5335), new IntPoint(6089, 5335), new IntPoint(6089, 5343), new IntPoint(6459, 5343), new IntPoint(6459, 4893), new IntPoint(6559,
4893), new IntPoint(6559, 4843), new IntPoint(6609, 4843), new IntPoint(6609, 4835), new IntPoint(6639, 4835) }, new Polygon() { new IntPoint(12637, 3243), new IntPoint(12663, 3243), new
IntPoint(12663, 3285), new IntPoint(12687, 3285), new IntPoint(12687, 3293), new IntPoint(12713, 3293), new IntPoint(12713, 3335), new IntPoint(12737, 3335), new IntPoint(12737, 3343), new
IntPoint(12763, 3343), new IntPoint(12763, 3385), new IntPoint(12787, 3385), new IntPoint(12787, 3393), new IntPoint(12813, 3393), new IntPoint(12813, 3435), new IntPoint(12837, 3435), new
IntPoint(12837, 3443), new IntPoint(12863, 3443), new IntPoint(12863, 3535), new IntPoint(12887, 3535), new IntPoint(12887, 3543), new IntPoint(12913, 3543), new IntPoint(12913, 3685), new
IntPoint(12937, 3685), new IntPoint(12937, 3693), new IntPoint(12963, 3693), new IntPoint(12963, 3835), new IntPoint(12987, 3835), new IntPoint(12987, 3843), new IntPoint(13013, 3843), new
IntPoint(13013, 5065), new IntPoint(12957, 5065), new IntPoint(12957, 5023), new IntPoint(12933, 5023), new IntPoint(12933, 5015), new IntPoint(12857, 5015), new IntPoint(12857, 4973), new
IntPoint(12833, 4973), new IntPoint(12833, 4965), new IntPoint(12807, 4965), new IntPoint(12807, 4923), new IntPoint(12783, 4923), new IntPoint(12783, 4915), new IntPoint(12707, 4915), new
IntPoint(12707, 4873), new IntPoint(12683, 4873), new IntPoint(12683, 4865), new IntPoint(12657, 4865), new IntPoint(12657, 4823), new IntPoint(12633, 4823), new IntPoint(12633, 4815), new
IntPoint(12607, 4815), new IntPoint(12607, 4623), new IntPoint(12583, 4623), new IntPoint(12583, 4615), new IntPoint(12557, 4615), new IntPoint(12557, 4573), new IntPoint(12533, 4573), new
IntPoint(12533, 4565), new IntPoint(12507, 4565), new IntPoint(12507, 4473), new IntPoint(12483, 4473), new IntPoint(12483, 4465), new IntPoint(12313, 4465), new IntPoint(12313, 4515), new
IntPoint(12013, 4515), new IntPoint(12013, 4615), new IntPoint(11963, 4615), new IntPoint(11963, 4665), new IntPoint(11913, 4665), new IntPoint(11913, 4715), new IntPoint(11863, 4715), new
IntPoint(11863, 4765), new IntPoint(11813, 4765), new IntPoint(11813, 4865), new IntPoint(11763, 4865), new IntPoint(11763, 4915), new IntPoint(11713, 4915), new IntPoint(11713, 4965), new
IntPoint(11663, 4965), new IntPoint(11663, 5065), new IntPoint(11613, 5065), new IntPoint(11613, 5115), new IntPoint(11563, 5115), new IntPoint(11563, 5165), new IntPoint(11513, 5165), new
IntPoint(11513, 5385), new IntPoint(11537, 5385), new IntPoint(11537, 5393), new IntPoint(11563, 5393), new IntPoint(11563, 5615), new IntPoint(11507, 5615), new IntPoint(11507, 5573), new
IntPoint(11483, 5573), new IntPoint(11483, 5565), new IntPoint(11457, 5565), new IntPoint(11457, 5473), new IntPoint(11433, 5473), new IntPoint(11433, 5465), new IntPoint(11407, 5465), new
IntPoint(11407, 5323), new IntPoint(11383, 5323), new IntPoint(11383, 5315), new IntPoint(11357, 5315), new IntPoint(11357, 5143), new IntPoint(11407, 5143), new IntPoint(11407, 5093), new
IntPoint(11457, 5093), new IntPoint(11457, 5043), new IntPoint(11507, 5043), new IntPoint(11507, 4943), new IntPoint(11557, 4943), new IntPoint(11557, 4893), new IntPoint(11607, 4893), new
IntPoint(11607, 4843), new IntPoint(11657, 4843), new IntPoint(11657, 4743), new IntPoint(11707, 4743), new IntPoint(11707, 4693), new IntPoint(11757, 4693), new IntPoint(11757, 4643), new
IntPoint(11807, 4643), new IntPoint(11807, 4543), new IntPoint(11857, 4543), new IntPoint(11857, 4393), new IntPoint(11907, 4393), new IntPoint(11907, 4193), new IntPoint(11957, 4193), new
IntPoint(11957, 3943), new IntPoint(12007, 3943), new IntPoint(12007, 3793), new IntPoint(12057, 3793), new IntPoint(12057, 3643), new IntPoint(12107, 3643), new IntPoint(12107, 3543), new
IntPoint(12157, 3543), new IntPoint(12157, 3493), new IntPoint(12207, 3493), new IntPoint(12207, 3443), new IntPoint(12257, 3443), new IntPoint(12257, 3393), new IntPoint(12307, 3393), new
IntPoint(12307, 3343), new IntPoint(12357, 3343), new IntPoint(12357, 3293), new IntPoint(12507, 3293), new IntPoint(12507, 3243), new IntPoint(12607, 3243), new IntPoint(12607, 3235), new
IntPoint(12637, 3235) }, new Polygon() { new IntPoint(10337, 3293), new IntPoint(10363, 3293), new IntPoint(10363, 3535), new IntPoint(10387, 3535), new IntPoint(10387, 3543), new IntPoint(10413,
3543), new IntPoint(10413, 3635), new IntPoint(10437, 3635), new IntPoint(10437, 3643), new IntPoint(10463, 3643), new IntPoint(10463, 3685), new IntPoint(10487, 3685), new IntPoint(10487, 3693), new
IntPoint(10707, 3693), new IntPoint(10707, 3635), new IntPoint(10737, 3635), new IntPoint(10737, 3643), new IntPoint(10763, 3643), new IntPoint(10763, 3685), new IntPoint(10787, 3685), new
IntPoint(10787, 3693), new IntPoint(10863, 3693), new IntPoint(10863, 3735), new IntPoint(10887, 3735), new IntPoint(10887, 3743), new IntPoint(10913, 3743), new IntPoint(10913, 3785), new
IntPoint(10937, 3785), new IntPoint(10937, 3793), new IntPoint(10963, 3793), new IntPoint(10963, 4015), new IntPoint(10913, 4015), new IntPoint(10913, 4165), new IntPoint(10863, 4165), new
IntPoint(10863, 4315), new IntPoint(10813, 4315), new IntPoint(10813, 4365), new IntPoint(10763, 4365), new IntPoint(10763, 4415), new IntPoint(10663, 4415), new IntPoint(10663, 4465), new
IntPoint(10613, 4465), new IntPoint(10613, 4515), new IntPoint(10563, 4515), new IntPoint(10563, 4565), new IntPoint(10513, 4565), new IntPoint(10513, 4615), new IntPoint(10463, 4615), new
IntPoint(10463, 4665), new IntPoint(10413, 4665), new IntPoint(10413, 4715), new IntPoint(10357, 4715), new IntPoint(10357, 4673), new IntPoint(10333, 4673), new IntPoint(10333, 4665), new
IntPoint(10307, 4665), new IntPoint(10307, 4593), new IntPoint(10357, 4593), new IntPoint(10357, 4543), new IntPoint(10407, 4543), new IntPoint(10407, 4493), new IntPoint(10457, 4493), new
IntPoint(10457, 4443), new IntPoint(10507, 4443), new IntPoint(10507, 4273), new IntPoint(10483, 4273), new IntPoint(10483, 4265), new IntPoint(10457, 4265), new IntPoint(10457, 4223), new
IntPoint(10433, 4223), new IntPoint(10433, 4215), new IntPoint(10407, 4215), new IntPoint(10407, 4173), new IntPoint(10383, 4173), new IntPoint(10383, 4165), new IntPoint(10357, 4165), new
IntPoint(10357, 4123), new IntPoint(10333, 4123), new IntPoint(10333, 4115), new IntPoint(10307, 4115), new IntPoint(10307, 4073), new IntPoint(10283, 4073), new IntPoint(10283, 4065), new
IntPoint(10257, 4065), new IntPoint(10257, 4023), new IntPoint(10233, 4023), new IntPoint(10233, 4015), new IntPoint(10207, 4015), new IntPoint(10207, 3973), new IntPoint(10183, 3973), new
IntPoint(10183, 3965), new IntPoint(10157, 3965), new IntPoint(10157, 3923), new IntPoint(10133, 3923), new IntPoint(10133, 3915), new IntPoint(10107, 3915), new IntPoint(10107, 3873), new
IntPoint(10083, 3873), new IntPoint(10083, 3865), new IntPoint(9957, 3865), new IntPoint(9957, 3823), new IntPoint(9933, 3823), new IntPoint(9933, 3815), new IntPoint(9713, 3815), new IntPoint(9713,
3865), new IntPoint(9663, 3865), new IntPoint(9663, 3915), new IntPoint(9613, 3915), new IntPoint(9613, 3965), new IntPoint(9563, 3965), new IntPoint(9563, 4015), new IntPoint(9513, 4015), new
IntPoint(9513, 4065), new IntPoint(9463, 4065), new IntPoint(9463, 4115), new IntPoint(9363, 4115), new IntPoint(9363, 4165), new IntPoint(9313, 4165), new IntPoint(9313, 4265), new IntPoint(9263,
4265), new IntPoint(9263, 4535), new IntPoint(9287, 4535), new IntPoint(9287, 4543), new IntPoint(9313, 4543), new IntPoint(9313, 4685), new IntPoint(9337, 4685), new IntPoint(9337, 4693), new
IntPoint(9363, 4693), new IntPoint(9363, 4785), new IntPoint(9387, 4785), new IntPoint(9387, 4793), new IntPoint(9413, 4793), new IntPoint(9413, 4835), new IntPoint(9437, 4835), new IntPoint(9437,
4843), new IntPoint(9463, 4843), new IntPoint(9463, 4885), new IntPoint(9487, 4885), new IntPoint(9487, 4893), new IntPoint(9513, 4893), new IntPoint(9513, 4935), new IntPoint(9537, 4935), new
IntPoint(9537, 4943), new IntPoint(9963, 4943), new IntPoint(9963, 5065), new IntPoint(9863, 5065), new IntPoint(9863, 5115), new IntPoint(9763, 5115), new IntPoint(9763, 5165), new IntPoint(9663,
5165), new IntPoint(9663, 5215), new IntPoint(9563, 5215), new IntPoint(9563, 5265), new IntPoint(9413, 5265), new IntPoint(9413, 5315), new IntPoint(9213, 5315), new IntPoint(9213, 5365), new
IntPoint(9013, 5365), new IntPoint(9013, 5415), new IntPoint(8757, 5415), new IntPoint(8757, 5373), new IntPoint(8733, 5373), new IntPoint(8733, 5365), new IntPoint(8707, 5365), new IntPoint(8707,
5143), new IntPoint(8757, 5143), new IntPoint(8757, 5093), new IntPoint(8857, 5093), new IntPoint(8857, 5043), new IntPoint(8907, 5043), new IntPoint(8907, 4993), new IntPoint(8957, 4993), new
IntPoint(8957, 4943), new IntPoint(9007, 4943), new IntPoint(9007, 4893), new IntPoint(9057, 4893), new IntPoint(9057, 4793), new IntPoint(9107, 4793), new IntPoint(9107, 4523), new IntPoint(9083,
4523), new IntPoint(9083, 4515), new IntPoint(9057, 4515), new IntPoint(9057, 4293), new IntPoint(9107, 4293), new IntPoint(9107, 4093), new IntPoint(9157, 4093), new IntPoint(9157, 3943), new
IntPoint(9207, 3943), new IntPoint(9207, 3893), new IntPoint(9257, 3893), new IntPoint(9257, 3843), new IntPoint(9307, 3843), new IntPoint(9307, 3793), new IntPoint(9357, 3793), new IntPoint(9357,
3743), new IntPoint(9407, 3743), new IntPoint(9407, 3693), new IntPoint(9457, 3693), new IntPoint(9457, 3643), new IntPoint(9507, 3643), new IntPoint(9507, 3593), new IntPoint(9607, 3593), new
IntPoint(9607, 3543), new IntPoint(9707, 3543), new IntPoint(9707, 3493), new IntPoint(9807, 3493), new IntPoint(9807, 3443), new IntPoint(9907, 3443), new IntPoint(9907, 3393), new IntPoint(10007,
3393), new IntPoint(10007, 3343), new IntPoint(10107, 3343), new IntPoint(10107, 3293), new IntPoint(10307, 3293), new IntPoint(10307, 3285), new IntPoint(10337, 3285) }, new Polygon() { new
IntPoint(2439, 4743), new IntPoint(2465, 4743), new IntPoint(2465, 4785), new IntPoint(2489, 4785), new IntPoint(2489, 4793), new IntPoint(2515, 4793), new IntPoint(2515, 4965), new IntPoint(2415,
4965), new IntPoint(2415, 5015), new IntPoint(1709, 5015), new IntPoint(1709, 4923), new IntPoint(1685, 4923), new IntPoint(1685, 4915), new IntPoint(1659, 4915), new IntPoint(1659, 4823), new
IntPoint(1635, 4823), new IntPoint(1635, 4785), new IntPoint(1639, 4785), new IntPoint(1639, 4793), new IntPoint(1709, 4793), new IntPoint(1709, 4743), new IntPoint(2409, 4743), new IntPoint(2409,
4735), new IntPoint(2439, 4735) }, new Polygon() { new IntPoint(3639, 4343), new IntPoint(3665, 4343), new IntPoint(3665, 4385), new IntPoint(3689, 4385), new IntPoint(3689, 4393), new IntPoint(3715,
4393), new IntPoint(3715, 4565), new IntPoint(3665, 4565), new IntPoint(3665, 4615), new IntPoint(3565, 4615), new IntPoint(3565, 4665), new IntPoint(3465, 4665), new IntPoint(3465, 4715), new
IntPoint(3365, 4715), new IntPoint(3365, 4765), new IntPoint(3265, 4765), new IntPoint(3265, 4815), new IntPoint(3115, 4815), new IntPoint(3115, 4865), new IntPoint(3065, 4865), new IntPoint(3065,
4915), new IntPoint(2909, 4915), new IntPoint(2909, 4873), new IntPoint(2885, 4873), new IntPoint(2885, 4865), new IntPoint(2859, 4865), new IntPoint(2859, 4723), new IntPoint(2835, 4723), new
IntPoint(2835, 4685), new IntPoint(2839, 4685), new IntPoint(2839, 4693), new IntPoint(2909, 4693), new IntPoint(2909, 4643), new IntPoint(2959, 4643), new IntPoint(2959, 4593), new IntPoint(3109,
4593), new IntPoint(3109, 4543), new IntPoint(3259, 4543), new IntPoint(3259, 4493), new IntPoint(3359, 4493), new IntPoint(3359, 4443), new IntPoint(3409, 4443), new IntPoint(3409, 4393), new
IntPoint(3509, 4393), new IntPoint(3509, 4343), new IntPoint(3609, 4343), new IntPoint(3609, 4335), new IntPoint(3639, 4335) }, new Polygon() { new IntPoint(5589, 3793), new IntPoint(5615, 3793), new
IntPoint(5615, 3935), new IntPoint(5639, 3935), new IntPoint(5639, 3943), new IntPoint(5665, 3943), new IntPoint(5665, 4035), new IntPoint(5689, 4035), new IntPoint(5689, 4043), new IntPoint(5715,
4043), new IntPoint(5715, 4185), new IntPoint(5739, 4185), new IntPoint(5739, 4193), new IntPoint(5765, 4193), new IntPoint(5765, 4285), new IntPoint(5789, 4285), new IntPoint(5789, 4293), new
IntPoint(5815, 4293), new IntPoint(5815, 4385), new IntPoint(5839, 4385), new IntPoint(5839, 4393), new IntPoint(5865, 4393), new IntPoint(5865, 4485), new IntPoint(5889, 4485), new IntPoint(5889,
4493), new IntPoint(5915, 4493), new IntPoint(5915, 4585), new IntPoint(5939, 4585), new IntPoint(5939, 4593), new IntPoint(5965, 4593), new IntPoint(5965, 4685), new IntPoint(5989, 4685), new
IntPoint(5989, 4693), new IntPoint(6015, 4693), new IntPoint(6015, 4735), new IntPoint(6039, 4735), new IntPoint(6039, 4743), new IntPoint(6065, 4743), new IntPoint(6065, 4865), new IntPoint(5865,
4865), new IntPoint(5865, 4915), new IntPoint(5559, 4915), new IntPoint(5559, 4873), new IntPoint(5535, 4873), new IntPoint(5535, 4865), new IntPoint(5459, 4865), new IntPoint(5459, 4823), new
IntPoint(5435, 4823), new IntPoint(5435, 4815), new IntPoint(5359, 4815), new IntPoint(5359, 4773), new IntPoint(5335, 4773), new IntPoint(5335, 4765), new IntPoint(5309, 4765), new IntPoint(5309,
4723), new IntPoint(5285, 4723), new IntPoint(5285, 4715), new IntPoint(5259, 4715), new IntPoint(5259, 4673), new IntPoint(5235, 4673), new IntPoint(5235, 4665), new IntPoint(5209, 4665), new
IntPoint(5209, 4623), new IntPoint(5185, 4623), new IntPoint(5185, 4615), new IntPoint(5159, 4615), new IntPoint(5159, 4573), new IntPoint(5135, 4573), new IntPoint(5135, 4565), new IntPoint(5109,
4565), new IntPoint(5109, 4523), new IntPoint(5085, 4523), new IntPoint(5085, 4515), new IntPoint(5059, 4515), new IntPoint(5059, 4473), new IntPoint(5035, 4473), new IntPoint(5035, 4465), new
IntPoint(5009, 4465), new IntPoint(5009, 4423), new IntPoint(4985, 4423), new IntPoint(4985, 4415), new IntPoint(4959, 4415), new IntPoint(4959, 4373), new IntPoint(4935, 4373), new IntPoint(4935,
4365), new IntPoint(4909, 4365), new IntPoint(4909, 4273), new IntPoint(4885, 4273), new IntPoint(4885, 4265), new IntPoint(4859, 4265), new IntPoint(4859, 4193), new IntPoint(4909, 4193), new
IntPoint(4909, 4143), new IntPoint(5059, 4143), new IntPoint(5059, 4043), new IntPoint(5109, 4043), new IntPoint(5109, 3943), new IntPoint(5159, 3943), new IntPoint(5159, 3893), new IntPoint(5209,
3893), new IntPoint(5209, 3793), new IntPoint(5559, 3793), new IntPoint(5559, 3785), new IntPoint(5589, 3785) }, new Polygon() { new IntPoint(8137, 3543), new IntPoint(8163, 3543), new IntPoint(8163,
3585), new IntPoint(8187, 3585), new IntPoint(8187, 3593), new IntPoint(8213, 3593), new IntPoint(8213, 3635), new IntPoint(8237, 3635), new IntPoint(8237, 3643), new IntPoint(8313, 3643), new
IntPoint(8313, 3685), new IntPoint(8337, 3685), new IntPoint(8337, 3693), new IntPoint(8363, 3693), new IntPoint(8363, 3785), new IntPoint(8387, 3785), new IntPoint(8387, 3793), new IntPoint(8413,
3793), new IntPoint(8413, 3835), new IntPoint(8437, 3835), new IntPoint(8437, 3843), new IntPoint(8463, 3843), new IntPoint(8463, 3885), new IntPoint(8487, 3885), new IntPoint(8487, 3893), new
IntPoint(8513, 3893), new IntPoint(8513, 3935), new IntPoint(8537, 3935), new IntPoint(8537, 3943), new IntPoint(8563, 3943), new IntPoint(8563, 4515), new IntPoint(8513, 4515), new IntPoint(8513,
4665), new IntPoint(8463, 4665), new IntPoint(8463, 4715), new IntPoint(7707, 4715), new IntPoint(7707, 4673), new IntPoint(7683, 4673), new IntPoint(7683, 4665), new IntPoint(7507, 4665), new
IntPoint(7507, 4623), new IntPoint(7483, 4623), new IntPoint(7483, 4615), new IntPoint(7359, 4615), new IntPoint(7359, 4573), new IntPoint(7335, 4573), new IntPoint(7335, 4565), new IntPoint(7259,
4565), new IntPoint(7259, 4523), new IntPoint(7235, 4523), new IntPoint(7235, 4515), new IntPoint(7109, 4515), new IntPoint(7109, 4093), new IntPoint(7159, 4093), new IntPoint(7159, 3993), new
IntPoint(7359, 3993), new IntPoint(7359, 3985), new IntPoint(7387, 3985), new IntPoint(7387, 3993), new IntPoint(7413, 3993), new IntPoint(7413, 4185), new IntPoint(7437, 4185), new IntPoint(7437,
4193), new IntPoint(7513, 4193), new IntPoint(7513, 4235), new IntPoint(7537, 4235), new IntPoint(7537, 4243), new IntPoint(7563, 4243), new IntPoint(7563, 4285), new IntPoint(7587, 4285), new
IntPoint(7587, 4293), new IntPoint(7657, 4293), new IntPoint(7657, 4285), new IntPoint(7687, 4285), new IntPoint(7687, 4293), new IntPoint(7713, 4293), new IntPoint(7713, 4335), new IntPoint(7737,
4335), new IntPoint(7737, 4343), new IntPoint(7907, 4343), new IntPoint(7907, 4293), new IntPoint(8057, 4293), new IntPoint(8057, 3873), new IntPoint(8033, 3873), new IntPoint(8033, 3865), new
IntPoint(8007, 3865), new IntPoint(8007, 3823), new IntPoint(7983, 3823), new IntPoint(7983, 3815), new IntPoint(7907, 3815), new IntPoint(7907, 3773), new IntPoint(7883, 3773), new IntPoint(7883,
3765), new IntPoint(7857, 3765), new IntPoint(7857, 3643), new IntPoint(7907, 3643), new IntPoint(7907, 3593), new IntPoint(7957, 3593), new IntPoint(7957, 3543), new IntPoint(8107, 3543), new
IntPoint(8107, 3535), new IntPoint(8137, 3535) }, new Polygon() { new IntPoint(6989, 3143), new IntPoint(7015, 3143), new IntPoint(7015, 3185), new IntPoint(7039, 3185), new IntPoint(7039, 3193), new
IntPoint(7115, 3193), new IntPoint(7115, 3515), new IntPoint(7065, 3515), new IntPoint(7065, 3565), new IntPoint(7015, 3565), new IntPoint(7015, 3615), new IntPoint(6915, 3615), new IntPoint(6915,
3665), new IntPoint(6815, 3665), new IntPoint(6815, 3715), new IntPoint(6715, 3715), new IntPoint(6715, 3765), new IntPoint(6615, 3765), new IntPoint(6615, 4465), new IntPoint(6459, 4465), new
IntPoint(6459, 4423), new IntPoint(6435, 4423), new IntPoint(6435, 4415), new IntPoint(6359, 4415), new IntPoint(6359, 4373), new IntPoint(6335, 4373), new IntPoint(6335, 4365), new IntPoint(6309,
4365), new IntPoint(6309, 4273), new IntPoint(6285, 4273), new IntPoint(6285, 4265), new IntPoint(6259, 4265), new IntPoint(6259, 4173), new IntPoint(6235, 4173), new IntPoint(6235, 4165), new
IntPoint(6209, 4165), new IntPoint(6209, 4073), new IntPoint(6185, 4073), new IntPoint(6185, 4065), new IntPoint(6159, 4065), new IntPoint(6159, 3793), new IntPoint(6209, 3793), new IntPoint(6209,
3743), new IntPoint(6259, 3743), new IntPoint(6259, 3643), new IntPoint(6309, 3643), new IntPoint(6309, 3593), new IntPoint(6359, 3593), new IntPoint(6359, 3493), new IntPoint(6409, 3493), new
IntPoint(6409, 3393), new IntPoint(6459, 3393), new IntPoint(6459, 3343), new IntPoint(6509, 3343), new IntPoint(6509, 3243), new IntPoint(6559, 3243), new IntPoint(6559, 3193), new IntPoint(6909,
3193), new IntPoint(6909, 3143), new IntPoint(6959, 3143), new IntPoint(6959, 3135), new IntPoint(6989, 3135) }, new Polygon() { new IntPoint(2465, 3935), new IntPoint(2489, 3935), new IntPoint(2489,
3943), new IntPoint(2515, 3943), new IntPoint(2515, 3985), new IntPoint(2539, 3985), new IntPoint(2539, 3993), new IntPoint(2565, 3993), new IntPoint(2565, 4065), new IntPoint(2515, 4065), new
IntPoint(2515, 4115), new IntPoint(2465, 4115), new IntPoint(2465, 4165), new IntPoint(2409, 4165), new IntPoint(2409, 4123), new IntPoint(2385, 4123), new IntPoint(2385, 4115), new IntPoint(2359,
4115), new IntPoint(2359, 4073), new IntPoint(2335, 4073), new IntPoint(2335, 4065), new IntPoint(2309, 4065), new IntPoint(2309, 4023), new IntPoint(2285, 4023), new IntPoint(2285, 3985), new
IntPoint(2289, 3985), new IntPoint(2289, 3993), new IntPoint(2359, 3993), new IntPoint(2359, 3943), new IntPoint(2409, 3943), new IntPoint(2409, 3893), new IntPoint(2465, 3893) }, new Polygon() { new
IntPoint(4789, 2993), new IntPoint(4815, 2993), new IntPoint(4815, 3035), new IntPoint(4839, 3035), new IntPoint(4839, 3043), new IntPoint(4865, 3043), new IntPoint(4865, 3215), new IntPoint(4815,
3215), new IntPoint(4815, 3265), new IntPoint(4765, 3265), new IntPoint(4765, 3365), new IntPoint(4715, 3365), new IntPoint(4715, 3465), new IntPoint(4665, 3465), new IntPoint(4665, 3565), new
IntPoint(4615, 3565), new IntPoint(4615, 3665), new IntPoint(4565, 3665), new IntPoint(4565, 3765), new IntPoint(4515, 3765), new IntPoint(4515, 3815), new IntPoint(4465, 3815), new IntPoint(4465,
3865), new IntPoint(4409, 3865), new IntPoint(4409, 3823), new IntPoint(4385, 3823), new IntPoint(4385, 3815), new IntPoint(4359, 3815), new IntPoint(4359, 3773), new IntPoint(4335, 3773), new
IntPoint(4335, 3765), new IntPoint(4309, 3765), new IntPoint(4309, 3723), new IntPoint(4285, 3723), new IntPoint(4285, 3715), new IntPoint(4259, 3715), new IntPoint(4259, 3643), new IntPoint(4309,
3643), new IntPoint(4309, 3543), new IntPoint(4359, 3543), new IntPoint(4359, 3443), new IntPoint(4409, 3443), new IntPoint(4409, 3393), new IntPoint(4459, 3393), new IntPoint(4459, 3343), new
IntPoint(4509, 3343), new IntPoint(4509, 3293), new IntPoint(4559, 3293), new IntPoint(4559, 3193), new IntPoint(4609, 3193), new IntPoint(4609, 3043), new IntPoint(4659, 3043), new IntPoint(4659,
2993), new IntPoint(4759, 2993), new IntPoint(4759, 2985), new IntPoint(4789, 2985) }, new Polygon() { new IntPoint(5889, 1793), new IntPoint(5915, 1793), new IntPoint(5915, 1865), new IntPoint(5865,
1865), new IntPoint(5865, 1965), new IntPoint(5815, 1965), new IntPoint(5815, 2535), new IntPoint(5839, 2535), new IntPoint(5839, 2543), new IntPoint(5865, 2543), new IntPoint(5865, 2585), new
IntPoint(5889, 2585), new IntPoint(5889, 2593), new IntPoint(5915, 2593), new IntPoint(5915, 2635), new IntPoint(5939, 2635), new IntPoint(5939, 2643), new IntPoint(6015, 2643), new IntPoint(6015,
2685), new IntPoint(6039, 2685), new IntPoint(6039, 2693), new IntPoint(6115, 2693), new IntPoint(6115, 2735), new IntPoint(6139, 2735), new IntPoint(6139, 2743), new IntPoint(6215, 2743), new
IntPoint(6215, 2865), new IntPoint(6165, 2865), new IntPoint(6165, 2965), new IntPoint(6115, 2965), new IntPoint(6115, 3015), new IntPoint(6065, 3015), new IntPoint(6065, 3115), new IntPoint(6015,
3115), new IntPoint(6015, 3215), new IntPoint(5965, 3215), new IntPoint(5965, 3265), new IntPoint(5915, 3265), new IntPoint(5915, 3365), new IntPoint(5865, 3365), new IntPoint(5865, 3465), new
IntPoint(5559, 3465), new IntPoint(5559, 3223), new IntPoint(5535, 3223), new IntPoint(5535, 3215), new IntPoint(5459, 3215), new IntPoint(5459, 1793), new IntPoint(5859, 1793), new IntPoint(5859,
1785), new IntPoint(5889, 1785) }, new Polygon() { new IntPoint(7987, 2393), new IntPoint(8013, 2393), new IntPoint(8013, 2435), new IntPoint(8037, 2435), new IntPoint(8037, 2443), new IntPoint(8063,
2443), new IntPoint(8063, 2485), new IntPoint(8087, 2485), new IntPoint(8087, 2493), new IntPoint(8113, 2493), new IntPoint(8113, 2585), new IntPoint(8137, 2585), new IntPoint(8137, 2593), new
IntPoint(8163, 2593), new IntPoint(8163, 2785), new IntPoint(8187, 2785), new IntPoint(8187, 2793), new IntPoint(8213, 2793), new IntPoint(8213, 2935), new IntPoint(8237, 2935), new IntPoint(8237,
2943), new IntPoint(8607, 2943), new IntPoint(8607, 2793), new IntPoint(8657, 2793), new IntPoint(8657, 2593), new IntPoint(8757, 2593), new IntPoint(8757, 2585), new IntPoint(8787, 2585), new
IntPoint(8787, 2593), new IntPoint(8813, 2593), new IntPoint(8813, 2635), new IntPoint(8837, 2635), new IntPoint(8837, 2643), new IntPoint(8913, 2643), new IntPoint(8913, 2685), new IntPoint(8937,
2685), new IntPoint(8937, 2693), new IntPoint(9007, 2693), new IntPoint(9007, 2685), new IntPoint(9037, 2685), new IntPoint(9037, 2693), new IntPoint(9063, 2693), new IntPoint(9063, 2735), new
IntPoint(9087, 2735), new IntPoint(9087, 2743), new IntPoint(9163, 2743), new IntPoint(9163, 2785), new IntPoint(9187, 2785), new IntPoint(9187, 2793), new IntPoint(9263, 2793), new IntPoint(9263,
2835), new IntPoint(9287, 2835), new IntPoint(9287, 2843), new IntPoint(9757, 2843), new IntPoint(9757, 2793), new IntPoint(9857, 2793), new IntPoint(9857, 2743), new IntPoint(9957, 2743), new
IntPoint(9957, 2693), new IntPoint(10057, 2693), new IntPoint(10057, 2643), new IntPoint(10157, 2643), new IntPoint(10157, 2635), new IntPoint(10187, 2635), new IntPoint(10187, 2643), new
IntPoint(10213, 2643), new IntPoint(10213, 2735), new IntPoint(10237, 2735), new IntPoint(10237, 2743), new IntPoint(10263, 2743), new IntPoint(10263, 2815), new IntPoint(10163, 2815), new
IntPoint(10163, 2865), new IntPoint(10113, 2865), new IntPoint(10113, 2915), new IntPoint(9913, 2915), new IntPoint(9913, 2965), new IntPoint(9813, 2965), new IntPoint(9813, 3015), new IntPoint(9613,
3015), new IntPoint(9613, 3065), new IntPoint(9463, 3065), new IntPoint(9463, 3115), new IntPoint(9263, 3115), new IntPoint(9263, 3165), new IntPoint(9213, 3165), new IntPoint(9213, 3215), new
IntPoint(9163, 3215), new IntPoint(9163, 3265), new IntPoint(9113, 3265), new IntPoint(9113, 3315), new IntPoint(9063, 3315), new IntPoint(9063, 3365), new IntPoint(9013, 3365), new IntPoint(9013,
3415), new IntPoint(8907, 3415), new IntPoint(8907, 3373), new IntPoint(8883, 3373), new IntPoint(8883, 3365), new IntPoint(8807, 3365), new IntPoint(8807, 3323), new IntPoint(8783, 3323), new
IntPoint(8783, 3315), new IntPoint(8757, 3315), new IntPoint(8757, 3273), new IntPoint(8733, 3273), new IntPoint(8733, 3265), new IntPoint(8657, 3265), new IntPoint(8657, 3223), new IntPoint(8633,
3223), new IntPoint(8633, 3215), new IntPoint(8307, 3215), new IntPoint(8307, 3173), new IntPoint(8283, 3173), new IntPoint(8283, 3165), new IntPoint(8257, 3165), new IntPoint(8257, 3123), new
IntPoint(8233, 3123), new IntPoint(8233, 3115), new IntPoint(7863, 3115), new IntPoint(7863, 3165), new IntPoint(7763, 3165), new IntPoint(7763, 3215), new IntPoint(7657, 3215), new IntPoint(7657,
2593), new IntPoint(7707, 2593), new IntPoint(7707, 2543), new IntPoint(7757, 2543), new IntPoint(7757, 2493), new IntPoint(7807, 2493), new IntPoint(7807, 2443), new IntPoint(7857, 2443), new
IntPoint(7857, 2393), new IntPoint(7957, 2393), new IntPoint(7957, 2385), new IntPoint(7987, 2385) }, new Polygon() { new IntPoint(11337, 1943), new IntPoint(11363, 1943), new IntPoint(11363, 1985),
new IntPoint(11387, 1985), new IntPoint(11387, 1993), new IntPoint(11463, 1993), new IntPoint(11463, 2035), new IntPoint(11487, 2035), new IntPoint(11487, 2043), new IntPoint(11513, 2043), new
IntPoint(11513, 2135), new IntPoint(11537, 2135), new IntPoint(11537, 2143), new IntPoint(11563, 2143), new IntPoint(11563, 2235), new IntPoint(11587, 2235), new IntPoint(11587, 2243), new
IntPoint(11613, 2243), new IntPoint(11613, 2385), new IntPoint(11637, 2385), new IntPoint(11637, 2393), new IntPoint(11663, 2393), new IntPoint(11663, 2485), new IntPoint(11687, 2485), new
IntPoint(11687, 2493), new IntPoint(11713, 2493), new IntPoint(11713, 2765), new IntPoint(11663, 2765), new IntPoint(11663, 2815), new IntPoint(11613, 2815), new IntPoint(11613, 2865), new
IntPoint(11563, 2865), new IntPoint(11563, 2915), new IntPoint(11513, 2915), new IntPoint(11513, 2965), new IntPoint(11463, 2965), new IntPoint(11463, 3015), new IntPoint(11363, 3015), new
IntPoint(11363, 3065), new IntPoint(11313, 3065), new IntPoint(11313, 3115), new IntPoint(11263, 3115), new IntPoint(11263, 3165), new IntPoint(11163, 3165), new IntPoint(11163, 3215), new
IntPoint(11113, 3215), new IntPoint(11113, 3265), new IntPoint(10857, 3265), new IntPoint(10857, 3223), new IntPoint(10833, 3223), new IntPoint(10833, 3215), new IntPoint(10757, 3215), new
IntPoint(10757, 3173), new IntPoint(10733, 3173), new IntPoint(10733, 3165), new IntPoint(10707, 3165), new IntPoint(10707, 3123), new IntPoint(10683, 3123), new IntPoint(10683, 3115), new
IntPoint(10657, 3115), new IntPoint(10657, 2943), new IntPoint(10707, 2943), new IntPoint(10707, 2893), new IntPoint(10757, 2893), new IntPoint(10757, 2793), new IntPoint(10807, 2793), new
IntPoint(10807, 2743), new IntPoint(10857, 2743), new IntPoint(10857, 2693), new IntPoint(10907, 2693), new IntPoint(10907, 2593), new IntPoint(10957, 2593), new IntPoint(10957, 2543), new
IntPoint(11007, 2543), new IntPoint(11007, 2443), new IntPoint(11057, 2443), new IntPoint(11057, 2193), new IntPoint(11107, 2193), new IntPoint(11107, 2093), new IntPoint(11157, 2093), new
IntPoint(11157, 1993), new IntPoint(11207, 1993), new IntPoint(11207, 1943), new IntPoint(11307, 1943), new IntPoint(11307, 1935), new IntPoint(11337, 1935) }, new Polygon() { new IntPoint(4939,
1643), new IntPoint(4965, 1643), new IntPoint(4965, 1685), new IntPoint(4989, 1685), new IntPoint(4989, 1693), new IntPoint(5015, 1693), new IntPoint(5015, 2115), new IntPoint(4965, 2115), new
IntPoint(4965, 2615), new IntPoint(4915, 2615), new IntPoint(4915, 2665), new IntPoint(4759, 2665), new IntPoint(4759, 2623), new IntPoint(4735, 2623), new IntPoint(4735, 2615), new IntPoint(4709,
2615), new IntPoint(4709, 2093), new IntPoint(4759, 2093), new IntPoint(4759, 1693), new IntPoint(4809, 1693), new IntPoint(4809, 1643), new IntPoint(4909, 1643), new IntPoint(4909, 1635), new
IntPoint(4939, 1635) }, new Polygon() { new IntPoint(3989, 2243), new IntPoint(4015, 2243), new IntPoint(4015, 2285), new IntPoint(4039, 2285), new IntPoint(4039, 2293), new IntPoint(4065, 2293), new
IntPoint(4065, 2335), new IntPoint(4089, 2335), new IntPoint(4089, 2343), new IntPoint(4115, 2343), new IntPoint(4115, 2415), new IntPoint(4065, 2415), new IntPoint(4065, 2465), new IntPoint(4015,
2465), new IntPoint(4015, 2515), new IntPoint(3959, 2515), new IntPoint(3959, 2473), new IntPoint(3935, 2473), new IntPoint(3935, 2465), new IntPoint(3909, 2465), new IntPoint(3909, 2423), new
IntPoint(3885, 2423), new IntPoint(3885, 2415), new IntPoint(3859, 2415), new IntPoint(3859, 2343), new IntPoint(3909, 2343), new IntPoint(3909, 2293), new IntPoint(3959, 2293), new IntPoint(3959,
2235), new IntPoint(3989, 2235) }, new Polygon() { new IntPoint(7837, 1743), new IntPoint(7863, 1743), new IntPoint(7863, 2015), new IntPoint(7663, 2015), new IntPoint(7663, 2065), new IntPoint(7563,
2065), new IntPoint(7563, 2115), new IntPoint(7513, 2115), new IntPoint(7513, 2165), new IntPoint(7463, 2165), new IntPoint(7463, 2215), new IntPoint(7413, 2215), new IntPoint(7413, 2265), new
IntPoint(7363, 2265), new IntPoint(7363, 2315), new IntPoint(7315, 2315), new IntPoint(7315, 2365), new IntPoint(7265, 2365), new IntPoint(7265, 2415), new IntPoint(7215, 2415), new IntPoint(7215,
2465), new IntPoint(7165, 2465), new IntPoint(7165, 2515), new IntPoint(6759, 2515), new IntPoint(6759, 2473), new IntPoint(6735, 2473), new IntPoint(6735, 2465), new IntPoint(6609, 2465), new
IntPoint(6609, 2423), new IntPoint(6585, 2423), new IntPoint(6585, 2415), new IntPoint(6509, 2415), new IntPoint(6509, 2373), new IntPoint(6485, 2373), new IntPoint(6485, 2365), new IntPoint(6409,
2365), new IntPoint(6409, 2323), new IntPoint(6385, 2323), new IntPoint(6385, 2315), new IntPoint(6309, 2315), new IntPoint(6309, 1993), new IntPoint(6359, 1993), new IntPoint(6359, 1943), new
IntPoint(6409, 1943), new IntPoint(6409, 1843), new IntPoint(6459, 1843), new IntPoint(6459, 1743), new IntPoint(7807, 1743), new IntPoint(7807, 1735), new IntPoint(7837, 1735) }, new Polygon() { new
IntPoint(10487, 1793), new IntPoint(10513, 1793), new IntPoint(10513, 1835), new IntPoint(10537, 1835), new IntPoint(10537, 1843), new IntPoint(10613, 1843), new IntPoint(10613, 1885), new
IntPoint(10637, 1885), new IntPoint(10637, 1893), new IntPoint(10663, 1893), new IntPoint(10663, 2065), new IntPoint(10613, 2065), new IntPoint(10613, 2115), new IntPoint(10563, 2115), new
IntPoint(10563, 2165), new IntPoint(10163, 2165), new IntPoint(10163, 2215), new IntPoint(10063, 2215), new IntPoint(10063, 2265), new IntPoint(9963, 2265), new IntPoint(9963, 2315), new
IntPoint(9863, 2315), new IntPoint(9863, 2365), new IntPoint(9407, 2365), new IntPoint(9407, 2293), new IntPoint(9457, 2293), new IntPoint(9457, 2193), new IntPoint(9507, 2193), new IntPoint(9507,
1993), new IntPoint(9557, 1993), new IntPoint(9557, 1843), new IntPoint(9607, 1843), new IntPoint(9607, 1793), new IntPoint(10457, 1793), new IntPoint(10457, 1785), new IntPoint(10487, 1785) }, new
Polygon() { new IntPoint(9087, 1743), new IntPoint(9113, 1743), new IntPoint(9113, 1815), new IntPoint(9063, 1815), new IntPoint(9063, 1915), new IntPoint(9013, 1915), new IntPoint(9013, 1965), new
IntPoint(8963, 1965), new IntPoint(8963, 2065), new IntPoint(8913, 2065), new IntPoint(8913, 2165), new IntPoint(8807, 2165), new IntPoint(8807, 2123), new IntPoint(8783, 2123), new IntPoint(8783,
2115), new IntPoint(8607, 2115), new IntPoint(8607, 2073), new IntPoint(8583, 2073), new IntPoint(8583, 2065), new IntPoint(8407, 2065), new IntPoint(8407, 2023), new IntPoint(8383, 2023), new
IntPoint(8383, 2015), new IntPoint(8207, 2015), new IntPoint(8207, 1743), new IntPoint(9057, 1743), new IntPoint(9057, 1735), new IntPoint(9087, 1735) } };
        public static float[] heightData = new float[] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 183.5748f, 183.5748f, 182.1325f, 182.1325f, 182.1325f, 182.6638f, 182.5681f, 184.4429f, 169.2222f, 165.8184f, 147.8032f, 139.2975f, 130.1534f,
108.1021f, 86.05072f, 93.3757f, 93.3757f, 93.3757f, 93.3757f, 93.3757f, 93.37569f, 93.37566f, 93.37566f, 93.37565f, 93.37564f, 93.37563f, 93.37563f, 93.37561f, 93.37562f, 93.37561f, 93.3756f,
93.3756f, 93.37556f, 93.3756f, 93.37558f, 93.3756f, 93.3756f, 93.3756f, 93.3756f, 93.3756f, 93.3756f, 93.3756f, 93.37558f, 93.79794f, 93.91988f, 93.37566f, 93.3757f, 93.37572f, 93.37575f, 93.37578f,
-224.1586f, -248.0108f, -271.863f, 49.76963f, 49.67759f, 49.58555f, 49.49351f, 49.40147f, 49.30943f, 49.96201f, 49.85706f, 49.75211f, 49.64717f, 49.54222f, 49.4561f, 49.45502f, 49.45395f, 49.45287f,
49.4518f, 49.65365f, 49.45012f, 49.44905f, 49.44799f, 49.44691f, 49.44588f, 49.4451f, 49.44432f, 49.57048f, 49.67667f, 49.73019f, 49.78371f, 49.83723f, 49.89075f, 49.98798f, 50.07724f, 50.1526f,
50.22796f, 50.30332f, 50.37868f, 50.45404f, 50.5294f, 49.95312f, 49.98926f, 50.06697f, 50.14468f, 50.22239f, 50.3001f, 50.37781f, 50.45552f, 50.53323f, 49.45153f, 48.92242f, 55.58168f, 53.87839f,
51.63817f, 49.39794f, 47.15772f, 52.11238f, 50.28061f, 49.77344f, 49.93756f, 50.10168f, 50.2658f, 50.42992f, 50.59404f, 50.75817f, 50.87874f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f,
51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 50.71557f, 51.59025f, 52.25825f, 52.92625f, 53.59427f, 54.26226f, 54.93026f, 56.07731f, 55.71871f, 55.15407f, 54.5894f, 54.02473f, 53.46005f, 52.89541f,
51.93678f, 50.55984f, 50.89214f, 51.13647f, 51.38081f, 0f, 0f, 0f, 0f, 183.5748f, 183.36f, 182.5244f, 182.1325f, 182.1326f, 182.1325f, 182.1325f, 184.1371f, 169.398f, 166.3824f, 152.1077f, 140.8153f,
127.9709f, 107.5063f, 93.3757f, 93.3757f, 93.3757f, 93.3757f, 93.3757f, 93.3757f, 93.37568f, 93.37567f, 93.37566f, 93.37566f, 93.37565f, 93.37564f, 93.37564f, 93.37563f, 93.37563f, 93.37561f,
93.37561f, 93.3756f, 93.37557f, 93.37558f, 93.3756f, 93.3756f, 93.3756f, 93.3756f, 93.3756f, 93.3756f, 93.3756f, 93.3756f, 93.37558f, 93.37561f, 93.37564f, 93.69734f, 93.3757f, 93.37573f, 93.37576f,
93.37579f, -180.4413f, -204.2934f, -228.1457f, 49.87608f, 49.78403f, 49.69199f, 49.59995f, 49.50792f, 49.41588f, 49.96196f, 49.85701f, 49.75206f, 49.64712f, 49.54217f, 49.4561f, 49.45502f, 49.45395f,
49.45287f, 49.4518f, 49.45113f, 49.45006f, 49.44899f, 49.44792f, 49.44685f, 49.44577f, 49.44498f, 49.4442f, 49.55092f, 49.6484f, 49.70192f, 49.75544f, 49.80896f, 49.86248f, 49.96314f, 50.05361f,
50.12897f, 50.20433f, 50.27969f, 50.35505f, 50.43041f, 50.50577f, 49.98171f, 50.05942f, 50.13713f, 50.21484f, 50.29254f, 50.37025f, 50.44796f, 50.52567f, 50.60339f, 48.6921f, 48.88612f, 49.08015f,
53.71507f, 51.47485f, 49.23463f, 51.81248f, 50.16843f, 50.24431f, 49.84406f, 49.98105f, 50.14517f, 50.30929f, 50.47341f, 50.63754f, 50.80161f, 50.92151f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f,
51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.21381f, 51.09673f, 51.97233f, 52.64034f, 53.30834f, 53.97635f, 54.64434f, 56.00032f, 55.45564f, 55.09846f, 54.53381f, 53.96913f, 53.40447f, 52.83979f,
51.92334f, 50.61417f, 50.87215f, 51.20509f, 51.44943f, 51.69377f, 0f, 0f, 0f, 0f, 182.5614f, 182.1325f, 182.1325f, 182.1325f, 182.1325f, 182.1325f, 182.1325f, 182.3583f, 174.19f, 166.5158f, 152.2411f,
142.333f, 125.7883f, 100.6547f, 93.3757f, 93.3757f, 93.3757f, 93.3757f, 93.3757f, 93.3757f, 93.37569f, 93.37569f, 93.37567f, 93.54056f, 93.37566f, 93.37565f, 93.37564f, 93.37563f, 93.37563f,
93.37563f, 93.37562f, 93.37561f, 93.37558f, 93.49086f, 93.3756f, 93.3756f, 93.3756f, 93.3756f, 93.3756f, 93.3756f, 93.3756f, 93.44612f, 93.3756f, 93.37563f, 93.37566f, 93.37569f, 93.3757f, 93.37573f,
93.37576f, 25.29637f, -136.7241f, -160.5763f, -184.4285f, 49.98251f, 50.08993f, 49.79844f, 49.7064f, 49.61436f, 49.52232f, 49.96191f, 49.85696f, 50.94133f, 49.64707f, 49.54212f, 49.4561f, 49.45502f,
49.45395f, 49.45287f, 49.4518f, 49.45097f, 49.44999f, 49.44892f, 49.44785f, 49.44678f, 49.44566f, 49.44486f, 49.44408f, 49.53136f, 49.62013f, 49.67365f, 49.72717f, 49.78069f, 49.83421f, 49.9501f,
50.02998f, 50.10533f, 50.1807f, 50.25606f, 50.33141f, 50.40678f, 50.48213f, 50.05186f, 50.12957f, 50.20728f, 50.28499f, 50.3627f, 50.44041f, 50.51812f, 50.59583f, 50.67354f, 48.90767f, 48.84983f,
49.04386f, 53.55177f, 51.31155f, 49.07132f, 51.91645f, 50.01399f, 50.20802f, 49.88402f, 50.02454f, 50.18865f, 50.35278f, 50.5169f, 50.68102f, 50.8451f, 50.96428f, 51.272f, 51.272f, 51.272f, 51.272f,
51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 50.80075f, 51.47788f, 52.35441f, 53.02242f, 53.69041f, 54.35843f, 55.6705f, 55.37835f, 54.83396f, 54.47819f, 53.91354f, 53.34887f, 52.78421f,
51.9077f, 50.68143f, 50.92628f, 51.18445f, 51.51805f, 51.76239f, 52.33529f, 0f, 0f, 0f, 0f, 181.9872f, 183.5442f, 182.1325f, 182.2141f, 183.5748f, 183.5748f, 183.5748f, 183.6034f, 174.6027f,
166.6493f, 153.1969f, 143.8508f, 123.6057f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.33549f, 93.37566f,
93.37569f, 93.37572f, 102.1228f, 104.6782f, -122.9778f, -63.99079f, -116.859f, -91.73932f, 50.08896f, 49.99692f, 49.90488f, 49.81284f, 49.7208f, 49.86154f, 49.96185f, 49.85691f, 49.75196f, 49.64702f,
49.54207f, 49.4561f, 49.86875f, 49.45395f, 49.45287f, 49.4518f, 49.45089f, 49.44992f, 49.44885f, 49.44778f, 49.44671f, 49.44554f, 49.44475f, 49.44396f, 49.5118f, 49.59186f, 49.64538f, 49.69891f,
49.75243f, 49.80595f, 49.93098f, 50.00634f, 50.0817f, 50.15706f, 50.23243f, 50.30779f, 50.38314f, 50.4585f, 50.12201f, 50.19973f, 50.27744f, 50.35514f, 50.43285f, 50.51056f, 50.58827f, 50.66598f,
50.74369f, 50.8214f, 48.81354f, 49.00756f, 53.38846f, 51.14824f, 48.908f, 50.41011f, 49.9777f, 50.17172f, 50.24278f, 50.06802f, 50.23214f, 50.39627f, 50.56039f, 50.72451f, 50.88859f, 51.272f, 51.272f,
51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.22764f, 51.18179f, 51.85904f, 52.7365f, 53.4045f, 54.0725f, 54.82747f, 55.31989f, 54.75638f, 54.21228f, 53.85793f, 53.29328f,
52.72861f, 51.89008f, 50.74869f, 50.99353f, 51.23838f, 51.49676f, 51.83101f, 52.31994f, 52.25838f, 0f, 0f, 0f, 0f, 183.5748f, 183.5748f, 183.543f, 182.1325f, 183.5748f, 183.5748f, 183.5748f,
183.5748f, 174.6027f, 166.7827f, 154.582f, 142.4011f, 121.0012f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74806f, 95.74811f,
95.74811f, 95.49187f, 93.37569f, 96.75484f, 111.4879f, 34.24019f, -65.0361f, -37.19501f, -73.14175f, -21.91831f, 50.5374f, 51.33079f, 50.01133f, 49.91929f, 49.82725f, 49.91119f, 49.96181f, 49.85686f,
49.75191f, 49.64697f, 49.54202f, 49.4561f, 49.45502f, 49.45395f, 49.45287f, 49.4518f, 49.45084f, 49.44985f, 49.44878f, 49.44771f, 49.44664f, 49.44542f, 49.44463f, 49.44385f, 49.49224f, 49.56359f,
49.61711f, 49.67064f, 49.72416f, 49.77768f, 49.90735f, 49.98271f, 50.05807f, 50.13343f, 50.20879f, 50.28415f, 50.35951f, 50.17915f, 50.19217f, 50.26988f, 50.34758f, 50.4253f, 50.50301f, 50.58072f,
50.65842f, 50.73613f, 50.81384f, 50.89155f, 47.9083f, 47.58297f, 52.79238f, 50.98492f, 47.66442f, 49.74738f, 49.9414f, 50.13544f, 50.32946f, 50.11152f, 50.27563f, 50.43975f, 50.60387f, 50.77131f,
50.93207f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 50.89344f, 51.56282f, 52.24019f, 53.11858f, 53.78659f, 54.45458f, 55.27824f, 54.93167f, 54.367f,
53.80234f, 53.23766f, 52.67302f, 51.87035f, 50.81594f, 51.06079f, 51.30563f, 51.55047f, 51.80907f, 52.37064f, 52.21788f, 52.06511f, 0f, 0f, 0f, 0f, 183.5748f, 183.5748f, 183.5748f, 183.5748f,
183.5748f, 183.5748f, 183.5748f, 182.2726f, 174.6027f, 166.8375f, 155.9672f, 140.5405f, 113.7796f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74807f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74806f, 95.74811f, 95.74811f, 95.74811f, 95.74811f, 95.49786f, 102.8638f, 111.4947f, 65.87844f, 18.27974f, 4.846951f, -21.53183f, -3.400402f, 50.30185f, 50.20982f, 50.11777f, 50.02573f, 49.93369f,
50.0667f, 49.96175f, 49.85681f, 49.75187f, 49.64692f, 49.54197f, 49.4561f, 49.45502f, 49.45395f, 49.45287f, 49.4518f, 49.45071f, 49.44978f, 49.44871f, 49.44764f, 49.44657f, 49.4453f, 49.44451f,
49.44373f, 49.47268f, 49.53532f, 49.58884f, 49.64237f, 49.69589f, 49.74941f, 49.88372f, 49.95908f, 50.03443f, 50.1098f, 50.18516f, 50.26052f, 50.33587f, 50.19685f, 50.26233f, 50.34003f, 50.41774f,
50.49545f, 50.57316f, 50.65087f, 50.72858f, 50.80629f, 50.884f, 50.9617f, 51.03941f, 48.93498f, 49.12901f, 50.82162f, 48.58139f, 49.71109f, 49.90511f, 50.09914f, 50.29317f, 50.155f, 50.32121f,
50.48324f, 50.64737f, 50.81148f, 50.10857f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 50.94835f, 51.49666f, 52.16467f, 52.83265f, 53.50066f, 54.16867f,
55.20295f, 54.65652f, 54.31142f, 53.74674f, 53.18208f, 52.6174f, 51.84853f, 50.8832f, 51.12804f, 51.37289f, 51.61773f, 51.86258f, 52.13136f, 52.17737f, 52.02461f, 51.87185f, 0f, 0f, 0f, 0f, 183.5748f,
183.5748f, 183.5748f, 183.5748f, 183.5748f, 183.5748f, 183.5748f, 174.6027f, 169.4112f, 163.3494f, 154.6149f, 138.6798f, 106.558f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74811f, 95.74811f, 95.74811f, 95.74811f, 95.74811f, 95.74811f, 101.1967f, 111.5015f, 94.7988f, 61.99697f, 42.25688f, 28.42236f, 15.11756f, 50.40829f, 50.31625f,
50.22421f, 50.13218f, 50.04014f, 50.02605f, 49.9617f, 49.85676f, 49.75181f, 49.64687f, 49.47726f, 49.4561f, 49.45502f, 49.45395f, 49.45287f, 49.45179f, 49.45074f, 49.44971f, 49.44864f, 49.44757f,
49.4465f, 49.44526f, 49.4444f, 49.44361f, 49.44101f, 49.50706f, 49.56058f, 49.6141f, 49.66762f, 49.781f, 49.86008f, 49.93545f, 50.0108f, 50.08616f, 50.16153f, 50.23688f, 50.31224f, 50.25477f,
50.33248f, 50.41019f, 50.48789f, 50.56561f, 50.64331f, 50.72103f, 50.79873f, 50.87644f, 50.95415f, 51.03186f, 51.10957f, 51.18728f, 49.09272f, 50.65831f, 49.44194f, 49.6748f, 49.86883f, 50.06285f,
50.25687f, 50.19848f, 50.36261f, 50.52673f, 50.69085f, 50.85497f, 51.272f, 51.272f, 51.98976f, 51.34345f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.21072f, 51.87874f, 52.54674f,
53.21473f, 53.88274f, 54.97449f, 54.58099f, 54.03481f, 53.69115f, 53.12648f, 52.56182f, 51.82455f, 50.95045f, 51.1953f, 51.44015f, 51.685f, 51.92983f, 52.28963f, 52.13687f, 51.98411f, 51.83134f,
51.67859f, 0f, 0f, 0f, 0f, 183.1529f, 180.2572f, 183.5748f, 183.5748f, 183.5748f, 181.9082f, 174.6027f, 174.6027f, 168.7637f, 159.6767f, 147.6363f, 123.2687f, 96.16302f, 95.74805f, 95.74805f,
95.74805f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74806f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74806f, 95.74805f, 95.74811f, 95.74811f, 95.74811f, 95.74811f, 95.74811f, 95.74805f, 95.74805f, 100.8411f, 111.5083f, 108.249f, 102.2522f, 79.12523f,
51.45977f, 50.60678f, 50.51474f, 50.4227f, 50.33066f, 50.23658f, 50.14197f, 50.04736f, 49.95238f, 49.85406f, 49.75128f, 49.64682f, 49.54187f, 49.4561f, 49.45502f, 49.45395f, 49.45287f, 49.4518f,
49.45072f, 49.44965f, 49.44857f, 49.44751f, 49.44644f, 49.44537f, 49.4443f, 49.4435f, 49.44628f, 49.47921f, 49.53535f, 49.61037f, 49.68573f, 49.76109f, 49.83645f, 49.91181f, 49.98717f, 50.06253f,
50.13789f, 50.21325f, 50.28861f, 50.36397f, 50.43932f, 50.51469f, 50.59005f, 50.66541f, 50.74077f, 50.8064f, 50.88229f, 50.95818f, 51.03407f, 51.10996f, 51.18586f, 51.26174f, 51.33763f, 50.495f,
49.44448f, 49.6385f, 49.83253f, 50.02656f, 50.11806f, 50.24197f, 50.40609f, 50.57021f, 50.73433f, 50.89845f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.25646f,
51.5928f, 52.26082f, 52.92108f, 53.3753f, 54.04469f, 54.76486f, 54.20021f, 53.63554f, 53.07088f, 52.50621f, 51.79855f, 51.01772f, 51.26256f, 51.5074f, 51.75225f, 51.9971f, 52.31612f, 52.09637f,
51.94361f, 51.79085f, 51.63808f, 51.48532f, 0f, 0f, 0f, 0f, 181.3726f, 140.2267f, 174.6027f, 174.6027f, 174.6027f, 174.6027f, 174.6027f, 169.4129f, 164.5516f, 155.8162f, 140.4937f, 112.8874f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74806f, 95.74806f, 95.74805f, 95.74805f, 95.74807f, 95.74805f, 95.74809f, 95.74811f, 95.74811f, 95.74809f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 100.2972f, 111.5151f,
108.2472f, 104.7037f, 88.99469f, 68.66482f, 50.68221f, 50.5868f, 50.48482f, 50.38139f, 50.27644f, 50.1715f, 50.06655f, 49.96161f, 49.85666f, 49.75171f, 49.64677f, 49.54182f, 49.4561f, 49.45502f,
49.45394f, 49.45287f, 49.45179f, 49.45071f, 49.44964f, 49.44856f, 49.44748f, 49.44632f, 49.44516f, 49.4441f, 49.44348f, 49.44824f, 49.47648f, 49.50163f, 49.61799f, 49.69569f, 49.77341f, 49.85111f,
49.92883f, 50.00653f, 50.08424f, 50.16195f, 50.23966f, 50.31736f, 50.39508f, 50.44342f, 50.52096f, 50.59851f, 50.67606f, 50.75361f, 50.83115f, 50.90871f, 51.01675f, 51.09446f, 51.17216f, 51.24988f,
51.32758f, 51.32763f, 50.33169f, 49.40819f, 49.60221f, 49.79221f, 49.90991f, 50.07369f, 50.23747f, 50.40125f, 50.56504f, 50.72882f, 50.8926f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f,
51.272f, 51.2687f, 51.272f, 51.0848f, 51.97489f, 52.64291f, 53.30305f, 53.75634f, 54.70927f, 54.14461f, 53.57994f, 53.01527f, 52.45062f, 51.88595f, 51.08497f, 51.32982f, 51.57466f, 51.81951f,
52.06435f, 52.27646f, 52.12339f, 51.90311f, 51.75034f, 51.59759f, 51.44482f, 51.29206f, 0f, 0f, 0f, 0f, 88.63313f, 174.6027f, 174.6027f, 170.4076f, 169.4162f, 169.4128f, 158.8242f, 153.6626f,
152.1194f, 146.9717f, 128.511f, 103.3596f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74805f, 95.74808f, 95.74805f, 95.74808f, 95.74805f, 95.74811f, 95.74811f, 95.74809f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74807f, 95.74807f, 98.5172f, 111.5219f, 108.2486f, 106.6566f, 91.67652f, 73.41762f, 52.97282f, 50.59656f, 50.4909f, 50.38524f, 50.27958f, 50.17392f, 50.06826f, 49.96271f, 49.8572f, 49.75171f,
49.64672f, 49.54177f, 49.4561f, 49.45502f, 49.4539f, 49.45274f, 49.45156f, 49.45039f, 49.44921f, 49.44804f, 49.44686f, 49.44568f, 49.44452f, 49.44386f, 49.44347f, 49.44597f, 49.47284f, 49.49063f,
49.49094f, 49.70902f, 49.84355f, 49.92127f, 49.97054f, 50.04808f, 50.12563f, 50.20318f, 50.28073f, 50.38752f, 50.46523f, 50.51338f, 50.59093f, 50.66847f, 50.74602f, 50.82357f, 50.90112f, 50.97867f,
51.0869f, 51.16461f, 51.24232f, 51.32003f, 51.34836f, 51.10997f, 50.16838f, 49.3719f, 49.52806f, 49.72168f, 49.91531f, 50.10893f, 50.28084f, 50.44462f, 50.6084f, 50.77218f, 50.93596f, 51.1002f,
51.26365f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.25963f, 51.46592f, 52.35697f, 53.02499f, 53.68502f, 54.13414f, 54.08902f, 53.52435f, 52.95969f, 52.39501f, 51.83036f, 51.15223f,
51.39708f, 51.64192f, 51.88676f, 52.1316f, 52.23681f, 52.08372f, 51.93066f, 51.70984f, 51.55708f, 51.40432f, 51.25156f, 51.3669f, 0f, 0f, 0f, 0f, 152.8162f, 174.6027f, 161.5278f, 156.4321f, 151.2766f,
148.0688f, 142.7735f, 138.9944f, 133.769f, 129.4653f, 106.5422f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74805f, 93.83349f, 93.8335f, 95.74805f, 95.74806f, 95.74806f, 95.74805f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 97.97363f, 111.5287f, 108.2499f, 107.5845f, 94.27095f, 77.47485f, 54.77411f, 50.60451f, 50.49886f, 50.3932f, 50.28753f, 50.18187f, 50.07621f,
49.97063f, 49.87778f, 49.7729f, 49.66988f, 49.56686f, 49.46833f, 49.45475f, 49.45358f, 49.4524f, 49.45123f, 49.45005f, 49.44888f, 49.4477f, 49.44653f, 49.44536f, 49.44424f, 49.44379f, 49.44399f,
49.44434f, 49.46503f, 49.48611f, 49.48627f, 49.48661f, 49.61633f, 49.97596f, 50.0405f, 50.11805f, 50.19559f, 50.27314f, 50.35069f, 50.42824f, 50.50579f, 50.58334f, 50.66089f, 50.73844f, 50.81599f,
50.89353f, 50.97108f, 51.04863f, 51.12618f, 51.20373f, 51.28128f, 51.35882f, 51.23086f, 50.98985f, 50.54899f, 49.31452f, 49.49187f, 49.68549f, 49.87912f, 50.07274f, 50.26637f, 50.45999f, 50.65177f,
50.81555f, 50.97933f, 51.14357f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.1715f, 51.84705f, 52.73905f, 53.40707f, 54.27282f, 54.03342f, 53.46875f, 52.90408f, 52.33941f,
51.77474f, 51.21948f, 51.46432f, 51.70918f, 51.95402f, 52.19886f, 52.19715f, 52.04407f, 51.89099f, 51.73792f, 51.51658f, 51.36382f, 51.24953f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 154.0164f, 146.1784f,
140.8724f, 135.5665f, 130.2605f, 130.4755f, 125.7933f, 121.2719f, 118.2973f, 106.2655f, 95.74799f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74805f, 93.37572f, 93.37572f, 93.37566f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 96.7159f, 111.5355f, 108.2513f, 108.4224f, 95.5392f, 80.88734f, 56.57541f, 50.61304f, 50.50937f, 50.40601f,
50.31131f, 50.19955f, 50.09632f, 50.00227f, 49.89925f, 49.79623f, 49.69507f, 49.60691f, 49.46616f, 49.46862f, 49.45293f, 49.45175f, 49.45058f, 49.44941f, 49.44823f, 49.44706f, 49.44588f, 49.44477f,
49.44417f, 49.44436f, 49.44471f, 49.44507f, 49.4614f, 49.48046f, 49.48053f, 49.48087f, 49.48121f, 49.49319f, 49.90399f, 50.18801f, 50.26556f, 50.34311f, 50.42065f, 50.4982f, 50.57575f, 50.6533f,
50.73085f, 50.8084f, 50.88594f, 50.96349f, 51.04104f, 51.11859f, 51.19614f, 51.27369f, 51.35124f, 51.25375f, 51.01274f, 50.77174f, 50.38612f, 49.30349f, 49.45567f, 49.6493f, 49.84293f, 50.03654f,
50.23017f, 50.4238f, 50.61742f, 50.81105f, 51.00467f, 51.18694f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.272f, 51.22947f, 51.78514f, 52.99001f, 53.21015f, 53.80311f, 53.73847f, 53.41315f,
52.84848f, 52.28381f, 51.71915f, 51.28674f, 51.53158f, 51.77643f, 52.02127f, 52.24491f, 52.15749f, 52.00442f, 51.85134f, 51.69826f, 51.54518f, 51.32332f, 51.34638f, 51.3669f, 51.3669f, 51.3669f, 0f,
0f, 0f, 0f, 133.7743f, 114.3206f, 114.9487f, 112.9166f, 112.5943f, 110.7318f, 109.1261f, 106.3109f, 100.7106f, 95.74805f, 95.74799f, 95.74799f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 94.99419f, 93.37557f, 93.3756f,
93.3756f, 95.74807f, 95.74807f, 95.74807f, 95.74807f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 111.5423f, 108.2526f, 107.0592f, 93.35953f, 80.21243f, 53.61454f,
50.63587f, 50.53264f, 50.42941f, 50.32618f, 50.22295f, 50.11972f, 50.01649f, 49.92259f, 49.83237f, 49.76116f, 49.58513f, 49.464f, 49.7891f, 49.45228f, 49.45111f, 49.44993f, 49.44876f, 49.44759f,
49.44641f, 49.44524f, 49.44455f, 49.44473f, 49.44508f, 49.44544f, 49.44579f, 49.45776f, 49.47481f, 49.4748f, 49.47512f, 49.47546f, 49.47467f, 49.47613f, 49.75484f, 50.19164f, 50.41307f, 50.49062f,
50.56817f, 50.64571f, 50.72326f, 50.80081f, 50.87836f, 50.9559f, 51.03345f, 51.111f, 51.18855f, 51.2661f, 51.34365f, 51.27664f, 51.03563f, 50.79462f, 50.55362f, 50.22327f, 49.29246f, 49.41948f,
49.61311f, 49.80673f, 50.00035f, 50.19398f, 50.3876f, 50.58123f, 50.77485f, 50.96848f, 51.06714f, 51.14936f, 51.20459f, 51.272f, 51.272f, 51.27578f, 51.29343f, 51.49921f, 52.16722f, 52.83522f,
54.15324f, 53.66668f, 53.11668f, 52.7929f, 52.22822f, 51.66356f, 51.354f, 51.59884f, 51.84368f, 52.08853f, 52.29455f, 52.11783f, 51.96476f, 51.81168f, 51.6586f, 51.50552f, 51.35245f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 103.5581f, 94.93071f, 92.00163f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74799f, 95.74801f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74807f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74807f, 95.74808f, 95.74808f,
95.74808f, 95.74802f, 95.36842f, 95.36842f, 95.74805f, 95.74805f, 95.74805f, 95.74802f, 95.74802f, 95.74802f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 111.3909f, 108.232f,
105.1978f, 91.31646f, 79.46289f, 50.7049f, 50.66704f, 50.55605f, 50.45281f, 50.34958f, 50.24636f, 50.14313f, 50.04571f, 49.96966f, 49.89846f, 49.75357f, 49.58601f, 49.46183f, 49.78693f, 49.99438f,
49.45046f, 49.44928f, 49.44811f, 49.44693f, 49.44576f, 49.44493f, 49.4451f, 49.44545f, 49.44581f, 49.44616f, 49.44652f, 49.45412f, 49.46916f, 49.46916f, 49.46938f, 49.46971f, 49.4689f, 49.47039f,
49.47073f, 49.6057f, 50.0425f, 50.47931f, 50.63813f, 50.71568f, 50.79322f, 50.87077f, 50.94833f, 51.02587f, 51.10342f, 51.18097f, 51.25851f, 51.33606f, 51.29953f, 51.05853f, 50.81752f, 50.57651f,
50.3355f, 50.0604f, 49.28143f, 49.38329f, 49.57691f, 49.77054f, 49.96416f, 50.15779f, 50.35141f, 50.54504f, 50.73866f, 50.76732f, 50.81703f, 50.87136f, 50.95632f, 51.04134f, 51.17641f, 51.30291f,
51.34743f, 51.8813f, 52.5493f, 53.2187f, 53.61446f, 53.04471f, 52.49489f, 52.17264f, 51.60796f, 51.42125f, 51.6661f, 51.91095f, 52.15578f, 52.34599f, 52.07818f, 51.9251f, 51.77203f, 51.61895f,
51.46587f, 51.31279f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 93.3757f, 93.42033f, 93.3757f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.74804f, 95.74799f, 93.37581f, 93.37581f, 93.37579f, 93.44126f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74807f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74802f, 95.74802f, 95.74802f, 95.74807f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74804f, 95.74802f, 95.74802f, 95.74802f, 95.74802f,
95.74803f, 95.74808f, 111.0363f, 108.2333f, 103.0346f, 89.32466f, 78.19122f, 50.7049f, 50.68267f, 50.57944f, 50.47622f, 50.37299f, 50.27831f, 50.18273f, 50.11137f, 50.03575f, 49.92384f, 49.72997f,
49.58689f, 49.45966f, 49.78476f, 50.10987f, 49.59703f, 49.44864f, 49.44746f, 49.44629f, 49.44532f, 49.44547f, 49.44582f, 49.44618f, 49.44653f, 49.44689f, 49.44724f, 49.45049f, 49.46351f, 49.46351f,
49.46362f, 49.46397f, 49.46314f, 49.46348f, 49.46382f, 49.46416f, 49.47603f, 49.89336f, 50.33016f, 50.76696f, 50.86319f, 50.94073f, 51.01828f, 51.09583f, 51.17338f, 51.25093f, 51.32848f, 51.32242f,
51.08142f, 50.84041f, 50.5994f, 50.35839f, 50.11739f, 49.87638f, 49.2704f, 49.34709f, 49.54072f, 49.73434f, 49.92797f, 50.12159f, 50.31522f, 50.46497f, 50.46772f, 50.48469f, 50.56941f, 50.62306f,
50.70875f, 50.84585f, 51.00042f, 51.13158f, 51.62384f, 52.43294f, 53.13029f, 53.80054f, 52.98624f, 52.66892f, 51.8731f, 51.55236f, 52.00993f, 51.73335f, 51.9782f, 52.22305f, 52.39923f, 52.03852f,
51.88544f, 51.73236f, 51.57159f, 51.35458f, 51.23706f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 93.3757f, 93.3757f, 93.3757f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 93.65344f, 93.3758f, 93.3758f, 93.37579f, 93.3758f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74802f, 95.74802f, 95.74803f, 95.74808f, 95.74806f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 110.6816f, 108.2347f, 95.12149f, 83.3696f, 61.67546f, 50.73492f, 50.69904f, 50.60285f, 50.49962f, 50.39667f, 50.32035f, 50.24426f,
50.17764f, 50.0941f, 49.90023f, 49.71973f, 49.58777f, 49.45749f, 49.78259f, 50.1077f, 50.4328f, 49.44767f, 49.44649f, 49.4457f, 49.44584f, 49.44619f, 49.44655f, 49.4469f, 49.44726f, 49.44762f,
49.44797f, 49.45168f, 49.45665f, 49.45665f, 49.4567f, 49.45704f, 49.45738f, 49.45772f, 49.45806f, 49.4584f, 49.45874f, 49.45907f, 49.70422f, 50.14193f, 50.57963f, 51.00118f, 51.11928f, 51.16579f,
51.24334f, 51.32089f, 51.34531f, 51.10431f, 50.8633f, 50.62229f, 50.38129f, 50.14027f, 49.89928f, 49.65827f, 49.25937f, 49.3109f, 49.50453f, 49.69815f, 49.89178f, 50.0854f, 50.16537f, 50.16813f,
50.17088f, 50.20484f, 50.28981f, 50.37626f, 50.4708f, 50.69326f, 50.82442f, 51.16116f, 52.05321f, 52.88284f, 53.71181f, 53.25655f, 52.36428f, 51.80078f, 51.43214f, 52.02149f, 50.88025f, 52.16575f,
52.41009f, 52.45424f, 51.99887f, 51.84579f, 51.69271f, 51.53963f, 51.37876f, 51.34953f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 93.3757f,
93.3757f, 93.24828f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.70223f, 93.37581f, 93.37581f, 93.37579f, 93.37581f, 95.74811f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74802f, 95.74802f, 95.74808f, 95.74808f, 95.74808f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74802f, 95.74802f, 108.152f, 6.332971f, 55.44186f, 58.30132f, 52.73503f, 51.34436f, 50.7049f, 50.62625f,
50.52977f, 50.45798f, 50.38662f, 50.31527f, 50.23038f, 50.0705f, 49.87662f, 49.7206f, 49.58865f, 49.45669f, 49.78043f, 50.10554f, 50.43064f, 50.12086f, 49.44608f, 49.44642f, 49.44678f, 49.44713f,
49.44749f, 49.44785f, 49.4482f, 49.44856f, 49.44891f, 49.44937f, 49.45098f, 49.45098f, 49.45097f, 49.45128f, 49.45162f, 49.45196f, 49.4523f, 49.45263f, 49.45297f, 49.45332f, 49.45365f, 49.55528f,
49.99208f, 50.42978f, 50.86749f, 51.2587f, 51.34486f, 51.2695f, 51.02799f, 50.78648f, 50.54498f, 50.30348f, 50.06197f, 49.82047f, 49.57896f, 49.25972f, 49.24834f, 49.27471f, 49.46834f, 49.66196f,
49.85558f, 49.86577f, 49.86853f, 49.87128f, 49.87159f, 49.95695f, 50.04376f, 50.13064f, 50.34674f, 50.51844f, 50.65791f, 51.31386f, 52.1936f, 53.02494f, 53.73259f, 52.9501f, 52.09338f, 51.46315f,
51.60468f, 51.99003f, 52.23437f, 52.47871f, 52.03738f, 52.53846f, 51.73186f, 51.5791f, 51.42633f, 51.27357f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f,
51.3669f, 0f, 0f, 0f, 0f, 93.37576f, 93.37575f, 93.37573f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 93.3758f, 93.3758f, 93.37579f,
93.3758f, 95.74811f, 95.74811f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74802f, 95.74802f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 94.78127f, 19.00383f, 31.89247f, 52.68593f, 52.73042f,
52.00627f, 51.09057f, 50.66125f, 50.59005f, 50.5611f, 50.56906f, 50.57701f, 50.55534f, 50.35181f, 50.13561f, 50.00911f, 49.90887f, 49.80862f, 49.77826f, 50.10336f, 50.42847f, 50.85579f, 49.72329f,
50.08411f, 49.4475f, 49.44786f, 49.44822f, 49.28878f, 49.44893f, 49.44928f, 49.44964f, 49.8786f, 49.87835f, 49.87875f, 49.87917f, 49.55233f, 49.44586f, 49.4462f, 49.44654f, 49.44687f, 49.44721f,
49.44755f, 56.34632f, 55.22585f, 54.04266f, 53.83334f, 53.62402f, 53.4147f, 53.20537f, 51.05079f, 50.80928f, 50.56778f, 50.32627f, 50.08476f, 49.84325f, 49.60175f, 49.36024f, 49.2361f, 49.23731f,
49.23851f, 49.43214f, 49.56342f, 49.56618f, 49.56894f, 49.57169f, 49.57445f, 49.62444f, 49.71127f, 49.79809f, 49.96868f, 50.18887f, 50.34835f, 50.80369f, 51.79045f, 52.62179f, 53.42606f, 52.99803f,
52.21673f, 51.46249f, 51.57888f, 51.92617f, 52.29403f, 52.14964f, 51.99688f, 51.84412f, 51.9038f, 51.5386f, 51.38583f, 51.23307f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 93.37575f, 93.37573f, 93.37572f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74806f, 95.74808f, 95.54289f, 95.74805f, 95.74806f, 95.74811f, 95.74811f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74802f, 95.74802f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74806f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 94.69928f, 93.37572f,
52.44952f, 52.494f, 52.4745f, 51.67231f, 50.87011f, 50.78578f, 51.30749f, 51.31545f, 51.32341f, 51.28515f, 51.19057f, 51.06722f, 50.85103f, 50.69881f, 50.59856f, 50.49831f, 49.77609f, 50.1012f,
50.4263f, 50.75141f, 50.64855f, 52.58459f, 49.44823f, 49.44859f, 49.44894f, 49.4493f, 49.44966f, 50.96424f, 50.64209f, 50.4604f, 50.46004f, 50.45975f, 50.46015f, 50.46057f, 50.95259f, 49.82048f,
49.44077f, 49.44111f, 49.44145f, 67.9336f, 63.26052f, 61.49146f, 59.7224f, 58.33986f, 58.13054f, 57.92122f, 57.71191f, 57.50259f, 50.59056f, 50.34906f, 50.10755f, 49.86604f, 49.62454f, 49.38303f,
49.14153f, 49.22521f, 49.22628f, 49.22447f, 49.26382f, 49.26658f, 49.26933f, 49.27209f, 49.27485f, 49.32552f, 49.41216f, 49.49881f, 49.58598f, 49.811f, 50.04141f, 50.29153f, 51.30797f, 52.21865f,
53.04998f, 53.04476f, 52.26347f, 51.5158f, 51.6853f, 51.94641f, 52.24301f, 52.21514f, 52.03439f, 51.8799f, 51.72683f, 51.62709f, 51.44144f, 52.05891f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 93.37573f, 93.37572f, 93.3757f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74811f, 95.74811f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74802f, 95.74802f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74805f, 94.69926f, 52.2131f, 52.25759f, 52.30207f, 52.08395f, 51.28175f, 50.85503f, 50.87726f, 50.89949f, 52.06981f, 51.96962f, 51.87503f, 51.78045f, 51.68586f, 51.56644f, 51.38851f, 51.28826f,
51.18801f, 51.08776f, 50.09903f, 50.42414f, 50.74924f, 51.57169f, 50.2514f, 49.44896f, 50.84465f, 51.41569f, 51.1796f, 51.16249f, 51.14537f, 51.1311f, 51.06271f, 51.04185f, 51.04149f, 51.04116f,
51.13f, 51.13f, 51.13f, 51.13f, 51.13f, 61.50184f, 62.81278f, 64.1237f, 65.51195f, 64.8686f, 63.10321f, 61.66223f, 61.45335f, 61.24446f, 62.00913f, 60.96502f, 50.13033f, 49.88883f, 49.64732f,
49.26791f, 49.22203f, 49.2229f, 49.21706f, 49.22543f, 49.22802f, 49.2306f, 49.23318f, 49.23577f, 49.2347f, 49.23311f, 49.08052f, 49.16717f, 49.25381f, 49.43238f, 49.69015f, 49.87354f, 50.79619f,
51.80966f, 52.64684f, 53.09152f, 52.3102f, 51.58373f, 51.84485f, 52.10596f, 52.32518f, 52.18783f, 52.02575f, 51.84459f, 51.68716f, 51.53409f, 51.37461f, 54.16632f, 53.73637f, 51.65695f, 51.33755f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 93.37572f, 93.37572f, 93.37569f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74811f, 95.74811f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74802f, 95.74804f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74805f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 94.69923f, 52.02117f, 52.06566f, 52.11015f, 51.69341f, 50.92429f, 50.94651f, 50.96875f, 50.99097f, 52.65409f, 52.14005f, 52.14003f, 52.14019f, 52.14063f,
52.14107f, 52.07821f, 51.97796f, 51.87771f, 51.77745f, 51.6772f, 50.42197f, 50.74707f, 49.44357f, 51.40376f, 51.28257f, 51.21756f, 51.15256f, 51.18509f, 51.26583f, 51.15093f, 51.13385f, 51.1311f,
51.13063f, 51.13028f, 51.13f, 51.13f, 51.13f, 51.13f, 51.13f, 51.13f, 51.49411f, 56.61558f, 57.92651f, 59.23744f, 61.87006f, 63.88836f, 65.88352f, 65.94754f, 65.73865f, 65.52975f, 65.32087f,
49.22285f, 49.22286f, 49.22287f, 49.22288f, 49.2229f, 49.2229f, 49.2229f, 49.23614f, 49.23439f, 49.23515f, 49.23356f, 49.23197f, 49.23038f, 49.22879f, 49.2272f, 48.92216f, 49.0541f, 49.31177f,
49.56095f, 50.28405f, 51.30085f, 52.24371f, 53.04204f, 52.35696f, 51.74329f, 52.00439f, 52.25934f, 52.23368f, 52.09632f, 51.95897f, 51.82103f, 51.65479f, 51.49443f, 51.3669f, 51.3669f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 93.37571f, 93.37569f, 93.37568f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74811f, 95.74811f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74802f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 94.69923f, 93.37558f, 51.87373f, 51.91822f, 51.30286f, 51.01577f, 51.038f, 51.06023f, 51.08246f, 52.13979f, 52.13977f, 52.13975f,
52.13972f, 52.1397f, 52.14011f, 52.14056f, 52.141f, 52.1489f, 52.15578f, 52.16265f, 51.83823f, 51.98709f, 52.16184f, 51.80382f, 51.57252f, 51.50751f, 51.4425f, 51.3775f, 51.28952f, 51.15435f,
51.13728f, 51.1311f, 51.13046f, 51.1301f, 51.13f, 51.13f, 51.13f, 51.13f, 51.13f, 51.13f, 51.13f, 51.11991f, 51.72932f, 53.04026f, 55.52103f, 56.97244f, 59.03391f, 61.02909f, 63.02429f, 65.01946f,
49.22288f, 49.22287f, 49.22288f, 49.22289f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.22623f, 49.2274f, 49.22857f, 49.22924f, 49.22765f, 49.22607f, 49.22448f, 49.22289f, 48.67654f, 48.93349f,
49.19115f, 49.77191f, 50.78872f, 51.80386f, 52.66188f, 52.40371f, 51.90284f, 52.16395f, 52.27954f, 52.14218f, 52.00013f, 51.78349f, 51.65199f, 51.59276f, 51.45449f, 51.3669f, 51.3669f, 51.3669f,
51.3669f, 51.3669f, 51.70277f, 51.3669f, 51.3669f, 51.28233f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 93.3757f, 93.37569f, 93.37567f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74809f, 95.74811f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74802f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74806f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 94.69924f, 93.3756f, 51.6818f, 51.71451f, 51.08502f, 51.10725f, 51.12948f, 51.15171f, 51.17394f, 52.13951f, 52.13949f,
52.13947f, 52.13944f, 52.13942f, 52.1394f, 52.1396f, 52.14581f, 52.15457f, 52.15955f, 51.96624f, 51.93024f, 52.05568f, 52.20542f, 52.13269f, 51.92679f, 51.79746f, 51.73246f, 51.66745f, 51.55808f,
51.30038f, 51.1407f, 51.13106f, 51.13033f, 51.13f, 51.13f, 51.13f, 51.13f, 51.13f, 51.13f, 50.99198f, 50.65518f, 50.40763f, 50.21661f, 50.02559f, 50.02966f, 50.64902f, 52.07483f, 54.1652f, 49.22288f,
49.22288f, 49.22288f, 49.22289f, 49.2229f, 49.22291f, 49.22292f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.22016f, 49.21857f, 48.55593f, 48.24434f,
49.25977f, 50.27657f, 51.29338f, 52.26875f, 52.45044f, 52.06239f, 52.31323f, 52.18803f, 52.05068f, 51.91332f, 51.77132f, 51.59159f, 51.50544f, 51.44735f, 51.3669f, 51.3669f, 51.3669f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 93.37569f, 93.37567f, 93.37566f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74805f, 95.74808f, 95.74811f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74802f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 93.48203f, 51.25987f, 51.26062f, 51.32396f, 51.17651f, 51.19873f, 51.22096f, 51.24319f, 51.26543f, 52.13923f, 52.13921f,
52.13918f, 52.13916f, 52.13914f, 52.13993f, 52.14272f, 52.14959f, 52.15013f, 52.11078f, 52.0747f, 52.03862f, 52.15386f, 52.27283f, 52.35942f, 52.1741f, 52.09455f, 52.0224f, 51.9574f, 51.82665f,
51.56894f, 51.31124f, 51.13097f, 51.13024f, 51.13f, 51.13f, 51.13f, 51.13f, 50.91076f, 50.57164f, 50.2322f, 49.9296f, 49.7384f, 49.54738f, 49.35636f, 49.36227f, 49.2229f, 49.2229f, 49.22291f,
49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.22292f, 49.22293f, 49.22294f, 49.22293f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 47.73639f,
48.74899f, 49.76444f, 50.78122f, 51.79753f, 52.14154f, 52.28124f, 52.23389f, 52.09653f, 51.95918f, 51.83711f, 51.75005f, 51.66203f, 51.54554f, 51.45866f, 51.3734f, 51.3669f, 51.3669f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 93.3756f, 93.3756f, 93.3756f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74811f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74802f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 93.37568f, 93.37567f, 51.26042f, 51.24576f, 51.26192f, 51.26268f, 51.26342f, 51.26418f, 51.35691f, 52.13895f,
52.13892f, 52.1389f, 52.13894f, 52.14133f, 52.14373f, 52.14649f, 52.15337f, 52.18705f, 52.20304f, 52.16695f, 52.14076f, 52.22714f, 52.31653f, 52.40311f, 52.39852f, 52.34186f, 52.26271f, 52.24734f,
52.09521f, 51.85874f, 51.64398f, 51.13089f, 51.13008f, 51.13f, 51.13f, 50.82753f, 50.4881f, 50.14867f, 49.80924f, 49.4698f, 49.26021f, 49.22327f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.22293f,
49.22292f, 49.22292f, 49.22292f, 49.2229f, 49.22292f, 49.22294f, 49.22295f, 49.22296f, 49.22295f, 49.22292f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f,
47.92456f, 49.02879f, 50.1361f, 51.65676f, 52.29044f, 52.19653f, 52.10804f, 52.05276f, 51.9657f, 51.87864f, 51.79157f, 51.70451f, 51.61649f, 51.49987f, 51.41299f, 51.3669f, 51.3669f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 93.3756f, 93.3756f,
93.3756f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74811f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74803f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74805f, 95.83508f, 95.59445f, 91.31418f, 78.17253f, 51.22353f, 51.26097f, 51.26173f, 51.26248f, 51.26323f, 51.26398f, 51.26473f,
52.13555f, 52.13795f, 52.14035f, 52.14275f, 52.14514f, 52.14754f, 52.15027f, 52.15714f, 52.19939f, 52.24479f, 52.24226f, 52.22313f, 52.27804f, 52.36023f, 52.44681f, 52.49885f, 52.49715f, 52.49512f,
52.45735f, 52.42772f, 52.23282f, 52.01806f, 51.8033f, 51.13f, 51.13f, 51.13f, 50.92801f, 50.55177f, 50.17553f, 49.7993f, 49.42307f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.22292f,
49.22295f, 49.22295f, 49.22295f, 49.22292f, 49.2229f, 49.22293f, 49.22296f, 49.22298f, 49.22298f, 49.22298f, 49.22295f, 49.22292f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f,
49.2229f, 48.39359f, 49.49781f, 50.60514f, 52.11542f, 51.13986f, 52.18134f, 52.09428f, 52.00722f, 51.92016f, 51.8331f, 51.74604f, 51.65898f, 51.57191f, 51.48486f, 51.39862f, 51.3669f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 93.3756f,
93.3756f, 93.3756f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74809f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74803f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74806f, 95.79428f, 97.06841f, 84.20543f, 60.59481f, 51.17976f, 51.2218f, 51.26153f, 51.26228f, 51.26303f, 51.26379f,
51.26453f, 51.26528f, 52.13836f, 52.14415f, 52.14655f, 52.14895f, 52.15135f, 52.15405f, 52.17896f, 52.22435f, 52.26974f, 52.31512f, 52.31539f, 52.34161f, 52.40393f, 52.49051f, 52.51446f, 52.51276f,
52.51095f, 52.50916f, 52.50399f, 52.49729f, 52.49059f, 52.17738f, 51.13f, 51.13f, 51.13f, 51.13f, 50.93555f, 50.55931f, 50.18308f, 49.80684f, 49.28566f, 49.2229f, 49.2229f, 49.2229f, 49.22291f,
49.22295f, 49.22297f, 49.22297f, 49.22294f, 49.22292f, 49.2229f, 49.22293f, 49.22296f, 49.22299f, 49.22302f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 49.2229f,
49.2229f, 49.2229f, -63.50472f, -43.22124f, -21.55899f, 2.123939f, 25.69393f, 51.65133f, 52.04874f, 51.96169f, 51.87463f, 51.78756f, 51.7005f, 51.61344f, 51.52638f, 51.43932f, 51.3669f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f,
93.37568f, 93.3756f, 93.37564f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74807f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.43147f, 96.49654f, 82.77819f, 57.12159f, 51.13599f, 51.16483f, 51.26133f, 51.26208f, 51.26284f,
51.26358f, 51.26434f, 51.26509f, 52.14557f, 52.14796f, 52.15036f, 52.15276f, 52.15516f, 52.15852f, 52.20391f, 52.2493f, 52.29469f, 52.34008f, 52.39851f, 52.40817f, 52.44762f, 52.52982f, 52.53007f,
52.52837f, 52.5246f, 52.52349f, 52.52322f, 52.51659f, 52.50997f, 52.50316f, 51.13f, 51.13f, 51.13f, 51.13f, 51.13f, 50.94308f, 50.56685f, 50.19062f, 49.81438f, 49.2229f, 49.2229f, 49.2229f, 49.22294f,
49.22298f, 49.22298f, 49.22296f, 49.22294f, 49.22292f, 49.22291f, 49.22294f, 49.22297f, 49.223f, 49.17747f, 49.2229f, 49.2229f, 49.2229f, 49.2229f, 47.35666f, 47.63733f, 49.2229f, 49.2229f, 49.2229f,
49.2229f, -61.09816f, -57.28933f, -58.05696f, -37.71625f, -17.31584f, 6.317056f, 31.11553f, 52.0032f, 51.91615f, 51.82909f, 51.74202f, 51.65497f, 51.56791f, 51.48084f, 51.39497f, 51.3669f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f,
93.37569f, 93.37567f, 93.37566f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74807f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 96.19299f, 94.78811f, 79.794f, 54.08254f, 51.09212f, 51.10775f, 51.21275f, 51.26189f, 51.26264f,
51.26339f, 51.26414f, 51.26489f, 52.15695f, 52.1573f, 53.05936f, 52.63774f, 52.21612f, 51.7945f, 51.46762f, 51.6526f, 51.83854f, 52.02449f, 52.00034f, 52.44663f, 52.49678f, 52.55102f, 52.54908f,
52.54536f, 52.53806f, 52.53786f, 52.5387f, 52.53953f, 52.54391f, 52.54259f, 51.13203f, 51.13f, 51.13f, 51.13f, 51.13f, 51.13f, 50.95097f, 50.57474f, 50.19851f, 49.2229f, 49.2229f, 49.22293f,
49.22297f, 49.22302f, 49.22298f, 49.22296f, 49.22293f, 49.22291f, 49.29451f, 57.87253f, 53.48573f, 49.75151f, 49.10302f, 49.16161f, 49.22276f, 49.2229f, 49.2229f, 49.2229f, 49.17735f, 49.2229f,
49.2229f, -60.60095f, -65.32687f, -67.02995f, -63.22147f, -59.41263f, -51.2155f, -32.21979f, -13.00053f, 10.4498f, 35.9118f, 51.81441f, 51.78344f, 51.69638f, 51.60932f, 51.52225f, 51.4352f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f,
0f, 0f, 0f, 0f, 93.37569f, 93.37568f, 93.37566f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.66629f, 84.99013f, 71.26328f, 56.93886f, 51.04812f, 51.06253f, 51.15547f,
51.26046f, 51.26244f, 51.26319f, 51.26394f, 51.29264f, 53.53561f, 53.11399f, 52.69237f, 52.27074f, 51.84912f, 51.4275f, 51.00588f, 50.69027f, 50.87322f, 51.06476f, 51.59222f, 52.10963f, 52.54137f,
52.56308f, 52.56043f, 52.55627f, 52.55157f, 52.55261f, 52.55614f, 52.55968f, 52.56322f, 51.55742f, 51.38813f, 51.5508f, 51.13665f, 51.13f, 51.13f, 51.13f, 51.30545f, 51.12991f, 50.56641f, 50.26328f,
49.31357f, 49.31243f, 49.29987f, 49.2593f, 62.37435f, 63.77554f, 65.17673f, 66.5779f, 62.33347f, 57.66653f, 53.64618f, 50.16705f, 49.03431f, 49.08702f, 49.3632f, 52.39484f, 56.41293f, 54.13046f,
49.26869f, 48.78043f, -35.51197f, -65.57722f, -66.9681f, -66.91222f, -69.15289f, -65.34477f, -61.044f, -47.13713f, -26.90885f, -9.178949f, 15.00395f, 39.06223f, 51.63422f, 51.65059f, 51.56353f,
51.47647f, 51.39091f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 93.37569f, 93.37569f, 93.37567f, 93.37566f, 95.74805f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f,
95.74802f, 95.74802f, 95.74802f, 95.74799f, 95.74799f, 95.74799f, 95.74799f, 95.74799f, 95.74799f, 95.748f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 93.37599f,
93.37595f, 93.37598f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 62.19304f, 53.0567f, 50.98961f,
51.00411f, 51.01852f, 51.09819f, 51.20322f, 51.26224f, 51.263f, 52.39258f, 52.93562f, 53.17922f, 52.74699f, 52.32537f, 51.90375f, 51.48212f, 51.0605f, 50.63888f, 50.21623f, 50.13724f, 50.7206f,
51.30198f, 51.93693f, 52.4917f, 52.57598f, 52.56639f, 52.54933f, 52.55631f, 52.57178f, 52.57545f, 52.57899f, 52.55146f, 51.96949f, 51.39191f, 51.5508f, 51.5508f, 51.53305f, 51.62999f, 52.78358f,
54.85686f, 51.41471f, 55.10657f, 55.22401f, 54.91449f, 54.83859f, 54.7627f, 52.33903f, 58.72737f, 60.12565f, 61.52396f, 62.92224f, 61.32493f, 56.6726f, 53.04831f, 49.90689f, 49.03434f, 49.03431f,
50.06524f, 51.81855f, 53.18559f, 41.42469f, 27.63252f, -24.08207f, -41.9501f, -66.48989f, -66.77734f, -67.44376f, -68.11016f, -68.94514f, -66.96738f, -60.63253f, -41.6948f, -23.05539f, -5.121246f,
19.79656f, 42.04545f, 51.43434f, 51.51775f, 51.43068f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f,
51.35867f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 93.3757f, 93.37569f, 93.37568f, 93.64206f, 95.74802f, 95.74807f, 95.74805f, 95.74802f, 95.74802f,
95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74803f, 95.74799f, 95.74799f, 95.74799f, 95.74799f, 95.74799f, 95.74799f, 95.74799f, 95.74799f, 95.74799f, 95.74799f, 95.74799f,
95.74799f, 95.74805f, 95.74805f, 93.37593f, 93.37601f, 93.37607f, 95.74802f, 95.74803f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 50.89875f, 50.91856f, 50.93837f, 50.95818f, 50.97451f, 51.04091f, 51.14594f, 51.25092f, 51.65969f, 52.20533f, 52.74841f, 53.21926f, 52.37787f, 51.95837f, 51.53675f, 51.11512f, 50.69325f,
50.2463f, 49.7261f, 49.65998f, 50.33882f, 51.00554f, 51.69471f, 52.38807f, 52.54272f, 52.51299f, 52.52268f, 52.5475f, 52.5723f, 52.59428f, 52.59772f, 52.55087f, 51.96889f, 51.5508f, 51.5508f,
51.55117f, 51.57422f, 52.23471f, 53.38832f, 54.65628f, 55.29471f, 54.89865f, 55.01608f, 54.82783f, 54.75195f, 54.67604f, 53.80251f, 54.41306f, 55.67812f, 57.07643f, 58.4747f, 58.41104f, 55.67669f,
51.54977f, 49.72097f, 49.13587f, 49.03434f, 49.80801f, 50.94512f, 44.49136f, 37.57801f, 21.0737f, -17.92845f, -39.17957f, -60.77198f, -67.69741f, -68.36383f, -69.03023f, -70.02955f, -71.14449f,
-66.68346f, -56.57355f, -36.92971f, -19.89123f, -1.082548f, 24.56414f, 45.02519f, 51.37244f, 51.38667f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.1655f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 93.37571f, 93.3757f, 93.37568f, 95.74802f, 95.74802f,
95.74802f, 95.74808f, 95.74805f, 95.74805f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74805f, 95.74804f, 95.74799f, 95.74799f, 95.74799f, 95.74799f, 95.74799f, 95.74799f, 95.74799f, 95.74799f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74804f, 93.37601f, 93.37618f, 93.37595f, 95.74808f, 95.74803f, 95.74802f, 95.74803f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 94.67215f, 50.84736f, 50.86717f, 50.88698f, 50.9068f, 50.92671f, 50.98015f, 51.08494f, 51.18982f, 51.49282f, 52.03698f, 52.55047f, 51.36499f, 51.86998f,
51.59137f, 51.16975f, 50.74454f, 50.23632f, 49.73512f, 49.36028f, 49.21486f, 49.87762f, 50.74343f, 51.4525f, 52.52169f, 52.49122f, 52.51377f, 52.5383f, 52.56282f, 52.58735f, 52.59855f, 52.56023f,
52.55035f, 51.96863f, 51.5508f, 51.5508f, 51.66188f, 52.44449f, 52.83945f, 53.99304f, 54.46361f, 54.57329f, 54.69072f, 54.8079f, 54.74118f, 54.66529f, 54.5894f, 55.31327f, 57.77813f, 54.52799f,
52.75829f, 54.02718f, 54.67297f, 53.05433f, 50.08107f, 49.19474f, 48.95795f, 49.03436f, 49.01049f, 48.31767f, 40.50164f, 25.66032f, 12.23793f, -19.44742f, -42.1488f, -63.74121f, -68.61749f,
-69.28389f, -69.95029f, -71.08284f, -70.44245f, -69.50459f, -66.11965f, -51.38083f, -33.0366f, -16.72911f, 2.969137f, 29.91024f, 48.10853f, 51.37762f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 50.99381f, 51.51854f, 51.3669f, 53.41702f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 0f, 0f, 0f, 0f, 93.37572f,
93.3757f, 93.37569f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74808f, 95.74805f, 95.74805f, 95.74805f, 93.69623f, 95.74805f, 95.74805f, 95.74799f, 95.74799f, 95.74799f, 95.74799f, 95.74805f,
95.74805f, 95.74805f, 95.74806f, 95.74808f, 95.74808f, 95.74807f, 95.74802f, 95.74802f, 95.74802f, 95.74808f, 95.74786f, 95.74793f, 95.74808f, 95.74802f, 95.74806f, 95.74808f, 95.74805f, 95.74805f,
95.74802f, 95.74802f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.68888f, 90.82812f, 50.79441f, 50.81578f, 50.83567f, 50.8575f, 50.8816f, 50.92167f, 51.02296f, 51.13573f, 51.34899f,
51.58516f, 51.39431f, 51.37472f, 51.50399f, 51.22233f, 50.7499f, 50.33439f, 49.84579f, 49.57093f, 49.29607f, 48.75367f, 49.41643f, 50.0792f, 51.36832f, 52.50492f, 52.52944f, 52.55397f, 52.57872f,
52.59526f, 52.5475f, 52.49186f, 52.51876f, 52.54566f, 52.03754f, 51.5508f, 51.5508f, 51.82517f, 52.89121f, 53.44418f, 54.19698f, 54.26609f, 54.36536f, 54.483f, 54.60594f, 54.67397f, 54.57864f,
54.51794f, 56.82533f, 59.6411f, 58.64177f, 55.34647f, 52.05123f, 50.28396f, 49.75611f, 47.93819f, 47.5431f, 47.21557f, 49.68906f, 48.52548f, 43.79206f, 34.91214f, 28.69792f, 10.71921f, -20.66202f,
-45.11828f, -65.12837f, -67.71946f, -70.09734f, -70.86221f, -70.61632f, -69.7356f, -68.85294f, -67.82664f, -65.41527f, -47.04773f, -29.99815f, -13.63121f, 7.071861f, 34.21256f, 51.11604f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 53.90902f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f,
51.3669f, 0f, 0f, 0f, 0f, 93.37573f, 93.37571f, 93.37569f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74808f, 95.4464f, 93.3756f, 93.3756f, 93.3756f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74807f, 95.74805f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74808f, 95.74808f, 95.74786f, 95.74792f, 95.74805f, 95.74808f, 95.74802f, 95.74805f,
95.74805f, 95.74811f, 95.74806f, 95.74805f, 95.74805f, 95.74805f, 95.74802f, 95.74808f, 95.74808f, 95.74805f, 93.3757f, 50.72174f, 50.7439f, 50.766f, 50.78981f, 50.81392f, 50.83802f, 50.83698f,
50.87638f, 51.1455f, 51.35773f, 51.42085f, 51.40384f, 51.38445f, 51.23946f, 50.93427f, 50.42252f, 50.05645f, 49.78158f, 49.50672f, 49.23186f, 48.95699f, 49.14834f, 52.57036f, 53.19465f, 53.81894f,
52.56963f, 52.59422f, 52.40976f, 52.43671f, 52.46027f, 52.48717f, 52.51409f, 52.54115f, 52.08705f, 51.5508f, 51.5508f, 52.14792f, 53.22187f, 53.94009f, 53.99048f, 54.06916f, 54.15721f, 54.2869f,
54.41901f, 54.52732f, 54.49202f, 55.52163f, 58.3374f, 61.15316f, 62.75559f, 59.46029f, 56.16505f, 53.11474f, 46.18627f, 44.29017f, 45.51225f, 45.67125f, 60.27188f, 52.21792f, 44.16397f, 37.05942f,
29.30145f, 9.200223f, -21.87268f, -48.08753f, -62.00378f, -64.59486f, -67.42245f, -71.2406f, -70.05698f, -69.0454f, -68.1469f, -67.20318f, -66.2472f, -65.67121f, -49.07372f, -32.21486f, -15.00521f,
11.18216f, 38.80544f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 53.16528f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.34144f, 50.93058f, 0f, 0f, 0f, 0f, 93.37572f, 93.37572f, 93.3757f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.4464f, 93.37559f, 93.3756f,
93.3756f, 95.74807f, 95.74806f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74808f, 95.74808f, 95.74808f, 95.74786f, 95.74793f, 95.74805f,
95.74805f, 95.74808f, 95.74802f, 95.74805f, 95.74805f, 95.74806f, 95.74811f, 95.74808f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 94.66331f, 50.76556f, 50.76208f, 50.75861f, 50.75443f,
50.74956f, 50.77034f, 50.79467f, 50.81326f, 50.90826f, 51.15942f, 51.35239f, 51.4249f, 51.4087f, 51.38491f, 50.79432f, 50.49009f, 50.26401f, 49.9891f, 49.71419f, 49.43928f, 49.16765f, 48.52242f,
50.91862f, 51.54291f, 52.16721f, 52.65437f, 52.50276f, 52.37818f, 52.40532f, 52.43246f, 52.45598f, 52.48306f, 52.51015f, 52.53724f, 52.19026f, 51.54761f, 51.5508f, 52.36526f, 53.9275f, 54.09074f,
53.78788f, 53.87045f, 53.90199f, 53.98052f, 54.18034f, 54.35717f, 54.44873f, 57.01974f, 59.82257f, 62.6254f, 65.42827f, 63.57407f, 61.9546f, 57.27494f, 42.87657f, 40.92091f, 40.13948f, 69.52377f,
61.46974f, 53.41579f, 45.49669f, 41.88221f, 28.6026f, 7.790806f, -23.1698f, -51.05701f, -58.87919f, -62.51052f, -71.2406f, -71.2406f, -70.74177f, -69.30531f, -67.86693f, -66.60171f, -66.2472f,
-66.2472f, -66.00868f, -52.69381f, -35.83471f, -9.278904f, 15.10549f, 51.3669f, 51.3669f, 51.35891f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f,
51.3669f, 51.3669f, 53.1395f, 51.3669f, 51.3669f, 51.34419f, 50.98631f, 50.17949f, 50.45653f, 0f, 0f, 0f, 0f, 93.37573f, 93.37572f, 93.37571f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f,
95.74802f, 95.74802f, 93.3756f, 93.37558f, 93.92281f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74786f, 95.74792f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74802f, 95.74805f, 95.74805f, 95.74805f, 95.7481f, 95.74811f, 95.74811f, 95.74805f, 95.74805f, 95.74805f, 94.46664f, 95.04133f,
50.77436f, 50.77088f, 50.76741f, 50.76324f, 50.75837f, 50.75349f, 50.75285f, 50.768f, 50.9015f, 51.09829f, 51.27857f, 51.42365f, 51.36162f, 50.97692f, 50.70148f, 50.42605f, 50.15063f, 49.87519f,
49.59976f, 49.32433f, 49.02041f, 48.54892f, 49.89117f, 50.51546f, 51.13975f, 51.76404f, 52.07736f, 51.95928f, 51.99543f, 52.18562f, 52.22171f, 52.2578f, 52.39842f, 52.76522f, 52.84103f, 51.68456f,
51.45805f, 52.5826f, 54.67053f, 54.17216f, 53.7408f, 53.61804f, 53.64659f, 53.67191f, 53.83943f, 54.06518f, 54.44009f, 57.06615f, 59.72379f, 62.38143f, 65.03907f, 67.68784f, 64.3926f, 48.65387f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, 62.6676f, 53.61747f, 50.2006f, 43.27225f, 27.90366f, 6.85896f, -24.46717f, -53.20791f, -59.4696f, -69.93669f, -71.2406f, -71.2406f, -71.2406f, -69.99008f,
-68.55171f, -67.11533f, -66.2472f, -66.2472f, -66.2472f, -66.2472f, -56.32759f, -39.45494f, -6.138736f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 52.40369f, 51.3669f, 51.35012f, 50.4274f, 50.5618f, 50.69619f, 50.97182f, 0f, 0f, 0f, 0f, 93.37573f, 93.37573f, 93.37572f, 95.74802f,
95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.748f, 95.74792f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74802f, 95.74803f, 95.74805f, 95.74805f, 95.74805f, 95.7481f, 95.74811f, 95.74811f,
95.74809f, 95.40644f, 103.4362f, 116.52f, 58.31674f, 50.77969f, 50.77621f, 50.77205f, 50.76717f, 50.7623f, 50.75741f, 50.7536f, 50.82316f, 51.00597f, 51.18624f, 51.37904f, 51.22874f, 50.96036f,
50.68086f, 50.33151f, 50.05599f, 49.79905f, 49.53572f, 49.26029f, 47.60948f, 48.17015f, 48.73082f, 49.48801f, 50.11231f, 50.7366f, 51.35455f, 51.40675f, 51.44283f, 51.47893f, 51.58524f, 52.69034f,
53.54084f, 53.62698f, 53.72089f, 53.72088f, 53.72087f, 53.72086f, 54.53176f, 53.98656f, 53.55531f, 53.29063f, 53.3198f, 53.40905f, 53.58541f, 53.83391f, 54.26481f, 56.16974f, 58.82738f, 61.48504f,
64.14267f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, 47.86353f, 58.47959f, 55.06273f, 43.99157f, 27.20482f, 6.069661f, -28.12974f, -56.42879f, -67.11504f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -70.67485f, -69.23649f, -67.82363f, -66.48582f, -66.2472f, -66.2472f, -66.2472f, -66.2472f, -65.27062f, -42.27797f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.67778f, 51.18711f, 50.80971f, 50.94411f, 51.07851f, 51.2129f, 51.48713f, 0f, 0f, 0f, 0f,
93.3757f, 93.3757f, 93.3757f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74799f, 95.74792f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74802f, 95.74802f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.7481f, 95.74811f, 95.74811f, 100.5569f, 114.2267f, 106.1403f, 83.09738f, 51.70741f, 50.78475f, 50.78081f, 50.77586f, 50.77043f, 50.76501f, 50.75959f, 50.75417f, 50.91364f,
51.09392f, 50.97569f, 50.91106f, 50.84642f, 50.60188f, 50.28162f, 49.9217f, 49.59701f, 49.29937f, 49.20079f, 48.52438f, 48.52398f, 48.52364f, 48.5233f, 49.08485f, 49.70914f, 50.33212f, 50.70005f,
50.74747f, 51.35652f, 53.39344f, 54.31209f, 54.24448f, 53.92096f, 53.72083f, 53.72091f, 53.72089f, 53.72088f, 54.33736f, 53.90687f, 53.47645f, 53.07538f, 53.11803f, 53.2532f, 53.38839f, 53.618f,
54.11872f, 55.27335f, 57.93099f, 60.58864f, 47.86584f, -71.2406f, -71.09384f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, 59.92486f, 44.04375f, 26.50587f, 0.2393384f,
-53.38787f, -64.07424f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.23729f, -69.92133f, -68.53253f, -67.18176f, -66.24387f, -66.08031f, -66.2472f, -66.2472f, -66.2472f, -56.81812f,
51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 50.16242f, 51.19202f, 51.31125f, 51.46082f,
51.59522f, 51.72961f, 52.00242f, 0f, 0f, 0f, 0f, 93.3757f, 93.3757f, 93.3757f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f,
95.74802f, 95.74802f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74807f, 95.74792f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f,
95.74802f, 95.74802f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.7481f, 96.70398f, 112.7128f, 108.5762f, 99.28985f, 87.03617f, 62.86572f, 50.78601f, 50.7866f, 50.78281f, 50.77739f,
50.77197f, 50.76655f, 50.76113f, 50.81854f, 50.5024f, 50.54047f, 50.47583f, 50.41121f, 50.34658f, 50.28194f, 49.96646f, 49.67284f, 49.34882f, 49.10468f, 48.52482f, 48.52449f, 48.52415f, 48.52382f,
48.52348f, 48.71794f, 49.31837f, 49.93447f, 52.09673f, 54.13416f, 54.81758f, 54.54609f, 54.22247f, 53.89885f, 53.72036f, 53.72093f, 53.72092f, 53.72091f, 53.72089f, 53.71249f, 53.16516f, 52.79302f,
52.94524f, 53.08147f, 53.2177f, 53.40153f, 53.96564f, 54.56518f, 56.81157f, -36.87803f, -50.33077f, -71.01353f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, 27.09184f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -70.60643f, -69.24928f, -67.95424f, -67.31505f, -65.53256f,
-63.83829f, -65.86026f, -66.45032f, -43.17514f, 51.3669f, 53.24563f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.37053f, 51.38742f,
51.43994f, 51.68579f, 51.70873f, 52.13792f, 51.97753f, 52.11193f, 52.24632f, 52.51772f, 0f, 0f, 0f, 0f, 93.37571f, 93.37571f, 93.37571f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f,
95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74807f, 95.74792f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74802f, 95.74802f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 97.07705f, 110.9493f, 112.5307f, 105.811f, 94.18839f,
81.93472f, 61.72674f, 50.78495f, 50.78629f, 50.7866f, 50.78425f, 50.77893f, 50.77351f, 50.76809f, 50.76267f, 50.16987f, 50.10524f, 50.04062f, 49.97599f, 49.91352f, 49.85156f, 49.78959f, 49.72242f,
49.59857f, 49.48151f, 48.52534f, 48.52501f, 48.52467f, 48.52433f, 48.52407f, 48.52372f, 48.52343f, 48.77871f, 52.29868f, 54.15316f, 54.40546f, 54.47607f, 54.1559f, 53.8317f, 53.72f, 53.72095f,
53.72095f, 53.72094f, 53.72092f, 51.69749f, 52.03347f, 52.39395f, 52.72321f, 52.87753f, 53.02551f, 53.18443f, 53.68618f, 54.57689f, 54.70309f, -49.87461f, -63.32745f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.23566f, -70.37093f, -69.62997f, -69.54845f, -69.46692f, -69.38538f, -69.30386f, -45.07006f, 51.7294f, 51.69734f, 51.3669f, 51.25373f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.3669f, 51.36821f,
51.38598f, 51.41907f, 51.55347f, 51.68786f, 51.82225f, 51.95665f, 52.09105f, 52.22544f, 54.6866f, 52.49424f, 52.62864f, 52.76303f, 53.03302f, 0f, 0f, 0f, 0f, 93.37573f, 93.3757f, 93.3757f, 95.74802f,
95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74803f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74793f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74802f, 95.74802f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 103.0015f, 113.8909f,
115.5778f, 111.8456f, 101.2533f, 88.80669f, 76.36295f, 58.1126f, 50.7036f, 50.73739f, 50.75558f, 50.7866f, 50.7866f, 50.78094f, 50.77505f, 50.76963f, 49.73465f, 49.67002f, 49.62125f, 49.61201f,
49.56686f, 49.52171f, 49.4753f, 49.36908f, 49.25202f, 49.13497f, 48.52586f, 48.52552f, 48.52518f, 48.52485f, 48.52452f, 48.5243f, 48.52428f, 48.52426f, 53.29128f, 53.54358f, 53.79589f, 54.0374f,
54.13037f, 53.81666f, 53.71954f, 53.7207f, 53.72168f, 53.72121f, 53.72137f, 51.31573f, 51.67519f, 52.03467f, 52.41933f, 52.79411f, 52.84521f, 52.99426f, 53.38992f, 53.89839f, 35.87238f, -62.8712f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.52644f, -71.65511f, -70.55952f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.41525f, 51.3669f, 51.3669f, 51.3669f,
51.37618f, 51.40987f, 51.53259f, 51.68393f, 51.80138f, 51.93578f, 52.07018f, 52.20457f, 52.33897f, 52.47729f, 52.61165f, 52.74216f, 55.06904f, 53.01095f, 53.14535f, 53.27975f, 53.54832f, 0f, 0f, 0f,
0f, 93.3757f, 93.3757f, 93.3757f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74802f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74793f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74802f, 95.74802f, 95.74802f, 95.74805f,
96.70551f, 107.4407f, 117.267f, 112.0124f, 110.6499f, 104.2012f, 91.78739f, 78.32185f, 65.57787f, 50.51913f, 50.42196f, 50.32586f, 50.31794f, 50.22767f, 50.69797f, 50.69796f, 50.69796f, 49.52998f,
49.33097f, 49.39825f, 49.3531f, 49.30795f, 49.26279f, 49.21763f, 49.13958f, 49.02253f, 48.90547f, 48.77075f, 48.52676f, 48.52604f, 48.52571f, 48.52537f, 48.52505f, 48.52517f, 48.52514f, 48.52512f,
48.52511f, 52.92745f, 53.17966f, 53.49168f, 53.64735f, 53.83081f, 53.71898f, 53.72012f, 53.72127f, 53.72242f, 53.72358f, 50.63673f, 51.15566f, 51.67459f, 52.5069f, 53.07192f, 52.95159f, 52.84379f,
53.07103f, 53.46378f, -62.95262f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -78.84348f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -70.32375f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f,
51.7294f, 51.29862f, 51.73166f, 51.27171f, 51.44775f, 51.62379f, 51.86593f, 52.13322f, 52.43685f, 52.58831f, 52.59124f, 52.72128f, 52.9864f, 53.12478f, 53.23591f, 53.25887f, 53.00493f, 53.52766f,
53.66206f, 53.79646f, 54.06362f, 0f, 0f, 0f, 0f, 93.3757f, 93.3757f, 93.3757f, 95.74802f, 95.74802f, 95.74802f, 95.74803f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f,
95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74792f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74802f, 95.74802f, 95.34556f, 94.55779f, 111.5858f, 114.3968f, 108.3154f, 104.8432f, 98.08778f, 89.07619f, 78.16969f, 68.34349f, 50.37103f, 50.28396f, 50.23052f, 50.22886f, 50.22842f, 50.22838f,
50.22834f, 50.22831f, 50.2283f, 50.22049f, 49.13934f, 49.09418f, 49.04903f, 49.00388f, 48.95871f, 48.91f, 48.79303f, 48.67612f, 48.57892f, 48.53148f, 48.52843f, 48.5266f, 48.52623f, 48.52591f,
48.52604f, 48.52603f, 48.52601f, 48.52599f, 48.52567f, 51.79301f, 52.66103f, 53.03811f, 53.1935f, 53.71736f, 53.71851f, 53.71966f, 53.72081f, 53.72195f, 53.72311f, 48.44839f, 49.81298f, 51.17755f,
52.56395f, 53.2388f, 53.02587f, 52.83164f, 52.63741f, 52.44318f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -75.20727f, -72.40517f, -71.07313f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -70.4327f, 51.7294f, 51.7294f,
51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 50.96001f, 51.13605f, 51.31208f, 51.48812f, 51.66417f, 51.8402f, 52.01624f, 52.19228f, 52.40238f, 52.73724f, 53.1484f, 53.33154f, 53.64008f, 53.7515f,
53.77558f, 53.90998f, 56.01804f, 54.17877f, 54.31317f, 54.57892f, 0f, 0f, 0f, 0f, 93.3757f, 93.3757f, 93.3757f, 93.5594f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74802f,
95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74808f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74802f, 95.3195f, 93.3757f, 92.5452f, 103.9441f, 102.665f, 97.61732f, 90.89301f, 84.13763f, 74.14125f, 64.79298f, 52.49427f, 50.23371f, 50.23205f, 50.23039f,
50.22917f, 50.22913f, 50.2291f, 50.22906f, 50.22903f, 50.22898f, 50.21939f, 50.2637f, 48.79011f, 48.7439f, 48.58318f, 48.65518f, 48.58366f, 48.53369f, 48.53369f, 48.53354f, 48.5305f, 48.52746f,
48.527f, 48.52675f, 48.52673f, 48.52689f, 48.5267f, 48.52669f, 48.52634f, 48.52544f, 48.52449f, 48.52353f, 51.95916f, 52.21278f, 53.17493f, 53.54617f, 53.71919f, 53.28497f, 53.28466f, 51.28783f,
49.44764f, 49.43631f, 51.10351f, 52.89515f, 53.24643f, 52.84103f, 52.55492f, 52.35729f, 52.16306f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -75.33337f, -71.59904f, -68.76895f, -69.70853f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, 51.7294f, 50.71843f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.66106f, 51.75113f, 51.35246f, 50.57702f, 51.70454f, 51.88058f, 52.05661f, 52.23265f, 52.40869f,
52.58473f, 52.76076f, 52.99086f, 53.29277f, 53.73963f, 54.19272f, 54.37024f, 54.55655f, 57.08838f, 54.67545f, 54.38565f, 0f, 0f, 0f, 0f, 93.3757f, 93.3757f, 93.3757f, 93.3757f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.74808f, 95.74806f, 95.74802f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74808f, 95.74807f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 87.77724f, 85.85954f, 54.1516f, 54.15166f, 68.98564f, 63.41356f, 64.77191f, 72.9886f, 69.88882f, 58.71247f,
51.54473f, 50.2348f, 50.23353f, 50.23191f, 50.23026f, 50.22988f, 50.22984f, 50.2298f, 50.22975f, 50.22971f, 50.23484f, 50.29574f, 50.37022f, 47.73573f, 48.5337f, 48.36903f, 48.53368f, 48.53367f,
48.53367f, 48.53366f, 48.53256f, 48.52951f, 48.52717f, 48.527f, 48.527f, 48.527f, 48.527f, 48.527f, 48.527f, 48.52644f, 48.5255f, 48.52454f, 48.52356f, 49.17358f, 49.87277f, 50.57197f, 51.27116f,
51.97036f, 51.32008f, 51.31316f, 51.30532f, 50.00621f, 50.60926f, 51.49368f, 52.74348f, 53.05678f, 52.73724f, 52.40646f, 52.07479f, 51.74488f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -75.3276f, -71.71345f, -68.0993f, -66.17265f, -68.34395f, -70.51521f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -44.65256f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.66531f, 51.2168f, 51.39283f, 51.56887f, 51.74491f, 51.92095f,
52.09698f, 52.27303f, 52.44906f, 52.6251f, 52.80266f, 53.02052f, 53.19615f, 53.35892f, 55.9818f, 53.90346f, 54.3252f, 54.74693f, 54.82205f, 55.52493f, 0f, 0f, 0f, 0f, 93.37572f, 93.37601f, 93.37595f,
93.37589f, 93.3763f, 95.74805f, 95.74805f, 95.74808f, 95.74808f, 95.74802f, 95.74802f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.74808f, 95.74807f, 95.74805f, 95.74805f, 95.74805f,
95.74805f, 95.74805f, 95.58299f, 93.20779f, 91.24918f, 89.93793f, 88.38051f, 88.76701f, 95.26738f, 85.45641f, 54.15071f, 54.15076f, 54.15082f, 54.15086f, 54.15092f, 54.07568f, 53.50642f, 53.68328f,
53.88968f, 55.66858f, 52.09151f, 50.45418f, 50.23473f, 50.23322f, 50.23176f, 50.23062f, 50.23058f, 50.23052f, 50.23048f, 50.23051f, 50.25128f, 50.29557f, 50.33987f, 50.38416f, 44.79137f, 44.79137f,
47.77546f, 48.53366f, 48.53365f, 48.53365f, 48.53364f, 48.53158f, 48.52885f, 48.52721f, 48.527f, 48.527f, 48.527f, 48.527f, 48.527f, 48.527f, 48.52653f, 48.52557f, 48.52462f, 48.52367f, 48.92995f,
49.62914f, 50.32834f, 51.02753f, 51.72673f, 51.33723f, 51.33031f, 51.32281f, 51.31524f, 50.87997f, 51.77085f, 52.64286f, 52.67477f, 52.4132f, 52.09911f, 51.76832f, 51.5321f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.70766f, -68.09351f, -64.44465f, -64.80806f, -66.97935f, -69.15062f, -71.14745f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -70.67775f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.25717f, 51.43321f,
51.60925f, 51.78528f, 51.96132f, 52.13736f, 52.31339f, 52.48943f, 52.66547f, 52.84148f, 53.05017f, 53.19576f, 53.30433f, 53.40239f, 53.48698f, 53.77462f, 54.03594f, 54.45767f, 54.06574f, 0f, 0f, 0f,
0f, 93.37758f, 93.3773f, 93.37702f, 93.37675f, 93.37647f, 93.37621f, 95.24142f, 95.75426f, 95.74806f, 95.74802f, 95.74802f, 95.74805f, 95.74805f, 95.74805f, 95.74805f, 95.73816f, 95.78825f, 95.24133f,
95.24133f, 95.24133f, 95.35197f, 95.74805f, 95.74805f, 94.75497f, 79.44089f, 75.05131f, 73.07561f, 71.45713f, 63.80077f, 54.00499f, 54.15226f, 54.24683f, 54.15002f, 54.15008f, 54.15013f, 54.15018f,
53.77798f, 53.15055f, 52.60953f, 52.79301f, 52.87516f, 51.30593f, 50.2348f, 50.23467f, 50.23307f, 50.23163f, 50.23131f, 50.23126f, 50.23122f, 50.23453f, 50.26772f, 50.31202f, 50.35333f, 50.38391f,
45.45216f, 44.79137f, 45.31648f, 47.11098f, 47.28085f, 48.38164f, 48.53362f, 48.53354f, 48.53087f, 48.52839f, 48.52723f, 48.527f, 48.527f, 48.527f, 48.527f, 48.527f, 48.527f, 48.52664f, 48.52569f,
48.5247f, 48.52382f, 48.71148f, 49.38551f, 50.08471f, 50.78391f, 51.412f, 51.35961f, 51.34745f, 51.34031f, 51.33562f, 51.68875f, 51.91102f, 52.53611f, 52.28185f, 52.02758f, 51.76885f, 51.46098f,
52.63469f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -70.81541f, -67.45327f, -63.82249f, -62.8102f, -64.01923f,
-65.61476f, -67.78603f, -69.95731f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -42.92056f, 51.74627f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f,
51.7294f, 51.53259f, 51.29754f, 51.47358f, 51.64962f, 51.82566f, 52.0017f, 52.17773f, 52.35377f, 52.5298f, 52.70261f, 52.86156f, 53.01088f, 53.13795f, 53.24658f, 53.34904f, 53.45784f, 53.56664f,
54.16262f, 55.45248f, 54.54669f, 0f, 0f, 0f, 0f, 93.37775f, 93.37791f, 93.37761f, 99.17871f, 93.37767f, 98.65275f, 98.64059f, 102.0378f, 101.5476f, 102.4415f, 102.8555f, 102.8263f, 102.6251f,
102.5774f, 101.9833f, 103.7401f, 96.35359f, 52.23868f, 51.98054f, 51.82742f, 51.6743f, 52.00625f, 52.20613f, 52.40601f, 59.97396f, 59.3227f, 56.74868f, 56.26381f, 54.90974f, 53.7784f, 53.92566f,
54.11032f, 54.14929f, 54.14935f, 54.1494f, 54.13927f, 53.48029f, 52.85285f, 52.22542f, 51.71517f, 51.89386f, 50.53069f, 50.2348f, 50.23458f, 50.23293f, 50.23218f, 50.23213f, 50.23208f, 50.25657f,
50.30095f, 50.33923f, 50.34989f, 50.36398f, 50.58914f, 49.22637f, 47.38881f, 47.83301f, 48.05731f, 48.23809f, 48.40493f, 48.57176f, 48.53269f, 48.53013f, 48.52758f, 48.52707f, 48.527f, 48.527f,
48.527f, 48.527f, 48.527f, 48.527f, 48.52675f, 48.52566f, 48.52474f, 48.52402f, 48.55517f, 49.14188f, 49.84108f, 50.54681f, 51.78373f, 51.54027f, 51.43433f, 51.37254f, 51.95218f, 52.69986f, 52.02209f,
52.1456f, 51.90693f, 51.66825f, 51.47878f, 51.9435f, 50.82573f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -69.86243f, -66.05781f,
-63.06889f, -62.8102f, -62.8102f, -64.89991f, -65.59245f, -66.57544f, -68.59272f, -70.76398f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -42.42934f, 51.54612f, 52.04296f, 51.82682f, 51.7294f,
51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 52.01219f, 51.61752f, 51.70144f, 51.51396f, 51.68999f, 51.86603f, 52.04207f, 52.21811f, 52.39092f, 52.55017f, 52.70155f, 52.85007f, 52.96929f,
53.07809f, 53.18689f, 53.29569f, 53.40449f, 53.51329f, 53.62209f, 53.73089f, 53.84938f, 0f, 0f, 0f, 0f, 134.1051f, 132.9536f, 131.7873f, 122.6387f, 129.4305f, 113.0493f, 108.2547f, 103.5188f,
103.888f, 102.3555f, 100.8865f, 101.1641f, 97.61968f, 96.49117f, 96.17694f, 98.95535f, 76.2596f, 52.82026f, 52.56371f, 52.41059f, 52.25747f, 52.17862f, 52.34992f, 52.5498f, 52.74968f, 52.94956f,
53.14944f, 53.25726f, 53.40453f, 53.55179f, 53.69906f, 53.97404f, 54.14843f, 54.14848f, 54.14853f, 53.81002f, 53.18259f, 52.55515f, 51.92772f, 51.30029f, 50.82043f, 50.2348f, 50.2348f, 50.23444f,
50.23295f, 50.23287f, 50.23446f, 50.27274f, 50.31073f, 50.32125f, 50.33055f, 50.33985f, 50.36788f, 50.61231f, 50.87614f, 49.59143f, 48.79065f, 49.01495f, 49.19534f, 49.36218f, 49.12069f, 48.53115f,
48.52858f, 48.52712f, 48.52714f, 48.52721f, 48.527f, 48.527f, 48.527f, 48.527f, 48.527f, 48.52673f, 48.52577f, 48.52497f, 48.52427f, 48.52356f, 48.89825f, 49.59744f, 50.51702f, 51.85144f, 52.03027f,
51.66999f, 51.57523f, 51.53275f, 52.44073f, 52.41633f, 52.01509f, 51.83024f, 51.6454f, 50.35324f, 54.48384f, 50.5155f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -72.03796f,
-71.2406f, -71.00052f, -68.48349f, -65.08026f, -62.8102f, -62.8102f, -62.8102f, -62.8102f, -64.68649f, -66.54419f, -67.16568f, -67.78716f, -69.39938f, -71.19616f, -71.2406f, -71.2406f, -70.55698f,
51.42062f, 51.92167f, 52.4227f, 52.76006f, 51.99778f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.69665f, 51.7294f, 51.71748f, 51.73037f, 51.90641f, 52.07922f, 52.23876f, 52.39014f,
52.54153f, 52.68926f, 52.80714f, 52.91594f, 53.02474f, 53.13354f, 53.24234f, 53.35114f, 53.45995f, 53.56874f, 53.67754f, 53.79618f, 0f, 0f, 0f, 0f, 112.2f, 107.4053f, 102.6106f, 97.81594f, 93.02129f,
88.22662f, 83.43195f, 80.85223f, 84.83269f, 83.61309f, 84.21813f, 84.82313f, 81.57211f, 76.32527f, 74.79269f, 69.7189f, 53.43507f, 53.40183f, 53.14497f, 52.99178f, 52.84064f, 52.67117f, 52.4966f,
52.69659f, 52.89657f, 53.13327f, 53.19021f, 53.00923f, 53.14595f, 53.29352f, 53.4987f, 53.83788f, 54.14384f, 54.14775f, 54.10839f, 53.51233f, 52.88489f, 52.25746f, 51.63003f, 51.00259f, 50.37629f,
50.2348f, 50.2348f, 50.23429f, 50.2336f, 50.24454f, 50.28223f, 50.29261f, 50.30191f, 50.3112f, 50.32051f, 50.33397f, 50.37353f, 50.63549f, 50.89931f, 51.16314f, 49.95648f, 49.97258f, 50.1526f,
50.08746f, 48.80115f, 48.5296f, 48.52722f, 48.52718f, 48.52719f, 48.52719f, 48.527f, 48.527f, 48.527f, 48.527f, 48.527f, 48.52697f, 48.52593f, 48.52522f, 48.52451f, 48.5238f, 48.65462f, 49.35706f,
50.58472f, 51.91914f, 52.61708f, 52.11136f, 51.81089f, 51.75223f, 51.74841f, 52.23898f, 51.99686f, 51.81202f, 51.62717f, 51.44233f, 51.25748f, 20.29317f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -74.20248f, -72.3419f, -70.48132f, -67.5059f, -64.18873f, -62.8102f, -62.8102f, -62.8102f, -62.8102f, -62.8102f, -64.14117f, -67.49592f, -68.1174f, -68.73888f, -69.36037f, -70.36479f,
-71.2406f, -71.2406f, 51.29514f, 51.79617f, 52.29721f, 52.79825f, 53.29381f, 53.01181f, 52.2028f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.76751f, 51.92736f,
52.07874f, 52.23012f, 52.38151f, 52.52844f, 52.645f, 52.7538f, 52.86259f, 52.9714f, 53.0802f, 53.18899f, 53.29779f, 53.40659f, 53.5154f, 53.6242f, 53.74298f, 0f, 0f, 0f, 0f, 87.37734f, 82.58257f,
77.78792f, 66.75396f, 63.83219f, 54.15494f, 55.281f, 59.32255f, 61.88556f, 64.68434f, 66.81847f, 68.09207f, 65.24659f, 60.26794f, 55.83359f, 53.63754f, 53.96918f, 53.98341f, 53.82998f, 53.67654f,
53.51266f, 53.05076f, 52.67578f, 52.87608f, 53.07637f, 53.20576f, 53.03833f, 52.87091f, 52.91996f, 53.06801f, 53.36255f, 53.70174f, 54.04093f, 54.14701f, 53.84206f, 53.21463f, 52.5872f, 51.95976f,
51.33233f, 50.7049f, 50.2348f, 50.2348f, 50.2348f, 50.23435f, 50.25375f, 50.26397f, 50.27327f, 50.28257f, 50.29187f, 50.30117f, 50.31046f, 50.33729f, 50.39484f, 50.65866f, 50.92249f, 51.18631f,
51.45014f, 50.93022f, 50.97412f, 49.76792f, 48.5291f, 48.52805f, 48.52723f, 48.52724f, 48.52724f, 48.52724f, 48.527f, 48.527f, 48.527f, 48.527f, 48.527f, 48.527f, 48.52618f, 48.52547f, 48.52476f,
48.52405f, 48.52341f, 49.31801f, 50.65243f, 51.98685f, 53.18476f, 52.69817f, 52.19244f, 51.9717f, 51.96789f, 50.83949f, 48.35579f, 44.7692f, 51.60896f, 19.83503f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -72.98022f, -72.37902f, -70.51846f, -68.65787f, -66.52834f, -63.46056f, -62.8102f, -62.8102f, -62.8102f, -62.8102f, -62.8102f, -62.8102f, -63.59583f, -68.71033f, -69.39333f,
-69.69062f, -70.3121f, -70.77731f, -67.25447f, 50.90909f, 51.67069f, 52.17172f, 52.67276f, 53.1738f, 53.67485f, 54.00306f, 53.16987f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f,
51.7294f, 51.7294f, 51.76734f, 51.91872f, 52.07011f, 52.22149f, 52.36761f, 52.48285f, 52.59165f, 52.70045f, 52.80925f, 52.91805f, 53.02685f, 53.13565f, 53.24444f, 53.35856f, 53.46731f, 53.57605f,
53.68977f, 0f, 0f, 0f, 0f, 13.31766f, 15.79526f, 18.27287f, 20.75047f, 23.92551f, 29.22073f, 41.49999f, 53.34671f, 53.35083f, 53.35552f, 53.36024f, 53.48253f, 53.78465f, 53.88473f, 53.98482f,
54.17165f, 54.50328f, 54.56498f, 54.41155f, 54.25613f, 53.84435f, 53.34535f, 52.87133f, 53.01947f, 53.21071f, 53.08501f, 52.91758f, 52.75014f, 52.69398f, 52.88721f, 53.2264f, 53.56559f, 53.90479f,
54.1202f, 53.54436f, 52.91693f, 52.2895f, 51.66206f, 51.03463f, 50.40719f, 50.2348f, 50.2348f, 50.23184f, 50.23533f, 50.24463f, 50.25393f, 50.26323f, 50.27252f, 50.28182f, 50.29112f, 50.30087f,
50.34117f, 50.41801f, 50.68184f, 50.94566f, 51.20949f, 51.47331f, 51.73942f, 51.04845f, 49.44837f, 48.52778f, 48.52728f, 48.52728f, 48.52729f, 48.52729f, 48.52729f, 45.68932f, 48.57242f, 48.72306f,
48.8737f, 49.17506f, 49.58951f, 48.52643f, 48.52572f, 48.525f, 48.52429f, 48.76131f, 49.52428f, 50.72014f, 52.05455f, 53.38897f, 53.285f, 52.77927f, 44.35419f, 33.99744f, 24.39227f, 9.902281f,
-11.98665f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -69.06812f, -71.2406f, -71.2406f, -69.64234f, -67.06344f, -64.97382f, -62.8102f, -62.8102f, -62.8102f, -62.8102f, -62.8102f,
-62.8102f, -62.8102f, -62.8102f, -63.0505f, -68.36789f, -70.30259f, -70.64236f, -70.9928f, -60.83f, -52.46119f, 32.97905f, 52.50318f, 52.94273f, 53.38228f, 53.82184f, 54.25054f, 54.57148f, 51.7294f,
51.7294f, 51.7294f, 51.7493f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7587f, 51.91008f, 52.06146f, 52.20676f, 52.3207f, 52.4295f, 52.5383f, 52.6471f, 52.7559f, 52.8647f, 52.9735f,
53.0823f, 53.1911f, 53.31085f, 53.41943f, 53.528f, 53.63657f, 0f, 0f, 0f, 0f, 53.27048f, 53.27458f, 53.27868f, 53.28278f, 53.28688f, 53.29098f, 53.29507f, 53.29917f, 53.30338f, 53.30809f, 53.31281f,
53.61819f, 54.0484f, 54.47791f, 54.681f, 54.78109f, 55.03739f, 55.14656f, 54.99313f, 54.63795f, 54.13895f, 53.63995f, 53.14095f, 53.16287f, 53.13168f, 52.96425f, 52.79682f, 52.62939f, 52.47968f,
52.75106f, 53.09026f, 53.42945f, 53.76864f, 54.10784f, 54.44703f, 52.61923f, 51.9918f, 51.36437f, 50.73693f, 50.1095f, 50.2348f, 50.23492f, 50.21599f, 50.22528f, 50.23458f, 50.24389f, 50.25318f,
50.26248f, 50.27178f, 50.28108f, 50.30059f, 50.34506f, 50.44118f, 50.70501f, 50.96884f, 51.23266f, 51.49649f, 51.7877f, 51.78721f, 51.78175f, 48.52722f, 48.52733f, 48.52733f, 48.52733f, 48.52734f,
48.52734f, 50.24122f, 50.80217f, 51.36314f, 51.9241f, 52.31081f, 52.30299f, 52.29518f, 48.52599f, 48.52528f, 49.02532f, 50.32028f, 50.83788f, 51.35548f, 52.18929f, 53.45667f, 53.87182f, 50.50093f,
29.61979f, 2.318466f, -13.86191f, -29.92295f, -44.37428f, -69.69345f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -69.5646f, -67.67627f, -65.83386f, -64.0333f,
-63.21658f, -62.8102f, -62.8102f, -62.8102f, -62.8102f, -62.8102f, -62.8102f, -62.8102f, -67.82405f, -71.31825f, -67.28101f, -59.34246f, -43.43227f, -18.87747f, 5.306691f, 53.65828f, 54.0975f,
54.45069f, 54.64106f, 54.641f, 54.64095f, 51.7294f, 51.7294f, 51.87271f, 52.00454f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.7294f, 51.75006f, 51.90144f, 52.04591f, 52.15855f, 52.26735f, 52.37615f,
52.48495f, 52.59375f, 52.70255f, 52.81135f, 52.92015f, 53.02895f, 53.13775f, 53.24656f, 53.35535f, 53.46415f, 53.58337f, 0f, 0f, 0f, 0f, 53.22294f, 53.22704f, 53.23114f, 53.23524f, 53.23933f,
53.24344f, 53.24753f, 53.25163f, 53.25594f, 53.26065f, 53.32364f, 53.75385f, 54.18405f, 54.61425f, 55.04446f, 55.44771f, 55.585f, 55.72814f, 55.43153f, 54.93254f, 54.43354f, 53.93455f, 53.43555f,
53.17714f, 53.00646f, 52.83073f, 52.65211f, 52.4735f, 52.39655f, 52.39661f, 52.48098f, 53.2933f, 53.6325f, 53.97168f, 54.31089f, 53.79795f, 51.79478f, 51.50219f, 52.50388f, 52.49911f, 52.49733f,
52.49555f, 50.20595f, 50.21524f, 50.22454f, 50.23384f, 50.24314f, 50.25244f, 50.26174f, 50.27206f, 50.30448f, 50.34299f, 50.46436f, 50.72818f, 50.99201f, 51.25584f, 51.54924f, 51.79325f, 51.7878f,
51.78213f, 51.77667f, 51.77122f, 49.46807f, 48.52739f, 48.52739f, 52.99026f, 53.55122f, 54.11217f, 54.67314f, 55.0321f, 55.02429f, 55.01647f, 55.00866f, 55.00085f, 49.80342f, 51.23536f, 51.75297f,
52.27056f, 52.78815f, 53.30576f, 53.82335f, 53.47691f, 36.26975f, 10.80987f, -18.02019f, -40.04551f, -54.38601f, -67.41396f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -69.56548f, -67.86256f, -66.07541f, -64.47749f, -63.37302f, -62.92745f, -62.8102f, -62.8102f, -62.94944f, -67.21841f, -68.11194f, -56.17726f,
-35.87432f, -14.39683f, 9.263689f, 31.26953f, 54.91525f, 54.4211f, 54.46551f, 54.5099f, 54.55474f, 54.6408f, 50.91816f, 51.92888f, 52.79672f, 52.34161f, 51.85277f, 51.61458f, 51.7294f, 51.7294f,
51.7294f, 51.74162f, 51.88504f, 51.99641f, 52.1052f, 52.214f, 52.3228f, 52.4316f, 52.5404f, 52.64921f, 52.758f, 52.86681f, 52.97561f, 53.0844f, 53.19321f, 53.30201f, 53.4108f, 53.53017f, 0f, 0f, 0f,
0f, 53.1754f, 53.1795f, 53.1836f, 53.1877f, 53.19179f, 53.19589f, 53.19999f, 53.20409f, 53.2085f, 53.21322f, 53.45929f, 53.8895f, 54.3197f, 54.7499f, 55.18011f, 55.61032f, 56.04052f, 56.21049f,
55.72614f, 55.22713f, 54.72814f, 54.22914f, 53.73014f, 52.9894f, 52.81078f, 52.63217f, 52.45437f, 52.3966f, 52.47226f, 53.19454f, 54.30657f, 56.10069f, 57.04391f, 54.49803f, 53.27966f, 52.51878f,
52.51949f, 52.51767f, 52.50925f, 52.50049f, 52.49871f, 52.49693f, 52.49568f, 50.2052f, 50.2145f, 50.2238f, 50.2331f, 50.2424f, 50.25169f, 50.26472f, 50.30836f, 50.34689f, 50.48753f, 50.75136f,
51.02513f, 51.3317f, 51.65335f, 51.79323f, 51.78777f, 51.7823f, 51.77684f, 51.77137f, 51.7659f, 51.76044f, 49.5008f, 56.30025f, 56.86121f, 57.42216f, 57.7534f, 57.74558f, 57.73776f, 57.72995f,
57.72213f, 55.94714f, 52.86201f, 52.89509f, 52.92818f, 52.84904f, 53.14542f, 53.44181f, 53.73819f, 48.51104f, 23.22687f, -9.588208f, -35.25979f, -54.90297f, -69.26807f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -70.98666f, -69.69973f, -68.11707f, -66.52271f, -64.98895f,
-63.54009f, -63.07767f, -65.14094f, -52.9683f, -33.35042f, -10.54111f, 14.80137f, 35.84405f, 44.98837f, 54.53557f, 53.00535f, 52.97694f, 53.12995f, 53.34217f, 53.76297f, 52.07212f, 53.08956f,
53.17592f, 52.66918f, 52.14809f, 51.5425f, 51.57627f, 51.7294f, 51.7294f, 52.06356f, 51.83425f, 51.94306f, 52.05185f, 52.16065f, 52.26945f, 52.37825f, 52.48705f, 52.59586f, 52.70466f, 52.81346f,
52.92226f, 53.03106f, 53.13985f, 53.24865f, 53.35746f, 53.47697f, 0f, 0f, 0f, 0f, 53.12786f, 53.13195f, 53.13605f, 53.14015f, 53.14425f, 53.14835f, 53.15245f, 53.15655f, 53.16107f, 53.18203f,
53.59495f, 54.02515f, 54.45536f, 54.88557f, 55.31577f, 55.74362f, 55.83195f, 55.71857f, 55.87291f, 55.52173f, 55.02273f, 54.52374f, 53.79122f, 52.79084f, 52.61222f, 52.4565f, 53.05991f, 54.15244f,
55.23011f, 56.27975f, 57.04341f, 57.04402f, 57.04463f, 54.60596f, 52.50849f, 52.50921f, 52.50993f, 52.50863f, 52.50837f, 52.50187f, 52.50009f, 52.49831f, 52.50045f, 52.50163f, 51.44648f, 50.21376f,
50.22306f, 50.23235f, 50.24165f, 50.26778f, 50.31225f, 50.35078f, 50.5107f, 50.81093f, 51.07798f, 51.39516f, 51.71682f, 51.79382f, 51.78836f, 51.78289f, 51.77742f, 51.77196f, 51.76649f, 51.76103f,
51.75626f, 59.82153f, 60.48252f, 60.58797f, 60.46688f, 60.45907f, 60.45125f, 60.44344f, 60.43562f, 52.73269f, 52.76579f, 52.79887f, 52.83195f, 52.18527f, 52.13614f, 52.43252f, 52.74786f, 44.54681f,
15.55329f, -22.17449f, -49.74052f, -67.08018f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.09727f, -69.91136f, -68.56718f, -67.03419f, -57.62218f, -29.7722f, -5.705811f, 20.32284f, 36.82631f, 43.6366f, 49.01495f, 50.16421f, 51.6909f, 51.3391f,
51.52589f, 51.92277f, 52.32751f, 53.83419f, 55.16886f, 53.47242f, 52.82752f, 52.28489f, 51.63167f, 51.19532f, 51.44814f, 51.7294f, 54.40023f, 52.0965f, 51.88971f, 51.9985f, 52.1073f, 52.2161f,
52.32491f, 52.43371f, 52.5425f, 52.65131f, 52.76012f, 52.8689f, 52.97771f, 53.08651f, 53.19531f, 53.30411f, 53.42377f, 0f, 0f, 0f, 0f, 53.08031f, 53.08442f, 53.08852f, 53.09261f, 53.09671f, 53.10081f,
53.10491f, 53.10901f, 53.11364f, 53.3004f, 53.73061f, 54.16081f, 54.59102f, 55.02122f, 55.39626f, 55.32021f, 55.20682f, 55.09343f, 54.98004f, 54.98026f, 55.31733f, 54.81833f, 57.03309f, 54.04049f,
53.31681f, 54.36645f, 55.41611f, 56.46575f, 57.04291f, 57.04352f, 57.04413f, 57.04474f, 57.04535f, 52.49821f, 52.49893f, 52.49964f, 52.50036f, 52.50108f, 52.50266f, 52.50325f, 52.50148f, 52.50057f,
52.50176f, 52.50295f, 51.82446f, 51.44771f, 51.00217f, 50.57285f, 50.23904f, 50.27167f, 50.31614f, 50.36061f, 50.56967f, 50.83404f, 51.13699f, 51.45863f, 51.77003f, 51.79441f, 51.78895f, 51.78348f,
51.77802f, 51.77255f, 51.76708f, 51.76162f, 51.75684f, 51.75139f, 63.48119f, 63.18818f, 63.18036f, 63.17255f, 63.16473f, 59.39867f, 52.60338f, 52.63647f, 52.67133f, 52.70264f, 52.73573f, 52.1035f,
51.17702f, 51.42324f, 52.27644f, 40.61198f, 7.879811f, -31.99211f, -59.08896f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -72.14691f, -26.17554f, -0.1956758f, 22.84082f, 38.12675f, 45.7328f, 50.04537f,
50.02875f, 50.01208f, 49.9935f, 50.03242f, 50.2375f, 50.50337f, 50.90811f, 60.44547f, 57.99547f, 55.54554f, 53.03538f, 52.2707f, 51.72621f, 51.25088f, 50.70719f, 53.4173f, 55.6067f, 54.34851f,
52.12954f, 51.94516f, 52.05396f, 52.16276f, 52.27156f, 52.38036f, 52.48916f, 52.59796f, 52.70676f, 52.81556f, 52.92436f, 53.03316f, 53.14196f, 53.25076f, 53.37057f, 0f, 0f, 0f, 0f, 53.03278f,
53.03687f, 53.04097f, 53.04507f, 53.04914f, 53.05323f, 53.05733f, 53.06144f, 53.06757f, 53.43149f, 53.8614f, 54.29131f, 54.72667f, 54.92186f, 54.80847f, 54.69508f, 54.5817f, 54.46831f, 54.35492f,
54.24153f, 54.32167f, 57.02418f, 57.02879f, 57.0334f, 57.03801f, 56.63585f, 57.0424f, 57.04302f, 57.04365f, 57.04427f, 57.04489f, 57.04546f, 56.56179f, 52.48864f, 52.48833f, 52.49008f, 52.4908f,
52.49152f, 52.49273f, 52.50425f, 52.50285f, 52.50188f, 52.50307f, 52.50426f, 52.20245f, 52.66095f, 51.45664f, 51.02731f, 50.59779f, 50.27798f, 50.32003f, 50.3645f, 50.59277f, 50.8788f, 51.20045f,
51.50845f, 51.79938f, 51.79524f, 51.78978f, 51.78432f, 51.77885f, 51.7734f, 51.76793f, 51.76221f, 51.75674f, 51.75127f, 51.74581f, 61.75918f, 52.4513f, 52.4513f, 52.4513f, 52.4513f, 52.50716f,
52.54206f, 52.56291f, 52.59606f, 52.62922f, 51.81248f, 50.88815f, 50.41396f, 52.02103f, 36.67698f, 0.2064145f, -50.83568f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.108f, -71.2406f, -71.2406f, -71.2406f, 6.805894f,
25.97231f, 40.07977f, 46.36845f, 50.03898f, 50.01931f, 50.00318f, 50.05116f, 50.24f, 50.31852f, 50.23796f, 50.12482f, 49.48872f, 63.27483f, 60.82484f, 58.3749f, 55.83208f, 53.3872f, 51.82227f,
49.20165f, 47.13298f, 55.92674f, 55.59875f, 54.7748f, 54.22926f, 52.16091f, 52.00061f, 52.10941f, 52.21821f, 52.32701f, 52.43581f, 52.54461f, 52.65342f, 52.76221f, 52.87101f, 52.97981f, 53.08862f,
53.19741f, 53.31736f, 0f, 0f, 0f, 0f, 52.9392f, 52.98933f, 52.99343f, 52.99753f, 53.0093f, 53.01339f, 53.01748f, 53.02166f, 53.10661f, 53.53593f, 53.96524f, 54.38997f, 54.41012f, 54.29673f, 54.18334f,
54.06996f, 53.95657f, 53.84317f, 53.72979f, 53.6164f, 54.27408f, 57.01765f, 57.02383f, 57.03018f, 57.03504f, 57.03965f, 57.04271f, 57.04449f, 57.04526f, 57.04591f, 57.04655f, 57.0472f, 52.48746f,
52.48606f, 52.48445f, 52.48167f, 52.48123f, 52.48199f, 52.48277f, 52.49489f, 52.50423f, 52.5032f, 52.50439f, 52.38243f, 52.1937f, 52.0989f, 51.84325f, 51.45496f, 51.02653f, 50.58999f, 50.3181f,
50.36248f, 50.58175f, 50.89245f, 51.21343f, 51.53442f, 51.80167f, 51.79621f, 51.79076f, 51.7853f, 51.77985f, 51.77439f, 51.76894f, 51.7628f, 51.75734f, 51.75187f, 51.74148f, 52.96967f, 52.4513f,
52.4513f, 52.4513f, 52.4513f, 52.4513f, 52.4513f, 52.46758f, 52.5001f, 52.53325f, 51.79856f, 50.80639f, 49.67279f, 9.302605f, -2.735643f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -69.93369f, -70.12813f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -29.75759f, 48.78425f, 45.00362f, 47.81285f, 50.0154f, 50.01281f, 50.09073f, 50.27887f, 50.46754f, 50.64933f, 50.60105f, 50.52048f, 50.43992f, 48.06932f, 66.1042f, 63.6542f,
61.20427f, 58.65372f, 56.18793f, 53.33516f, 50.22923f, 47.2769f, 55.95092f, 55.62293f, 55.36152f, 55.03285f, 54.10352f, 52.19068f, 52.05606f, 52.16486f, 52.27367f, 52.38246f, 52.49126f, 52.60007f,
52.70886f, 52.81767f, 52.92646f, 53.03526f, 53.14407f, 53.26416f, 0f, 0f, 0f, 0f, 52.84364f, 52.84349f, 52.84335f, 52.8432f, 52.92476f, 52.62631f, 52.9698f, 52.9741f, 53.24264f, 53.67195f, 54.01947f,
54.00275f, 53.78498f, 53.6716f, 53.55821f, 53.44482f, 53.33144f, 53.21804f, 53.10466f, 52.99127f, 57.00669f, 57.01287f, 57.01905f, 57.02522f, 57.0314f, 57.03667f, 57.04099f, 57.04313f, 57.04523f,
57.04729f, 57.04794f, 55.42203f, 52.48518f, 52.48379f, 52.48211f, 52.47934f, 52.47656f, 52.47462f, 52.47322f, 52.48269f, 52.49809f, 52.50447f, 52.34383f, 52.06596f, 51.87636f, 51.6086f, 51.64732f,
51.7402f, 51.48224f, 51.04658f, 50.60695f, 50.36638f, 50.6351f, 50.95609f, 51.27707f, 51.59806f, 51.80226f, 51.79681f, 51.79135f, 51.7859f, 51.78044f, 51.77499f, 51.76953f, 51.76367f, 51.75821f,
51.75274f, 51.74306f, 52.48711f, 52.64333f, 52.4513f, 52.4513f, 52.4513f, 52.4513f, 52.4513f, 52.4513f, 52.4513f, 52.45954f, 51.85823f, 50.72462f, 6.532331f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -66.6454f, -51.54549f,
-50.46466f, -38.34177f, -34.57221f, -26.58424f, -71.2406f, -28.26724f, 49.21223f, 49.38457f, 49.55209f, 49.87475f, 50.10136f, 50.31663f, 50.5071f, 50.69523f, 50.88387f, 50.96414f, 50.88358f,
50.80302f, 50.72245f, 51.6338f, 70.40653f, 66.09108f, 63.70977f, 60.57462f, 57.46869f, 54.36273f, 51.2568f, 51.62299f, 55.9751f, 55.64711f, 55.38577f, 55.0571f, 54.72844f, 53.97461f, 52.21888f,
52.11152f, 52.22031f, 52.32911f, 52.43791f, 52.54672f, 52.65552f, 52.76432f, 52.87312f, 52.98191f, 53.09072f, 53.21096f, 0f, 0f, 0f, 0f, 52.42918f, 52.84282f, 52.84267f, 52.84253f, 52.84249f,
52.35109f, 52.92213f, 52.95613f, 53.37867f, 53.60221f, 53.48905f, 53.3759f, 53.15986f, 53.04647f, 52.93547f, 52.8637f, 52.84084f, 52.84071f, 52.64837f, 52.5766f, 57.00191f, 57.00809f, 57.01427f,
57.02045f, 57.02662f, 57.0328f, 57.03831f, 57.04144f, 57.04355f, 57.04565f, 57.04861f, 52.48372f, 52.48232f, 52.48093f, 52.47903f, 52.47626f, 52.4735f, 52.47074f, 52.4679f, 52.47159f, 52.48729f,
52.25578f, 52.02231f, 51.66505f, 51.52092f, 51.26577f, 51.01062f, 50.94514f, 51.24458f, 51.50317f, 51.06355f, 50.37775f, 50.69874f, 51.01973f, 51.34071f, 51.66171f, 51.80285f, 51.79739f, 51.79194f,
51.78649f, 51.78103f, 51.77558f, 51.77012f, 51.76467f, 51.75922f, 51.75376f, 51.74825f, 52.06276f, 52.40577f, 52.4513f, 52.4513f, 52.4513f, 52.4513f, 52.4513f, 52.4513f, 52.4513f, 52.4513f, 5.084955f,
-74.58392f, -71.51514f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -66.17545f, -50.3877f, -30.99455f, -12.57078f, 12.82139f, 30.3811f, 44.89898f, 54.4696f, 56.07264f, 53.15331f, 49.89307f, 50.03536f, 50.17765f, 50.31994f, 50.49638f, 50.69574f, 50.91743f,
51.11161f, 51.29443f, 51.24667f, 51.16611f, 51.08554f, 51.27772f, 62.09783f, 64.34297f, 62.08543f, 59.82803f, 56.08158f, 53.82882f, 51.98003f, 51.66013f, 51.6259f, 55.99928f, 55.67129f, 55.41001f,
55.08134f, 54.75269f, 54.42402f, 53.84275f, 52.24561f, 52.16697f, 52.27576f, 52.38457f, 52.49337f, 52.60217f, 52.71096f, 52.81976f, 52.92857f, 53.03737f, 53.15776f, 0f, 0f, 0f, 0f, 52.84229f,
52.84215f, 53.42579f, 52.84185f, 52.84181f, 52.84166f, 52.65607f, 53.04016f, 53.08852f, 52.99781f, 52.92743f, 52.85704f, 52.84064f, 52.84051f, 52.84038f, 52.84025f, 52.84011f, 52.83998f, 52.83985f,
52.83971f, 56.99713f, 57.0033f, 57.00948f, 57.01567f, 57.02184f, 57.02802f, 57.03419f, 57.0397f, 57.04185f, 56.42585f, 51.78728f, 52.12804f, 52.36536f, 52.45243f, 52.47587f, 52.47301f, 52.47001f,
52.46701f, 52.46545f, 52.4668f, 52.4679f, 52.0157f, 51.38696f, 51.03144f, 50.92002f, 50.751f, 50.67183f, 50.69987f, 50.51826f, 51.3021f, 51.52013f, 50.44139f, 50.76237f, 51.08337f, 51.40436f,
51.72534f, 51.80344f, 51.79799f, 51.79253f, 51.78708f, 51.78162f, 51.77617f, 51.77104f, 51.76593f, 51.76148f, 51.75555f, 51.75891f, 51.80196f, 51.96088f, 52.2645f, 52.42487f, 52.4513f, 52.4513f,
52.4513f, 52.4513f, 52.4513f, 17.04182f, -68.72125f, -69.67316f, -68.77854f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -66.20207f, -50.58464f, -30.0985f, -13.70559f, 0.2172089f, 21.67223f, 32.86997f, 44.08848f, 53.4877f, 55.0907f, 57.61632f, 57.97574f, 50.51863f, 50.66092f,
50.8032f, 50.94549f, 51.08778f, 51.23006f, 51.37235f, 51.5426f, 51.66658f, 51.78045f, 51.51526f, 51.80589f, 51.82083f, 51.83578f, 56.56436f, 55.9053f, 53.67774f, 51.76571f, 51.73149f, 51.69727f,
51.67023f, 51.63594f, 54.51961f, 55.38337f, 55.35675f, 55.10559f, 54.77693f, 54.44826f, 54.11959f, 53.67638f, 52.27092f, 52.22242f, 52.33121f, 52.44002f, 52.54882f, 52.65762f, 52.76642f, 52.87522f,
52.99167f, 53.10455f, 0f, 0f, 0f, 0f, 53.77651f, 52.84147f, 52.84132f, 52.84118f, 52.84113f, 52.84099f, 52.84084f, 52.8407f, 52.84056f, 52.84043f, 52.84029f, 52.84016f, 52.83991f, 52.83978f,
52.83965f, 52.83951f, 52.83938f, 52.83924f, 52.83912f, 52.83898f, 55.72836f, 56.99853f, 57.00787f, 57.01192f, 57.01614f, 57.02278f, 57.02942f, 57.03564f, 57.04181f, 51.23178f, 51.57918f, 51.91994f,
52.16497f, 52.29116f, 52.47197f, 52.46897f, 52.46597f, 52.46358f, 52.46476f, 52.46597f, 52.46715f, 52.46832f, 50.7516f, 50.62403f, 50.72348f, 50.79507f, 50.86666f, 50.78518f, 50.60355f, 50.42193f,
50.2403f, 50.50504f, 50.82602f, 51.14701f, 51.46799f, 51.78899f, 51.80404f, 51.79858f, 51.79346f, 51.78835f, 51.78376f, 51.77926f, 51.77491f, 51.76985f, 51.76237f, 51.75432f, 51.77667f, 51.81972f,
51.86276f, 51.91523f, 52.14491f, 52.3159f, 52.42505f, 52.4513f, 52.4513f, -19.44836f, -29.22984f, -48.63345f, -62.10978f, -63.84621f, -68.75393f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -70.87859f, -54.55914f, -38.26595f, -21.45991f, -3.382878f, 9.973646f, 24.94204f, 36.53568f, 46.93909f, 52.50578f,
54.1088f, 55.45939f, 55.81882f, 56.0403f, 51.14419f, 51.37307f, 51.45995f, 51.54683f, 51.63371f, 51.6988f, 51.6988f, 51.6988f, 51.70249f, 51.70914f, 51.73363f, 51.78357f, 51.79852f, 51.81346f,
51.82841f, 51.83457f, 51.80531f, 51.7634f, 51.72957f, 51.69573f, 51.67073f, 51.63708f, 54.89817f, 54.82236f, 54.84826f, 54.77231f, 54.68547f, 54.45595f, 54.14384f, 53.81517f, 53.39733f, 52.29485f,
52.27787f, 52.38667f, 52.49547f, 52.34906f, 52.71307f, 52.82188f, 52.87857f, 52.76438f, 0f, 0f, 0f, 0f, 52.84095f, 52.8408f, 52.84065f, 52.8405f, 52.95111f, 52.84031f, 52.84016f, 52.84002f, 52.83987f,
52.83972f, 52.83958f, 52.83943f, 52.83918f, 52.83904f, 52.83891f, 52.83878f, 52.83865f, 52.83852f, 52.83838f, 52.83825f, 53.74613f, 57.00039f, 57.00443f, 57.00849f, 57.01254f, 57.01664f, 57.02292f,
57.02979f, 57.03666f, 51.02425f, 51.37108f, 51.71184f, 51.96458f, 52.20501f, 52.46792f, 52.46491f, 52.46219f, 52.46288f, 52.46417f, 52.46548f, 52.46668f, 52.4679f, 50.47916f, 50.88308f, 50.9183f,
50.98989f, 51.04465f, 50.87047f, 50.66191f, 50.44048f, 50.21906f, 50.33704f, 50.88966f, 51.21065f, 51.53164f, 51.81078f, 51.8062f, 51.80161f, 51.79704f, 51.79261f, 51.78838f, 51.78387f, 51.77724f,
51.7692f, 51.76114f, 51.75467f, 51.79443f, 51.83747f, 51.88052f, 51.93294f, 51.97607f, 52.05131f, 52.21754f, 52.3417f, -2.976029f, -3.318894f, -9.474234f, -33.93168f, -46.96837f, -58.97912f,
-65.61871f, -70.84981f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -72.38977f, -71.2406f, -28.3439f, -12.64925f, 2.006168f,
17.10402f, 27.6404f, 38.32114f, 47.95323f, 51.51621f, 52.76453f, 53.30247f, 53.69961f, 54.04193f, 54.55334f, 51.6988f, 51.75197f, 51.6988f, 51.6988f, 51.6988f, 51.6988f, 51.6991f, 51.7038f, 51.71045f,
51.7171f, 51.7463f, 51.76125f, 51.7762f, 51.79115f, 51.80606f, 51.80027f, 51.7757f, 51.75163f, 51.72491f, 51.69427f, 51.66019f, 51.61737f, 54.33717f, 54.26137f, 54.28572f, 54.20976f, 54.13381f,
54.05785f, 53.97831f, 53.79599f, 53.51076f, 53.11987f, 52.31748f, 52.33332f, 52.44212f, 52.41851f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.84027f, 52.84013f, 52.83998f, 52.83983f,
52.83978f, 52.83964f, 52.83949f, 52.83934f, 52.8392f, 52.83905f, 52.8389f, 52.83875f, 52.8385f, 52.83836f, 52.8382f, 52.83806f, 52.83792f, 52.83778f, 52.8376f, 52.83748f, 53.74463f, 56.99694f,
57.001f, 57.00505f, 57.0091f, 57.01315f, 57.01721f, 57.02306f, 57.39359f, 51.19242f, 51.38189f, 51.6084f, 51.79125f, 52.12318f, 52.40973f, 52.46086f, 52.46095f, 52.4622f, 52.46336f, 52.46435f,
52.46559f, 52.46757f, 50.96995f, 51.07738f, 51.11314f, 51.18472f, 51.13739f, 50.9275f, 50.70051f, 50.47908f, 50.25766f, 50.03622f, 50.9533f, 51.27429f, 51.81792f, 51.81487f, 51.81038f, 51.80605f,
51.80185f, 51.79766f, 51.79212f, 51.78407f, 51.77602f, 51.76796f, 51.75991f, 51.76913f, 51.81218f, 51.85523f, 51.89828f, 51.95065f, 51.98438f, 52.03867f, 52.08205f, 52.11946f, 47.49925f, 32.8638f,
22.26054f, -7.993961f, -34.23288f, -49.78337f, -61.909f, -68.30516f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -69.60871f, -71.2406f, -71.2406f,
-71.2406f, 0.9116876f, 6.686705f, 24.22019f, 27.58598f, 36.94762f, 46.85721f, 50.74385f, 51.45844f, 51.98656f, 52.28896f, 52.5455f, 52.80206f, 53.0586f, 51.6988f, 51.6988f, 51.6988f, 51.6988f,
51.6988f, 51.69953f, 51.70477f, 51.71112f, 51.71749f, 51.72387f, 51.728f, 51.73893f, 51.75388f, 51.76883f, 51.78323f, 51.76608f, 51.73951f, 51.71696f, 51.69305f, 51.66836f, 51.6437f, 51.60668f,
53.77617f, 53.70036f, 53.72319f, 53.64723f, 53.57127f, 53.49531f, 53.41935f, 53.34339f, 53.26743f, 53.12957f, 52.8439f, 52.33885f, 52.37886f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f,
0f, 0f, 52.8396f, 52.83945f, 52.83931f, 52.83916f, 52.8391f, 52.83896f, 52.83888f, 52.83878f, 52.83867f, 52.83855f, 52.83845f, 52.83837f, 52.83837f, 52.83829f, 52.83821f, 52.83813f, 52.83805f,
52.83796f, 52.83788f, 52.83779f, 53.74431f, 56.66098f, 56.67395f, 56.47714f, 56.50231f, 56.52748f, 56.55266f, 56.56638f, 55.65374f, 51.33189f, 51.52174f, 51.74825f, 51.58931f, 51.78265f, 52.23737f,
52.45871f, 52.45961f, 52.46042f, 52.46126f, 52.46217f, 52.46308f, 52.46561f, 51.16479f, 51.57505f, 51.30796f, 51.37672f, 51.19133f, 50.93711f, 50.73259f, 50.50952f, 50.28645f, 50.06338f, 49.84031f,
51.82217f, 51.82354f, 51.81952f, 51.81509f, 51.8109f, 51.80574f, 51.79848f, 51.79042f, 51.78284f, 51.77479f, 51.76674f, 51.75869f, 51.78689f, 51.82993f, 51.87299f, 51.91603f, 51.96835f, 52.0148f,
52.0723f, 52.09978f, 52.10185f, 50.86156f, 53.88203f, 49.89387f, 26.84805f, -3.46667f, -32.91818f, -53.10272f, -64.85356f, -70.79675f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-70.38698f, -69.49107f, -71.2406f, -71.2406f, -71.2406f, -18.97349f, 52.29988f, 36.41772f, 38.75389f, 39.02154f, 47.978f, 50.10006f, 52.33834f, 52.22919f, 52.13083f, 52.06793f, 52.00503f, 51.94212f,
51.77158f, 51.7226f, 51.70261f, 51.6983f, 51.6988f, 51.70022f, 51.70314f, 51.70795f, 51.71392f, 51.71991f, 51.7259f, 51.72635f, 51.72112f, 51.73156f, 51.74651f, 51.75894f, 51.73195f, 51.70373f,
51.68077f, 51.65825f, 51.63447f, 51.60927f, 51.7783f, 53.21516f, 53.13936f, 53.06356f, 53.08469f, 53.00873f, 52.93277f, 52.85682f, 52.78085f, 52.7049f, 52.62894f, 52.55298f, 52.45933f, 52.31068f,
52.24599f, 52.21391f, 52.18183f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.83893f, 52.83878f, 52.83863f, 52.83848f, 52.83833f, 52.83877f, 52.83874f, 52.83872f, 52.83868f, 52.83862f, 52.83855f, 52.83848f,
52.83841f, 52.83834f, 52.83828f, 52.83821f, 52.83815f, 52.83808f, 52.83802f, 52.83795f, 53.28182f, 54.89154f, 54.91671f, 54.94188f, 54.96704f, 54.99221f, 55.01665f, 54.92862f, 54.8096f, 51.46417f,
51.66158f, 51.74399f, 51.51791f, 51.33092f, 51.70668f, 52.26023f, 52.45718f, 52.45802f, 52.45899f, 52.45991f, 52.46082f, 52.03869f, 52.2444f, 52.14168f, 51.75623f, 51.37724f, 51.07739f, 50.79601f,
50.72245f, 50.50275f, 50.27922f, 50.06838f, 49.83215f, 51.83244f, 51.82899f, 51.8246f, 51.82058f, 51.81855f, 51.80582f, 51.79646f, 51.78838f, 51.78161f, 51.77356f, 51.76551f, 51.76159f, 51.80464f,
51.84769f, 51.89074f, 51.93379f, 52.00162f, 52.06129f, 52.09687f, 52.09137f, 52.44221f, 54.35268f, 54.50286f, 51.50233f, 49.36401f, 30.97243f, 0.8607771f, -28.47507f, -54.05157f, -68.70543f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -17.37522f, -17.42725f, 52.73083f, 52.5312f, 52.33161f, 52.05145f, 51.9875f, 51.98994f, 51.98562f, 51.9323f, 51.98228f,
51.97946f, 51.97773f, 51.97668f, 51.97562f, 51.97457f, 51.7226f, 51.7226f, 51.7226f, 51.71173f, 51.70369f, 51.70516f, 51.7082f, 51.71053f, 51.71591f, 51.7219f, 51.72759f, 51.72511f, 51.71972f,
51.71452f, 51.72419f, 51.7262f, 51.69781f, 51.66945f, 51.64454f, 51.62203f, 51.60058f, 51.51701f, 51.76951f, 52.04633f, 52.57836f, 52.51351f, 52.52215f, 52.45426f, 52.41122f, 52.36818f, 52.32513f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.11227f, 52.23531f, 51.9808f, 52.3063f, 51.80756f, 0f, 0f, 0f, 0f, 52.83825f, 52.8381f, 52.83795f, 52.83876f, 52.83874f, 52.83871f, 52.83869f,
52.83867f, 52.83864f, 52.83862f, 52.83855f, 52.83848f, 52.83841f, 52.83835f, 52.83828f, 52.83821f, 52.83815f, 52.83808f, 52.83802f, 52.83795f, 52.94664f, 53.35627f, 53.38144f, 53.40661f, 53.43177f,
53.45695f, 53.63173f, 53.51285f, 53.39397f, 51.57491f, 51.80143f, 51.67259f, 51.44652f, 51.22578f, 51.15633f, 50.97377f, 50.93941f, 51.01809f, 52.45673f, 50.91524f, 50.92766f, 51.10929f, 51.45294f,
51.78092f, 51.73388f, 51.34843f, 51.00248f, 50.69505f, 50.65188f, 50.64652f, 50.65645f, 50.66637f, 50.67629f, 51.1632f, 51.59834f, 51.58243f, 51.65859f, 51.73475f, 51.80534f, 51.79655f, 51.78716f,
51.77988f, 51.77183f, 51.76377f, 51.78214f, 51.82523f, 51.86831f, 51.91434f, 52.00176f, 52.0889f, 52.09433f, 52.22002f, 52.91454f, 54.14989f, 54.35265f, 54.32452f, 53.74783f, 51.40728f, 49.99264f,
32.53148f, 2.972175f, -24.67353f, -54.0701f, -71.02267f, -71.2406f, -70.0374f, -69.02121f, -71.2406f, -71.2406f, 53.05995f, 53.05412f, 52.96217f, 52.76256f, 52.56293f, 52.36334f, 52.16374f, 51.96853f,
51.98615f, 51.98861f, 51.98689f, 51.98253f, 51.9783f, 51.97448f, 51.97102f, 51.97012f, 51.7226f, 51.7226f, 51.7226f, 51.7226f, 51.72316f, 51.71939f, 51.71129f, 51.71348f, 51.71556f, 51.71821f,
51.72388f, 51.72822f, 51.72388f, 51.71848f, 51.71308f, 51.70786f, 51.69991f, 51.66367f, 51.63528f, 51.61336f, 51.65954f, 51.72115f, 51.70525f, 51.78535f, 52.06217f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.83845f, 52.83876f, 52.83873f, 52.83871f,
52.83868f, 52.83866f, 52.83862f, 52.83862f, 52.83859f, 52.83857f, 52.83854f, 52.83848f, 52.83841f, 52.83835f, 52.83828f, 52.83821f, 52.83815f, 52.83809f, 52.83802f, 52.83795f, 52.23005f, 51.24945f,
51.84618f, 51.87135f, 51.89651f, 51.86562f, 51.97837f, 51.85949f, 51.74062f, 51.89384f, 51.82727f, 51.63654f, 51.48237f, 51.36223f, 51.25227f, 50.49482f, 49.53204f, 49.59535f, 49.38698f, 49.41377f,
49.44057f, 50.58637f, 50.8775f, 51.20719f, 51.53542f, 51.32257f, 50.95636f, 50.73751f, 50.63566f, 50.64558f, 50.6555f, 50.66543f, 50.67535f, 51.38607f, 51.54813f, 51.53008f, 51.60624f, 51.67786f,
51.75856f, 51.80833f, 51.78626f, 51.77787f, 51.7698f, 51.76538f, 51.80579f, 51.84892f, 51.91357f, 52.06552f, 52.08851f, 52.0918f, 52.32449f, 53.2356f, 54.19125f, 54.35251f, 54.35256f, 54.17413f,
53.9476f, 53.60933f, 51.79456f, 50.97919f, 37.63195f, 8.996092f, -20.46345f, -47.61662f, -79.17686f, -71.2406f, -71.2406f, -14.6391f, 53.07891f, 53.05253f, 53.0467f, 52.9939f, 52.79428f, 52.59467f,
52.39506f, 52.19547f, 51.99589f, 51.98292f, 51.98482f, 51.98609f, 51.9808f, 51.97376f, 51.96822f, 51.96442f, 51.96066f, 51.7226f, 51.7226f, 51.7226f, 51.72264f, 51.72343f, 51.72413f, 51.72293f,
51.72028f, 51.7207f, 51.72285f, 51.72584f, 51.72804f, 51.72243f, 51.71673f, 51.71106f, 51.70637f, 51.70055f, 51.66208f, 51.66278f, 51.72229f, 51.71843f, 51.71094f, 51.7033f, 51.79597f, 52.07801f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.83838f,
52.8384f, 52.79527f, 52.83857f, 52.83863f, 52.83861f, 52.83854f, 52.83856f, 52.83854f, 52.83852f, 52.83849f, 52.83846f, 52.83841f, 52.83835f, 52.83828f, 52.83821f, 52.83815f, 52.83809f, 52.83802f,
52.83795f, 50.14887f, 50.04737f, 49.94587f, 49.80685f, 50.33589f, 50.21677f, 50.325f, 50.25169f, 50.38566f, 51.86943f, 51.89085f, 51.80845f, 51.6869f, 51.57531f, 51.46591f, 51.16956f, 50.26201f,
50.1143f, 49.97842f, 50.00522f, 50.03201f, 50.13752f, 50.36041f, 50.68569f, 51.01537f, 51.22269f, 50.90498f, 50.77811f, 50.6776f, 50.60931f, 50.57653f, 50.66448f, 50.67441f, 51.65462f, 51.65452f,
51.65335f, 51.55388f, 51.63005f, 51.70621f, 51.78237f, 51.8088f, 51.77677f, 51.76857f, 51.78035f, 51.82467f, 51.95836f, 52.07324f, 52.08511f, 52.16554f, 52.60955f, 53.35196f, 54.20222f, 54.3525f,
54.3525f, 54.23058f, 54.01513f, 53.77021f, 53.56767f, 53.35197f, 52.56467f, 51.56386f, 41.80109f, 16.26788f, -9.739346f, -30.28375f, -72.10413f, 38.0424f, 53.00412f, 53.04552f, 53.04511f, 53.03928f,
53.03274f, 52.83083f, 52.62639f, 52.42679f, 52.2272f, 52.02763f, 51.98258f, 51.98231f, 51.98348f, 51.97984f, 51.97229f, 51.96435f, 51.95766f, 51.9539f, 51.7226f, 51.7226f, 51.7226f, 51.72276f,
51.7235f, 51.72436f, 51.72496f, 51.72391f, 51.7234f, 51.72477f, 51.72678f, 51.72643f, 51.71947f, 51.71402f, 51.70976f, 51.70966f, 51.76128f, 51.77792f, 51.72632f, 51.71371f, 51.70822f, 51.70072f,
51.69309f, 51.75836f, 52.09385f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 0f, 0f, 0f, 0f, 52.83831f, 52.83834f, 52.78495f, 52.83839f, 52.83842f, 52.83845f, 52.83847f, 52.8385f, 52.83848f, 52.83846f, 52.83843f, 52.83842f, 52.83839f, 52.83835f, 52.83829f, 52.83822f,
52.83815f, 52.83809f, 52.83802f, 51.36455f, 50.22417f, 50.12267f, 50.02118f, 49.91967f, 49.82108f, 49.83591f, 49.84983f, 49.86462f, 51.20463f, 51.85531f, 51.89151f, 51.89359f, 51.86795f, 51.78894f,
51.67955f, 51.57016f, 50.88152f, 50.63324f, 50.56986f, 50.59666f, 50.57915f, 50.37182f, 50.20652f, 50.45798f, 50.70943f, 50.83218f, 50.82874f, 50.63857f, 50.53806f, 50.48659f, 50.33703f, 50.47642f,
50.89452f, 51.65456f, 51.65464f, 51.65428f, 51.65311f, 51.65195f, 51.65385f, 51.72713f, 51.80618f, 51.80756f, 51.76735f, 51.83665f, 52.0145f, 52.06983f, 52.0817f, 52.39494f, 53.12861f, 53.61446f,
54.17944f, 54.3525f, 54.3525f, 54.24825f, 54.0022f, 53.81124f, 53.60693f, 53.37312f, 53.3252f, 53.3252f, 53.01743f, 51.09419f, 49.59438f, 35.89654f, 15.94162f, 43.77717f, 53.48871f, 53.26724f,
52.99742f, 53.00747f, 53.03008f, 53.02603f, 52.96263f, 52.69379f, 52.45852f, 52.25894f, 52.05937f, 51.98263f, 51.98235f, 51.98167f, 51.97599f, 51.96544f, 51.96368f, 51.96395f, 51.83728f, 51.7226f,
51.7226f, 51.7226f, 51.72303f, 51.72377f, 51.7245f, 51.72523f, 51.72575f, 51.72578f, 51.72651f, 51.72754f, 51.72393f, 51.71214f, 51.70867f, 51.75516f, 51.86823f, 51.98439f, 51.86753f, 51.72503f,
51.71203f, 51.69961f, 51.69051f, 51.68288f, 51.70566f, 52.06851f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.83825f, 52.83828f, 52.83831f, 52.83833f, 52.83836f, 52.83839f, 52.83841f, 52.83844f, 52.83843f, 52.83841f, 52.83839f, 52.83836f, 52.83833f,
52.83831f, 52.83828f, 52.83822f, 52.83815f, 52.83809f, 52.83802f, 50.43308f, 50.29948f, 50.19798f, 50.09647f, 49.99411f, 49.82048f, 49.83531f, 49.84923f, 50.38254f, 51.85466f, 51.85476f, 51.87237f,
51.89155f, 51.89073f, 51.89037f, 51.86518f, 51.7838f, 51.55627f, 51.15256f, 51.1613f, 51.05201f, 50.76929f, 50.48656f, 50.20385f, 50.3175f, 50.30496f, 50.38626f, 50.46943f, 50.55593f, 50.6308f,
50.70568f, 49.7709f, 50.65899f, 50.99377f, 51.40295f, 51.65457f, 51.65466f, 51.65405f, 51.65289f, 51.65182f, 51.66093f, 51.74162f, 51.82849f, 51.78669f, 52.05112f, 52.05211f, 52.06189f, 52.37747f,
53.19968f, 53.92138f, 54.16893f, 54.04766f, 54.28885f, 54.26947f, 54.0206f, 53.77382f, 53.58286f, 53.3919f, 53.3252f, 53.3252f, 53.33798f, 53.43666f, 53.26535f, 53.41279f, 49.53625f, 47.58958f,
52.8819f, 53.27364f, 53.05216f, 52.90132f, 52.94746f, 52.97411f, 53.00487f, 53.01279f, 52.85423f, 52.58541f, 52.31934f, 52.09111f, 51.98267f, 51.97993f, 51.97347f, 51.96765f, 51.94879f, 51.92407f,
51.80215f, 51.68022f, 51.92041f, 51.87896f, 51.72255f, 51.72331f, 51.72404f, 51.72478f, 51.72551f, 51.72745f, 51.72817f, 51.7289f, 51.72744f, 51.71307f, 51.7415f, 51.83412f, 51.95008f, 52.06682f,
52.04564f, 51.86721f, 51.7209f, 51.7092f, 51.69747f, 51.68475f, 51.67346f, 51.67767f, 51.9987f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.83819f, 52.83822f, 52.83825f, 52.83827f, 52.8383f, 52.83833f, 52.83836f, 52.83838f, 52.83838f, 52.83836f,
52.83833f, 52.83831f, 52.83828f, 52.83826f, 52.83823f, 52.83821f, 52.83816f, 52.83809f, 50.84176f, 50.42956f, 50.37754f, 50.27328f, 50.17178f, 50.05605f, 49.81989f, 49.83471f, 50.1627f, 51.34733f,
51.85473f, 51.85483f, 51.86372f, 51.88949f, 51.89146f, 51.89107f, 51.89071f, 51.89035f, 51.86254f, 51.66983f, 51.44993f, 51.16763f, 50.88534f, 50.6031f, 50.32124f, 50.18151f, 50.26323f, 50.33793f,
50.41438f, 50.49639f, 50.57127f, 50.34219f, 50.10114f, 50.75822f, 51.09303f, 51.42781f, 51.65452f, 51.65459f, 51.65468f, 51.65384f, 51.65273f, 51.65165f, 51.67484f, 51.76036f, 51.84143f, 51.87854f,
48.82408f, 49.94679f, 53.04448f, 53.87688f, 54.14016f, 53.59984f, 53.8047f, 54.13859f, 54.14574f, 53.79296f, 53.54543f, 53.36826f, 53.3252f, 53.3252f, 53.42914f, 53.50977f, 53.6172f, 53.6899f,
53.55239f, 52.24348f, 51.48277f, 52.26257f, 52.6998f, 52.83708f, 52.68565f, 52.74066f, 52.95031f, 52.9655f, 52.98338f, 52.9838f, 52.74586f, 52.47707f, 52.20829f, 51.63289f, 51.46198f, 51.64801f,
51.91499f, 51.82719f, 51.89971f, 51.77779f, 51.68023f, 51.8543f, 51.99354f, 52.13277f, 52.26547f, 52.20383f, 52.20375f, 52.20367f, 52.19722f, 52.19722f, 52.19722f, 52.01325f, 51.94454f, 51.97205f,
52.03294f, 52.13133f, 52.216f, 52.09308f, 51.86689f, 51.70707f, 51.69673f, 51.68639f, 51.67605f, 51.66571f, 51.66387f, 51.9577f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.83813f, 52.83816f, 52.83818f, 52.83821f, 52.83824f, 52.83826f, 52.83829f,
52.83832f, 52.83833f, 52.8383f, 52.83828f, 52.83825f, 52.83823f, 52.8382f, 52.83818f, 52.83816f, 52.83814f, 52.73798f, 51.14576f, 50.42648f, 50.42371f, 50.34859f, 50.24709f, 50.07909f, 49.81928f,
50.09196f, 50.88484f, 51.8547f, 51.8548f, 51.85488f, 51.85494f, 51.88023f, 51.89214f, 51.89177f, 51.89141f, 51.89104f, 52.01312f, 52.02442f, 51.69835f, 51.28828f, 51.00642f, 50.72455f, 50.44268f,
50.48005f, 50.53059f, 50.58113f, 50.65899f, 50.9556f, 50.93058f, 50.54958f, 50.50212f, 50.85746f, 51.19228f, 51.52706f, 51.65442f, 51.6545f, 51.65457f, 51.65463f, 51.65376f, 51.65275f, 51.65591f,
51.68117f, 51.78022f, -21.06743f, 26.1936f, 48.33823f, 51.85673f, 54.04553f, 53.41251f, 53.32804f, 53.70036f, 54.12019f, 54.16422f, 53.74266f, 53.37642f, 53.3252f, 53.3252f, 53.5024f, 53.68319f,
53.74705f, 53.81091f, 53.8528f, 53.8572f, 53.84942f, 53.17637f, 51.7309f, 52.08046f, 52.51768f, 52.46999f, 52.4348f, 52.81121f, 52.95316f, 52.96835f, 52.98354f, 52.9063f, 52.63753f, 52.36875f,
50.87619f, 51.24578f, 51.71322f, 51.79406f, 51.71348f, 51.85001f, 51.75344f, 51.667f, 51.7882f, 51.92743f, 52.06667f, 52.20098f, 52.2038f, 52.20372f, 52.20461f, 52.20477f, 52.20477f, 52.20476f,
52.20477f, 52.19138f, 52.16913f, 52.1483f, 52.27563f, 52.35112f, 52.15257f, 51.87031f, 51.69833f, 51.68261f, 51.67226f, 51.66193f, 51.65159f, 51.64707f, 52.13239f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.83807f, 52.8381f, 52.83812f, 52.83815f,
52.83818f, 52.8382f, 52.83823f, 52.83826f, 52.83827f, 52.83825f, 52.83823f, 52.8382f, 52.83818f, 52.83815f, 52.83813f, 52.8381f, 52.8381f, 52.53488f, 51.0043f, 50.42363f, 50.42013f, 50.41405f,
50.3224f, 50.09568f, 49.9049f, 50.81213f, 51.61118f, 51.85476f, 51.85497f, 51.85496f, 51.85503f, 51.87796f, 51.92151f, 50.34333f, 50.40345f, 50.46358f, 50.52365f, 51.86119f, 51.86144f, 51.86169f,
51.89485f, 50.76175f, 50.25914f, 51.72042f, 51.77097f, 51.82151f, 52.47626f, 52.81144f, 51.44057f, 50.87982f, 50.71196f, 50.9567f, 51.26035f, 51.62228f, 51.65551f, 51.65437f, 51.65445f, 51.65453f,
51.65457f, 51.65469f, 51.65839f, 51.66209f, 21.00295f, -13.32258f, 1.544182f, 32.80382f, 47.20093f, 53.8633f, 52.86737f, 53.26215f, 53.68197f, 54.10179f, 54.18269f, 53.76113f, 53.53f, 53.37185f,
53.47279f, 53.80981f, 53.90225f, 53.94916f, 53.90239f, 53.8572f, 53.85513f, 53.76336f, 53.64662f, 52.58835f, 51.55837f, 51.89835f, 52.24045f, 52.12894f, 52.50536f, 52.87361f, 52.95601f, 52.9712f,
53.0667f, 52.79799f, 52.52921f, 50.94663f, 51.62456f, 51.7905f, 51.71452f, 51.66872f, 51.80523f, 51.72908f, 51.667f, 51.72209f, 51.86132f, 52.00393f, 52.15727f, 52.20377f, 52.20365f, 52.20965f,
52.21106f, 52.21181f, 52.21225f, 52.21227f, 52.18314f, 52.14911f, 52.12977f, 52.39803f, 52.48592f, 52.21262f, 51.91657f, 51.69702f, 51.66849f, 51.65815f, 51.6478f, 51.63747f, 51.70458f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.83801f,
52.83804f, 52.83806f, 52.83809f, 52.83812f, 52.83814f, 52.83817f, 52.8382f, 52.83822f, 52.8382f, 52.83817f, 52.83815f, 52.83813f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.39341f, 50.97791f,
50.42211f, 50.41812f, 50.41373f, 50.39676f, 50.11226f, 49.85927f, 51.53228f, 51.85592f, 51.85633f, 51.85625f, 51.85511f, 51.86008f, 51.90203f, 51.8819f, 51.94202f, 52.00214f, 52.06226f, 52.12233f,
51.87505f, 51.87531f, 51.87556f, 51.29055f, 50.25285f, 49.58323f, 52.6679f, 52.0597f, 52.41859f, 52.71285f, 52.77506f, 51.60475f, 51.21007f, 50.89878f, 51.0561f, 51.36928f, 51.67103f, 51.66084f,
51.65425f, 51.65433f, 51.6544f, 51.65449f, 51.6548f, 51.65464f, 51.66405f, -23.47169f, -15.35929f, -7.892703f, 11.45552f, 30.12218f, 47.36848f, 53.70432f, 53.24083f, 53.66357f, 54.08339f, 54.13489f,
53.89099f, 53.73592f, 53.22352f, 53.66406f, 54.07777f, 54.07407f, 53.97622f, 53.87836f, 53.8572f, 53.76723f, 53.65049f, 53.53374f, 53.41701f, 51.77765f, 51.54665f, 51.7051f, 51.83135f, 52.1995f,
52.57592f, 52.91194f, 52.95885f, 53.07102f, 52.95845f, 51.58804f, 51.54765f, 51.67479f, 51.75358f, 51.7139f, 51.67793f, 51.73787f, 51.70473f, 51.667f, 51.67003f, 51.79738f, 51.94983f, 52.10317f,
52.20373f, 52.20355f, 52.20855f, 52.21622f, 52.21707f, 52.21792f, 52.21578f, 52.16527f, 52.12477f, 52.12785f, 52.44151f, 52.56946f, 52.27269f, 51.97592f, 51.69835f, 51.65437f, 51.64403f, 51.63369f,
51.62334f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
0f, 0f, 0f, 0f, 52.83794f, 52.83797f, 52.838f, 52.83803f, 52.83808f, 52.8381f, 52.8381f, 52.83813f, 52.83816f, 52.83814f, 52.83812f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.25195f, 51.04583f, 50.42059f, 50.4166f, 50.41222f, 50.40823f, 50.23186f, 49.75839f, 51.8596f, 51.85845f, 51.85748f, 51.85551f, 51.8536f, 51.85856f, 51.88039f, 52.14463f, 53.1318f, 53.60082f,
53.66093f, 53.02568f, 51.92337f, 51.88918f, 51.72327f, 50.76061f, 50.22984f, 49.77702f, 53.15295f, 52.70531f, 52.49145f, 52.56285f, 52.62345f, 51.80038f, 51.48164f, 51.08978f, 51.20132f, 51.49002f,
51.67668f, 51.66641f, 51.65615f, 51.65422f, 51.65429f, 51.65437f, 51.65445f, 51.65453f, -26.15805f, -29.80949f, -36.25363f, -28.87471f, -21.73295f, -2.663066f, 22.35476f, 43.98924f, 52.96867f,
53.67968f, 54.06215f, 54.25951f, 54.10984f, 53.68231f, 53.19861f, 53.61655f, 53.76584f, 53.87006f, 53.90453f, 53.85886f, 53.7711f, 53.65435f, 53.53762f, 53.42088f, 53.30413f, 52.93153f, 51.52678f,
51.53575f, 51.60162f, 51.75926f, 52.27006f, 52.64647f, 52.95178f, 52.9617f, 51.24388f, 51.36428f, 51.5057f, 51.62635f, 51.74701f, 51.74598f, 51.69649f, 51.67416f, 51.68037f, 51.667f, 51.667f,
51.74239f, 51.89573f, 52.04907f, 52.20368f, 52.20345f, 52.20618f, 52.21964f, 52.22224f, 52.22308f, 52.20288f, 52.13712f, 52.10083f, 52.15675f, 52.47258f, 52.64049f, 52.34685f, 52.05319f, 51.76064f,
51.5654f, 51.62991f, 51.61957f, 51.68293f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.1333f, 51.11376f, 50.41906f, 50.41508f, 50.4107f, 50.40671f, 50.59621f, 51.84593f, 51.8568f, 51.85767f, 51.85555f, 51.85373f, 51.85221f, 51.85051f, 51.8492f,
51.91436f, 52.60302f, 53.50405f, 53.9995f, 53.17429f, 52.07035f, 51.90304f, 51.21227f, 50.69684f, 50.24401f, 49.79119f, 51.56905f, 51.74809f, 51.94586f, 52.41184f, 52.48233f, 52.07585f, 51.70636f,
51.31531f, 51.328f, 51.59052f, 51.68227f, 51.672f, 51.66173f, 51.65146f, 51.65417f, 51.65425f, 51.65432f, -63.76193f, -52.56428f, -45.71443f, -49.366f, -52.27126f, -42.62624f, -28.76245f, -11.82712f,
12.42999f, 37.09356f, 51.37109f, 53.68571f, 52.64863f, 54.24646f, 52.79288f, 53.09689f, 53.30934f, 53.38376f, 53.49406f, 53.61515f, 53.62929f, 53.59651f, 53.53129f, 53.42474f, 53.308f, 53.19126f,
53.07452f, 52.56729f, 51.50109f, 51.52556f, 51.55002f, 51.57449f, 51.96288f, 52.71703f, 51.08141f, 51.20181f, 51.37658f, 51.44946f, 51.56998f, 51.6905f, 51.78371f, 51.73673f, 51.68893f, 51.667f,
51.667f, 51.667f, 51.68314f, 51.84163f, 51.99497f, 52.20358f, 52.20335f, 52.20382f, 52.21752f, 52.2274f, 52.22824f, 52.18782f, 52.13773f, 52.34912f, 52.0471f, 52.55207f, 52.63247f, 52.47324f,
52.18221f, 51.8912f, 51.60017f, 51.30916f, 51.29772f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.17316f, 51.18169f, 50.29754f, 50.41356f, 50.40918f, 51.34536f, 51.82545f, 51.83435f, 51.84325f, 51.85561f, 51.84998f, 51.84541f, 51.83969f,
51.83396f, 51.84136f, 51.90805f, 51.66643f, 51.61021f, 52.10972f, 52.69763f, 52.21897f, 51.66459f, 51.16384f, 50.71101f, 50.25819f, 49.08358f, 49.97061f, 50.14965f, 50.32869f, 49.80851f, 51.33582f,
52.28298f, 51.90928f, 51.51823f, 51.49752f, 51.73378f, 51.68785f, 51.67758f, 51.66731f, 51.65564f, 51.64677f, 51.65413f, -64.74017f, -64.86189f, -65.65263f, -65.91328f, -63.19893f, -61.07953f,
-58.899f, -49.64519f, -36.12968f, -19.56474f, 2.808891f, 28.47747f, 46.65565f, 50.11049f, 51.51621f, 52.62307f, 52.86687f, 52.96937f, 53.1159f, 53.27718f, 53.2756f, 53.25183f, 53.22806f, 53.20428f,
53.18051f, 53.14109f, 53.0769f, 52.96165f, 52.84491f, 51.93774f, 51.49089f, 51.51536f, 51.53983f, 52.09425f, 52.2665f, 78.51367f, 51.20837f, 51.34809f, 51.41788f, 51.52097f, 51.62801f, 51.73866f,
51.78147f, 51.73048f, 51.67578f, 51.646f, 51.667f, 51.667f, 58.4065f, 58.32822f, 63.22525f, 58.11171f, 57.82067f, 52.21515f, 52.22886f, 52.22412f, 52.43598f, 52.94913f, 53.10013f, 52.44813f,
52.51933f, 52.53006f, 52.53643f, 52.31277f, 52.02175f, 51.73074f, 51.43972f, 51.1487f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.57684f, 51.24961f, 50.25813f, 51.19847f, 51.7897f, 51.80167f, 51.81356f, 51.82277f, 51.83167f, 51.84033f, 51.83152f,
51.82472f, 51.819f, 51.81327f, 51.84017f, 51.90474f, 51.68425f, 51.34064f, 50.99704f, 50.92834f, 51.19393f, 50.6779f, 50.07666f, 50.72519f, 50.27237f, 48.5946f, 48.76078f, 48.90414f, 49.0475f,
49.19041f, 49.32076f, 48.56545f, 52.1122f, 51.72115f, 51.66705f, 51.90762f, 51.89041f, 51.68311f, 51.67289f, 15.15302f, -70.14586f, -69.34325f, -66.17464f, -66.80504f, -67.0871f, -67.54332f,
-67.83761f, -66.3383f, -63.5295f, -62.5229f, -56.51656f, -42.6901f, -26.81858f, -6.286942f, 18.2069f, 26.57378f, 36.93526f, 52.39806f, 52.59563f, 52.82074f, 52.94569f, 52.92192f, 52.89815f, 52.87437f,
52.8506f, 52.82682f, 52.80305f, 52.77928f, 52.7555f, 52.73173f, 52.68603f, 53.44855f, 51.95228f, 52.45311f, 52.73904f, 53.02497f, 53.31091f, 64.66439f, 66.71534f, 61.98367f, 57.25204f, 52.52078f,
51.53994f, 51.64001f, 51.74455f, 51.77105f, 51.71635f, 51.66164f, 51.63732f, 63.86581f, 63.4183f, 62.98794f, 62.87118f, 62.41975f, 61.88997f, 53.88795f, 53.04296f, 53.01505f, 53.6762f, 54.14252f,
53.76822f, 53.27616f, 52.41529f, 52.42603f, 52.43677f, 52.41375f, 52.15231f, 51.8624f, 51.51799f, 51.27926f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.20221f, 51.77678f, 51.77676f, 51.77736f, 51.78902f, 51.80099f, 51.8112f, 51.82008f,
51.82389f, 51.81458f, 51.80526f, 51.79831f, 51.79258f, 51.83772f, 51.90144f, 51.70207f, 51.35846f, 51.01486f, 50.67125f, 50.34012f, 49.06673f, 48.03844f, 48.59656f, 49.29239f, 48.67522f, 48.83638f,
48.95974f, 49.06936f, 48.32439f, 46.19375f, 42.4981f, 35.87901f, 41.41264f, 51.83657f, 52.07668f, 52.26311f, -20.49432f, -71.2406f, -71.29858f, -70.4043f, -68.67928f, -68.70995f, -67.89612f,
-68.50206f, -68.97778f, -69.29321f, -69.43118f, -68.7699f, -66.8093f, -66.05634f, -62.54747f, -49.32834f, -33.41842f, -16.32474f, -5.465919f, 3.152165f, 52.29934f, 52.54354f, 52.59201f, 52.56824f,
52.54446f, 52.53305f, 52.52325f, 52.51345f, 52.50364f, 52.49384f, 52.48403f, 52.47423f, 52.46442f, 52.46439f, 52.59372f, 51.80367f, 53.13f, 53.41594f, 53.70187f, 53.9878f, 91.56242f, 83.28215f,
75.00194f, 66.72179f, 58.44146f, 51.50271f, 51.94777f, 52.42373f, 53.05068f, 53.78872f, 54.52677f, 64.10878f, 63.72656f, 63.28397f, 62.83647f, 62.52949f, 62.11285f, 60.9068f, 57.12489f, 54.96818f,
54.45663f, 55.08523f, 54.90833f, 54.43631f, 53.92126f, 52.32404f, 52.32831f, 52.33276f, 52.34347f, 52.28858f, 52.17928f, 52.30999f, 52.30962f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 51.77702f, 51.77702f, 51.77699f, 51.777f,
51.77756f, 51.78833f, 51.79961f, 51.80851f, 51.80695f, 51.79764f, 51.78831f, 51.779f, 51.77314f, 51.83442f, 51.89814f, 51.71989f, 51.37629f, 51.03268f, 50.71404f, 50.41313f, 50.11222f, 47.8033f,
46.98783f, 48.58312f, 48.69962f, 48.82261f, 48.86072f, 47.24761f, 44.01696f, 41.37238f, 35.188f, 31.69283f, 37.03986f, 15.92618f, -13.75037f, -34.02262f, -71.2406f, -71.2406f, -71.2406f, -70.46069f,
-69.86154f, -69.03084f, -68.55756f, -69.45248f, -70.30273f, -70.74881f, -70.88679f, -70.9799f, -70.67004f, -70.34275f, -69.58978f, -67.45979f, -55.95599f, -40.69788f, -25.60213f, 52.90994f, 52.79827f,
52.52956f, 52.46423f, 52.46425f, 52.46427f, 52.46428f, 52.4643f, 52.46432f, 52.46433f, 52.46435f, 52.46436f, 52.46439f, 52.5167f, 52.89706f, 53.23505f, 53.52098f, 53.80691f, 52.87498f, 50.05674f,
48.06743f, 50.0769f, 89.80656f, 81.52636f, 73.24609f, 64.96582f, 59.10993f, 55.91048f, 55.37535f, 56.1134f, 56.85145f, 58.06421f, 63.93277f, 63.59927f, 63.15145f, 62.70291f, 62.26322f, 61.23702f,
59.37104f, 57.38326f, 56.42948f, 56.08632f, 55.99796f, 55.57644f, 55.10442f, 54.56874f, 52.31217f, 52.3119f, 52.31163f, 52.31137f, 52.31116f, 52.31097f, 52.31076f, 52.31054f, 52.30854f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.26163f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 51.77722f,
51.77722f, 51.77721f, 51.77721f, 51.7772f, 51.77832f, 51.78716f, 51.79633f, 51.78812f, 51.7784f, 51.77138f, 51.76206f, 51.76739f, 51.83111f, 51.89483f, 51.73771f, 51.3998f, 51.09119f, 50.79028f,
50.48937f, 50.18846f, 49.88755f, 48.52428f, 48.57933f, 48.64044f, 48.53644f, 45.25004f, 40.66262f, 35.87787f, 31.55885f, 26.61239f, 14.98024f, -0.4217975f, -18.53647f, -45.01566f, -47.3993f,
-70.7145f, -71.21246f, -71.2406f, -71.01312f, -70.16486f, -69.58218f, -69.40019f, -70.29513f, -71.12108f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.10493f,
-62.37636f, 52.8726f, 52.8726f, 52.90118f, 52.76436f, 52.50062f, 52.46428f, 52.4643f, 52.46432f, 52.46433f, 52.46435f, 52.46436f, 52.46438f, 52.46439f, 52.77374f, 53.29712f, 53.62601f, 53.91194f,
54.04811f, 54.0139f, 52.77711f, 50.78778f, 50.05743f, 50.51705f, 67.45604f, 88.05066f, 79.77039f, 70.58885f, 64.35898f, 64.4026f, 60.24368f, 59.1761f, 59.91417f, 61.11855f, 63.63094f, 63.39313f,
63.08112f, 62.75652f, 62.05415f, 59.89572f, 58.46935f, 58.15632f, 57.8234f, 57.43671f, 56.74209f, 56.19355f, 55.7225f, 55.16552f, 52.31281f, 52.31254f, 52.31229f, 52.31206f, 52.3119f, 52.31171f,
52.3115f, 52.3113f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 51.77747f, 51.77741f, 51.77741f, 51.77741f, 51.77741f, 51.77741f, 51.77817f, 51.78239f, 51.77307f, 51.76151f, 51.75444f, 51.74512f, 51.76409f, 51.8278f, 51.89153f, 51.77088f,
51.46834f, 51.16743f, 50.86652f, 50.56561f, 50.26469f, 49.96379f, 49.21687f, 48.44474f, 48.43222f, 39.61959f, 36.01402f, 30.32741f, 26.93583f, 14.80187f, -1.22455f, -16.00567f, -28.71624f, -46.02247f,
-55.81828f, -61.81135f, -71.2406f, -71.2406f, -71.2406f, -71.22227f, -70.70481f, -70.15467f, -70.24284f, -71.10283f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-70.37483f, -71.2406f, 52.8726f, 52.8726f, 52.8726f, 52.87411f, 52.89242f, 52.73044f, 52.46431f, 52.46433f, 52.46434f, 52.46436f, 52.46437f, 52.46439f, 52.68858f, 53.18583f, 53.69675f, 54.01698f,
54.25274f, 54.13469f, 54.0139f, 54.0139f, 53.50816f, 51.76653f, 51.36187f, 50.9572f, 50.55254f, 65.81555f, 84.4326f, 75.21063f, 66.77001f, 59.88366f, 61.2963f, 63.01663f, 63.43335f, 67.54329f,
67.1076f, 63.42445f, 63.14686f, 62.6251f, 61.01734f, 60.01205f, 59.70071f, 59.38768f, 59.07464f, 58.62842f, 57.8884f, 57.30389f, 56.44057f, 55.71784f, 52.41736f, 52.35963f, 52.32335f, 52.31282f,
52.31264f, 52.31244f, 52.31224f, 53.0611f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 51.77741f, 51.77741f, 51.77741f, 51.77741f, 51.77741f, 51.77742f, 51.77743f, 51.77747f, 51.75613f, 51.74641f, 51.73708f, 50.62727f, 50.78318f,
50.50294f, 50.79848f, 51.03463f, 51.32798f, 51.24367f, 50.94276f, 50.64185f, 50.34093f, 50.04002f, 49.73911f, 48.19083f, 33.77242f, 28.96822f, 23.0436f, 11.47019f, 0.09575629f, -15.1867f, -29.20198f,
-41.79284f, -50.43542f, -59.72335f, -69.61992f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.18787f, -70.72717f, -71.08547f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -69.7229f, -71.2406f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.88341f, 52.68645f, 52.46435f, 52.46437f, 52.46439f, 52.60873f, 53.05821f, 53.59792f,
54.09594f, 54.40794f, 54.40815f, 54.1488f, 54.0139f, 54.0139f, 54.0139f, 54.01238f, 52.26763f, 51.80202f, 51.39735f, 50.99268f, 49.97525f, 49.3515f, 59.5684f, 64.43753f, 57.98764f, 51.53767f,
53.79031f, 62.84583f, 64.74275f, 66.43089f, 63.67119f, 63.2521f, 62.17896f, 61.47341f, 61.15963f, 61.14606f, 61.36199f, 61.5456f, 61.08324f, 60.61742f, 60.13342f, 59.52128f, 52.09608f, 52.25898f,
52.3393f, 52.32273f, 52.30615f, 52.29821f, 52.31164f, 52.37059f, 52.37882f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.0876f, 52.8381f, 52.03327f, 51.77725f, 51.77725f, 51.77727f, 51.77728f, 51.7773f, 51.77731f, 51.77733f, 51.77735f, 51.72814f, 50.61228f,
50.2024f, 50.39587f, 50.62634f, 49.73088f, 49.79348f, 49.71828f, 49.81125f, 49.80605f, 48.98729f, 50.41718f, 50.11626f, 49.81535f, 34.82522f, 24.55158f, 19.75734f, 0.2060676f, -14.10327f, -27.90595f,
-41.98797f, -52.32833f, -60.8283f, -69.63591f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.19632f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.86771f, 52.6274f, 52.52594f, 52.99258f, 53.4703f, 54.01002f,
54.49471f, 54.6213f, 54.35326f, 54.16291f, 54.0139f, 54.0139f, 54.0139f, 54.0139f, 54.0139f, 52.98094f, 52.24216f, 51.8375f, 53.77275f, 50.64476f, 50.02101f, 49.29516f, 49.37833f, 49.65114f, 49.8494f,
50.72926f, 60.16008f, 61.94222f, 63.63035f, 64.4159f, 63.23293f, 63.45037f, 63.68967f, 63.97096f, 64.25227f, 64.53357f, 64.55128f, 64.07518f, 63.73328f, 63.24928f, 54.72752f, 51.24325f, 51.40771f,
51.57216f, 51.70704f, 51.72258f, 51.76043f, 52.79638f, 51.68831f, 51.69653f, 52.3063f, 52.23224f, 52.3063f, 52.0885f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.0378f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 51.38996f, 52.8381f, 53.06191f, 51.7772f, 51.7772f, 51.7772f, 51.7772f, 51.77721f, 51.77709f, 51.77721f, 51.77723f, 49.96604f, 50.19698f,
50.42793f, 50.62202f, 50.85249f, 49.14363f, 51.31342f, 51.45359f, 51.42782f, 50.56488f, 50.97516f, 50.74883f, 50.52251f, 50.29618f, -66.79766f, -37.50364f, -45.59666f, -25.43735f, -57.8154f,
-55.02283f, -62.11402f, -70.18483f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, 9.819304f, 52.87315f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.85195f, 53.34269f, 53.88239f, 54.4221f, 54.7961f,
54.66933f, 54.40697f, 54.10606f, 54.0139f, 54.0139f, 54.0139f, 54.0139f, 54.0139f, 54.0139f, 53.712f, 52.68232f, 53.14893f, 55.15521f, 53.7474f, 50.69053f, 50.06678f, 50.03247f, 50.32124f, 49.90134f,
49.48859f, 57.42501f, 59.14167f, 60.25713f, 60.21823f, 63.93882f, 64.2574f, 64.52599f, 64.89374f, 65.19528f, 65.39575f, 65.62071f, 65.86643f, 66.11765f, 55.45526f, 50.30881f, 50.43214f, 50.55489f,
50.71933f, 50.88379f, 51.02361f, 51.04668f, 51.05491f, 51.00602f, 51.01424f, 52.3063f, 52.27381f, 52.3063f, 51.98664f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.77858f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 51.7772f, 51.7772f, 51.77717f, 51.77712f, 51.77705f, 51.77698f, 51.7765f, 51.77583f, 51.55929f, 50.35936f, 50.42252f,
50.65346f, 50.84817f, 51.07863f, 51.3091f, 51.53957f, 51.75591f, 51.78518f, 49.94662f, 51.66095f, 50.56964f, 51.2083f, -66.73799f, -66.60655f, -66.47511f, -65.8418f, -67.92017f, -68.39237f,
-69.20654f, -70.02068f, -70.83485f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.18922f, 11.18272f, 52.87293f, 52.87218f, 52.87153f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 54.29448f, 54.8342f, 54.97731f, 54.64645f,
54.38392f, 54.12139f, 54.0139f, 54.0139f, 54.0139f, 54.0139f, 54.0139f, 54.0139f, 54.0139f, 54.0139f, 53.12247f, 52.7178f, 52.14989f, 51.7486f, 51.36005f, 50.73629f, 50.68662f, 50.60982f, 49.89645f,
49.49065f, 54.39957f, 56.05847f, 57.57078f, 61.59686f, 64.55066f, 64.67558f, 65.08517f, 65.50159f, 65.93002f, 66.22122f, 66.43961f, 66.68533f, 66.8382f, 50.3078f, 50.30763f, 50.30747f, 50.30731f,
50.30714f, 50.30897f, 50.3641f, 50.39886f, 50.37077f, 50.32373f, 50.33196f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 53.01506f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 51.77703f, 51.77692f, 51.77685f, 51.77678f, 51.77653f, 51.77585f, 51.77518f, 51.46202f, 50.58829f, 50.64805f,
50.87899f, 51.06661f, 51.27721f, 51.48492f, 51.68596f, 51.80722f, 49.83257f, 40.82401f, 17.08762f, -9.105411f, -31.62196f, -66.54688f, -66.41543f, -66.15544f, -66.09435f, -66.94768f, -67.79846f,
-68.61263f, -69.42678f, -70.24094f, -71.05145f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-66.11516f, -13.43483f, 30.89103f, 50.94748f, 52.87196f, 52.87121f, 52.87046f, 52.87153f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 55.2463f, 55.786f, 54.72922f,
54.39925f, 54.13672f, 54.0139f, 54.0139f, 54.0139f, 54.0139f, 54.0139f, 54.0139f, 54.0139f, 54.0139f, 54.0139f, 53.56261f, 53.06804f, 52.45589f, 51.84621f, 51.7486f, 51.40581f, 51.25513f, 50.60493f,
49.89156f, 49.49271f, 51.69769f, 53.93002f, 58.57745f, 63.33311f, 65.11235f, 65.29594f, 65.64333f, 66.063f, 66.49932f, 66.93588f, 67.30819f, 67.50423f, 50.25298f, 50.36809f, 50.36722f, 50.36636f,
50.36551f, 50.36472f, 50.36415f, 50.30895f, 50.26395f, 49.68955f, 49.79786f, 51.56026f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 51.77672f, 51.77665f, 51.77658f, 51.77648f, 51.77594f, 51.77527f, 51.77459f, 51.47514f, 50.63885f,
50.69018f, 51.00732f, 51.18562f, 51.38666f, 51.5877f, 51.78874f, 48.62927f, 43.01455f, 22.24096f, -2.728995f, -23.51603f, -58.58752f, -65.39931f, -66.43289f, -66.09287f, -65.96143f, -66.38863f,
-67.24133f, -68.05208f, -68.86282f, -69.67356f, -70.48431f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -54.52705f, -5.604102f, 34.14439f, 53.30209f, 52.99804f, 52.87023f, 52.86948f, 52.86972f, 52.87161f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.8726f, 52.66804f, 52.58456f, 52.58453f,
52.58449f, 54.48134f, 54.15205f, 53.74479f, 53.70316f, 53.73109f, 53.75902f, 53.78325f, 53.8406f, 53.85972f, 53.87884f, 53.89796f, 53.91709f, 53.92446f, 53.37403f, 52.76188f, 52.14973f, 51.7486f,
51.7486f, 51.31341f, 50.60004f, 49.88667f, 49.49477f, 51.36631f, 56.12197f, 60.87769f, 65.40225f, 65.74103f, 65.95445f, 66.20149f, 66.63207f, 67.06863f, 67.50519f, 68.05556f, 68.32312f, 51.15391f,
51.15271f, 51.15152f, 51.15032f, 51.14528f, 50.94371f, 51.1153f, 51.47192f, 51.78164f, 51.34238f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.2572f, 52.65325f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.5165f, 51.77637f, 51.77631f, 51.77605f, 51.77538f, 51.77474f,
51.77402f, 51.25195f, 50.69061f, 50.66457f, 50.63774f, 50.84406f, 51.39729f, 51.69049f, 49.10762f, 41.19027f, 28.17088f, 3.046295f, -19.3164f, -40.72908f, -66.29608f, -66.16464f, -66.0332f,
-65.90176f, -65.77031f, -65.84487f, -66.63905f, -67.44864f, -68.25821f, -69.13129f, -70.08668f, -71.07677f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -65.24873f, -40.34506f, 2.098728f, 37.6175f, 53.8266f, 53.45141f, 53.07622f, 52.8685f, 52.86791f, 52.8698f, 52.87169f, 52.8726f, 52.8726f, 52.51812f, 52.51957f,
52.51954f, 52.51951f, 52.51947f, 52.51944f, 52.51941f, 53.90484f, 53.06025f, 53.08454f, 53.11243f, 53.18515f, 53.21303f, 53.2409f, 53.26877f, 53.29664f, 53.32451f, 53.32184f, 53.77957f, 53.49323f,
53.06787f, 52.45573f, 51.84694f, 51.7486f, 51.8421f, 51.56947f, 51.45774f, 49.49683f, 53.66649f, 58.42215f, 63.17787f, 66.27621f, 66.36971f, 66.5533f, 66.75159f, 67.20137f, 67.63792f, 68.07449f,
68.59623f, 52.05669f, 52.0555f, 52.0543f, 51.99739f, 51.76681f, 51.54945f, 51.81646f, 52.15487f, 52.26291f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 51.77662f, 51.77612f,
51.77551f, 51.77483f, 51.77395f, 51.77353f, 51.77308f, 50.73801f, 50.71323f, 50.68844f, 50.66365f, 50.67162f, 50.98669f, 39.36567f, 28.30067f, 8.915644f, -13.65873f, -35.32764f, -51.3261f, -68.07758f,
-66.56381f, -65.84932f, -65.71063f, -65.57919f, -65.44774f, -66.11017f, -66.91924f, -67.79162f, -68.68681f, -69.76701f, -70.77058f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -68.99876f, -53.18992f, -22.51423f, 12.09852f, 41.09282f, 54.29514f, 53.91994f, 53.54475f, 53.16956f, 52.86678f, 52.86799f, 52.86988f, 52.87177f, 52.57914f,
52.46058f, 52.45539f, 52.45449f, 52.45446f, 52.45442f, 52.45439f, 52.45436f, 52.44961f, 52.48486f, 52.51273f, 52.54061f, 52.56848f, 52.59636f, 52.62422f, 52.6521f, 52.66474f, 52.6516f, 52.88386f,
53.53817f, 53.28258f, 52.99623f, 52.67192f, 52.14958f, 51.7486f, 51.84412f, 51.99389f, 52.14365f, 52.29343f, 55.96677f, 60.72243f, 65.47809f, 66.87292f, 66.99841f, 67.18198f, 67.36558f, 67.54916f,
68.20724f, 68.6438f, 69.08035f, 53.06273f, 52.89593f, 52.58193f, 52.26793f, 52.18619f, 52.25916f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.24735f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
51.77554f, 51.77478f, 51.77387f, 51.8694f, 52.21599f, 52.56259f, 50.92775f, 50.76369f, 50.7387f, 50.71366f, 50.68861f, 50.66357f, 26.47627f, 14.44486f, -9.162903f, -34.17353f, -48.48433f, -64.46994f,
-69.04324f, -67.52763f, -66.52014f, -65.75871f, -65.38807f, -65.25662f, -65.56641f, -66.37547f, -67.20372f, -68.27988f, -69.27758f, -70.08707f, -70.85374f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -65.98517f, -55.92045f, -27.07231f, 6.339829f, 36.08419f, 51.79832f, 54.6763f, 54.50961f, 54.14734f, 53.78506f, 53.42279f, 53.08505f, 52.82509f, 54.07689f,
52.40897f, 52.40304f, 52.39712f, 52.39145f, 52.3894f, 52.38938f, 52.38934f, 52.38931f, 50.95438f, 50.38406f, 50.87078f, 50.87859f, 51.95182f, 51.97969f, 52.00384f, 51.94709f, 51.92994f, 52.01608f,
52.63006f, 53.28438f, 53.07192f, 52.78558f, 52.49924f, 52.2129f, 51.84752f, 51.84613f, 51.9959f, 52.14567f, 52.29544f, 52.3063f, 65.76955f, 67.77834f, 67.4435f, 67.62708f, 67.81067f, 67.99426f,
68.17784f, 56.87634f, 52.3063f, 52.3063f, 52.3063f, 52.50573f, 52.42085f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 51.93674f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 0f, 0f, 0f, 0f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.81934f, 51.58129f, 52.85053f, 53.16249f, 53.5017f, 53.88991f, 52.43745f, 51.544f, 51.21833f, 50.92283f, 50.76325f, 50.7382f, 50.71317f, 16.68144f, -4.973643f, -29.03853f, -45.6422f, -63.14832f,
-71.22261f, -70.00891f, -68.49329f, -67.33383f, -66.52547f, -65.71713f, -65.06551f, -65.02264f, -65.83171f, -66.84633f, -67.67666f, -68.44332f, -69.21001f, -69.97668f, -70.74336f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -70.12329f, -57.1704f, -30.77592f, -15.80667f, -1.490113f, 29.10373f, 47.0225f, 53.84835f, 54.50483f, 54.63988f, 54.68269f, 54.57101f, 54.20872f, 53.84645f,
54.16531f, 54.14929f, 53.3061f, 52.34551f, 52.33959f, 52.33366f, 52.32774f, 52.32433f, 52.32429f, 52.32426f, 50.38416f, 50.38408f, 50.38405f, 50.38403f, 50.384f, 50.66444f, 51.27877f, 51.26162f,
51.24447f, 51.83688f, 52.37627f, 53.03058f, 52.81782f, 52.53105f, 52.28859f, 52.00225f, 51.77922f, 51.88335f, 52.01109f, 52.14768f, 52.26854f, 52.3063f, 52.3063f, 56.87864f, 56.50082f, 68.25576f,
56.59995f, 56.64951f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 51.5093f, 53.74305f, 55.00825f, 54.74905f, 54.31104f, 52.5146f, 52.18893f, 51.86327f, 51.5376f, 51.21194f, 50.91759f, 50.76276f, -1.054801f, -25.93492f, -46.26909f,
-65.43282f, -69.72565f, -71.21265f, -70.97458f, -69.45897f, -68.14752f, -67.33916f, -66.53082f, -65.72247f, -64.96568f, -65.52315f, -66.36137f, -67.19959f, -68.03781f, -68.87604f, -69.71425f,
-70.55249f, -71.39069f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, 3.81693f, 23.71463f, 34.46418f, 40.71817f, 44.1484f, 52.69625f, 53.44841f, 54.20057f, 54.47092f, 54.54954f, 54.62815f,
54.70677f, 54.45721f, 54.02067f, 53.68559f, 53.24995f, 52.63924f, 52.28205f, 52.27612f, 52.2702f, 52.25622f, 52.20418f, 52.15271f, 50.38354f, 50.38409f, 50.38407f, 50.38405f, 50.38402f, 50.38893f,
50.45025f, 50.57615f, 50.92811f, 51.58378f, 52.23945f, 52.83567f, 52.57753f, 52.2906f, 52.07794f, 51.7916f, 51.85138f, 51.97232f, 52.09326f, 52.2142f, 52.30528f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 54.31429f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 58.23098f, 64.76891f, 71.05129f, 71.44212f, 69.63667f, 64.95132f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 32.18966f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 51.21225f, 53.24923f, 54.80049f, 54.41992f, 54.3255f, 53.15954f, 52.83387f, 52.50821f, 52.18254f, 51.85649f, 51.49836f, 51.13386f, -29.77059f,
-50.43198f, -65.41626f, -68.14536f, -69.63434f, -71.12333f, -71.2406f, -70.42463f, -68.9612f, -68.15285f, -67.34451f, -66.53616f, -65.96408f, -67.04323f, -67.93698f, -68.8002f, -69.66343f, -70.52666f,
-71.38988f, -72.25312f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, 51.70712f, 51.93707f, 52.16702f, 52.20695f, 52.29929f, 52.39163f, 52.41408f, 53.04847f, 53.80063f, 54.30143f, 54.38006f,
54.45868f, 54.48874f, 53.99479f, 53.55824f, 53.16805f, 52.73172f, 52.2954f, 52.03497f, 51.94874f, 51.87919f, 51.80965f, 51.70127f, 50.7322f, 50.38289f, 50.38376f, 50.38409f, 50.38407f, 50.38404f,
50.38974f, 50.37875f, 50.22643f, 50.66297f, 51.33068f, 51.98635f, 52.61799f, 52.36746f, 52.08052f, 51.82163f, 51.83888f, 51.96001f, 52.08114f, 52.23296f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 53.9333f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 65.69151f, 83.75928f, 90.47452f, 92.18419f, 93.84917f, 95.51418f, 96.88273f, 90.23175f, 72.17764f, 52.3063f, 40.33855f, 20.13891f,
0.1474794f, -17.8229f, -39.83488f, -86.04827f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 51.66663f, 52.95274f, 54.40674f, 54.3255f, 54.3255f, 53.80448f, 53.47881f, 53.12531f, 52.76232f, 52.39349f, 52.02465f,
51.65582f, -60.46384f, -65.26875f, -66.56506f, -68.05405f, -69.54303f, -71.03201f, -71.2406f, -71.18924f, -69.87469f, -68.96655f, -68.1582f, -67.43631f, -67.52377f, -68.65521f, -69.74341f, -70.60662f,
-71.46985f, -72.33308f, -73.1963f, -74.05952f, -71.2406f, -71.2406f, -71.2406f, 22.71722f, 52.05507f, 52.35331f, 52.58326f, 52.81322f, 53.10702f, 52.74875f, 52.73912f, 52.84085f, 52.71107f, 53.40069f,
54.10009f, 54.21058f, 54.2892f, 54.09137f, 53.54276f, 53.09581f, 52.65927f, 52.22272f, 51.90033f, 51.81155f, 51.46143f, 51.35703f, 51.28745f, 50.86079f, 50.06597f, 50.38224f, 50.38311f, 50.38385f,
50.38408f, 50.38406f, 50.38605f, 50.37507f, 49.83259f, 49.82353f, 51.07758f, 51.73325f, 52.38892f, 52.15738f, 51.87045f, 51.81832f, 51.93952f, 52.06828f, 52.22488f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.01583f, 51.04808f, 49.8848f, 48.72154f, 93.1973f, 104.3093f, 104.3412f, 104.3731f, 104.027f, 103.3687f, 102.7104f, 102.3542f, 86.85831f, 56.51889f,
31.22999f, 6.263031f, -18.70431f, -43.67127f, -68.63842f, -93.60538f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.57831f, 53.75177f, 54.3255f, 54.3255f, 54.3255f, 54.29485f, 54.02195f, 53.65311f, 53.28428f,
52.91544f, 52.54661f, 52.17777f, -65.10958f, -65.53352f, -66.47375f, -67.96273f, -69.45171f, -70.9407f, -71.2406f, -71.2406f, -70.84035f, -69.78023f, -69.01902f, -68.47128f, -69.11987f, -70.25131f,
-71.1339f, -71.59831f, -71.54355f, -71.73865f, -71.93375f, -71.2406f, -71.2406f, -71.2406f, 52.56118f, 52.63546f, 52.72634f, 53.17928f, 53.22946f, 53.45941f, 53.62181f, 54.19162f, 53.46621f,
53.22926f, 53.1274f, 53.03637f, 53.75291f, 54.0411f, 54.11972f, 53.6646f, 53.11483f, 52.63338f, 52.19684f, 51.76028f, 51.67049f, 51.63492f, 51.2775f, 50.92323f, 50.79853f, 50.38513f, 49.52792f,
50.38158f, 50.38245f, 50.38319f, 50.38401f, 50.38408f, 50.38237f, 50.10888f, 49.43657f, 48.86345f, 50.37706f, 51.48015f, 52.13582f, 51.9473f, 51.7865f, 51.90705f, 52.07201f, 52.2662f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.13017f, 51.96414f, 51.72581f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 47.37625f, 45.32357f, 44.7914f, 37.95909f, 102.5734f, 107.9137f, 107.0396f, 106.0244f, 105.5647f, 105.4861f, 105.4364f,
105.3867f, 105.313f, 82.74482f, 48.57499f, 14.2778f, -19.9566f, -54.19058f, -88.42456f, -122.6582f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.78259f, 53.49002f, 54.31499f, 54.3255f, 54.3255f, 54.3255f, 54.3255f,
54.3255f, 54.17507f, 53.80624f, 53.4374f, 53.06857f, -64.31116f, -65.06612f, -65.84149f, -66.70371f, -67.87142f, -69.36041f, -70.8494f, -71.2406f, -71.2406f, -71.2406f, -70.6012f, -70.04289f,
-69.61481f, -70.71598f, -71.23711f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, 52.7995f, 53.24942f, 53.41575f, 53.6457f, 53.87566f, 54.1056f, 54.285f,
54.58014f, 54.97681f, 54.12469f, 53.59302f, 53.39442f, 53.36199f, 53.87162f, 53.7876f, 53.23783f, 52.68806f, 52.17094f, 51.7344f, 51.41455f, 51.44134f, 51.44336f, 51.10286f, 50.74346f, 50.38532f,
49.79488f, 49.33955f, 50.38087f, 50.38182f, 50.38255f, 50.3834f, 50.38409f, 50.24823f, 49.71177f, 49.047f, 48.08101f, 49.38104f, 50.93056f, 51.88272f, 51.76943f, 51.88905f, 52.08106f, 52.27525f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 51.32729f, 50.76109f, 50.48301f, 51.30342f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 54.46012f, 58.21217f, 60.47407f, 62.80811f, 62.33812f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 42.54108f, 41.4072f, 40.72871f, 96.30368f, 108.9291f, 108.741f, 108.5814f, 108.6505f,
108.6008f, 108.5511f, 108.5014f, 108.4517f, 108.402f, 108.0392f, 79.4437f, 45.21013f, 86.5313f, 79.17007f, 71.80885f, 64.4477f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.85074f, 53.5816f, 54.26742f, 54.3255f, 54.3255f,
54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.2839f, 53.93726f, 53.59053f, -64.41168f, -65.28057f, -66.14946f, -67.01836f, -67.79847f, -69.2691f, -70.75808f, -71.2406f, -71.2406f, -71.2406f,
-71.23331f, -71.07787f, -71.09946f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -70.30841f, -71.2406f, 53.4712f, 53.47041f, 53.87298f, 54.19738f, 54.48605f,
54.7518f, 54.91006f, 54.05426f, 53.88585f, 53.61706f, 53.62278f, 53.62981f, 53.62234f, 53.66357f, 53.36083f, 52.81107f, 52.2613f, 51.71601f, 51.27197f, 51.18493f, 51.2122f, 51.23946f, 50.9282f,
50.56881f, 50.14215f, 49.59061f, 49.40922f, 50.14216f, 50.38129f, 50.38219f, 50.3831f, 50.39597f, 50.3292f, 49.23022f, 48.63638f, 46.61532f, 48.38503f, 49.93455f, 51.46908f, 51.89592f, 52.09012f,
52.28431f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 51.92356f, 50.75255f, 49.88034f, 49.24023f, 49.92941f, 51.33194f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 58.88382f, 68.00723f, 74.03822f, 76.92525f, 77.69243f, 79.87821f, 89.84518f, 91.81891f, 91.7845f, 91.96573f, 91.81889f, 91.81892f, 93.33668f, 97.08923f, 107.0436f, 106.3344f,
105.6252f, 104.9159f, 104.4557f, 104.2853f, 104.1149f, 103.9445f, 103.7743f, 103.6038f, 106.0953f, 103.2404f, 103.0263f, 96.39891f, 93.3359f, 93.3359f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 54.3255f, 54.3255f, 54.3255f,
54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.4786f, -63.85078f, -64.71967f, -65.58855f, -66.45744f, -67.32633f, -68.16071f, -69.17778f, -70.66677f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -47.21351f, 53.70416f, 54.14454f, 54.52307f,
54.85141f, 55.14546f, 54.75499f, 53.74176f, 53.25955f, 53.60101f, 53.60673f, 53.61297f, 53.62029f, 53.48384f, 52.93406f, 52.3843f, 51.83453f, 51.28476f, 50.92878f, 50.95578f, 50.98304f, 51.01031f,
50.75356f, 50.32163f, 49.84528f, 49.36892f, 49.38682f, 50.19291f, 50.38136f, 50.38229f, 50.40921f, 50.4335f, 50.4438f, 50.45411f, 50.04915f, 44.7914f, 47.38902f, 48.93853f, 51.90498f, 52.09917f,
52.29024f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 51.3488f, 50.17781f, 49.30402f, 48.16042f, 48.55538f, 49.95792f, 51.36044f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 89.56709f, 81.56541f, 84.16768f, 87.83732f, 88.64188f, 88.9828f, 90.56341f, 91.2896f, 91.42981f, 91.42981f, 91.42978f, 91.42978f, 91.42978f, 91.42979f, 91.42983f, 92.90381f,
92.73181f, 92.55979f, 92.24327f, 91.42979f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 92.13773f, 93.33589f, 93.33589f, 93.33589f, 93.33589f, 93.33589f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 54.3255f, 54.3255f,
54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 18.83092f, -64.16629f, -64.98824f, -65.89653f, -66.76542f, -67.6343f, -68.50319f, -69.21198f, -70.57547f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.45237f, -71.2406f, 53.97647f, 54.41402f,
54.79463f, 55.17315f, 55.50544f, 54.55983f, 53.43964f, 52.45993f, 53.58496f, 53.59068f, 53.59613f, 53.60344f, 53.05707f, 52.5073f, 51.95753f, 51.40776f, 50.6925f, 50.69936f, 50.80357f, 50.8045f,
50.80952f, 50.56183f, 50.14851f, 49.74368f, 49.35596f, 49.33614f, 50.2492f, 50.38146f, 50.41649f, 50.45858f, 50.46929f, 50.47959f, 50.48988f, 50.51414f, 49.68013f, 44.7914f, 51.1282f, 52.10822f,
52.30242f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 51.94472f, 50.77406f, 49.60306f, 48.34398f, 69.01863f, 70.15491f, 65.26107f, 48.58046f, 50.30319f, 52.3063f, 52.3063f,
52.04229f, 52.3063f, 91.42981f, 91.42981f, 91.42981f, 91.38847f, 91.37379f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 91.42978f, 91.42978f, 91.42984f, 91.42984f,
91.42984f, 91.42979f, 91.42981f, 91.42978f, 91.42979f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 93.3359f, 93.3359f, 93.3359f, 93.3359f, 93.3359f, 0f, 0f, 0f, 0f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 54.3255f,
54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, -72.3507f, -67.73299f, -64.93286f, -66.16189f, -67.07339f, -67.94228f, -68.81117f, -69.60291f, -70.48415f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, 54.411f,
54.64058f, 54.84513f, 55.24465f, 55.70766f, 54.42959f, 52.81362f, 51.24019f, 51.42088f, 53.57462f, 54.78222f, 55.83716f, 55.9977f, 55.34167f, 55.24665f, 50.981f, 50.44294f, 50.65546f, 50.80351f,
50.80444f, 50.80536f, 50.60615f, 50.21712f, 49.82708f, 49.43704f, 49.15515f, 50.29008f, 50.42382f, 50.4717f, 50.49477f, 50.50508f, 50.51538f, 50.52303f, 50.52411f, 50.52403f, 50.52405f, 52.11728f,
52.31147f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 51.37032f, 49.46546f, 66.41946f, 77.0442f, 81.15543f, 86.10324f, 90.79385f, 94.34233f, 65.89938f, 52.3063f,
84.11101f, 91.42981f, 91.4341f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 91.42978f, 91.42978f, 91.42984f,
91.42984f, 91.42984f, 91.42984f, 91.42981f, 91.42982f, 91.42981f, 91.42979f, 91.42981f, 91.42981f, 91.42981f, 91.42983f, 91.42984f, 91.42984f, 93.3359f, 93.3359f, 93.3359f, 93.3359f, 0f, 0f, 0f, 0f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, -55.82491f, -71.8577f, -66.82205f, -64.85096f, -66.17246f, -67.30785f, -68.23433f, -69.11915f, -69.98503f,
-70.63689f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
54.7277f, 54.92482f, 55.12193f, 55.35703f, 55.60022f, 54.40977f, 53.14843f, 53.10401f, 50.62573f, 56.00162f, 56.00045f, 55.99929f, 55.99813f, 55.94192f, 55.70661f, 55.27641f, 55.1074f, 54.07433f,
50.80346f, 51.11179f, 50.98902f, 50.59833f, 50.20763f, 49.81694f, 49.46217f, 49.31032f, 50.43132f, 50.47908f, 50.52008f, 50.52386f, 50.52404f, 50.52406f, 50.52408f, 50.5241f, 50.52411f, 50.52413f,
50.52415f, 52.35908f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 51.88605f, 49.91393f, 61.1293f, 80.71893f, 87.61314f, 92.73741f, 97.53464f, 104.6222f, 107.432f, 98.17633f,
96.65866f, 91.42981f, 91.42981f, 91.42979f, 91.42978f, 91.4298f, 91.42978f, 91.42978f, 91.42979f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 91.42984f,
91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42982f, 91.42984f, 93.33589f, 93.03075f, 91.42981f, 91.42982f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 93.45548f, 93.33589f, 93.33589f, 93.33589f,
0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, -75.98238f, -70.87452f, -65.91109f, -64.76906f, -66.09056f, -67.40985f, -68.4538f,
-69.38464f, -70.29601f, -71.04511f, -71.63248f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, 55.72926f, 55.32342f, 55.1245f, 55.26397f, 55.39632f, 54.4356f, 53.951f, 53.57066f, 53.19032f, 56.00206f, 56.00089f, 55.99973f, 55.99856f, 55.9974f, 55.98551f,
55.81651f, 55.6475f, 55.277f, 55.00977f, 51.3662f, 50.97551f, 50.58481f, 50.19412f, 49.84121f, 49.68983f, 49.54103f, 49.39223f, 50.52995f, 50.52407f, 50.52409f, 50.52412f, 50.52414f, 50.52416f,
50.52417f, 50.52419f, 50.52421f, 50.52422f, 50.52683f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 51.5496f, 49.22892f, 76.38771f, 88.87122f, 98.39182f, 103.7948f, 107.3269f,
107.4823f, 97.33836f, 95.84717f, 91.59708f, 91.42978f, 91.42978f, 91.42978f, 91.42981f, 91.4298f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42981f, 91.42981f,
91.42981f, 91.42978f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.97845f, 93.3359f, 93.33591f, 91.42982f, 91.42982f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.88261f,
93.33506f, 93.3347f, 93.33434f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, -64.147f, -78.90038f, -74.51794f, -70.0358f, -65.00014f, -64.68715f, -66.00865f,
-67.33015f, -68.63646f, -69.59975f, -70.53059f, -71.44888f, -72.33759f, -73.39198f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, 56.13854f, 55.62297f, 55.25527f, 55.08471f, 55.11445f, 54.5891f, 54.20876f, 53.82841f, 53.44807f, 56.00012f, 56.00133f, 55.99978f, 55.99899f,
55.99783f, 56.23044f, 56.35661f, 56.14734f, 55.88011f, 55.61288f, 51.35269f, 50.962f, 50.5713f, 50.22049f, 50.06932f, 49.92053f, 49.77174f, 49.62295f, 50.52413f, 50.52416f, 50.52419f, 50.5242f,
50.52422f, 50.52424f, 50.52426f, 50.52427f, 50.52471f, 50.52628f, 50.52744f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 51.28293f, 70.4054f, 85.50722f, 96.87989f, 104.6667f,
107.4571f, 99.5068f, 96.50449f, 95.09828f, 93.74839f, 91.42984f, 91.42978f, 91.42978f, 91.42981f, 91.42981f, 91.4298f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f,
91.42978f, 91.42978f, 91.42978f, 91.42983f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.69308f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
93.33581f, 92.08327f, 93.3351f, 93.33475f, 93.33439f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 54.3255f, 54.3255f, 54.3255f, 54.3255f, -85.48643f, -81.10402f, -76.72158f, -71.87503f, -67.95674f,
-64.36197f, -64.63111f, -65.92675f, -67.24825f, -68.56976f, -69.81487f, -70.7457f, -71.67655f, -72.60739f, -73.53823f, -74.46908f, -70.85313f, -71.07582f, -72.60297f, -71.2406f, -71.2406f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.35569f, -71.2406f, 40.65723f, 56.42209f, 55.9065f, 55.43598f, 55.26251f, 55.10993f, 54.89791f, 54.55284f, 54.20776f, 53.86269f, 55.99972f,
55.99974f, 55.99975f, 55.99943f, 55.99826f, 56.25347f, 56.57721f, 56.72771f, 56.48321f, 56.21598f, 51.19757f, 50.86053f, 50.59978f, 50.44882f, 50.30003f, 50.15123f, 50.00245f, 49.85365f, 50.31864f,
50.52424f, 50.52427f, 50.52429f, 50.52304f, 50.52097f, 50.51902f, 50.51898f, 50.51911f, 50.51906f, 50.51911f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 50.99853f,
74.29282f, 89.87976f, 103.4755f, 107.45f, 98.02545f, 96.232f, 94.89828f, 93.56458f, 91.42981f, 91.42984f, 91.42978f, 91.42978f, 91.42981f, 91.42981f, 91.4298f, 91.42978f, 91.42978f, 91.42978f,
91.42978f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 91.42979f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42983f, 91.42981f, 91.42976f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 93.4441f, 93.33479f, 93.33443f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 53.01086f, 54.3255f, -71.2406f, -71.2406f, -71.2406f,
-72.24439f, -74.5428f, -70.16038f, -66.91871f, -65.9762f, -65.16064f, -66.05876f, -67.276f, -68.59731f, -69.91182f, -71.0347f, -71.96725f, -73.63317f, -73.83234f, -9.231647f, -71.2406f, -71.2406f,
-70.96268f, -69.61382f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -70.18922f, -71.2406f, 42.05924f, 57.30065f, 56.70567f, 56.16523f, 55.63574f, 55.45597f, 55.31571f, 55.17148f,
54.98334f, 55.52979f, 56.08717f, 55.99969f, 55.99971f, 55.99973f, 55.99974f, 55.9987f, 56.27649f, 56.60023f, 56.92396f, 57.08467f, 56.52245f, 54.3054f, 51.56302f, 50.92654f, 50.67953f, 50.53074f,
50.38195f, 50.23315f, 50.08436f, 49.93557f, 50.51851f, 50.51626f, 50.51402f, 50.51177f, 50.51057f, 50.5106f, 50.51064f, 50.51068f, 50.51073f, 50.51586f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 50.7141f, 82.3885f, 100.8813f, 107.4244f, 98.93542f, 96.38602f, 94.75412f, 91.79821f, 91.42978f, 91.42981f, 91.42984f, 91.42978f, 91.42981f, 91.42981f, 91.42981f,
91.42983f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 91.42978f, 91.42978f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f,
91.42983f, 91.42981f, 91.42976f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 93.33551f, 93.33526f, 93.33501f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, -71.2406f,
-71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.06244f, -69.47936f, -68.58127f, -67.71851f, -66.85706f, -66.28875f, -67.50238f, -68.71601f, -69.92964f, -71.14739f, -71.3472f, -71.2406f, -20.73653f,
7.503434f, 30.13448f, 52.61627f, 40.1646f, -71.2406f, -71.2406f, -71.2406f, -71.09427f, -69.86237f, -71.24304f, -71.2406f, -71.2406f, 43.47542f, 56.90776f, 56.86049f, 56.81174f, 56.30261f, 55.85085f,
55.62252f, 55.48291f, 55.35591f, 55.43871f, 55.86516f, 56.29161f, 56.24136f, 55.99969f, 55.9997f, 55.99971f, 56.00357f, 56.29952f, 56.62326f, 56.8695f, 56.37676f, 54.39154f, 52.69111f, 52.56267f,
51.92566f, 51.27499f, 50.76144f, 50.61266f, 50.46385f, 50.31506f, 50.16628f, 48.57664f, 50.50482f, 50.50257f, 50.50218f, 50.50223f, 50.50227f, 50.50231f, 50.50235f, 50.56828f, 50.95154f, 51.42682f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 50.42967f, 93.87634f, 107.2841f, 102.1184f, 96.64243f, 95.01054f, 91.77978f, 91.42981f, 91.42978f, 91.42981f, 91.42984f, 91.42981f,
91.42981f, 91.42984f, 91.42984f, 91.42984f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42979f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42984f, 91.42984f, 91.42984f,
91.42984f, 91.42984f, 91.42984f, 91.42983f, 91.42981f, 91.42975f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 93.33574f, 93.33551f, 93.33526f, 0f, 0f, 0f, 0f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.16204f, -70.32223f, -69.46078f, -68.59933f, -67.73789f, -67.73236f, -68.94599f, -70.15961f,
-71.2406f, -71.2406f, -43.84f, -7.63563f, 15.89251f, 38.52354f, 51.25579f, 51.96363f, 40.94787f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, -71.2406f, 44.88779f, 56.91193f, 56.86466f,
56.81738f, 56.7701f, 56.4345f, 56.06597f, 55.79358f, 55.66178f, 55.62427f, 55.64792f, 56.06959f, 56.49598f, 56.92237f, 55.99966f, 55.99967f, 55.99969f, 56.01809f, 56.14463f, 56.08249f, 56.13614f,
54.24976f, 53.2863f, 53.3087f, 53.33111f, 52.93427f, 52.28387f, 51.6332f, 50.9874f, 50.69456f, 50.54578f, 50.46454f, 49.51382f, 50.11798f, 51.27906f, 51.51132f, 50.97784f, 50.51149f, 50.49398f,
50.61821f, 51.00396f, 51.38722f, 51.77048f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 50.20044f, 45.04671f, 100.1105f, 96.76222f, 94.93785f, 91.75813f, 91.42981f, 91.42981f,
91.42981f, 93.15701f, 93.15701f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f,
91.42978f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42983f, 91.42981f, 91.42975f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 93.33593f,
93.33569f, 93.33545f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, -44.31763f, -71.2406f, -71.2406f, -71.2406f, -71.10638f, -71.2406f, -71.2406f, -70.68369f, -71.1067f, -70.3416f, -69.48016f,
-68.62147f, -69.17597f, -70.3896f, -71.2406f, -66.57093f, -28.58277f, -0.4130768f, 24.28146f, 46.52788f, 49.89532f, 50.60317f, 49.04863f, 49.04869f, 45.95944f, 45.90884f, 45.96747f, 46.02611f,
56.73805f, 56.75509f, 56.86213f, 56.81475f, 56.76738f, 56.72f, 56.51999f, 56.25176f, 56.03006f, 55.92806f, 55.89413f, 55.88056f, 56.27401f, 56.70041f, 55.6237f, 54.0042f, 54.0101f, 55.41148f,
55.32869f, 55.35716f, 55.63461f, 54.12702f, 53.92839f, 53.95079f, 53.9732f, 53.99561f, 53.92918f, 53.29274f, 52.64208f, 51.9914f, 51.06505f, 50.69007f, 52.02139f, 52.0956f, 51.20714f, 51.9087f,
53.13729f, 53.81399f, 53.26366f, 52.60635f, 51.5815f, 51.43963f, 51.82289f, 52.20615f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 49.98071f, 45.02442f, 96.6629f, 94.83829f, 91.44552f,
91.42978f, 91.42984f, 91.42984f, 91.42984f, 93.33653f, 93.33651f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 91.42978f, 91.42978f,
91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 93.20508f, 93.33824f, 93.33821f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 93.33611f, 93.33588f, 93.33563f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, -29.55488f, -42.34464f, -57.4811f, -67.96637f, -71.2406f, -71.2406f, -71.2406f, -70.42703f,
-69.32521f, -69.51447f, -71.09702f, -70.36099f, -69.54315f, -70.61958f, -71.2406f, -51.68647f, -16.95895f, 6.914209f, 32.67065f, 47.8735f, 49.05671f, 49.04854f, 49.14484f, 50.36417f, 56.64181f,
56.61344f, 56.62257f, 56.68652f, 56.75852f, 56.82343f, 56.83433f, 56.80026f, 56.7669f, 56.73386f, 56.70305f, 56.58f, 56.3729f, 56.18539f, 56.15078f, 56.10065f, 56.3152f, 56.36887f, 55.31979f,
53.73899f, 53.82964f, 54.04937f, 54.76868f, 54.93886f, 54.55808f, 54.57048f, 54.59288f, 54.61529f, 54.6377f, 54.63173f, 54.51685f, 54.30162f, 53.65096f, 53.00029f, 52.34962f, 53.32275f, 53.53421f,
52.64574f, 51.75727f, 52.56855f, 53.69555f, 55.0554f, 56.05857f, 55.13004f, 54.19665f, 52.98941f, 52.25857f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.12635f, 46.01466f,
93.33727f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 93.3365f, 93.33651f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42981f, 91.42981f, 91.42981f, 91.42978f,
91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42979f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 93.33807f, 93.33838f, 93.3383f, 91.42986f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 93.3363f, 93.33606f, 93.33582f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, -3.074325f, -14.79212f, -27.41276f, -40.4649f, -53.18715f, -64.98834f,
-71.2406f, -71.2406f, -69.87305f, -69.10445f, -68.00263f, -67.71149f, -69.47482f, -71.08673f, -70.84955f, -61.34996f, -36.429f, -10.45708f, 15.45398f, 41.0596f, 46.7564f, 49.04845f, 50.40684f,
51.71408f, 56.72435f, 56.69598f, 56.66762f, 56.64753f, 56.71149f, 56.78342f, 56.84395f, 56.8484f, 56.8484f, 56.84801f, 56.83199f, 56.80133f, 56.76797f, 56.63934f, 56.50082f, 56.38605f, 56.3035f,
55.94223f, 55.47319f, 54.98606f, 53.82969f, 53.82964f, 53.91779f, 54.58377f, 54.8128f, 54.78988f, 54.76216f, 54.73368f, 54.70519f, 54.67663f, 51.15496f, 54.32711f, 55.3105f, 54.65983f, 54.00916f,
55.0433f, 54.97281f, 54.08434f, 53.19586f, 52.3074f, 53.22862f, 54.35555f, 55.48249f, 55.92918f, 54.01806f, 52.80928f, 54.31247f, 52.54547f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 93.3365f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 91.42981f, 91.42982f, 91.42987f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42981f,
91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 93.338f, 93.33823f,
93.33798f, 91.42978f, 91.42978f, 91.42978f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 93.33658f, 93.33649f, 93.3364f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 28.32944f, -0.7831196f, -13.58267f,
-26.25504f, -37.98759f, -49.67416f, -61.36086f, -70.41496f, -68.9409f, -67.7384f, -67.32614f, -66.68004f, -65.90848f, -67.6718f, -68.92145f, -46.97545f, -21.17153f, -3.234654f, 24.03434f, 44.45068f,
49.04837f, 50.62313f, 53.06395f, 54.37119f, 56.77853f, 56.75016f, 56.72179f, 56.69342f, 56.73645f, 56.80832f, 56.8484f, 56.8484f, 56.8484f, 56.8484f, 56.8484f, 56.87236f, 56.98653f, 56.82233f,
56.69847f, 56.58021f, 56.51299f, 55.77111f, 54.76774f, 54.20717f, 53.82968f, 53.82964f, 53.9248f, 54.54699f, 54.81587f, 54.7918f, 54.76323f, 54.73465f, 51.89573f, 50.46791f, 50.40361f, 50.40008f,
54.50412f, 56.42424f, 56.4768f, 56.38466f, 55.52294f, 54.63446f, 53.74599f, 52.87754f, 53.88869f, 55.01562f, 56.14256f, 55.96349f, 53.85801f, 52.75766f, 54.01546f, 52.38078f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42982f,
91.42984f, 91.42984f, 91.42984f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42984f, 91.42978f, 91.42978f,
91.42978f, 91.42978f, 91.42978f, 91.44619f, 91.42978f, 91.42978f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42978f, 91.42981f, 93.32286f, 93.33568f, 93.33559f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
10.56932f, 16.23868f, 1.636116f, -11.49212f, -23.57118f, -36.27367f, -48.14645f, -60.8604f, -67.95584f, -66.55193f, -65.57857f, -65.18071f, -64.77649f, -64.24837f, -52.90981f, -31.34276f, -11.41123f,
4.829167f, 32.61458f, 46.5112f, 49.96279f, 54.40822f, 55.88332f, 56.83241f, 56.83015f, 56.80173f, 56.7733f, 56.74487f, 56.76912f, 56.83321f, 56.8484f, 56.8484f, 56.8484f, 56.8484f, 56.8484f, 56.8484f,
57.02411f, 57.02569f, 56.90288f, 56.78007f, 56.4687f, 55.35223f, 54.25999f, 53.84145f, 53.82968f, 53.82964f, 53.93163f, 54.52845f, 54.81673f, 54.79266f, 51.9273f, 50.01899f, 49.95268f, 49.94916f,
49.94109f, 49.93758f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.07307f, 55.18459f, 54.29611f, 53.51088f, 54.54875f, 55.67569f, 56.80263f, 57.92955f, 53.70483f, 54.51112f, 52.8231f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 93.14934f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42987f, 91.42987f, 91.42987f, 91.42986f, 91.42981f,
91.42981f, 93.33659f, 93.33662f, 93.33654f, 91.42975f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.4298f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.88253f, 95.78937f, 93.33486f, 93.33454f, 0f, 0f, 0f, 0f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 35.70328f, 27.05732f, 12.94185f, 4.015786f, -10.37539f, -23.11857f, -35.86176f, -48.60498f, -60.55606f, -65.36488f, -64.01294f, -63.41875f, -63.02088f, -62.623f, -36.70407f, -15.0893f,
-5.641393f, 13.40965f, 41.19506f, 48.3687f, 53.45624f, 56.84086f, 56.8484f, 56.83502f, 56.76649f, 56.83104f, 56.82732f, 56.7989f, 56.79402f, 56.84834f, 56.8484f, 56.8484f, 56.8484f, 56.8484f,
56.8484f, 56.8484f, 57.1098f, 57.23011f, 57.10729f, 57.19485f, 56.05058f, 54.90901f, 53.8645f, 53.83572f, 53.82967f, 53.82964f, 53.94961f, 54.53435f, 52.45602f, 52.27232f, 51.65456f, 51.70189f,
51.74928f, 51.78182f, 51.04895f, 53.20526f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.47585f, 55.73473f, 54.84625f, 54.14424f, 55.20882f, 56.33575f, 57.4627f, 58.58963f, 53.82041f, 52.3063f,
52.24503f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 91.30781f, 91.42978f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42986f, 91.42987f, 91.42987f, 91.42987f,
91.42987f, 91.42987f, 91.42987f, 93.3365f, 93.33655f, 93.33648f, 91.42975f, 91.42975f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42979f, 91.88264f, 93.33524f, 93.33468f, 93.33397f,
0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 45.40905f, 30.4546f, 17.96589f, 9.266422f, -5.791591f, -22.79991f, -35.54314f, -48.28583f, -58.96976f, -62.87062f, -61.70636f, -61.22623f, -60.81681f,
-59.89538f, 1.164176f, 0.1283198f, 36.55293f, 44.47483f, 47.72649f, 51.3361f, 56.01491f, 56.8484f, 56.82944f, 56.65806f, 56.70789f, 56.77296f, 56.83754f, 56.82764f, 56.8484f, 56.8484f, 56.8484f,
56.8484f, 56.8484f, 56.8484f, 56.8484f, 57.2188f, 57.45082f, 57.32826f, 56.48798f, 55.76588f, 54.62664f, 53.86115f, 53.82975f, 53.82967f, 53.82963f, 53.83189f, 54.55234f, 58.58148f, 56.47152f,
56.45744f, 56.45074f, 56.4454f, 55.92567f, 55.17163f, 56.45392f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.28485f, 55.39637f, 54.77758f, 55.86889f, 56.99582f, 58.12276f, 59.2497f,
53.88802f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.59824f, 54.39085f, 52.3063f, 91.42978f, 91.42978f, 91.42978f, 91.42981f, 91.42981f, 91.42981f, 91.42987f, 91.42987f,
91.42987f, 91.42987f, 91.42978f, 91.42978f, 91.42975f, 91.42975f, 91.46269f, 91.46223f, 91.42981f, 91.42981f, 91.42975f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42986f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42992f, 91.42978f, 91.42984f, 91.43765f, 93.33524f,
93.33488f, 93.33453f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 51.86414f, 35.52013f, 24.92086f, 13.92649f, -0.3536545f, -17.95954f, -35.19676f, -47.45218f, -57.38277f, -60.47106f,
-59.1968f, -59.06227f, -58.70123f, 17.41789f, 42.3417f, 44.09349f, 45.60842f, 47.12323f, 50.30111f, 54.80445f, 56.7906f, 56.72006f, 56.6292f, 56.58419f, 56.64927f, 56.89485f, 56.80596f, 56.8484f,
56.8484f, 56.8484f, 56.8484f, 56.8484f, 58.32643f, 58.66426f, 59.00494f, 56.48354f, 56.4768f, 56.4768f, 55.51346f, 56.4768f, 56.4768f, 56.46024f, 53.82967f, 53.82962f, 53.85497f, 54.57031f, 56.4768f,
56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 55.94651f, 55.41093f, 56.52895f, 57.65589f, 58.78283f, 59.90976f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 54.28662f, 66.19963f, 85.96096f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42981f, 91.42987f, 91.42979f, 91.42978f,
91.42978f, 91.42978f, 91.42978f, 91.42975f, 91.42975f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42975f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42979f, 91.42978f, 91.42984f, 91.42984f, 91.42984f, 93.33525f,
93.33489f, 93.33453f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 39.18893f, 30.90321f, 18.58631f, 5.080492f, -12.52171f, -30.12742f, -45.86588f, -56.25257f,
-57.88212f, -56.70151f, -56.94342f, 56.4768f, 56.4768f, 56.4768f, 54.17426f, 55.67822f, 56.4768f, 56.4768f, 56.59559f, 56.5724f, 56.49999f, 56.45348f, 56.52553f, 56.4768f, 56.4768f, 56.4768f,
56.4768f, 56.4768f, 56.73511f, 57.2909f, 57.63087f, 57.97084f, 58.31813f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 54.00355f, 56.4768f, 56.4768f,
56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.44958f, 56.0621f, 57.18902f, 56.84215f, 56.4768f, 56.4768f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 56.46699f, 73.25883f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f,
91.42978f, 91.42978f, 91.42975f, 91.42975f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42975f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42986f, 91.42978f, 91.42978f, 91.42978f, 91.42979f, 91.42978f, 91.42978f, 91.42979f, 91.42984f, 91.42984f, 91.42984f, 93.33525f,
93.3349f, 93.33453f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 46.86509f, 36.15871f, 23.24638f, 10.13987f, -7.083667f, -24.68947f, -44.27938f,
-56.56847f, -55.38786f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.41979f, 56.34738f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f,
56.4768f, 56.45639f, 56.58493f, 56.94674f, 57.26744f, 57.86366f, 58.20453f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f,
56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.48397f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 57.81614f, 74.94739f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f,
91.42975f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 91.42976f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42983f, 91.42978f, 91.42978f, 91.42978f, 91.42982f, 91.42978f, 91.42978f, 91.42978f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 93.33526f, 93.3349f,
93.33454f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.14271f, 40.82002f, 27.90617f, 14.99235f, -1.645721f, -23.10515f, -46.15815f, -14.3267f,
56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.3567f, 55.53902f,
55.87898f, 56.21888f, 56.5508f, 56.94072f, 57.28412f, 57.67324f, 56.54062f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.28456f, 56.16476f, 56.4768f, 56.4768f, 56.4768f, 56.4768f,
56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 52.32783f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 52.3063f, 52.54814f, 59.63839f, 76.33288f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42976f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42975f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42986f, 91.42978f, 91.42978f, 91.42996f, 91.42978f, 91.42978f, 91.42978f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 93.33526f, 93.33491f, 93.33455f, 0f, 0f, 0f,
0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.83308f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 45.59824f, 32.56599f, 19.6522f, 3.823948f, 56.4768f, 56.4768f, 57.83194f, 56.51062f,
56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.18891f, 55.05788f, 54.83305f, 55.17165f, 55.46558f,
55.64851f, 56.01778f, 56.3637f, 56.75282f, 56.64915f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 49.54887f, 45.79565f, 50.37455f, 56.15191f, 56.4768f, 56.4768f, 56.4768f, 56.4768f,
56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
52.3063f, 52.3063f, 56.37178f, 82.72325f, 91.42984f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42975f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42987f,
91.42978f, 91.42978f, 91.42996f, 91.42978f, 91.42978f, 91.42978f, 91.42979f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 93.33527f, 93.33491f, 93.33455f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 54.0245f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f,
56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.1444f, 54.86318f, 53.85144f, 54.12326f, 54.44356f, 54.66569f, 54.84278f, 55.09484f, 55.44329f, 55.83241f,
56.15382f, 56.38494f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 51.24164f, 51.2583f, 54.26766f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f,
56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 53.27633f, 52.3063f, 52.30465f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 52.3063f,
91.42984f, 91.42984f, 91.42984f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42975f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 91.42981f, 91.42981f, 91.42981f, 91.42982f, 91.42986f, 91.42979f, 91.42995f, 91.42978f,
91.42978f, 91.42978f, 91.42978f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 93.33527f, 93.33492f, 93.33456f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f,
56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 55.951f, 54.8223f, 53.53746f, 53.07368f, 53.39398f, 53.68871f, 53.8658f, 54.04289f, 54.21998f, 54.52287f, 54.91199f, 55.18017f, 55.4113f, 55.64244f,
55.87357f, 56.1047f, 56.33583f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f,
56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 53.26551f, 52.4353f, 52.37164f, 52.30977f, 52.3063f, 52.3063f, 52.3063f, 52.3063f, 91.42984f, 91.42984f, 91.42984f,
91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42975f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 91.42981f, 91.42981f, 91.42987f, 91.42982f, 91.42993f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42984f,
91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 93.33528f, 93.33492f, 93.33456f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 56.25665f, 56.50317f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f,
56.4768f, 56.4768f, 56.4768f, 56.4768f, 53.5002f, 52.61414f, 52.8381f, 52.8381f, 52.89834f, 53.06591f, 53.24301f, 53.4201f, 53.63939f, 53.9754f, 54.20654f, 54.43767f, 54.66881f, 54.98602f, 55.52858f,
56.07115f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.45612f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 57.07514f, 56.4768f, 56.4768f, 56.4768f,
56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 53.33522f, 52.52171f, 52.45805f, 52.39439f, 52.33073f, 52.3063f, 52.3063f, 52.3063f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42979f,
91.42978f, 91.42976f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.4298f, 93.3364f, 93.3362f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42979f, 91.42984f, 91.42984f, 91.42984f,
91.42984f, 91.42984f, 91.42984f, 91.42984f, 93.33528f, 93.33493f, 93.33457f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 55.28741f, 55.53631f, 55.83157f, 56.40267f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 57.47948f, 56.4768f, 56.4768f,
56.4768f, 56.4768f, 52.17809f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 53.07212f, 53.61469f, 54.15725f, 54.69982f, 55.24238f, 55.78493f, 56.3275f, 56.4768f,
56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.46769f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 57.69923f, 55.69524f, 56.48158f, 56.4768f, 56.4768f, 56.4768f,
56.4768f, 56.4768f, 56.4768f, 56.4768f, 52.67179f, 52.60812f, 52.54446f, 52.4808f, 52.41714f, 52.36519f, 52.3063f, 52.3063f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 93.18076f, 93.3161f, 91.42983f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f,
91.42984f, 91.42984f, 91.42984f, 93.54169f, 93.33493f, 93.33457f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 53.94016f, 54.23209f, 54.52402f, 54.81596f, 55.38699f, 56.05309f, 56.46493f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f,
56.4768f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 53.1504f, 53.95267f, 54.49636f, 55.04005f, 55.58374f, 56.04129f, 56.4768f, 56.4768f, 56.4768f,
56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.4768f, 52.8381f, 52.8381f, 52.8381f, 57.74926f, 57.43521f, 57.12115f, 56.57713f, 56.45554f, 56.46653f, 56.4768f,
56.4768f, 56.49931f, 57.35801f, 54.01205f, 52.69454f, 52.63088f, 52.56722f, 52.50381f, 52.45416f, 50.68025f, 48.65574f, 91.42984f, 91.42984f, 91.42981f, 91.42981f, 91.42981f, 91.42979f, 91.4298f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42984f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42978f, 91.42984f, 91.42984f, 91.42981f, 91.42981f, 91.42978f, 91.42978f, 91.42978f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f,
91.42984f, 91.42984f, 96.50916f, 93.33495f, 93.33461f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.94878f, 53.21982f, 53.51175f, 53.80368f, 54.33776f, 55.00386f, 55.66994f, 56.09969f, 56.09969f, 56.09969f, 56.09969f, 56.09969f, 56.09969f, 56.09969f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 54.20973f, 54.75342f, 55.29711f, 55.84081f, 56.29765f, 56.26432f, 56.27564f, 56.28695f, 56.4768f,
56.4768f, 56.4768f, 56.4768f, 56.4768f, 56.09969f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 58.42214f, 55.91299f, 55.59892f, 55.28487f, 54.97081f, 54.98507f, 55.12217f,
55.25925f, 55.39634f, 52.8381f, 52.79167f, 52.72814f, 52.66461f, 52.60451f, 51.97911f, 49.95462f, 47.9301f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42979f, 91.42978f, 91.4298f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42984f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42981f, 91.4298f, 91.42979f, 91.42985f, 91.42987f, 91.42981f, 91.42981f, 91.42978f, 91.42978f, 91.42979f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f,
91.42984f, 95.85827f, 93.33572f, 93.33565f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.82098f, 51.51892f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.85015f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 53.0262f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 55.23634f, 54.96576f, 54.97711f, 54.98845f, 54.99963f, 55.00173f, 55.00247f, 55.65831f, 52.8381f,
52.63614f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 54.41925f, 54.70481f, 54.39074f, 54.07669f, 53.76264f, 53.44857f, 53.18439f, 52.92888f, 52.8381f,
52.8381f, 52.8381f, 52.81493f, 52.75485f, 52.69478f, 51.25344f, 49.22896f, 47.20444f, 91.45757f, 94.81593f, 91.42981f, 91.42981f, 91.42981f, 91.42979f, 91.42978f, 91.42978f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42984f, 91.42984f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.64835f, 91.42978f,
91.42984f, 91.42987f, 91.42987f, 91.42981f, 91.42981f, 91.42984f, 91.42978f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 95.04588f,
93.33572f, 93.33565f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.83253f,
49.15018f, 44.7914f, 49.88477f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 53.30403f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 53.73174f, 53.74268f, 53.74424f, 53.74498f, 53.69603f, 52.8381f, 52.8381f, 52.8381f, 52.91933f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 53.49665f, 53.18259f, 52.89779f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.5523f, 55.64254f, 65.99546f, 76.34888f, 102.1112f, 98.00996f, 93.96846f, 91.42981f, 91.42981f, 91.42979f, 91.42978f, 91.42978f, 91.42978f, 91.42981f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42984f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.58267f, 93.33644f, 91.64616f, 91.42986f, 91.42986f,
91.42987f, 91.88621f, 93.338f, 93.338f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 93.3358f, 93.33572f, 93.33565f, 0f, 0f,
0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 55.45537f, 49.70382f, 44.7914f, 40.41899f, 44.7914f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.49612f, 51.72665f, 51.81797f, 62.10573f, 81.96477f, 92.30432f,
99.29528f, 101.509f, 101.204f, 97.16253f, 91.46456f, 91.42981f, 91.42979f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42984f, 91.42984f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42982f, 93.07604f, 91.42983f, 91.42983f, 91.42984f, 91.42982f, 93.338f, 93.338f, 93.338f, 93.338f, 91.42984f,
91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 93.33579f, 93.33572f, 93.33565f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.48314f, 55.98595f, 52.20013f, 44.7914f, 38.75434f, 33.93369f, 44.79139f, 52.63151f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.65855f, 51.48061f, 50.48595f, 55.73916f, 95.436f, 111.479f, 108.2629f, 101.509f, 101.509f, 100.1882f, 95.52576f,
91.42981f, 91.42981f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42981f, 91.42981f, 91.42981f, 91.42984f, 91.42984f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42984f, 91.42984f, 91.42983f, 91.42978f, 91.42978f, 91.42981f, 91.42981f, 93.338f, 93.338f, 93.338f, 93.04276f, 91.42983f, 91.42981f, 91.42981f, 91.42983f, 91.42984f,
91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 93.33579f, 93.33572f, 93.33565f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 56.5627f, 50.81116f, 45.05957f, 39.30802f, 21.33503f, 31.3718f, 44.25523f, 51.32241f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 51.56387f, 50.49003f, 63.18593f, 90.28455f, 113.0593f, 108.5353f, 101.509f, 101.509f, 99.58929f, 98.68182f, 95.46761f, 91.42981f, 91.42978f,
91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.42981f, 91.42982f, 91.42984f, 91.42984f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42984f, 91.42984f,
91.42984f, 91.42983f, 91.42978f, 91.42978f, 91.42978f, 91.42978f, 91.67767f, 93.338f, 93.29367f, 91.42984f, 91.42984f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 92.3781f, 98.05001f,
107.7553f, 117.4605f, 127.1658f, 136.871f, 146.5762f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 57.1164f, 51.3648f,
45.61326f, 39.86168f, 30.35551f, 19.6779f, 29.71468f, 40.36499f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 51.62179f, 50.49409f, 74.74099f, 92.7975f, 110.15f, 108.8079f, 101.7786f, 101.509f, 98.99041f, 98.08295f, 97.17548f, 94.62017f, 91.42978f, 91.42979f, 91.42979f, 91.42979f, 91.42979f,
91.42979f, 91.74418f, 91.75314f, 91.42984f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42983f, 91.42978f, 91.42978f,
91.42978f, 91.42979f, 91.42984f, 91.42983f, 91.42976f, 91.42975f, 91.42982f, 91.42984f, 91.42981f, 91.63541f, 107.3984f, 118.2975f, 119.899f, 121.2667f, 122.36f, 123.3679f, 124.3758f, 125.3838f,
126.3917f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 57.67003f, 51.91844f, 46.16685f, 40.41531f, 34.66372f, 7.984002f,
18.02076f, 28.05753f, 40.66554f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 51.64341f, 50.6316f,
73.99351f, 94.1633f, 107.2407f, 109.0804f, 102.0757f, 101.509f, 98.66368f, 97.48405f, 96.5766f, 95.66912f, 93.77271f, 91.42979f, 91.42979f, 91.42978f, 91.42978f, 93.26816f, 93.3365f, 93.33663f,
93.33655f, 91.42981f, 91.42981f, 91.42981f, 91.42982f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42982f, 91.42978f, 91.42978f, 91.42978f, 91.42981f, 91.42984f,
91.42982f, 91.42984f, 91.42984f, 91.42976f, 91.42982f, 100.2664f, 115.9178f, 119.5608f, 121.6243f, 122.9105f, 124.9289f, 131.4595f, 139.3381f, 147.2164f, 154.525f, 159.4854f, 0f, 0f, 0f, 0f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 58.22374f, 52.4722f, 46.72061f, 40.96901f, 35.21747f, -3.709907f, 6.326875f, 16.36363f, 26.40041f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 51.92696f, 50.71902f, 74.30026f, 95.29961f, 104.3315f, 109.3529f,
102.3726f, 101.509f, 99.25504f, 96.88519f, 95.97772f, 95.07026f, 94.16276f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 93.26823f, 93.33663f, 93.33739f, 93.33645f, 91.42984f, 91.42984f, 91.42984f,
91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42982f, 91.42978f, 91.42978f, 91.42979f, 91.42981f, 91.42984f, 91.42982f, 91.42984f, 91.42984f, 91.42984f,
105.4818f, 116.261f, 119.5422f, 122.314f, 132.0391f, 139.4463f, 145.7034f, 147.6977f, 147.3616f, 147.2195f, 147.5279f, 150.7457f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 54.29965f, 53.02578f, 47.27424f, 41.52265f, 35.77106f, 15.55622f, -5.36705f, 4.669732f, 14.70649f, 34.50943f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.24583f, 50.74064f, 73.66946f, 92.46635f, 101.4222f, 109.6255f, 102.6696f, 101.509f, 99.84644f, 96.2863f,
95.37884f, 94.47137f, 93.56388f, 91.42981f, 91.42983f, 91.42983f, 91.42983f, 91.42984f, 92.95049f, 93.33766f, 91.42978f, 91.42982f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f,
91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42978f, 91.42978f, 91.42981f, 91.42981f, 91.42982f, 91.42984f, 91.42979f, 91.42984f, 100.4706f, 117.2275f, 120.1693f, 123.3088f, 135.3984f,
143.474f, 150.6301f, 154.1691f, 154.9229f, 156.8883f, 158.7471f, 159.9937f, 165.1269f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 54.48452f, 53.57947f,
47.82788f, 42.07635f, 36.32475f, 28.83232f, -17.06095f, -7.024179f, 3.012604f, 13.04936f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 54.65261f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.5647f, 50.76225f, 54.96217f, 86.27901f, 98.51287f, 109.898f, 102.9667f, 101.509f, 100.4378f, 95.68742f, 94.77995f, 93.87249f, 91.42981f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42984f, 91.42984f, 91.42984f, 91.42978f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f,
91.42984f, 91.42978f, 91.42978f, 91.42981f, 91.42981f, 91.42982f, 91.42984f, 91.42978f, 95.46572f, 116.9756f, 122.2337f, 125.5627f, 137.6609f, 146.1948f, 155.7055f, 159.0844f, 163.1081f, 164.4938f,
165.1239f, 164.8177f, 161.646f, 163.2827f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 54.67429f, 54.13312f, 48.38157f, 42.62999f, 36.87845f, 31.12686f, -28.75485f,
-18.71809f, -8.681322f, 1.355461f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 50.87649f, 55.03121f, 78.08966f, 94.03563f, 107.6027f, 103.4264f, 101.509f, 101.0293f, 95.50679f, 94.18108f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42978f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42978f, 91.42981f,
91.42981f, 91.42981f, 91.42981f, 91.42978f, 91.52194f, 115.7779f, 121.9635f, 127.1971f, 137.2206f, 144.9904f, 156.9405f, 163.2394f, 165.164f, 169.6318f, 171.3074f, 171.208f, 171.1317f, 171.9777f,
171.9777f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 54.68681f, 48.93522f, 43.18367f, 37.43209f, 31.68055f, -40.44876f, -30.41198f, -20.37522f, -10.33845f, 1.838943f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 51.19537f,
55.10032f, 73.60544f, 87.9012f, 102.2984f, 104.0158f, 101.509f, 101.509f, 96.09816f, 93.58221f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42984f, 91.42984f, 91.42984f, 91.42984f,
91.42984f, 91.42984f, 91.42982f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42983f, 91.42978f, 91.42981f, 91.42981f, 91.42981f, 91.42981f,
91.42978f, 93.49416f, 119.8406f, 126.6334f, 131.9008f, 142.1691f, 147.5485f, 161.9334f, 165.1068f, 171.9247f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 0f, 0f, 0f, 0f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 55.69474f, 49.48885f, 43.73726f, 37.98572f, 32.23413f, -0.4308033f, -42.10591f, -32.06912f, -22.03237f, -11.99559f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 51.51424f, 55.16936f, 67.44466f,
80.98978f, 96.99377f, 104.6054f, 101.509f, 101.509f, 96.68956f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f,
91.42978f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42983f, 91.42978f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 103.0753f,
122.6675f, 131.2341f, 136.8301f, 145.1646f, 155.8454f, 164.7572f, 171.8392f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 56.25079f, 50.51115f, 44.29102f, 39.03174f, 33.2921f, 27.55239f, -54.0326f, -44.01657f, -34.00055f, -23.98454f, -13.96851f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 53.30998f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 51.83311f, 49.826f, 60.53332f, 74.07843f, 91.68919f, 101.509f,
101.509f, 101.509f, 97.28093f, 91.42981f, 91.42981f, 91.42981f, 91.42982f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f,
91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42983f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 112.1991f, 125.4945f, 134.2982f, 141.9552f,
144.0511f, 159.2064f, 166.223f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 52.8381f, 56.80677f, 51.06707f, 45.32743f,
39.09307f, 33.84802f, 28.10838f, -65.70123f, -55.6852f, -45.66918f, -35.65315f, -25.63714f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 53.11674f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 53.26444f, 52.8381f, 52.8381f, 52.15199f, 50.14489f, 53.62184f, 67.16695f, 107.7236f, 101.509f, 101.509f, 103.3948f, 91.42981f,
91.42981f, 91.42981f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42984f,
91.42984f, 91.42984f, 91.42984f, 91.42984f, 91.42983f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42981f, 91.42978f, 120.5697f, 128.3214f, 137.1252f, 147.0803f, 152.2937f, 162.9797f, 168.1325f,
171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 0f, 0f, 0f, 0f, 52.8381f, 52.8381f, 57.36276f, 51.62312f, 45.88341f, 40.14371f, 33.89516f, 28.66436f,
-77.36983f, -67.35382f, -57.33779f, -47.32177f, -37.30574f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 53.21466f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 54.6969f, 52.8381f, 52.47086f, 50.46376f, 46.71049f, 60.25561f, 107.7222f, 101.509f, 101.509f, 100.4587f, 93.33665f, 93.33663f, 93.33662f, 93.33662f,
93.33661f, 93.16045f, 93.2392f, 93.31795f, 93.3967f, 93.33655f, 93.33655f, 93.33652f, 93.33652f, 93.33651f, 93.3365f, 93.33649f, 93.33649f, 93.33649f, 93.33648f, 93.33647f, 93.33646f, 93.33646f,
93.33646f, 93.33645f, 93.33644f, 93.33643f, 93.33642f, 93.33638f, 93.33637f, 94.61661f, 131.1118f, 131.1484f, 139.9521f, 152.2054f, 154.3855f, 164.5452f, 171.9777f, 171.9777f, 171.9777f, 171.9777f,
171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 0f, 0f, 0f, 0f, 52.8381f, 57.9188f, 52.1791f, 46.43946f, 40.69975f, 34.96011f, 28.69729f, 23.4807f, -79.02245f, -69.00642f, -58.99039f,
-48.97437f, -38.95834f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.39562f, 50.38435f, 42.1693f, 55.74242f, 101.509f, 101.509f, 101.509f, 93.33667f, 93.33666f, 93.33663f, 93.33662f, 93.33662f, 93.33663f, 93.33662f, 93.33661f,
93.33659f, 93.33658f, 93.33657f, 93.33656f, 93.33654f, 93.33653f, 93.33622f, 93.33652f, 93.33651f, 93.33651f, 93.3365f, 93.3365f, 93.33649f, 93.33648f, 93.33648f, 93.33647f, 93.33647f, 93.33646f,
93.33637f, 93.33636f, 93.33636f, 93.33636f, 93.33635f, 140.434f, 133.9754f, 141.9681f, 157.3306f, 157.7172f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f,
171.9777f, 171.9777f, 0f, 0f, 0f, 0f, 58.47479f, 52.73515f, 46.99544f, 41.2558f, 35.51609f, 29.77639f, 23.49938f, -90.69103f, -80.675f, -70.659f, -60.64297f, -50.62695f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f,
52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.58765f, 52.8381f, 52.8381f, 53.49289f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 52.8381f, 39.85009f,
52.71537f, 50.70411f, 35.23888f, 48.812f, 101.509f, 101.509f, 101.509f, 93.33669f, 93.33665f, 93.33665f, 93.33665f, 93.33665f, 93.33664f, 93.33664f, 93.33662f, 93.33662f, 93.3366f, 93.33659f,
93.33657f, 93.33656f, 93.33654f, 93.33595f, 93.33654f, 93.33653f, 93.33652f, 93.33652f, 93.33652f, 93.33652f, 93.3365f, 93.33649f, 93.33649f, 93.33649f, 93.33647f, 93.33634f, 93.33633f, 93.33633f,
93.33633f, 93.33632f, 149.7562f, 136.8024f, 145.6061f, 155.726f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 171.9777f, 0f, 0f, 0f,
0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f,
0f, 0f, 0f };

    }
}
