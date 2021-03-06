import { NgModule } from '@angular/core';
import { SystemRoutingModule } from './system-routing.module';
import { CoreModule } from '../shared/modules/core.module';
import { NotesModule } from './notes/notes.module';
import { TasksModule } from './tasks/tasks.module';
import { FeedsModule } from './feeds/feeds.module';

import { SystemComponent } from './system.component';
import { SystemSidebarComponent } from './shared/components/system-sidebar/system-sidebar.component';
import { SystemHeaderComponent } from './shared/components/system-header/system-header.component';
import { CardsDeleteModalComponent } from './shared/components/cards-delete-dialog/cards-delete-dialog.component';

@NgModule({
  imports: [
    CoreModule,
    NotesModule,
    TasksModule,
    FeedsModule,
    SystemRoutingModule
  ],
  declarations: [
    SystemComponent,
    SystemSidebarComponent,
    SystemHeaderComponent,
    CardsDeleteModalComponent
  ],
  entryComponents: [CardsDeleteModalComponent]
})
export class SystemModule { }
