﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Xunit;

namespace System.Security.Cryptography.X509Certificates.Tests
{
    internal static class TestData
    {
        public static byte[] MsCertificate = (
            "308204ec308203d4a003020102021333000000b011af0a8bd03b9fdd00010000" +
            "00b0300d06092a864886f70d01010505003079310b3009060355040613025553" +
            "311330110603550408130a57617368696e67746f6e3110300e06035504071307" +
            "5265646d6f6e64311e301c060355040a13154d6963726f736f667420436f7270" +
            "6f726174696f6e312330210603550403131a4d6963726f736f667420436f6465" +
            "205369676e696e6720504341301e170d3133303132343232333333395a170d31" +
            "34303432343232333333395a308183310b300906035504061302555331133011" +
            "0603550408130a57617368696e67746f6e3110300e060355040713075265646d" +
            "6f6e64311e301c060355040a13154d6963726f736f667420436f72706f726174" +
            "696f6e310d300b060355040b13044d4f5052311e301c060355040313154d6963" +
            "726f736f667420436f72706f726174696f6e30820122300d06092a864886f70d" +
            "01010105000382010f003082010a0282010100e8af5ca2200df8287cbc057b7f" +
            "adeeeb76ac28533f3adb407db38e33e6573fa551153454a5cfb48ba93fa837e1" +
            "2d50ed35164eef4d7adb137688b02cf0595ca9ebe1d72975e41b85279bf3f82d" +
            "9e41362b0b40fbbe3bbab95c759316524bca33c537b0f3eb7ea8f541155c0865" +
            "1d2137f02cba220b10b1109d772285847c4fb91b90b0f5a3fe8bf40c9a4ea0f5" +
            "c90a21e2aae3013647fd2f826a8103f5a935dc94579dfb4bd40e82db388f12fe" +
            "e3d67a748864e162c4252e2aae9d181f0e1eb6c2af24b40e50bcde1c935c49a6" +
            "79b5b6dbcef9707b280184b82a29cfbfa90505e1e00f714dfdad5c238329ebc7" +
            "c54ac8e82784d37ec6430b950005b14f6571c50203010001a38201603082015c" +
            "30130603551d25040c300a06082b06010505070303301d0603551d0e04160414" +
            "5971a65a334dda980780ff841ebe87f9723241f230510603551d11044a3048a4" +
            "463044310d300b060355040b13044d4f5052313330310603550405132a333135" +
            "39352b34666166306237312d616433372d346161332d613637312d3736626330" +
            "35323334346164301f0603551d23041830168014cb11e8cad2b4165801c9372e" +
            "331616b94c9a0a1f30560603551d1f044f304d304ba049a0478645687474703a" +
            "2f2f63726c2e6d6963726f736f66742e636f6d2f706b692f63726c2f70726f64" +
            "756374732f4d6963436f645369675043415f30382d33312d323031302e63726c" +
            "305a06082b06010505070101044e304c304a06082b06010505073002863e6874" +
            "74703a2f2f7777772e6d6963726f736f66742e636f6d2f706b692f6365727473" +
            "2f4d6963436f645369675043415f30382d33312d323031302e637274300d0609" +
            "2a864886f70d0101050500038201010031d76e2a12573381d59dc6ebf93ad444" +
            "4d089eee5edf6a5bb779cf029cbc76689e90a19c0bc37fa28cf14dba9539fb0d" +
            "e0e19bf45d240f1b8d88153a7cdbadceb3c96cba392c457d24115426300d0dff" +
            "47ea0307e5e4665d2c7b9d1da910fa1cb074f24f696b9ea92484daed96a0df73" +
            "a4ef6a1aac4b629ef17cc0147f48cd4db244f9f03c936d42d8e87ce617a09b68" +
            "680928f90297ef1103ba6752adc1e9b373a6d263cd4ae23ee4f34efdffa1e0bb" +
            "02133b5d20de553fa3ae9040313875285e04a9466de6f57a7940bd1fcde845d5" +
            "aee25d3ef575c7e6666360ccd59a84878d2430f7ef34d0631db142674a0e4bbf" +
            "3a0eefb6953aa738e4259208a6886682").HexToByteArray();

        public const string PfxDataPassword = "12345";

        public static byte[] PfxData = (
            "308206a20201033082065e06092a864886f70d010701a082064f0482064b3082" +
            "0647308203c006092a864886f70d010701a08203b1048203ad308203a9308203" +
            "a5060b2a864886f70d010c0a0102a08202b6308202b2301c060a2a864886f70d" +
            "010c0103300e04085052002c7da2c2a6020207d0048202907d485e3bfc6e6457" +
            "c811394c145d0e8a18325646854e4ff0097bc5a98547f5ad616c8efda8505aa8" +
            "7564ed4800a3139759497c60c6688b51f376acae906429c8771cb1428226b68a" +
            "6297207bcc9dd7f9563478dd83880aab2304b545759b2275305df4eff9fac24a" +
            "3cc9d3b2d672efe45d8f48e24a16506c1d7566fc6d1b269fbf201b3ac3309d3e" +
            "bc6fd606257a7a707aa2f790ea3fe7a94a51138540c5319010cba6de9fb9d85f" +
            "cdc78da60e33df2f21c46fb9a8554b4f82e0a6edba4db5585d77d331d35daaed" +
            "51b6a5a3e000a299880fb799182c8ca3004b7837a9feb8bfc76778089993f3d1" +
            "1d70233608af7c50722d680623d2bf54bd4b1e7a604184d9f44e0af8099ffa47" +
            "1e5536e7902793829db9902ddb61264a62962950ad274ea516b2d44be9036530" +
            "016e607b73f341aeefed2211f6330364738b435b0d2ed6c57747f6c8230a053f" +
            "78c4dd65db83b26c6a47836a6cbbab92cbb262c6fb6d08632b4457f5fa8eabfa" +
            "65db34157e1d301e9085cc443582cdd15404314872748545eb3fc3c574882655" +
            "8c9a85f966e315775bbe9da34d1e8b6dadc3c9e120c6d6a2e1cffe4eb014c3ce" +
            "fbc19356ce33dac60f93d67a4de247b0dae13cd8b8c9f15604cc0ec9968e3ad7" +
            "f57c9f53c45e2ecb0a0945ec0ba04baa15b48d8596edc9f5fe9165a5d21949fb" +
            "5fe30a920ad2c0f78799f6443c300629b8ca4dca19b9dbf1e27aab7b12271228" +
            "119a95c9822be6439414beeae24002b46eb97e030e18bd810ade0bcf4213a355" +
            "038b56584b2fbcc3f5ea215d0cf667ffd823ea03ab62c3b193dfb4450aabb50b" +
            "af306e8088ee7384fa2fdff03e0dd7acd61832223e806a94d46e196462522808" +
            "3163f1caf333fdbbe2d54ca86968867ce0b6dd5e5b7f0633c6fab4a19cc14f64" +
            "5ec14d0b1436f7623181db301306092a864886f70d0109153106040401000000" +
            "305d06092b060104018237110131501e4e004d006900630072006f0073006f00" +
            "6600740020005300740072006f006e0067002000430072007900700074006f00" +
            "67007200610070006800690063002000500072006f0076006900640065007230" +
            "6506092a864886f70d01091431581e5600500076006b0054006d0070003a0034" +
            "0064006100340061003100650036002d0066003700380062002d003400360061" +
            "0035002d0039003800380033002d003500320063003800330032006100340063" +
            "0030006100623082027f06092a864886f70d010706a08202703082026c020100" +
            "3082026506092a864886f70d010701301c060a2a864886f70d010c0106300e04" +
            "08e0c117e67a75d8eb020207d080820238292882408b31826f0dc635f9bbe7c1" +
            "99a48a3b4fefc729dbf95508d6a7d04805a8dd612427f93124f522ac7d3c6f4d" +
            "db74d937f57823b5b1e8cfae4ece4a1fffd801558d77ba31985aa7f747d834cb" +
            "e84464ef777718c9865c819d6c9daa0fa25e2a2a80b3f2aaa67d40e382eb084c" +
            "ca85e314ea40c3ef3ed1593904d7a16f37807c99af06c917093f6c5aaebb12a6" +
            "c58c9956d4fbbdde1f1e389989c36e19dd38d4b978d6f47131e458ab68e237e4" +
            "0cb6a87f21c8773de845780b50995a51f041106f47c740b3bd946038984f1ac9" +
            "e91230616480962f11b0683f8802173c596c4bd554642f51a76f9dfff9053def" +
            "7b3c3f759fc7eeac3f2386106c4b8cb669589e004fb235f0357ea5cf0b5a6fc7" +
            "8a6d941a3ae44af7b601b59d15cd1ec61bccc481fbb83eae2f83153b41e71ef7" +
            "6a2814ab59347f116ab3e9c1621668a573013d34d13d3854e604286733c6bad0" +
            "f511d7f8fd6356f7c3198d0cb771af27f4b5a3c3b571fdd083fd68a9a1eea783" +
            "152c436f7513613a7e399a1da48d7e55db7504dc47d1145df8d7b6d32eaa4cce" +
            "e06f98bb3dda2cc0d0564a962f86dfb122e4f7e2ed6f1b509c58d4a3b2d0a687" +
            "88f7e313aecfbdef456c31b96fc13586e02aeb65807ed83bb0cb7c28f157bc95" +
            "c9c593c9194691539ae3c620ed1d4d4af0177f6b9483a5341d7b084bc5b425af" +
            "b658168ee2d8fb2bfab07a3ba061687a5ecd1f8da9001dd3e7be793923094abb" +
            "0f2cf4d24cb071b9e568b18336bb4dc541352c9785c48d0f0e53066eb2009efc" +
            "b3e5644ed12252c1bc303b301f300706052b0e03021a0414f90827ae93fd3a91" +
            "54c3c0840d7950b0e30ffbaf0414e147930b932899741c92d765226893877025" +
            "4a2b020207d0").HexToByteArray();

        public static byte[] StoreSavedAsPfxData = (
            "3082070406092a864886f70d010702a08206f5308206f10201013100300b0609" +
            "2a864886f70d010701a08206d9308201e530820152a0030201020210d5b5bc1c" +
            "458a558845bff51cb4dff31c300906052b0e03021d05003011310f300d060355" +
            "040313064d794e616d65301e170d3130303430313038303030305a170d313130" +
            "3430313038303030305a3011310f300d060355040313064d794e616d6530819f" +
            "300d06092a864886f70d010101050003818d0030818902818100b11e30ea8742" +
            "4a371e30227e933ce6be0e65ff1c189d0d888ec8ff13aa7b42b68056128322b2" +
            "1f2b6976609b62b6bc4cf2e55ff5ae64e9b68c78a3c2dacc916a1bc7322dd353" +
            "b32898675cfb5b298b176d978b1f12313e3d865bc53465a11cca106870a4b5d5" +
            "0a2c410938240e92b64902baea23eb093d9599e9e372e48336730203010001a3" +
            "46304430420603551d01043b3039801024859ebf125e76af3f0d7979b4ac7a96" +
            "a1133011310f300d060355040313064d794e616d658210d5b5bc1c458a558845" +
            "bff51cb4dff31c300906052b0e03021d0500038181009bf6e2cf830ed485b86d" +
            "6b9e8dffdcd65efc7ec145cb9348923710666791fcfa3ab59d689ffd7234b787" +
            "2611c5c23e5e0714531abadb5de492d2c736e1c929e648a65cc9eb63cd84e57b" +
            "5909dd5ddf5dbbba4a6498b9ca225b6e368b94913bfc24de6b2bd9a26b192b95" +
            "7304b89531e902ffc91b54b237bb228be8afcda26476308204ec308203d4a003" +
            "020102021333000000b011af0a8bd03b9fdd0001000000b0300d06092a864886" +
            "f70d01010505003079310b300906035504061302555331133011060355040813" +
            "0a57617368696e67746f6e3110300e060355040713075265646d6f6e64311e30" +
            "1c060355040a13154d6963726f736f667420436f72706f726174696f6e312330" +
            "210603550403131a4d6963726f736f667420436f6465205369676e696e672050" +
            "4341301e170d3133303132343232333333395a170d3134303432343232333333" +
            "395a308183310b3009060355040613025553311330110603550408130a576173" +
            "68696e67746f6e3110300e060355040713075265646d6f6e64311e301c060355" +
            "040a13154d6963726f736f667420436f72706f726174696f6e310d300b060355" +
            "040b13044d4f5052311e301c060355040313154d6963726f736f667420436f72" +
            "706f726174696f6e30820122300d06092a864886f70d01010105000382010f00" +
            "3082010a0282010100e8af5ca2200df8287cbc057b7fadeeeb76ac28533f3adb" +
            "407db38e33e6573fa551153454a5cfb48ba93fa837e12d50ed35164eef4d7adb" +
            "137688b02cf0595ca9ebe1d72975e41b85279bf3f82d9e41362b0b40fbbe3bba" +
            "b95c759316524bca33c537b0f3eb7ea8f541155c08651d2137f02cba220b10b1" +
            "109d772285847c4fb91b90b0f5a3fe8bf40c9a4ea0f5c90a21e2aae3013647fd" +
            "2f826a8103f5a935dc94579dfb4bd40e82db388f12fee3d67a748864e162c425" +
            "2e2aae9d181f0e1eb6c2af24b40e50bcde1c935c49a679b5b6dbcef9707b2801" +
            "84b82a29cfbfa90505e1e00f714dfdad5c238329ebc7c54ac8e82784d37ec643" +
            "0b950005b14f6571c50203010001a38201603082015c30130603551d25040c30" +
            "0a06082b06010505070303301d0603551d0e041604145971a65a334dda980780" +
            "ff841ebe87f9723241f230510603551d11044a3048a4463044310d300b060355" +
            "040b13044d4f5052313330310603550405132a33313539352b34666166306237" +
            "312d616433372d346161332d613637312d373662633035323334346164301f06" +
            "03551d23041830168014cb11e8cad2b4165801c9372e331616b94c9a0a1f3056" +
            "0603551d1f044f304d304ba049a0478645687474703a2f2f63726c2e6d696372" +
            "6f736f66742e636f6d2f706b692f63726c2f70726f64756374732f4d6963436f" +
            "645369675043415f30382d33312d323031302e63726c305a06082b0601050507" +
            "0101044e304c304a06082b06010505073002863e687474703a2f2f7777772e6d" +
            "6963726f736f66742e636f6d2f706b692f63657274732f4d6963436f64536967" +
            "5043415f30382d33312d323031302e637274300d06092a864886f70d01010505" +
            "00038201010031d76e2a12573381d59dc6ebf93ad4444d089eee5edf6a5bb779" +
            "cf029cbc76689e90a19c0bc37fa28cf14dba9539fb0de0e19bf45d240f1b8d88" +
            "153a7cdbadceb3c96cba392c457d24115426300d0dff47ea0307e5e4665d2c7b" +
            "9d1da910fa1cb074f24f696b9ea92484daed96a0df73a4ef6a1aac4b629ef17c" +
            "c0147f48cd4db244f9f03c936d42d8e87ce617a09b68680928f90297ef1103ba" +
            "6752adc1e9b373a6d263cd4ae23ee4f34efdffa1e0bb02133b5d20de553fa3ae" +
            "9040313875285e04a9466de6f57a7940bd1fcde845d5aee25d3ef575c7e66663" +
            "60ccd59a84878d2430f7ef34d0631db142674a0e4bbf3a0eefb6953aa738e425" +
            "9208a68866823100").HexToByteArray();


        public static byte[] StoreSavedAsCerData = (
            "308201e530820152a0030201020210d5b5bc1c458a558845bff51cb4dff31c30" +
            "0906052b0e03021d05003011310f300d060355040313064d794e616d65301e17" +
            "0d3130303430313038303030305a170d3131303430313038303030305a301131" +
            "0f300d060355040313064d794e616d6530819f300d06092a864886f70d010101" +
            "050003818d0030818902818100b11e30ea87424a371e30227e933ce6be0e65ff" +
            "1c189d0d888ec8ff13aa7b42b68056128322b21f2b6976609b62b6bc4cf2e55f" +
            "f5ae64e9b68c78a3c2dacc916a1bc7322dd353b32898675cfb5b298b176d978b" +
            "1f12313e3d865bc53465a11cca106870a4b5d50a2c410938240e92b64902baea" +
            "23eb093d9599e9e372e48336730203010001a346304430420603551d01043b30" +
            "39801024859ebf125e76af3f0d7979b4ac7a96a1133011310f300d0603550403" +
            "13064d794e616d658210d5b5bc1c458a558845bff51cb4dff31c300906052b0e" +
            "03021d0500038181009bf6e2cf830ed485b86d6b9e8dffdcd65efc7ec145cb93" +
            "48923710666791fcfa3ab59d689ffd7234b7872611c5c23e5e0714531abadb5d" +
            "e492d2c736e1c929e648a65cc9eb63cd84e57b5909dd5ddf5dbbba4a6498b9ca" +
            "225b6e368b94913bfc24de6b2bd9a26b192b957304b89531e902ffc91b54b237" +
            "bb228be8afcda26476").HexToByteArray();

        public static byte[] StoreSavedAsSerializedCerData = (
            "0200000001000000bc0000001c0000006c000000010000000000000000000000" +
            "00000000020000007b00370037004500420044003000320044002d0044003800" +
            "440045002d0034003700350041002d0038003800360037002d00440032003000" +
            "4200300030003600340045003400390046007d00000000004d00690063007200" +
            "6f0073006f006600740020005300740072006f006e0067002000430072007900" +
            "700074006f0067007200610070006800690063002000500072006f0076006900" +
            "64006500720000002000000001000000e9010000308201e530820152a0030201" +
            "020210d5b5bc1c458a558845bff51cb4dff31c300906052b0e03021d05003011" +
            "310f300d060355040313064d794e616d65301e170d3130303430313038303030" +
            "305a170d3131303430313038303030305a3011310f300d060355040313064d79" +
            "4e616d6530819f300d06092a864886f70d010101050003818d00308189028181" +
            "00b11e30ea87424a371e30227e933ce6be0e65ff1c189d0d888ec8ff13aa7b42" +
            "b68056128322b21f2b6976609b62b6bc4cf2e55ff5ae64e9b68c78a3c2dacc91" +
            "6a1bc7322dd353b32898675cfb5b298b176d978b1f12313e3d865bc53465a11c" +
            "ca106870a4b5d50a2c410938240e92b64902baea23eb093d9599e9e372e48336" +
            "730203010001a346304430420603551d01043b3039801024859ebf125e76af3f" +
            "0d7979b4ac7a96a1133011310f300d060355040313064d794e616d658210d5b5" +
            "bc1c458a558845bff51cb4dff31c300906052b0e03021d0500038181009bf6e2" +
            "cf830ed485b86d6b9e8dffdcd65efc7ec145cb9348923710666791fcfa3ab59d" +
            "689ffd7234b7872611c5c23e5e0714531abadb5de492d2c736e1c929e648a65c" +
            "c9eb63cd84e57b5909dd5ddf5dbbba4a6498b9ca225b6e368b94913bfc24de6b" +
            "2bd9a26b192b957304b89531e902ffc91b54b237bb228be8afcda26476").HexToByteArray();

        public static byte[] StoreSavedAsSerializedStoreData = (
            "00000000434552540200000001000000bc0000001c0000006c00000001000000" +
            "000000000000000000000000020000007b003700370045004200440030003200" +
            "44002d0044003800440045002d0034003700350041002d003800380036003700" +
            "2d004400320030004200300030003600340045003400390046007d0000000000" +
            "4d006900630072006f0073006f006600740020005300740072006f006e006700" +
            "2000430072007900700074006f00670072006100700068006900630020005000" +
            "72006f007600690064006500720000002000000001000000e9010000308201e5" +
            "30820152a0030201020210d5b5bc1c458a558845bff51cb4dff31c300906052b" +
            "0e03021d05003011310f300d060355040313064d794e616d65301e170d313030" +
            "3430313038303030305a170d3131303430313038303030305a3011310f300d06" +
            "0355040313064d794e616d6530819f300d06092a864886f70d01010105000381" +
            "8d0030818902818100b11e30ea87424a371e30227e933ce6be0e65ff1c189d0d" +
            "888ec8ff13aa7b42b68056128322b21f2b6976609b62b6bc4cf2e55ff5ae64e9" +
            "b68c78a3c2dacc916a1bc7322dd353b32898675cfb5b298b176d978b1f12313e" +
            "3d865bc53465a11cca106870a4b5d50a2c410938240e92b64902baea23eb093d" +
            "9599e9e372e48336730203010001a346304430420603551d01043b3039801024" +
            "859ebf125e76af3f0d7979b4ac7a96a1133011310f300d060355040313064d79" +
            "4e616d658210d5b5bc1c458a558845bff51cb4dff31c300906052b0e03021d05" +
            "00038181009bf6e2cf830ed485b86d6b9e8dffdcd65efc7ec145cb9348923710" +
            "666791fcfa3ab59d689ffd7234b7872611c5c23e5e0714531abadb5de492d2c7" +
            "36e1c929e648a65cc9eb63cd84e57b5909dd5ddf5dbbba4a6498b9ca225b6e36" +
            "8b94913bfc24de6b2bd9a26b192b957304b89531e902ffc91b54b237bb228be8" +
            "afcda264762000000001000000f0040000308204ec308203d4a0030201020213" +
            "33000000b011af0a8bd03b9fdd0001000000b0300d06092a864886f70d010105" +
            "05003079310b3009060355040613025553311330110603550408130a57617368" +
            "696e67746f6e3110300e060355040713075265646d6f6e64311e301c06035504" +
            "0a13154d6963726f736f667420436f72706f726174696f6e3123302106035504" +
            "03131a4d6963726f736f667420436f6465205369676e696e6720504341301e17" +
            "0d3133303132343232333333395a170d3134303432343232333333395a308183" +
            "310b3009060355040613025553311330110603550408130a57617368696e6774" +
            "6f6e3110300e060355040713075265646d6f6e64311e301c060355040a13154d" +
            "6963726f736f667420436f72706f726174696f6e310d300b060355040b13044d" +
            "4f5052311e301c060355040313154d6963726f736f667420436f72706f726174" +
            "696f6e30820122300d06092a864886f70d01010105000382010f003082010a02" +
            "82010100e8af5ca2200df8287cbc057b7fadeeeb76ac28533f3adb407db38e33" +
            "e6573fa551153454a5cfb48ba93fa837e12d50ed35164eef4d7adb137688b02c" +
            "f0595ca9ebe1d72975e41b85279bf3f82d9e41362b0b40fbbe3bbab95c759316" +
            "524bca33c537b0f3eb7ea8f541155c08651d2137f02cba220b10b1109d772285" +
            "847c4fb91b90b0f5a3fe8bf40c9a4ea0f5c90a21e2aae3013647fd2f826a8103" +
            "f5a935dc94579dfb4bd40e82db388f12fee3d67a748864e162c4252e2aae9d18" +
            "1f0e1eb6c2af24b40e50bcde1c935c49a679b5b6dbcef9707b280184b82a29cf" +
            "bfa90505e1e00f714dfdad5c238329ebc7c54ac8e82784d37ec6430b950005b1" +
            "4f6571c50203010001a38201603082015c30130603551d25040c300a06082b06" +
            "010505070303301d0603551d0e041604145971a65a334dda980780ff841ebe87" +
            "f9723241f230510603551d11044a3048a4463044310d300b060355040b13044d" +
            "4f5052313330310603550405132a33313539352b34666166306237312d616433" +
            "372d346161332d613637312d373662633035323334346164301f0603551d2304" +
            "1830168014cb11e8cad2b4165801c9372e331616b94c9a0a1f30560603551d1f" +
            "044f304d304ba049a0478645687474703a2f2f63726c2e6d6963726f736f6674" +
            "2e636f6d2f706b692f63726c2f70726f64756374732f4d6963436f6453696750" +
            "43415f30382d33312d323031302e63726c305a06082b06010505070101044e30" +
            "4c304a06082b06010505073002863e687474703a2f2f7777772e6d6963726f73" +
            "6f66742e636f6d2f706b692f63657274732f4d6963436f645369675043415f30" +
            "382d33312d323031302e637274300d06092a864886f70d010105050003820101" +
            "0031d76e2a12573381d59dc6ebf93ad4444d089eee5edf6a5bb779cf029cbc76" +
            "689e90a19c0bc37fa28cf14dba9539fb0de0e19bf45d240f1b8d88153a7cdbad" +
            "ceb3c96cba392c457d24115426300d0dff47ea0307e5e4665d2c7b9d1da910fa" +
            "1cb074f24f696b9ea92484daed96a0df73a4ef6a1aac4b629ef17cc0147f48cd" +
            "4db244f9f03c936d42d8e87ce617a09b68680928f90297ef1103ba6752adc1e9" +
            "b373a6d263cd4ae23ee4f34efdffa1e0bb02133b5d20de553fa3ae9040313875" +
            "285e04a9466de6f57a7940bd1fcde845d5aee25d3ef575c7e6666360ccd59a84" +
            "878d2430f7ef34d0631db142674a0e4bbf3a0eefb6953aa738e4259208a68866" +
            "82000000000000000000000000").HexToByteArray();

        public static byte[] DssCer = (
            "3082025d3082021da00302010202101e9ae1e91e07de8640ac7af21ac22e8030" +
            "0906072a8648ce380403300e310c300a06035504031303466f6f301e170d3135" +
            "303232343232313734375a170d3136303232343232313734375a300e310c300a" +
            "06035504031303466f6f308201b73082012c06072a8648ce3804013082011f02" +
            "818100871018cc42552d14a5a9286af283f3cfba959b8835ec2180511d0dceb8" +
            "b979285708c800fc10cb15337a4ac1a48ed31394072015a7a6b525986b49e5e1" +
            "139737a794833c1aa1e0eaaa7e9d4efeb1e37a65dbc79f51269ba41e8f0763aa" +
            "613e29c81c3b977aeeb3d3c3f6feb25c270cdcb6aee8cd205928dfb33c44d2f2" +
            "dbe819021500e241edcf37c1c0e20aadb7b4e8ff7aa8fde4e75d02818100859b" +
            "5aeb351cf8ad3fabac22ae0350148fd1d55128472691709ec08481584413e9e5" +
            "e2f61345043b05d3519d88c021582ccef808af8f4b15bd901a310fefd518af90" +
            "aba6f85f6563db47ae214a84d0b7740c9394aa8e3c7bfef1beedd0dafda079bf" +
            "75b2ae4edb7480c18b9cdfa22e68a06c0685785f5cfb09c2b80b1d05431d0381" +
            "8400028180089a43f439b924bef3529d8d6206d1fca56a55caf52b41d6ce371e" +
            "bf07bda132c8eadc040007fcf4da06c1f30504ebd8a77d301f5a4702f01f0d2a" +
            "0707ac1da38dd3251883286e12456234da62eda0df5fe2fa07cd5b16f3638bec" +
            "ca7786312da7d3594a4bb14e353884da0e9aecb86e3c9bdb66fca78ea85e1cc3" +
            "f2f8bf0963300906072a8648ce380403032f00302c021461f6d143a47a4f7e0e" +
            "0ef9848b7f83eacbf83ffd021420e2ac47e656874633e01b0d207a99280c1127" +
            "01").HexToByteArray();

        public static byte[] CertWithPolicies = (
            "308201f33082015ca0030201020210134fb7082cf69bbb4930bfc8e1ca446130" +
            "0d06092a864886f70d0101050500300e310c300a06035504031303466f6f301e" +
            "170d3135303330313232343735385a170d3136303330313034343735385a300e" +
            "310c300a06035504031303466f6f30819f300d06092a864886f70d0101010500" +
            "03818d0030818902818100c252d52fb96658ddbb7d19dd9caaf203ec0376f77c" +
            "3012bd93e14bb22a6ff2b5ce8060a197e3fd8289fbff826746baae0db8d68b47" +
            "a1cf13678717d7db9a16dab028927173a3e843b3a7df8c5a4ff675957ea20703" +
            "6389a60a83d643108bd1293e2135a672a1cff10b7d5b3c78ab44d35e20ca6a5c" +
            "5b6f714c5bfd66ed4307070203010001a3523050301b06092b06010401823714" +
            "02040e1e0c00480065006c006c006f0000301a06092b0601040182371507040d" +
            "300b060357080902010302010230150603551d20040e300c3004060262133004" +
            "06027021300d06092a864886f70d0101050500038181001be04e59fbea63acfb" +
            "c8b6fd3d02dd7442532344cfbc124e924c0bacf23865e4ce2f442ad60ae457d8" +
            "4f7a1f05d50fb867c20e778e412a25237054555669ced01c1ce1ba8e8e57510f" +
            "73e1167c920f78aa5415dc5281f0c761fb25bb1ebc707bc003dd90911e649915" +
            "918cfe4f3176972f8afdc1cccd9705e7fb307a0c17d273").HexToByteArray();

        public static byte[] CertWithTemplateData = (
            "308201dc30820145a00302010202105101b8242daf6cae4c53bac68a948b0130" +
            "0d06092a864886f70d0101050500300e310c300a06035504031303466f6f301e" +
            "170d3135303330313232333133395a170d3136303330313034333133395a300e" +
            "310c300a06035504031303466f6f30819f300d06092a864886f70d0101010500" +
            "03818d0030818902818100a6dcff50bd1fe420301fea5fa56be93a7a53f2599c" +
            "e453cf3422bec797bac0ed78a03090a3754569e6494bcd585ac16a5ea5086344" +
            "3f25521085ca09580579cf0b46bd6e50015319fba5d2bd3724c53b20cdddf604" +
            "74bd7ef426aead9ca5ffea275a4b2b1b6f87c203ab8783559b75e319722886fb" +
            "eb784f5f06823906b2a9950203010001a33b3039301b06092b06010401823714" +
            "02040e1e0c00480065006c006c006f0000301a06092b0601040182371507040d" +
            "300b0603570809020103020102300d06092a864886f70d010105050003818100" +
            "962594da079523c26e2d3fc573fd17189ca33bedbeb2c38c92508fc2a865973b" +
            "e85ba686f765101aea0a0391b22fcfa6c0760eece91a0eb75501bf6871553f8d" +
            "6b089cf2ea63c872e0b4a178795b71826c4569857b45994977895e506dfb8075" +
            "ed1b1096987f2c8f65f2d6bbc788b1847b6ba13bee17ef6cb9c6a3392e13003f").HexToByteArray();

        public static byte[] ComplexNameInfoCert = (
            "308204BE30820427A00302010202080123456789ABCDEF300D06092A864886F70" +
            "D01010505003081A43110300E06035504061307436F756E747279310E300C0603" +
            "550408130553746174653111300F060355040713084C6F63616C6974793111300" +
            "F060355040A13084578616D706C654F31123010060355040B13094578616D706C" +
            "654F55311E301C06035504031315636E2E6973737565722E6578616D706C652E6" +
            "F72673126302406092A864886F70D0109011617697373756572656D61696C4065" +
            "78616D706C652E6F7267301E170D3133313131323134313531365A170D3134313" +
            "231333135313631375A3081A63110300E06035504061307436F756E747279310E" +
            "300C0603550408130553746174653111300F060355040713084C6F63616C69747" +
            "93111300F060355040A13084578616D706C654F31123010060355040B13094578" +
            "616D706C654F55311F301D06035504031316636E2E7375626A6563742E6578616" +
            "D706C652E6F72673127302506092A864886F70D01090116187375626A65637465" +
            "6D61696C406578616D706C652E6F7267305C300D06092A864886F70D010101050" +
            "0034B003048024100DC6FBBDA0300520DFBC9F046CC865D8876AEAC353807EA84" +
            "F58F92FE45EE03C22E970CAF41031D47F97C8A5117C62718482911A8A31B58D92" +
            "328BA3CF9E605230203010001A382023730820233300B0603551D0F0404030200" +
            "B0301D0603551D250416301406082B0601050507030106082B060105050703023" +
            "081FD0603551D120481F53081F28217646E73312E6973737565722E6578616D70" +
            "6C652E6F72678217646E73322E6973737565722E6578616D706C652E6F7267811" +
            "569616E656D61696C31406578616D706C652E6F7267811569616E656D61696C32" +
            "406578616D706C652E6F7267A026060A2B060104018237140203A0180C1669737" +
            "375657275706E31406578616D706C652E6F7267A026060A2B0601040182371402" +
            "03A0180C1669737375657275706E32406578616D706C652E6F7267861F6874747" +
            "03A2F2F757269312E6973737565722E6578616D706C652E6F72672F861F687474" +
            "703A2F2F757269322E6973737565722E6578616D706C652E6F72672F308201030" +
            "603551D110481FB3081F88218646E73312E7375626A6563742E6578616D706C65" +
            "2E6F72678218646E73322E7375626A6563742E6578616D706C652E6F726781157" +
            "3616E656D61696C31406578616D706C652E6F7267811573616E656D61696C3240" +
            "6578616D706C652E6F7267A027060A2B060104018237140203A0190C177375626" +
            "A65637475706E31406578616D706C652E6F7267A027060A2B0601040182371402" +
            "03A0190C177375626A65637475706E32406578616D706C652E6F7267862068747" +
            "4703A2F2F757269312E7375626A6563742E6578616D706C652E6F72672F862068" +
            "7474703A2F2F757269322E7375626A6563742E6578616D706C652E6F72672F300" +
            "D06092A864886F70D0101050500038181005CD44A247FF4DFBF2246CC04D7D57C" +
            "EF2B6D3A4BC83FF685F6B5196B65AFC8F992BE19B688E53E353EEA8B63951EC40" +
            "29008DE8B851E2C30B6BF73F219BCE651E5972E62D651BA171D1DA9831A449D99" +
            "AF4E2F4B9EE3FD0991EF305ADDA633C44EB5E4979751280B3F54F9CCD561AC27D" +
            "3426BC6FF32E8E1AAF9F7C0150A726B").HexToByteArray();

        internal static string NormalizeX500String(string expected)
        {
            if (Interop.IsWindows)
            {
                return expected;
            }

            // Windows calls OID(2.5.4.8) "S", which matches ITU X.520.
            // OpenSSL calls it "ST", because RFC1327 calls "S" surname.
            // 
            // This provides a test mitigation for issue 1985, allowing the
            // thrust of the test to proceed with this one known problem.
            return expected.Replace(" S=", " ST=");
        }
    }
}