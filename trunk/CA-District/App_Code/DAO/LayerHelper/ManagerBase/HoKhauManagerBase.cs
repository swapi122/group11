




/*
'===============================================================================
'  LayerHelper.CAQ.BL.HoKhauManagerBase
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.CAQ.BLL;
using LayerHelper.CAQ.DAL;
using LayerHelper.CAQ.DAL.EntityClasses;
using LayerHelper.CAQ.DAL.FactoryClasses;
using LayerHelper.CAQ.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LayerHelper.CAQ.BLL
{
	public class HoKhauManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public HoKhauManagerBase()
		{
			// Nothing for now.
		}
		
		public HoKhauEntity Insert(HoKhauEntity _HoKhauEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_HoKhauEntity, true);
			}
			return _HoKhauEntity;
		}

		
		public HoKhauEntity Insert(Guid Id, Guid IdLoaiHoKhau, Guid IdKiemDien, Guid IdNuoc, Guid IdTinh, Guid IdHuyen, Guid IdXa, Guid IdThon, Guid IdOkhuVuc, Guid IdToDanPho, string SoNha, string Duong, string TongHopCacNoiCuNgu, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			HoKhauEntity _HoKhauEntity = new HoKhauEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_HoKhauEntity.Id = Id;
				_HoKhauEntity.IdLoaiHoKhau = IdLoaiHoKhau;
				_HoKhauEntity.IdKiemDien = IdKiemDien;
				_HoKhauEntity.IdNuoc = IdNuoc;
				_HoKhauEntity.IdTinh = IdTinh;
				_HoKhauEntity.IdHuyen = IdHuyen;
				_HoKhauEntity.IdXa = IdXa;
				_HoKhauEntity.IdThon = IdThon;
				_HoKhauEntity.IdOkhuVuc = IdOkhuVuc;
				_HoKhauEntity.IdToDanPho = IdToDanPho;
				_HoKhauEntity.SoNha = SoNha;
				_HoKhauEntity.Duong = Duong;
				_HoKhauEntity.TongHopCacNoiCuNgu = TongHopCacNoiCuNgu;
				_HoKhauEntity.MaRutGon = MaRutGon;
				_HoKhauEntity.MaTp = MaTp;
				_HoKhauEntity.GhiChu = GhiChu;
				_HoKhauEntity.IdNguoiTao = IdNguoiTao;
				_HoKhauEntity.NgayTao = NgayTao;
				_HoKhauEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_HoKhauEntity.NgayCapNhat = NgayCapNhat;
				_HoKhauEntity.NgayHetHan = NgayHetHan;
				_HoKhauEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_HoKhauEntity, true);
			}
			return _HoKhauEntity;
		}

		public HoKhauEntity Insert(Guid IdLoaiHoKhau, Guid IdKiemDien, Guid IdNuoc, Guid IdTinh, Guid IdHuyen, Guid IdXa, Guid IdThon, Guid IdOkhuVuc, Guid IdToDanPho, string SoNha, string Duong, string TongHopCacNoiCuNgu, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			HoKhauEntity _HoKhauEntity = new HoKhauEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_HoKhauEntity.IdLoaiHoKhau = IdLoaiHoKhau;
				_HoKhauEntity.IdKiemDien = IdKiemDien;
				_HoKhauEntity.IdNuoc = IdNuoc;
				_HoKhauEntity.IdTinh = IdTinh;
				_HoKhauEntity.IdHuyen = IdHuyen;
				_HoKhauEntity.IdXa = IdXa;
				_HoKhauEntity.IdThon = IdThon;
				_HoKhauEntity.IdOkhuVuc = IdOkhuVuc;
				_HoKhauEntity.IdToDanPho = IdToDanPho;
				_HoKhauEntity.SoNha = SoNha;
				_HoKhauEntity.Duong = Duong;
				_HoKhauEntity.TongHopCacNoiCuNgu = TongHopCacNoiCuNgu;
				_HoKhauEntity.MaRutGon = MaRutGon;
				_HoKhauEntity.MaTp = MaTp;
				_HoKhauEntity.GhiChu = GhiChu;
				_HoKhauEntity.IdNguoiTao = IdNguoiTao;
				_HoKhauEntity.NgayTao = NgayTao;
				_HoKhauEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_HoKhauEntity.NgayCapNhat = NgayCapNhat;
				_HoKhauEntity.NgayHetHan = NgayHetHan;
				_HoKhauEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_HoKhauEntity, true);
			}
			return _HoKhauEntity;
		}

		public bool Update(HoKhauEntity _HoKhauEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(HoKhauFields.Id == _HoKhauEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_HoKhauEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(HoKhauEntity _HoKhauEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_HoKhauEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdLoaiHoKhau, Guid IdKiemDien, Guid IdNuoc, Guid IdTinh, Guid IdHuyen, Guid IdXa, Guid IdThon, Guid IdOkhuVuc, Guid IdToDanPho, string SoNha, string Duong, string TongHopCacNoiCuNgu, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HoKhauEntity _HoKhauEntity = new HoKhauEntity(Id);
				if (adapter.FetchEntity(_HoKhauEntity))
				{
				
					_HoKhauEntity.IdLoaiHoKhau = IdLoaiHoKhau;
					_HoKhauEntity.IdKiemDien = IdKiemDien;
					_HoKhauEntity.IdNuoc = IdNuoc;
					_HoKhauEntity.IdTinh = IdTinh;
					_HoKhauEntity.IdHuyen = IdHuyen;
					_HoKhauEntity.IdXa = IdXa;
					_HoKhauEntity.IdThon = IdThon;
					_HoKhauEntity.IdOkhuVuc = IdOkhuVuc;
					_HoKhauEntity.IdToDanPho = IdToDanPho;
					_HoKhauEntity.SoNha = SoNha;
					_HoKhauEntity.Duong = Duong;
					_HoKhauEntity.TongHopCacNoiCuNgu = TongHopCacNoiCuNgu;
					_HoKhauEntity.MaRutGon = MaRutGon;
					_HoKhauEntity.MaTp = MaTp;
					_HoKhauEntity.GhiChu = GhiChu;
					_HoKhauEntity.IdNguoiTao = IdNguoiTao;
					_HoKhauEntity.NgayTao = NgayTao;
					_HoKhauEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_HoKhauEntity.NgayCapNhat = NgayCapNhat;
					_HoKhauEntity.NgayHetHan = NgayHetHan;
					_HoKhauEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_HoKhauEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HoKhauEntity _HoKhauEntity = new HoKhauEntity(Id);
				if (adapter.FetchEntity(_HoKhauEntity))
				{
					adapter.DeleteEntity(_HoKhauEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("HoKhauEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdLoaiHoKhau(Guid IdLoaiHoKhau)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdLoaiHoKhau == IdLoaiHoKhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdKiemDien(Guid IdKiemDien)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdKiemDien == IdKiemDien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNuoc(Guid IdNuoc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdNuoc == IdNuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdTinh(Guid IdTinh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdTinh == IdTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdHuyen(Guid IdHuyen)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdXa(Guid IdXa)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdThon(Guid IdThon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdThon == IdThon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdOkhuVuc(Guid IdOkhuVuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdToDanPho(Guid IdToDanPho)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdToDanPho == IdToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteBySoNha(string SoNha)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByDuong(string Duong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTongHopCacNoiCuNgu(string TongHopCacNoiCuNgu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.TongHopCacNoiCuNgu == TongHopCacNoiCuNgu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("HoKhauEntity", filter);
			}
			return toReturn;
		}
		

		
		public HoKhauEntity SelectOne(Guid Id)
		{
			HoKhauEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				HoKhauEntity _HoKhauEntity = new HoKhauEntity(Id);
				if (adapter.FetchEntity(_HoKhauEntity))
				{
					toReturn = _HoKhauEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectAllLST()
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, null, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdLoaiHoKhauLST(Guid IdLoaiHoKhau)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdLoaiHoKhau == IdLoaiHoKhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdLoaiHoKhauLST_Paged(Guid IdLoaiHoKhau, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdLoaiHoKhau == IdLoaiHoKhau);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiHoKhauRDT(Guid IdLoaiHoKhau)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdLoaiHoKhau == IdLoaiHoKhau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiHoKhauRDT_Paged(Guid IdLoaiHoKhau, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdLoaiHoKhau == IdLoaiHoKhau);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdKiemDienLST(Guid IdKiemDien)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdKiemDien == IdKiemDien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdKiemDienLST_Paged(Guid IdKiemDien, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdKiemDien == IdKiemDien);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdKiemDienRDT(Guid IdKiemDien)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdKiemDien == IdKiemDien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdKiemDienRDT_Paged(Guid IdKiemDien, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdKiemDien == IdKiemDien);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdNuocLST(Guid IdNuoc)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdNuoc == IdNuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdNuocLST_Paged(Guid IdNuoc, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdNuoc == IdNuoc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNuocRDT(Guid IdNuoc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdNuoc == IdNuoc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNuocRDT_Paged(Guid IdNuoc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdNuoc == IdNuoc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdTinhLST(Guid IdTinh)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdTinh == IdTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdTinhLST_Paged(Guid IdTinh, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdTinh == IdTinh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhRDT(Guid IdTinh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdTinh == IdTinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdTinhRDT_Paged(Guid IdTinh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdTinh == IdTinh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdHuyenLST(Guid IdHuyen)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdHuyenLST_Paged(Guid IdHuyen, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdHuyenRDT(Guid IdHuyen)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdHuyenRDT_Paged(Guid IdHuyen, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdHuyen == IdHuyen);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdXaLST(Guid IdXa)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdXaLST_Paged(Guid IdXa, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdXaRDT(Guid IdXa)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdXaRDT_Paged(Guid IdXa, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdXa == IdXa);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdThonLST(Guid IdThon)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdThon == IdThon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdThonLST_Paged(Guid IdThon, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdThon == IdThon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdThonRDT(Guid IdThon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdThon == IdThon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdThonRDT_Paged(Guid IdThon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdThon == IdThon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdOkhuVucLST(Guid IdOkhuVuc)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdOkhuVucLST_Paged(Guid IdOkhuVuc, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdOkhuVucRDT(Guid IdOkhuVuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdOkhuVucRDT_Paged(Guid IdOkhuVuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdOkhuVuc == IdOkhuVuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdToDanPhoLST(Guid IdToDanPho)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdToDanPho == IdToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdToDanPhoLST_Paged(Guid IdToDanPho, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdToDanPho == IdToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdToDanPhoRDT(Guid IdToDanPho)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdToDanPho == IdToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdToDanPhoRDT_Paged(Guid IdToDanPho, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdToDanPho == IdToDanPho);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectBySoNhaLST(string SoNha)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectBySoNhaLST_Paged(string SoNha, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectBySoNhaRDT(string SoNha)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectBySoNhaRDT_Paged(string SoNha, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.SoNha == SoNha);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByDuongLST(string Duong)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByDuongLST_Paged(string Duong, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByDuongRDT(string Duong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByDuongRDT_Paged(string Duong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.Duong == Duong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByTongHopCacNoiCuNguLST(string TongHopCacNoiCuNgu)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.TongHopCacNoiCuNgu == TongHopCacNoiCuNgu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByTongHopCacNoiCuNguLST_Paged(string TongHopCacNoiCuNgu, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.TongHopCacNoiCuNgu == TongHopCacNoiCuNgu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTongHopCacNoiCuNguRDT(string TongHopCacNoiCuNgu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.TongHopCacNoiCuNgu == TongHopCacNoiCuNgu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTongHopCacNoiCuNguRDT_Paged(string TongHopCacNoiCuNgu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.TongHopCacNoiCuNgu == TongHopCacNoiCuNgu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null);
			}
			return _HoKhauCollection;
		}
		
		// Return EntityCollection<HoKhauEntity>
		public EntityCollection<HoKhauEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<HoKhauEntity> _HoKhauCollection = new EntityCollection<HoKhauEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_HoKhauCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _HoKhauCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _HoKhauCollection = new EntityCollection(new HoKhauEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(HoKhauFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_HoKhauCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
