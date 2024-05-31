string[] text = {
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
    "χαίρων καρπαλίμως, εἰ καὶ μάλα τηλόθεν ἐστί,", //
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
    "οὐ γάρ τι στυγερῇ ἐπὶ γαστέρι κύντερον ἄλλο // ἔπλετο",
    "(ἔπλετο), ἥ τ᾽ ἐκέλευσεν ἕο μνήσασθαι ἀνάγκῃ",
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
    "ἔγνω γὰρ φᾶρός τε χιτῶνά τε εἵματ᾽ ἰδοῦσα // καλά",
    "(καλά), τά ῥ᾽ αὐτὴ τεῦξε σὺν ἀμφιπόλοισι γυναιξί:",
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
    "ἔνθα μὲν ἑπτάετες μένον ἔμπεδον, εἵματα δ᾽ αἰεὶ // δάκρυσι δεύεσκον",
    "(δάκρυσι δεύεσκον), τά μοι ἄμβροτα δῶκε Καλυψώ:",
    "ἀλλ᾽ ὅτε δὴ ὀγδόατόν μοι ἐπιπλόμενον ἔτος ἦλθεν,",
    "καὶ τότε δή μ᾽ ἐκέλευσεν ἐποτρύνουσα νέεσθαι",
    "Ζηνὸς ὑπ᾽ ἀγγελίης, ἢ καὶ νόος ἐτράπετ᾽ αὐτῆς.",
    "πέμπε δ᾽ ἐπὶ σχεδίης πολυδέσμου, πολλὰ δ᾽ ἔδωκε,",
    "σῖτον καὶ μέθυ ἡδύ, καὶ ἄμβροτα εἵματα ἕσσεν,",
    "οὖρον δὲ προέηκεν ἀπήμονά τε λιαρόν τε.",
    "ἑπτὰ δὲ καὶ δέκα μὲν πλέον ἤματα ποντοπορεύων,",
    "ὀκτωκαιδεκάτῃ δ᾽ ἐφάνη ὄρεα σκιόεντα // γαίης ὑμετέρης",
    "(γαίης ὑμετέρης), γήθησε δέ μοι φίλον ἦτορ",
    "δυσμόρῳ: ἦ γὰρ ἔμελλον ἔτι ξυνέσεσθαι ὀιζυῖ // πολλῇ",
    "(πολλῇ), τήν μοι ἐπῶρσε Ποσειδάων ἐνοσίχθων,",
    "ὅς μοι ἐφορμήσας ἀνέμους κατέδησε κέλευθον,",
    "ὤρινεν δὲ θάλασσαν ἀθέσφατον, οὐδέ τι κῦμα",
    "εἴα ἐπὶ σχεδίης ἁδινὰ στενάχοντα φέρεσθαι.",
    "τὴν μὲν ἔπειτα θύελλα διεσκέδασ᾽: αὐτὰρ ἐγώ γε",
    "νηχόμενος τόδε λαῖτμα διέτμαγον, (ὄφρα με γαίῃ)",
    "ὄφρα με γαίῃ // ὑμετέρῃ ἐπέλασσε φέρων ἄνεμός τε καὶ ὕδωρ.",
    "ἔνθα κέ μ᾽ ἐκβαίνοντα βιήσατο κῦμ᾽ ἐπὶ χέρσου,",
    "πέτρῃς πρὸς μεγάλῃσι βαλὸν καὶ ἀτερπέι χώρῳ:",
    "ἀλλ᾽ ἀναχασσάμενος νῆχον πάλιν, ἧος ἐπῆλθον",
    "ἐς ποταμόν, τῇ δή μοι ἐείσατο χῶρος ἄριστος,",
    "λεῖος πετράων, καὶ ἐπὶ σκέπας ἦν ἀνέμοιο.",
    "ἐκ δ᾽ ἔπεσον θυμηγερέων, ἐπὶ δ᾽ ἀμβροσίη νὺξ // ἤλυθ᾽",
    "(ἤλυθ᾽). ἐγὼ δ᾽ ἀπάνευθε διιπετέος ποταμοῖο // ἐκβὰς",
    "(ἐκβὰς) ἐν θάμνοισι κατέδραθον, ἀμφὶ δὲ φύλλα // ἠφυσάμην",
    "(ἠφυσάμην): ὕπνον δὲ θεὸς κατ᾽ ἀπείρονα χεῦεν.",
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
    "ταῦτά τοι ἀχνύμενός περ ἀληθείην κατέλεξα."
}; // 114 lines

string[] translation = {
    "but when they had both poured libations, and drank as much as their heart wished,",
    "Alcinous addressed the assembly and said among them:",
    "listen, leaders and counsellors of the Phaeacians",
    "in order that I may say what the heart in my breast orders me to.",
    "now on one hand, having finished your feast, you each of you to your house to rest;",
    "but at dawn having called upon more old men",
    "we will receive the stranger in our halls and to the gods",
    "we will make good sacrifices, but then about his sending",
    "we will think, so the stranger without toil and trouble",
    "may under our escort come to his fatherland",
    "rejoicing swiftly, even if he is from very far",
    "nor meanwhile shall he at any rate suffer any evil and harm,",
    "at least until he goes upon his land; but then there",
    "he shall suffer whatever the Fate and dread spinners for him",
    "spun out with their thread at his birth, when his mother bore him.",
    "but if at any rate he is one of the immortals come down from heaven,",
    "then this is a certain other thing that the gods are preparing.",
    "for before at any rate the gods always appeared in bodily form",
    "to us, when we sacrifice glorious hecatombs,",
    "and they feast beside us, sitting where we sit.",
    "even if a certain traveller going alone meets them,",
    "they use no concealement, since we are of relationship to them,",
    "like both the Cyclopes and the wild tribe of Giants.",
    "but resourceful Odysseus replied to him, answering:",
    "Alcinous, may another think be the object of care in your mind: for I at any rate am not",
    "like the immortals, who have broad heaven,",
    "not in stature nor in form, but like mortal men.",
    "those men you knew, carrying the most suffering",
    "of men, to them I would liken myself in pain.",
    "yes and still I could have spoken more about the evils,",
    "indeed at any rate all together as great as what I suffered of the gods' desire.",
    "but for my part permit me to take supper despire being troubled;",
    "for there is nothing more dog-like than a hateful belly",
    "which both orders a man with force to think about it",
    "even though he is very distressed and has grief in his heart, - HOLODACTYLIC LINE (FAST)",
    "even as I have grief in my heart, the belly very much always",
    "commands me to eat and to drink, but from me",
    "makes my forget all the things I have suffered, and orders me to fill myself quite full.",
    "but make haste with dawn appearing,",
    "so that you may place me, the unlucky one, upon my fatherland",
    "even though I have suffered many things; and may life leave me having seen",
    "my property, and both my slaves and my big high roofed house.",
    "so he spoke, but then all the men applauded and ordered",
    "to send the stranger, since he spoke following due measure.",
    "but when they both poured libations and drank as much as their heart wished,",
    "on one hand, each of the men when home to rest,",
    "but in the hall heavenly Odysseus was left remaining,",
    "but beside him both Arete and godlike Alcinous",
    "sat; but the attendants cleared away the dishes of the feast.",
    "but white-armed Arete was the first to speak;",
    "for she knew his beautiful garment, both the cloak and tunic, having seen it",
    "that she herself made with her woman slaves;",
    "and she spoke to him, and addressed him with winged words:",
    "stranger, for my part I myself will ask you first;",
    "who are you among men, and from where? who gave you this cloak?",
    "indeed, do you not say that you came here wandering over the sea?",
    "but resourceful Odysseus replied, answering:",
    "it is painful, queen, to continuously tell (the story)",
    "of my troubles, since the heavenly gods gave me many;",
    "but I will tell you this, of which you ask and enquire me.",
    "Ogygia, a certain island, lies far off in the sea;",
    "there on one hand the daughter of Atlas, crafty Calypso",
    "dwells, fairheaded, a terrible goddess; not a certain one with her",
    "has sex, neither of gods nor of mortal men.",
    "but fate led me, the unlucky one, to her home",
    "alone, since my swift ship, with his bright thunderbolt",
    "Zeus held back and shattered it in the middle of the wine-dark sea.",
    "there on one hand all my other good comrades perished",
    "but I, having grasped the curved ship's keel into my arms",
    "for nine days I was drifiting; but on the tenth black night",
    "the gods brought me to the island Ogygia, where Calypso",
    "dwells fairheaded, a terrible goddess, who having taken me",
    "both kindly welcomed me and looked after me and said",
    "she would make me immortal and ageless for all my days;",
    "but she never persuaded the heart in my breast.",
    "on one hand I stayed there firm-set for seven years, but I always wet my garment with tears",
    "the immortal one that Calypso gave to me;",
    "but indeed when the eighth year approaching me came,",
    "then indeed she ordered me to go, urging me on",
    "because of a message by Zeus, or even that her own mind turned.",
    "but she sent me upon a strong-bound raft, but gave me much",
    "food and pleasant wine, and put an immortal rainment on me,",
    "but she sent on a wind both favorable and warm.", // 266, end of 3.x
    "but on one hand I sailed for seventeen days passing over the sea",
    "but on the eighteenth appeared the shadowy mountains of your land",
    "but my dear heart rejoiced",
    "ill fatedly; for I was still destined to be with much woe",
    "which Poseidon the Earth shaker sent against me",
    "having stirred up the winds to me, he kept me from continuing my journey,",
    "but he wondrously stirred up the sea, nor did a certain wave",
    "permit me to be carried upon my raft, groaning ceaselessly.",
    "then the furious storm shattered my raft; but I at any rate",
    "clove through this gulf by swimming,",
    "as both the wind and the water, carrying me, brought me to your land.",
    "there if I had tried to come ashore the wave would have forcibly drove me upon dry land,",
    "threw me towards great rocks and a joyless place;",
    "but having given way I swam back, until I came upon",
    "a river, which indeed appeared to me the best place,",
    "smooth of rocks, and there was shelter from the wind.",
    "but out of the water I sank down gathering my breath, but immortal night came upon me",
    "but I stepped out from the river fallen from Zeus",
    "in bushes lay down to sleep, but gathered leaves around me",
    "but a god poured endless sleep upon me.",
    "on one hand there in leaves, my heart having been sorrowful",
    "I slept all night long and until dawn and the middle of the day.",
    "and the sun verged towards afternoon and sweet sleep released me.",
    "but I noticed the handmaids of your daughter upon the shore",
    "playing, but in them there was her, like the goddesses;",
    "I approached her; but she did not fail a certain good thought,",
    "as you would not expect of the younger ones having met you",
    "to do; for the younger ones always behave thoughtlessly",
    "she gave me food in plenty and sparkling wine",
    "and bathed me in the river and gave to me this garment.",
    "in these things, despite grieving, I have told the truth."









};

Console.WriteLine("Lines 1-23: Section 1.n");
Console.WriteLine("Lines 24-42: Section 2.n");
Console.WriteLine("Lines 43-83: Section 3.n");
int max_line_number = translation.Length;
bool finish = false;
int score = 0;
int attempts = -1;
bool[,] tested = new bool[120, 2];
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
    int line_number = 0;
    bool failed = true;
    while (failed == true)
    {
        line_number = r.Next(start-1, end);
        if (tested[line_number, 0] == false) failed = false;
    }
    tested[line_number, 0] = true;
    Console.WriteLine($"{line_number+1}: {text[line_number]}"); // max index 113
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
        } else
        {
            tested[line_number, 1] = true;
        }
    }
    attempts++;
    if (attempts == end - start)
    {
        finish = true;
        attempts++;
    }
}
Console.WriteLine($"Final score is {score}/{attempts} or {(100*score)/attempts}%");
for (int i = 0; i < 120; i++)
{
    if (tested[i, 1])
    {
        Console.Write($"{i+1} ");
    }
}
