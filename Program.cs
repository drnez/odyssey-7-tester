﻿string[] text = {
    "αὐτὰρ ἐπεὶ σπεῖσάν τ᾽ ἔπιόν θ᾽, ὅσον ἤθελε θυμός,",
    "τοῖσιν δ᾽ Ἀλκίνοος ἀγορήσατο καὶ μετέειπε:",
    "κέκλυτε, Φαιήκων ἡγήτορες ἠδὲ μέδοντες",
    "ὄφρ᾽ εἴπω τά με θυμὸς ἐνὶ στήθεσσι κελεύει.",
    "νῦν μὲν δαισάμενοι κατακείετε οἴκαδ᾽ ἰόντες:",
    "ἠῶθεν δὲ γέροντας ἐπὶ πλέονας καλέσαντες",
    "ξεῖνον ἐνὶ μεγάροις ξεινίσσομεν ἠδὲ θεοῖσιν",
    "ῥέξομεν ἱερὰ καλά, ἔπειτα δὲ καὶ περὶ πομπῆς",
    "μνησόμεθ᾽, ὥς χ᾽ ὁ ξεῖνος ἄνευθε πόνου καὶ ἀνίης",
    "πομπῇ ὑφ᾽ ἡμετέρῃ ἣν πατρίδα γαῖαν ἵκηται",
    "χαίρων καρπαλίμως, εἰ καὶ μάλα τηλόθεν ἐστί,",
    "μηδέ τι μεσσηγύς γε κακὸν καὶ πῆμα πάθῃσι,",
    "πρίν γε τὸν ἧς γαίης ἐπιβήμεναι: ἔνθα δ᾽ ἔπειτα",
    "πείσεται, ἅσσα οἱ αἶσα κατὰ κλῶθές τε βαρεῖαι",
    "γιγνομένῳ νήσαντο λίνῳ, ὅτε μιν τέκε μήτηρ.",
    "εἰ δέ τις ἀθανάτων γε κατ᾽ οὐρανοῦ εἰλήλουθεν,",
    "ἄλλο τι δὴ τόδ᾽ ἔπειτα θεοὶ περιμηχανόωνται.",
    "αἰεὶ γὰρ τὸ πάρος γε θεοὶ φαίνονται ἐναργεῖς",
    "ἡμῖν, εὖτ᾽ ἔρδωμεν ἀγακλειτὰς ἑκατόμβας,",
    "δαίνυνταί τε παρ᾽ ἄμμι καθήμενοι ἔνθα περ ἡμεῖς.",
    "εἰ δ᾽ ἄρα τις καὶ μοῦνος ἰὼν ξύμβληται ὁδίτης,",
    "οὔ τι κατακρύπτουσιν, ἐπεί σφισιν ἐγγύθεν εἰμέν,",
    "ὥς περ Κύκλωπές τε καὶ ἄγρια φῦλα Γιγάντων.",
    "τὸν δ᾽ ἀπαμειβόμενος προσέφη πολύμητις Ὀδυσσεύς:",
    "‘Ἀλκίνο᾽, ἄλλο τί τοι μελέτω φρεσίν: οὐ γὰρ ἐγώ γε",
    "ἀθανάτοισιν ἔοικα, τοὶ οὐρανὸν εὐρὺν ἔχουσιν,",
    "οὐ δέμας οὐδὲ φυήν, ἀλλὰ θνητοῖσι βροτοῖσιν.",
    "οὕς τινας ὑμεῖς ἴστε μάλιστ᾽ ὀχέοντας ὀιζὺν",
    "ἀνθρώπων, τοῖσίν κεν ἐν ἄλγεσιν ἰσωσαίμην.",
    "καὶ δ᾽ ἔτι κεν καὶ μᾶλλον ἐγὼ κακὰ μυθησαίμην,",
    "ὅσσα γε δὴ ξύμπαντα θεῶν ἰότητι μόγησα.",
    "ἀλλ᾽ ἐμὲ μὲν δορπῆσαι ἐάσατε κηδόμενόν περ:",
    "οὐ γάρ τι στυγερῇ ἐπὶ γαστέρι κύντερον ἄλλο",
    "ἔπλετο, ἥ τ᾽ ἐκέλευσεν ἕο μνήσασθαι ἀνάγκῃ",
    "καὶ μάλα τειρόμενον καὶ ἐνὶ φρεσὶ πένθος ἔχοντα,",
    "ὡς καὶ ἐγὼ πένθος μὲν ἔχω φρεσίν, ἡ δὲ μάλ᾽ αἰεὶ",
    "ἐσθέμεναι κέλεται καὶ πινέμεν, ἐκ δέ με πάντων",
    "ληθάνει ὅσσ᾽ ἔπαθον, καὶ ἐνιπλησθῆναι ἀνώγει.",
    "ὑμεῖς δ᾽ ὀτρύνεσθαι ἅμ᾽ ἠοῖ φαινομένηφιν,",
    "ὥς κ᾽ ἐμὲ τὸν δύστηνον ἐμῆς ἐπιβήσετε πάτρης",
    "καί περ πολλὰ παθόντα: ἰδόντα με καὶ λίποι αἰὼν",
    "κτῆσιν ἐμήν, δμῶάς τε καὶ ὑψερεφὲς μέγα δῶμα.",
    "ὣς ἔφαθ᾽, οἱ δ᾽ ἄρα πάντες ἐπῄνεον ἠδ᾽ ἐκέλευον",
    "πεμπέμεναι τὸν ξεῖνον, ἐπεὶ κατὰ μοῖραν ἔειπεν.",
    "αὐτὰρ ἐπεὶ σπεῖσάν τ᾽ ἔπιον θ᾽ ὅσον ἤθελε θυμός,",
    "οἱ μὲν κακκείοντες ἔβαν οἶκόνδε ἕκαστος,",
    "αὐτὰρ ὁ ἐν μεγάρῳ ὑπελείπετο δῖος Ὀδυσσεύς,",
    "πὰρ δέ οἱ Ἀρήτη τε καὶ Ἀλκίνοος θεοειδὴς",
    "ἥσθην: ἀμφίπολοι δ᾽ ἀπεκόσμεον ἔντεα δαιτός.",
    "τοῖσιν δ᾽ Ἀρήτη λευκώλενος ἤρχετο μύθων:",
    "ἔγνω γὰρ φᾶρός τε χιτῶνά τε εἵματ᾽ ἰδοῦσα",
    "καλά, τά ῥ᾽ αὐτὴ τεῦξε σὺν ἀμφιπόλοισι γυναιξί:",
    "καί μιν φωνήσασ᾽ ἔπεα πτερόεντα προσηύδα:",
    "ξεῖνε, τὸ μέν σε πρῶτον ἐγὼν εἰρήσομαι αὐτή:",
    "τίς πόθεν εἰς ἀνδρῶν; τίς τοι τάδε εἵματ᾽ ἔδωκεν;",
    "οὐ δὴ φῆς ἐπὶ πόντον ἀλώμενος ἐνθάδ᾽ ἱκέσθαι;",
    "τὴν δ᾽ ἀπαμειβόμενος προσέφη πολύμητις Ὀδυσσεύς:",
    "‘ἀργαλέον, βασίλεια, διηνεκέως ἀγορεῦσαι",
    "κήδε᾽, ἐπεί μοι πολλὰ δόσαν θεοὶ Οὐρανίωνες:",
    "τοῦτο δέ τοι ἐρέω ὅ μ᾽ ἀνείρεαι ἠδὲ μεταλλᾷς.",
    "Ὠγυγίη τις νῆσος ἀπόπροθεν εἰν ἁλὶ κεῖται:",
    "ἔνθα μὲν Ἄτλαντος θυγάτηρ, δολόεσσα Καλυψὼ",
    "ναίει ἐυπλόκαμος, δεινὴ θεός: οὐδέ τις αὐτῇ",
    "μίσγεται οὔτε θεῶν οὔτε θνητῶν ἀνθρώπων.",
    "ἀλλ᾽ ἐμὲ τὸν δύστηνον ἐφέστιον ἤγαγε δαίμων",
    "οἶον, ἐπεί μοι νῆα θοὴν ἀργῆτι κεραυνῷ",
    "Ζεὺς ἔλσας ἐκέασσε μέσῳ ἐνὶ οἴνοπι πόντῳ.",
    "ἔνθ᾽ ἄλλοι μὲν πάντες ἀπέφθιθεν ἐσθλοὶ ἑταῖροι,",
    "αὐτὰρ ἐγὼ τρόπιν ἀγκὰς ἑλὼν νεὸς ἀμφιελίσσης",
    "ἐννῆμαρ φερόμην: δεκάτῃ δέ με νυκτὶ μελαίνῃ",
    "νῆσον ἐς Ὠγυγίην πέλασαν θεοί, ἔνθα Καλυψὼ",
    "ναίει ἐυπλόκαμος, δεινὴ θεός, ἥ με λαβοῦσα",
    "ἐνδυκέως ἐφίλει τε καὶ ἔτρεφεν ἠδὲ ἔφασκε",
    "θήσειν ἀθάνατον καὶ ἀγήραον ἤματα πάντα:",
    "ἀλλ᾽ ἐμὸν οὔ ποτε θυμὸν ἐνὶ στήθεσσιν ἔπειθεν.",
    "ἔνθα μὲν ἑπτάετες μένον ἔμπεδον, εἵματα δ᾽ αἰεὶ",
    "δάκρυσι δεύεσκον, τά μοι ἄμβροτα δῶκε Καλυψώ:",
    "ἀλλ᾽ ὅτε δὴ ὀγδόατόν μοι ἐπιπλόμενον ἔτος ἦλθεν,",
    "καὶ τότε δή μ᾽ ἐκέλευσεν ἐποτρύνουσα νέεσθαι",
    "Ζηνὸς ὑπ᾽ ἀγγελίης, ἢ καὶ νόος ἐτράπετ᾽ αὐτῆς.",
    "πέμπε δ᾽ ἐπὶ σχεδίης πολυδέσμου, πολλὰ δ᾽ ἔδωκε,",
    "σῖτον καὶ μέθυ ἡδύ, καὶ ἄμβροτα εἵματα ἕσσεν,",
    "οὖρον δὲ προέηκεν ἀπήμονά τε λιαρόν τε.",
    "ἑπτὰ δὲ καὶ δέκα μὲν πλέον ἤματα ποντοπορεύων,",
    "ὀκτωκαιδεκάτῃ δ᾽ ἐφάνη ὄρεα σκιόεντα",
    "γαίης ὑμετέρης, γήθησε δέ μοι φίλον ἦτορ",
    "δυσμόρῳ: ἦ γὰρ ἔμελλον ἔτι ξυνέσεσθαι ὀιζυῖ",
    "πολλῇ, τήν μοι ἐπῶρσε Ποσειδάων ἐνοσίχθων,",
    "ὅς μοι ἐφορμήσας ἀνέμους κατέδησε κέλευθον,",
    "ὤρινεν δὲ θάλασσαν ἀθέσφατον, οὐδέ τι κῦμα",
    "εἴα ἐπὶ σχεδίης ἁδινὰ στενάχοντα φέρεσθαι.",
    "τὴν μὲν ἔπειτα θύελλα διεσκέδασ᾽: αὐτὰρ ἐγώ γε",
    "νηχόμενος τόδε λαῖτμα διέτμαγον, ὄφρα με γαίῃ",
    "ὑμετέρῃ ἐπέλασσε φέρων ἄνεμός τε καὶ ὕδωρ.",
    "ἔνθα κέ μ᾽ ἐκβαίνοντα βιήσατο κῦμ᾽ ἐπὶ χέρσου,",
    "πέτρῃς πρὸς μεγάλῃσι βαλὸν καὶ ἀτερπέι χώρῳ:",
    "ἀλλ᾽ ἀναχασσάμενος νῆχον πάλιν, ἧος ἐπῆλθον",
    "ἐς ποταμόν, τῇ δή μοι ἐείσατο χῶρος ἄριστος,",
    "λεῖος πετράων, καὶ ἐπὶ σκέπας ἦν ἀνέμοιο.",
    "ἐκ δ᾽ ἔπεσον θυμηγερέων, ἐπὶ δ᾽ ἀμβροσίη νὺξ",
    "ἤλυθ᾽. ἐγὼ δ᾽ ἀπάνευθε διιπετέος ποταμοῖο",
    "ἐκβὰς ἐν θάμνοισι κατέδραθον, ἀμφὶ δὲ φύλλα",
    "ἠφυσάμην: ὕπνον δὲ θεὸς κατ᾽ ἀπείρονα χεῦεν.",
    "ἔνθα μὲν ἐν φύλλοισι φίλον τετιημένος ἦτορ",
    "εὗδον παννύχιος καὶ ἐπ᾽ ἠῶ καὶ μέσον ἦμαρ.",
    "δείλετό τ᾽ ἠέλιος καί με γλυκὺς ὕπνος ἀνῆκεν.",
    "ἀμφιπόλους δ᾽ ἐπὶ θινὶ τεῆς ἐνόησα θυγατρὸς",
    "παιζούσας, ἐν δ᾽ αὐτὴ ἔην ἐικυῖα θεῇσι:",
    "τὴν ἱκέτευσ᾽: ἡ δ᾽ οὔ τι νοήματος ἤμβροτεν ἐσθλοῦ,",
    "ὡς οὐκ ἂν ἔλποιο νεώτερον ἀντιάσαντα",
    "ἐρξέμεν: αἰεὶ γάρ τε νεώτεροι ἀφραδέουσιν.",
    "ἥ μοι σῖτον ἔδωκεν ἅλις ἠδ᾽ αἴθοπα οἶνον",
    "καὶ λοῦσ᾽ ἐν ποταμῷ καί μοι τάδε εἵματ᾽ ἔδωκε.",
    "ταῦτά τοι ἀχνύμενός περ ἀληθείην κατέλεξα.",
}; // 114 lines

string[] translation = {
    "but when they had both poured libations, and drank as much as their heart wished,",
    "Alcinous addressed the assembly and said among them:",
    "listen, leaders and counsellors of the Phaeacians",
    "in order that I may say what the heart in my breast orders me to.",
    "now on one hand, having finished your feast, you each of you to your house to rest;"
};

int max_line_number = translation.Length;
bool finish = false;
int score = 0;
int attempts = -1;
Random r = new Random();

bool valid = false;
int start = 0;
int end = 0;
while (!valid)
{
    valid = true;
    try {
        Console.Write("Starting Line Number: ");
        start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Final Line Number: ");
        end = Convert.ToInt32(Console.ReadLine());
    }
    catch {
        valid = false;
        Console.WriteLine("Invalid!");
    }
    if (end > max_line_number || end == 0)
    {
        valid = false;
        Console.WriteLine("Final number invalid!");
    }
    if (start == 0)
    {
        valid = false;
        Console.WriteLine("Start may not be 0");
    }
}

while (!finish)
{
    int line_number = r.Next(start-1, end);
    Console.WriteLine(text[line_number]); // max index 113
    string? input = Console.ReadLine();
    if (input == "-1")
    {
        finish = true;
    }
    else if (input == translation[line_number])
    {
        Console.WriteLine("Correct! Yay!");
        score++;
    }
    else
    {
        Console.WriteLine($"Correct Translation: {translation[line_number]}");
        Console.Write("Override? ");
        string? change = Console.ReadLine();
        if (change == "y")
        {
            Console.WriteLine("Acknowledged.");
            score++;
        }
    }
    attempts++;
}
Console.WriteLine($"Final score is {score}/{attempts} or {(100*score)/attempts}%");
