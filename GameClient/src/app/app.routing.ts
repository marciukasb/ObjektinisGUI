import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home';
import { AuthGuard, AdminGuard } from './_guards';

const appRoutes: Routes = [
    { path: '', component: HomeComponent, canActivate: [AuthGuard] },
    // otherwise redirect to home
    { path: '**', redirectTo: '' }
];

export const routing = RouterModule.forRoot(appRoutes);