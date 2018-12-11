import { Component, OnInit } from '@angular/core';
import { HostListener } from '@angular/core';

@Component({ templateUrl: 'home.component.html' })
export class HomeComponent implements OnInit {
    direction: string = "right";
    character: string = `/assets/character/${this.direction}/character.gif`;
    blast: string = `/assets/spells/green_blast.png`;
    hide: Array<boolean> = [];
    hideBlast: Array<boolean> = [];
    CharacterPossition: number = 20;
    BlastPossition: number = 20;
    
    constructor() {
        for (var i = 0; i <= 100; i++) {
            this.hide[i] = true;
        }
        this.hide[this.CharacterPossition] = false;
        for (var i = 0; i <= 100; i++) {
            this.hideBlast[i] = true;
        }
    }

    ngOnInit() { }

    @HostListener('document:keypress', ['$event'])
    handleKeyboardEvent(event: KeyboardEvent) {
        this.hide[this.CharacterPossition] = true;
        if (event.key === "d") {
            this.direction = "right";
            this.CharacterPossition++;
        }
        if (event.key === "a") {
            this.direction = "left";
            this.CharacterPossition--;
        }
        if (event.key === "e") {
            this.castSpell("");
        }

        this.character = `/assets/character/${this.direction}/character.gif`;
        this.hide[this.CharacterPossition] = false;
    }

    castSpell(spell) {
        setTimeout(() => {
            this.character = `/assets/character/${this.direction}/character_attack1.gif`;
            setTimeout(() => {
                this.character = `/assets/character/${this.direction}/character_attack2.gif`;
                setTimeout(() => {
                    this.character = `/assets/character/${this.direction}/character_attack3.gif`;
                    setTimeout(() => {
                        this.character = `/assets/character/${this.direction}/character_attack3.gif`;
                        if (this.direction == "right") {
                            this.hideBlast[this.BlastPossition] = true;
                            this.BlastPossition = this.CharacterPossition;
                            this.BlastPossition += 9;
                            this.hideBlast[this.BlastPossition] = false;
                            this.blast = `/assets/spells/${this.direction}/fire_blast.png`;
                            this.blastMovement();
                        }
                        this.character = `/assets/character/${this.direction}/character_attack3.gif`;
                        if (this.direction == "left") {
                            this.hideBlast[this.BlastPossition] = true;
                            this.BlastPossition = this.CharacterPossition;
                            this.BlastPossition += 1;
                            this.hideBlast[this.BlastPossition] = false;
                            this.blast = `/assets/spells/${this.direction}/fire_blast.png`;
                            this.blastMovement();
                        }
                    }, 100);
                }, 100);
            }, 100);
        }, 100);

    }

    blastMovement() {
        if(this.direction == "right") {
            for (var j = 0; j <= 50; j++) {
                setTimeout(() => {
                    this.hideBlast[this.BlastPossition] = true;
                    this.BlastPossition++;
                    this.hideBlast[this.BlastPossition] = false;
                    setTimeout(() => {
                        this.hideBlast[this.BlastPossition] = true;
                        this.BlastPossition++;
                        this.hideBlast[this.BlastPossition] = false;
                    },
                        100);
                },
                    100);
            }
        }
        else {
            for (var j = 0; j <= 50; j++) {
                setTimeout(() => {
                    this.hideBlast[this.BlastPossition] = true;
                    this.BlastPossition--;
                    this.hideBlast[this.BlastPossition] = false;
                    setTimeout(() => {
                        this.hideBlast[this.BlastPossition] = true;
                        this.BlastPossition--;
                        this.hideBlast[this.BlastPossition] = false;
                    },
                        100);
                },
                    100);
            }
        }
        setTimeout(() => {
            this.character = `/assets/character/${this.direction}/character.gif`;
        }, 500);
        this.character = `/assets/character/${this.direction}/character.gif`;
    }
}