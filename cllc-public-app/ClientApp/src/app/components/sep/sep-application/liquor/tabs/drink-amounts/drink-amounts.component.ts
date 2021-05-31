import { Component, EventEmitter, OnInit, Input, Output } from '@angular/core';
import { FormArray, FormBuilder } from '@angular/forms';
import { SepDrinkType } from '@models/sep-drink-type.model';
import { SepApplication } from '@models/sep-application.model';
import { SpecialEventsDataService } from '@services/special-events-data.service';

@Component({
  selector: 'app-drink-amounts',
  templateUrl: './drink-amounts.component.html',
  styleUrls: ['./drink-amounts.component.scss']
})
export class DrinkAmountsComponent implements OnInit {
  _application: SepApplication
  @Input()
  set application(value: SepApplication) {
    this._application = value;
  };

  get application() {
    return this._application;
  }
  @Output() saved: EventEmitter<{declaredServings: number}> = new EventEmitter<{declaredServings: number}>();
  @Output() back: EventEmitter<boolean> = new EventEmitter<boolean>();
  form: FormArray;
  // a list of drink types that will be fetched from the server
  drinkTypes: SepDrinkType[] = [];

  constructor(private fb: FormBuilder,
    private sepDataService: SpecialEventsDataService) { }

  ngOnInit(): void {
    this.form = this.fb.array([]);
    this.sepDataService.getSepDrinkTypes()
    .subscribe(data => {
      this.drinkTypes = data;
    });
  }

  addDrinkType(value: any = {}){
    let drinkType = this.fb.group({
      id: [''],
      estimatedServings: [''],
      drinkTypeId: [''],
    });
    drinkType.patchValue(value);
    this.form.push(drinkType);
  }

  next() {
    this.saved.next(<any>{drinksSalesForecasts: this.form.value});
  }
}
