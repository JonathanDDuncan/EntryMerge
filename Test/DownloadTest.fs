﻿namespace EntryMergeTest
module DownloadTest =
    open System.IO
    open EntryMerge.Download
    open Fuchu

    let wd = Path.Combine ("C:\Users\User\Documents", "Merge") 
     
    let exportpage = 
        "http://signtyp.uconn.edu/signpuddle/export.php"
    let signpuddleindexurl = 
        "http://signtyp.uconn.edu/signpuddle/index.php"

    [<Tests>] 
    let tests = 
        testList "Dowload test group" [
            testCase "construct url " <| 
                fun _ -> Assert.Equal("url for puddle", 
                            "http://signtyp.uconn.edu/signpuddle/export.php?ui=1&ex_source=All&action=Download&sgn=106", 
                            fullurl "106" exportpage  );
            testCase "construct filename " <| 
                fun _ -> Assert.Equal("filename for puddle", 
                            "C:\Users\User\Documents\Merge\sgn106_PuddleName.spml", 
                            puddlefilename wd "106" "PuddleName"  )
 
        ]