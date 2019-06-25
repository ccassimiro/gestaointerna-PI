import TelaLogin from '../login.vue'
import TelaPrincipal from '../home.vue'
import TelaImportarMembros from '../importacao.vue'
import TelaListagemMembros from '../listagem-membros.vue'
import TelaRelatorios from '../ver-relatorios.vue'
import TelaPeopleAnalytics from '../people-analytics-forms.vue'

export const routes = [
    {
        path: '/login',
        component: TelaLogin,
        name: 'login',
        meta: {
            allowAnonymousAccess: true,
        },
    },
    {
        path: '/',
        component: TelaPrincipal,
        name: 'main',
        meta: {
            allowAnonymousAccess: true,
        }    
    },
    {
        path: '/importacao',
        component: TelaImportarMembros,
        name: 'importacao',

    },
    {
        path: '/listagem-membros',
        component: TelaListagemMembros,
        name: 'listagem-membros'
    }, 
    {
        path: '/relatorios',
        component: TelaRelatorios,
        name: 'relatorios'
    },
    {
        path: '/forms',
        component: TelaPeopleAnalytics,
        name: 'forms'
    }

];

