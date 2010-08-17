




/*
'===============================================================================
'  LayerHelper.CAQ.BL.PhanLoaiDoiTuongManagerBase
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
	public class PhanLoaiDoiTuongManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public PhanLoaiDoiTuongManagerBase()
		{
			// Nothing for now.
		}
		
		public PhanLoaiDoiTuongEntity Insert(PhanLoaiDoiTuongEntity _PhanLoaiDoiTuongEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_PhanLoaiDoiTuongEntity, true);
			}
			return _PhanLoaiDoiTuongEntity;
		}

		
		public PhanLoaiDoiTuongEntity Insert(Guid Id, Guid IdDoiTuong, string TrangThaiPhanLoai, DateTime NgayPhanLoai, Guid IdPhanLoai, Guid IdLoaiDoiTuong, string NoiDung, string MaRutGon, string MaTp, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			PhanLoaiDoiTuongEntity _PhanLoaiDoiTuongEntity = new PhanLoaiDoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PhanLoaiDoiTuongEntity.Id = Id;
				_PhanLoaiDoiTuongEntity.IdDoiTuong = IdDoiTuong;
				_PhanLoaiDoiTuongEntity.TrangThaiPhanLoai = TrangThaiPhanLoai;
				_PhanLoaiDoiTuongEntity.NgayPhanLoai = NgayPhanLoai;
				_PhanLoaiDoiTuongEntity.IdPhanLoai = IdPhanLoai;
				_PhanLoaiDoiTuongEntity.IdLoaiDoiTuong = IdLoaiDoiTuong;
				_PhanLoaiDoiTuongEntity.NoiDung = NoiDung;
				_PhanLoaiDoiTuongEntity.MaRutGon = MaRutGon;
				_PhanLoaiDoiTuongEntity.MaTp = MaTp;
				_PhanLoaiDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
				_PhanLoaiDoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_PhanLoaiDoiTuongEntity.NgayTao = NgayTao;
				_PhanLoaiDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_PhanLoaiDoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_PhanLoaiDoiTuongEntity.NgayHetHan = NgayHetHan;
				_PhanLoaiDoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_PhanLoaiDoiTuongEntity, true);
			}
			return _PhanLoaiDoiTuongEntity;
		}

		public PhanLoaiDoiTuongEntity Insert(Guid IdDoiTuong, string TrangThaiPhanLoai, DateTime NgayPhanLoai, Guid IdPhanLoai, Guid IdLoaiDoiTuong, string NoiDung, string MaRutGon, string MaTp, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			PhanLoaiDoiTuongEntity _PhanLoaiDoiTuongEntity = new PhanLoaiDoiTuongEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_PhanLoaiDoiTuongEntity.IdDoiTuong = IdDoiTuong;
				_PhanLoaiDoiTuongEntity.TrangThaiPhanLoai = TrangThaiPhanLoai;
				_PhanLoaiDoiTuongEntity.NgayPhanLoai = NgayPhanLoai;
				_PhanLoaiDoiTuongEntity.IdPhanLoai = IdPhanLoai;
				_PhanLoaiDoiTuongEntity.IdLoaiDoiTuong = IdLoaiDoiTuong;
				_PhanLoaiDoiTuongEntity.NoiDung = NoiDung;
				_PhanLoaiDoiTuongEntity.MaRutGon = MaRutGon;
				_PhanLoaiDoiTuongEntity.MaTp = MaTp;
				_PhanLoaiDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
				_PhanLoaiDoiTuongEntity.IdNguoiTao = IdNguoiTao;
				_PhanLoaiDoiTuongEntity.NgayTao = NgayTao;
				_PhanLoaiDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_PhanLoaiDoiTuongEntity.NgayCapNhat = NgayCapNhat;
				_PhanLoaiDoiTuongEntity.NgayHetHan = NgayHetHan;
				_PhanLoaiDoiTuongEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_PhanLoaiDoiTuongEntity, true);
			}
			return _PhanLoaiDoiTuongEntity;
		}

		public bool Update(PhanLoaiDoiTuongEntity _PhanLoaiDoiTuongEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(PhanLoaiDoiTuongFields.Id == _PhanLoaiDoiTuongEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_PhanLoaiDoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(PhanLoaiDoiTuongEntity _PhanLoaiDoiTuongEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_PhanLoaiDoiTuongEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdDoiTuong, string TrangThaiPhanLoai, DateTime NgayPhanLoai, Guid IdPhanLoai, Guid IdLoaiDoiTuong, string NoiDung, string MaRutGon, string MaTp, string LoaiDanhMuc, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhanLoaiDoiTuongEntity _PhanLoaiDoiTuongEntity = new PhanLoaiDoiTuongEntity(Id);
				if (adapter.FetchEntity(_PhanLoaiDoiTuongEntity))
				{
				
					_PhanLoaiDoiTuongEntity.IdDoiTuong = IdDoiTuong;
					_PhanLoaiDoiTuongEntity.TrangThaiPhanLoai = TrangThaiPhanLoai;
					_PhanLoaiDoiTuongEntity.NgayPhanLoai = NgayPhanLoai;
					_PhanLoaiDoiTuongEntity.IdPhanLoai = IdPhanLoai;
					_PhanLoaiDoiTuongEntity.IdLoaiDoiTuong = IdLoaiDoiTuong;
					_PhanLoaiDoiTuongEntity.NoiDung = NoiDung;
					_PhanLoaiDoiTuongEntity.MaRutGon = MaRutGon;
					_PhanLoaiDoiTuongEntity.MaTp = MaTp;
					_PhanLoaiDoiTuongEntity.LoaiDanhMuc = LoaiDanhMuc;
					_PhanLoaiDoiTuongEntity.IdNguoiTao = IdNguoiTao;
					_PhanLoaiDoiTuongEntity.NgayTao = NgayTao;
					_PhanLoaiDoiTuongEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_PhanLoaiDoiTuongEntity.NgayCapNhat = NgayCapNhat;
					_PhanLoaiDoiTuongEntity.NgayHetHan = NgayHetHan;
					_PhanLoaiDoiTuongEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_PhanLoaiDoiTuongEntity, true);
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
				PhanLoaiDoiTuongEntity _PhanLoaiDoiTuongEntity = new PhanLoaiDoiTuongEntity(Id);
				if (adapter.FetchEntity(_PhanLoaiDoiTuongEntity))
				{
					adapter.DeleteEntity(_PhanLoaiDoiTuongEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("PhanLoaiDoiTuongEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDoiTuong(Guid IdDoiTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThaiPhanLoai(string TrangThaiPhanLoai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.TrangThaiPhanLoai == TrangThaiPhanLoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayPhanLoai(DateTime NgayPhanLoai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayPhanLoai == NgayPhanLoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdPhanLoai(Guid IdPhanLoai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdPhanLoai == IdPhanLoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdLoaiDoiTuong(Guid IdLoaiDoiTuong)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdLoaiDoiTuong == IdLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNoiDung(string NoiDung)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NoiDung == NoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByLoaiDanhMuc(string LoaiDanhMuc)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("PhanLoaiDoiTuongEntity", filter);
			}
			return toReturn;
		}
		

		
		public PhanLoaiDoiTuongEntity SelectOne(Guid Id)
		{
			PhanLoaiDoiTuongEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				PhanLoaiDoiTuongEntity _PhanLoaiDoiTuongEntity = new PhanLoaiDoiTuongEntity(Id);
				if (adapter.FetchEntity(_PhanLoaiDoiTuongEntity))
				{
					toReturn = _PhanLoaiDoiTuongEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectAllLST()
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, null, 0, null);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDoiTuongCollection;
		}


		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByIdDoiTuongLST(Guid IdDoiTuong)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByIdDoiTuongLST_Paged(Guid IdDoiTuong, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDoiTuongRDT(Guid IdDoiTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDoiTuongRDT_Paged(Guid IdDoiTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdDoiTuong == IdDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByTrangThaiPhanLoaiLST(string TrangThaiPhanLoai)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.TrangThaiPhanLoai == TrangThaiPhanLoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByTrangThaiPhanLoaiLST_Paged(string TrangThaiPhanLoai, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.TrangThaiPhanLoai == TrangThaiPhanLoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiPhanLoaiRDT(string TrangThaiPhanLoai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.TrangThaiPhanLoai == TrangThaiPhanLoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiPhanLoaiRDT_Paged(string TrangThaiPhanLoai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.TrangThaiPhanLoai == TrangThaiPhanLoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByNgayPhanLoaiLST(DateTime NgayPhanLoai)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayPhanLoai == NgayPhanLoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByNgayPhanLoaiLST_Paged(DateTime NgayPhanLoai, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayPhanLoai == NgayPhanLoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayPhanLoaiRDT(DateTime NgayPhanLoai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayPhanLoai == NgayPhanLoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayPhanLoaiRDT_Paged(DateTime NgayPhanLoai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayPhanLoai == NgayPhanLoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByIdPhanLoaiLST(Guid IdPhanLoai)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdPhanLoai == IdPhanLoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByIdPhanLoaiLST_Paged(Guid IdPhanLoai, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdPhanLoai == IdPhanLoai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdPhanLoaiRDT(Guid IdPhanLoai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdPhanLoai == IdPhanLoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdPhanLoaiRDT_Paged(Guid IdPhanLoai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdPhanLoai == IdPhanLoai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByIdLoaiDoiTuongLST(Guid IdLoaiDoiTuong)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdLoaiDoiTuong == IdLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByIdLoaiDoiTuongLST_Paged(Guid IdLoaiDoiTuong, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdLoaiDoiTuong == IdLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiDoiTuongRDT(Guid IdLoaiDoiTuong)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdLoaiDoiTuong == IdLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdLoaiDoiTuongRDT_Paged(Guid IdLoaiDoiTuong, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdLoaiDoiTuong == IdLoaiDoiTuong);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByNoiDungLST(string NoiDung)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NoiDung == NoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByNoiDungLST_Paged(string NoiDung, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NoiDung == NoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNoiDungRDT(string NoiDung)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NoiDung == NoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNoiDungRDT_Paged(string NoiDung, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NoiDung == NoiDung);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByLoaiDanhMucLST(string LoaiDanhMuc)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByLoaiDanhMucLST_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT(string LoaiDanhMuc)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByLoaiDanhMucRDT_Paged(string LoaiDanhMuc, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.LoaiDanhMuc == LoaiDanhMuc);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return EntityCollection<PhanLoaiDoiTuongEntity>
		public EntityCollection<PhanLoaiDoiTuongEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<PhanLoaiDoiTuongEntity> _PhanLoaiDoiTuongCollection = new EntityCollection<PhanLoaiDoiTuongEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_PhanLoaiDoiTuongCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _PhanLoaiDoiTuongCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _PhanLoaiDoiTuongCollection = new EntityCollection(new PhanLoaiDoiTuongEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(PhanLoaiDoiTuongFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_PhanLoaiDoiTuongCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
