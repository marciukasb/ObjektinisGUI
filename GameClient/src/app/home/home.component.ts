import { Component, OnInit } from '@angular/core';
import { HostListener } from '@angular/core';

@Component({templateUrl: 'home.component.html'})


export class HomeComponent implements OnInit {
    direction: string = "right";
    character: string = `/assets/character/${this.direction}/character.gif`;
    hide: Array<boolean> = [];
    possition:number = 20;
    key;
    constructor() 
    { 
        for (var i = 0; i <= 100; i++) {
            this.hide[i] = true;
        }
        this.hide[this.possition] = false;
       }

    ngOnInit() {
    }

    @HostListener('document:keypress', ['$event'])
    handleKeyboardEvent(event: KeyboardEvent) { 
        this.hide[this.possition] = true;
        debugger;
        if (event.key === "d") {
            this.direction = "right";
            this.possition++;
        }
        if (event.key === "a") {
            this.direction = "left";
            this.possition--;
        }

        this.character = `/assets/character/${this.direction}/character.gif`;

        if (event.key === "e") {
            setTimeout(() => 
            { 
                this.character = `/assets/character/${this.direction}/character_attack1.gif`; 
                setTimeout(() => 
                { 
                    this.character = `/assets/character/${this.direction}/character_attack2.gif`; 
                    setTimeout(() => 
                    { 
                        this.character = `/assets/character/${this.direction}/character_attack3.gif`; 
                    }, 100);
                }, 100);
            }, 100);
            
        }
        this.hide[this.possition] = false;
    }
}