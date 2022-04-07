EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL Back(CharName)

{Name("Violet")}
{Icon("violin")}
Oh It's you Conductor! I was told you wished to speak with me.
Is there something in particular you need?

{Name("You")}
....

* [o h right, about that...] -> one

* [Would you like to go for a walk?] -> two

=== one ===

{Name("Violet")}
{Icon("violin")}
What is it? are you alright Conductor? you seem awfully uncomfortable!

* [ok so, um would you-] -> four
 
 === four ==
{Name("Violet")}
{Icon("violin")}
A walk you say? well I suppose if you wouldn't mind the company it'd be fine..
Though are you alright? You seem to be sweating rather purfusely!

* [of course! It's just quite warm in here!] -> two

* [ Am I? I hadn't noticed..] -> three

=== three ===
{Name("Violet")}
{Icon("violin")}
I see.. You must take better care of yourself then, if you hadn't noticed this must be 
a common occurance -> two

=== two ==

{Name("You")}
(The two of you arrive at a lovely park, birds chirp and flowers bloom as many couples can be seen exchanging tender glances,
While one pair are seemingly laughing at man who fell over. 
How charming)

{Name("Violet")}
{Icon("violin")}
My it's rather full here today, Is this what you always do after work Conductor?

* [Yes, i like getting in a walk] -> five

* [No, I'm usually much lazier honestly] -> six

=== five === 

{Name("Violet")}
{Icon("violin")}
My My how admirable! I wish I had the time too.. 
I usually head have to hurry home to look after my mother as shes been ill for many years now.. 
So getting out like this is quite the treat! 

* [Your mothers ill?] -> seven

* [oh i see, Glad to help] -> seven


=== six ===

{Name("Violet")}
{Icon("violin")}
I tend to be the same, though It's mainly due to caring for a my ill mother.
Rather then laziness, only so many hours in a day after all. 

* [Your mothers ill?] -> seven

=== seven ===

{Name("Violet")}
{Icon("violin")}
It's exactly as it sounds, theres not much too say on the matter
I simply have to continue forward regardless.
Even if I can't take every oppurtunity

* [ .... ]-> eight

* [ That's quite Impressive ] -> eight

=== eight ===
{Name("Violet")}
{Icon("violin")}
It is what it is, my apologies for rambling. 

* [It's not problem] -> ten

* [Thank you for telling me] -> ten

=== ten === 
{Name("Violet")}
{Icon("violin")}
(She looks to the couples around and notices picnics seem to be rather popular
in this park. She seems to be eyeing an ice cream truck nearby)

*[Get her an Ice cream] -> eleven

*[well, its getting late. We better head back] -> tweleve

=== eleven ===

{Name("You")}
(You hand her an Ice cream)

{Name("Violet")}
{Icon("violin")}
{Back("powercouple")}
Oh my! How did you know?
oh thank you! Lets sit for a bit shall we?

-> END

=== tweleve ===
{Name("Violet")}
{Icon("violin")}
I see, Its been a pleasure.
See you tomorrow

-> END




 








-> END
 