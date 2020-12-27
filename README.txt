Projet Unity

1-) Le jeu - Flappy bird.

	Pour ce projet, j'ai décidé de coder le jeu du Flappy Bird vu en TP.
Lorsqu'on lance l'application, on commence par une petite de chargement de 3 secondes qui nous mène au menu de départ.
Le menu de départ se compose du titre et d'un bouton Play, une touche suffit sur le bouton Play pour lancer le jeu.
En jeu, les contrôles fonctionnent comme ceci :
	- Si on appuie sur l'écran sur l'écran, l'oiseau monte tant qu'on appuie ou qu'on appuie à la chaîne.
	- Plus on appuie pas sur l'écran, plus l'oiseau descend vite jusqu'à une certaine vitesse.
	- Si on appuie sur le côté gauche de l'écran, l'oiseau en plus de sauter va aller à gauche.
	- Si on appuie sur le côté droit de l'écran, l'oiseau en plus de sauter va aller à droite.
Le score est indiqué en haut au centre de l'écran par un chiffre en blanc. On gagne 1 point à chaque qu'on passe un couple de tuyau.
La vie du joueur est indiqué au haut à droite de l'écran par un chiffre vert. On commence avec 5 points de vie. À chaque fois qu'on touche un tuyau,on perd 1 point de vie.
Lorsque le joueur atteint 0, l'écran de fin de jeu s'affiche et indique notre score. Il suffit d'appuyer rapidement sur l'écran 2 fois pour relancer le jeu sur l'écran de chargement et ainsi revenir au menu du début.
En jeu, l'oiseau ne peux pas sortir de l'écran par le haut, la droite ou la gauche. Cependant si il sort par l'écran du bas jusqu'à ne plus être visible, le joueur a instantanément perdu et fait apparaître l'écran de fin du jeu.

2 -) La réalisation du projet. 

Pour le projet ce qui a causé le plus de soucis fût la répétition infinie du background. En effet, un premier soucis qui s'est posé était que le code fournit dans le PDF est bon mais pas pour le sens demandé dans le même PDF( code bon pour gauche à droite et le pdf demande à droite à gauche).
De plus pour une raison qui m'est inconnue, si je m'étais la position du en x du 3ème background comme point de répétition, un écart se crée. J'ai du mettre tester des valeurs jusqu'à ce que effectivement ça marche sans soucis.
Autre point de soucis a été de faire un semblant de descente en parabole, la force du saut a également un petit point de préocupation.
Un point qui a posé énormément de problème a été la génération des pipes, pour une raison que je n'ai point compris si je faisais comme le PDF demandait de donner en Start() la position d'origine à des Transform pour les garder en mémoire et derrière jouer sur une fourchette de valeur aléatoire
à partir de cette position d'origine sauvegardée un problème se créait. Si le jeu tournait plus de 20s, les pipes commençaient à aller de plus en plus bas ou de plus en plus haut  au point de sortir de l'écran. N'ayant pas trouvé l'origine du problème(car dans les faits je suis d'accord avec l'idée du code fournit et 
si je fait la trace, c'est censé effectivement fonctionner sans problèmes mais dans les faits c'était pas du tout ça), j'ai résolu ce problème en sauvegardant les positions Y d'origines dans des variables float.
Le reste des problèmes n'ont été que des problèmes de connaissances par rapport à comment faire sur Unity et la lecture de la documentation ou de rapide recherche internet ont permis de résoudre tout ceci rapidement.
Pour les tests, j'ai utilisé mon téléphone (un Xiaomi Redmi Note 7 64Go) en utilisant l'application Unity Remote 5 (infernal à faire fonctionner au passage), puis j'ai testé l'apk sur mon téléphone et le téléphone de ma mère (un Xiaomi Mi A1).


3-) Source

Pour les musiques : https://freemusicarchive.org/genre/Chiptune?sort=track_date_published&d=1&page=1
Pour les recherces : Google - StackOverflow - Youtube - les forums Unity - la documentation Unity - Reddit - votre PDF 